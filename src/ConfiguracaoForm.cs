using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.aptidao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.crossover;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.mutacao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.selecao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.solucao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.substituicao;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.utils;
using ZedGraph;

namespace traveling_salesperson_problem_genetic_algorithm
{
    public partial class ConfiguracaoForm : Form, IAlgoritmoGeneticoObserver
    {
        private Graphics g;
        int count;
        int pontoCount;

        private GraphPane paneMedia;
        private PointPairList mediaPopulacao = new PointPairList();

        private Mapa mapa;
        private CrossoverPmx crossover;
        private MutacaoDoisGenes mutacao;

        Populacao populacao;

        int evolucoes;
        double positivoInfinito = double.PositiveInfinity;

        int totalExecucoes = 5;
        int tipoExecucao;
        int contagemEvolucao ;
        bool isExportacao = false;
        string[,] resultados;
        int[] evolucoesSalvas = {100, 200, 400, 600, 1000, 1600};
        double[] resultadosExecucoes;

        public ConfiguracaoForm()
        {
            this.mapa = Mapa.getInstance();

            InitializeComponent();

            this.AutoScroll = true;

            resultados = new string[7, 5];
            resultadosExecucoes = new double[evolucoesSalvas.Length];

            paneMedia = zedMedia.GraphPane;
            paneMedia.Title.Text = "Média da População";
            paneMedia.XAxis.Title.Text = "Evolucão";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMedia.Refresh();
        }


        private void ConfiguracaoForm_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Pen caneta = new Pen(Color.Red, 3);
            int X = e.X;
            int Y = e.Y;

            mapa.adicionarPonto(X, Y);

            Rectangle retangulo = new Rectangle(X - 5, Y - 5, 10, 10);
            g.DrawEllipse(caneta, retangulo);
            g.DrawString((pontoCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, X + 3, Y);
            g.DrawString("X:" + X.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 25);
            g.DrawString("Y:" + Y.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 18);

            pontoCount++;
            labelQtdeCidades.Text = pontoCount.ToString();
            lbComplex.Text = Fatorial((ulong)pontoCount).ToString();

            if(++count >= 4)
            {
                buttonCriarPop.Enabled = true;
            }

            if(++count >= 1)
            {
                buttonLimpar.Enabled = true;
            }
            else
            {
                buttonLimpar.Enabled = false;
            }
        }

        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
                return 1;
            else return number * Fatorial(number - 1);
        }
        
        private void desenharPontos()
        {
            if(mapa.quantidadePontos > 0)
            {

                for(int i = 0; i < mapa.quantidadePontos; i++)
                {
                    Pen caneta = new Pen(Color.Red, 3);
                    int[] coordenadas = mapa.getCordenadas(i);
                    Rectangle retangulo = new Rectangle(coordenadas[0] - 5, coordenadas[1] - 5, 10, 10);
                    g.DrawEllipse(caneta, retangulo);
                    g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coordenadas[0] + 3, coordenadas[1]);
                    g.DrawString("X:" + coordenadas[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coordenadas[0] - 20, coordenadas[1] - 25);
                    g.DrawString("Y:" + coordenadas[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coordenadas[0] - 20, coordenadas[1] - 18);
                }
            }
        }

        
        private void desenharLinhas(Populacao pop, Color cor)
        {
            Pen caneta = new Pen(cor, 4);
            int geneA, geneB;

            Individuo melhor = pop.getMelhorIndividuo();

            for(int i = 0; i < Configuracao.tamanhoCromossomo; i++)
            {
                if(i < Configuracao.tamanhoCromossomo - 1)
                {
                    geneA = melhor.cromossomo[i];
                    geneB = melhor.cromossomo[i + 1];
                }
                else
                {
                    geneA = melhor.cromossomo[i];
                    geneB = melhor.cromossomo[0];
                }

                int[] coordenadaA = mapa.getCordenadas(geneA);
                int[] coordenadaB = mapa.getCordenadas(geneB);

                g.DrawLine(caneta, coordenadaA[0], coordenadaA[1], coordenadaB[0], coordenadaB[1]);

            }
        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            Configuracao.tamanhoPopulacao = int.Parse(labelTamamnhoPop.Text);
            populacao = new Populacao(gerarIndividuos());
            buttonExecutar.Enabled = true;
            btnExecuteAndExport.Enabled = true;
        }

        private Individuo[] gerarIndividuos()
        {
            Individuo[] individuos = new Individuo[Configuracao.tamanhoPopulacao];

            for (int i = 0; i < individuos.Length; i++)
            {
                individuos[i] = new Individuo(gerarCromossomo());
            }
            return individuos;
        }

        private int[] gerarCromossomo()
        {
            Configuracao.tamanhoCromossomo = mapa.quantidadePontos;
            int[] cromossomo = new int[Configuracao.tamanhoCromossomo];
            List<int> genes = RandomNumber.RandomNumbers(0, cromossomo.Length);
            for (int j = 0; j < cromossomo.Length; j++)
            {
                cromossomo[j] = genes[j];
            }
            return cromossomo;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pontoCount = 0;
            evolucoes = 0;
            labelEvolucoes.Text = "00";
            populacao.geracao = 0;

            contagemEvolucao = 0;

            Configuracao.tamanhoPopulacao = 0;
            if (!isExportacao)
            {
                mapa.limpar();
            }
            populacao = null;

            labelQtdeCidades.Text = "--";

            buttonCriarPop.Enabled = false;
            buttonExecutar.Enabled = false;
            buttonLimpar.Enabled = false;
            botaoExportarMelhorIndiv.Enabled = false;
            btnExecuteAndExport.Enabled = false;

            g.Clear(Color.White);
            count = 0;

            mediaPopulacao.Clear();
            zedMedia.Refresh();

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            buttonCriarPop.Enabled = false;

            int torneio = int.Parse(labelTamannhoTorneio.Text);
            evolucoes += int.Parse(labelEvolucao.Text);

            positivoInfinito = double.PositiveInfinity;

            Configuracao.numeroCompetidores = torneio;

            Configuracao.Tipo tipo = Configuracao.Tipo.FIXO;

            if(rbDHM_ILC.Checked)
            {
                tipo = Configuracao.Tipo.DHM_ILC;
            }
            else if(rbILM_DHC.Checked)
            {
                tipo = Configuracao.Tipo.ILM_DHC;
            }

            Configuracao.tipo = tipo;

            AlgoritmoGenetico algoritmoGenetico = new AlgoritmoGenetico();
            algoritmoGenetico.aptidao = new AptidaoDistancia(mapa);
            algoritmoGenetico.selecao = new SelecaoTorneio(Configuracao.numeroCompetidores, Configuracao.aleatorio);
            algoritmoGenetico.mutacao = mutacao = new MutacaoDoisGenes(Configuracao.taxaMutacao, Configuracao.aleatorio);
            algoritmoGenetico.solucao = new SolucaoLimiteGeracao(evolucoes);
            algoritmoGenetico.crossover = crossover = new CrossoverPmx(Configuracao.aleatorio, Configuracao.taxaCrossover);
            algoritmoGenetico.substituicao = new SubstituicaoTotal();
            algoritmoGenetico.observadores.Add(this);
            algoritmoGenetico.execute(populacao);

            g.Clear(Color.White);
            desenharLinhas(populacao, Color.Blue);
            desenharPontos();

            botaoExportarMelhorIndiv.Enabled = true;
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() {Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true})
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                Pen caneta = new Pen(Color.Red, 3);;
                                String[] posicao = line.Split(' ');
                                String x = posicao[0];
                                String y = posicao[1];
                                int posicaoX = Int16.Parse(x);
                                int posicaoY = Int16.Parse(y);
                                Rectangle rect = new Rectangle(posicaoX - 5, posicaoY - 5, 10, 10);
                                g.DrawEllipse(caneta, rect);
                                g.DrawString((pontoCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, posicaoX + 3, posicaoY);
                                g.DrawString("X:" + posicaoX.ToString(), new Font("Arial Black", 6), Brushes.Black, posicaoX - 20, posicaoY - 25);
                                g.DrawString("Y:" + posicaoY.ToString(), new Font("Arial Black", 6), Brushes.Black, posicaoX - 20, posicaoY - 18);

                                mapa.adicionarPonto(posicaoX, posicaoY);

                                pontoCount++;

                                labelQtdeCidades.Text = pontoCount.ToString();
                                lbComplex.Text = Fatorial((ulong)pontoCount).ToString();

                                if (++count >= 4)
                                {
                                    buttonCriarPop.Enabled = true;
                                }

                                if (++count >= 1)
                                {
                                    buttonLimpar.Enabled = true;
                                }
                                else
                                {
                                    buttonLimpar.Enabled = false;
                                }
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string caminho = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            String agora = DateTime.Now.Ticks + "";
            string nomeArquivo = "dataset_" + agora + ".txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(caminho, nomeArquivo)))
            {
                for (int i = 0; i < mapa.quantidadePontos; i++)
                {
                    outputFile.WriteLine(mapa.getCoordenadaX(i) + " " + mapa.getCoordenadaY(i));
                }
            }
            MessageBox.Show("Arquivo "+ nomeArquivo + " salvo com sucesso na sua Área de Trabalho", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbFFMCR_CheckedChanged(object sender, EventArgs e)
        {
            labelTaxaCrossover.Text = "050000";
            labelTaxaMutacao.Text = "050000";
            labelTaxaCrossover.Refresh();
            labelTaxaMutacao.Refresh();
        }

        private void rbFixed_CheckedChanged(object sender, EventArgs e)
        {
            labelTaxaCrossover.Text = "090000";
            labelTaxaMutacao.Text = "003000";
            labelTaxaCrossover.Refresh();
            labelTaxaMutacao.Refresh();
        }

        private void rbDHM_ILC_CheckedChanged(object sender, EventArgs e)
        {
            labelTaxaCrossover.Text = "000000";
            labelTaxaMutacao.Text = "100000";
            labelTaxaCrossover.Refresh();
            labelTaxaMutacao.Refresh();
        }

        private void rbILM_DHC_CheckedChanged(object sender, EventArgs e)
        {

            labelTaxaCrossover.Text = "100000";
            labelTaxaMutacao.Text = "000000";
            labelTaxaCrossover.Refresh();
            labelTaxaMutacao.Refresh();
        }

        private void btnExportarMelhorIndiv_Click(object sender, EventArgs e)
        {
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            String now = DateTime.Now.Ticks + "";
            string fileName = "melhor_resultado_" + now + ".txt";
            Individuo best = populacao.getMelhorIndividuo();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(strPath, fileName)))
            {
                outputFile.WriteLine("ID" + " - " + "X" + "/" + "Y");
                for (int i = 0; i < Configuracao.tamanhoCromossomo; i++)
                {
                    outputFile.WriteLine(best.cromossomo[i] + 1 + " - " + mapa.getCoordenadaX(best.cromossomo[i]) + "/" + mapa.getCoordenadaY(best.cromossomo[i]));
                }
            }
            MessageBox.Show("Arquivo " + fileName + " salvo com sucesso na sua Área de Trabalho", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExecuteAndExport_Click(object sender, EventArgs e)
        {
            isExportacao = true;
            resultados[0, 0] = "Geração";
            resultados[0, 1] = "DHM/ILC";
            resultados[0, 2] = "ILM/DHC";
            resultados[0, 3] = "0.03MR0.9CR";
            resultados[0, 4] = "FFMCR";

            resultados[1, 0] = "100";
            resultados[2, 0] = "200";
            resultados[3, 0] = "400";
            resultados[4, 0] = "600";
            resultados[5, 0] = "1000";
            resultados[6, 0] = "1600";

            tipoExecucao = 0;
            double[] somas = new double[resultadosExecucoes.Length];

            for(int i = 0; i < totalExecucoes; i++)
            {
                rbDHM_ILC.Checked = true;
                rbDHM_ILC_CheckedChanged(sender, e);
                btnExecutar_Click(sender, e);
                btnLimpar_Click(sender, e);
                btnCriarPop_Click(sender, e);

                for (int j = 0; j < resultadosExecucoes.Length; j++)
                {
                    somas[j] += resultadosExecucoes[j];
                    resultadosExecucoes[j] = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                resultados[i + 1, tipoExecucao + 1] = somas[i] / totalExecucoes + "";
                somas[i] = 0;
            }

            tipoExecucao++;

            for (int i = 0; i < totalExecucoes; i++)
            {
                rbILM_DHC.Checked = true;
                rbILM_DHC_CheckedChanged(sender, e);
                btnExecutar_Click(sender, e);
                btnLimpar_Click(sender, e);
                btnCriarPop_Click(sender, e);

                for (int j = 0; j < resultadosExecucoes.Length; j++)
                {
                    somas[j] += resultadosExecucoes[j];
                    resultadosExecucoes[j] = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                resultados[i + 1, tipoExecucao + 1] = somas[i] / totalExecucoes + "";
                somas[i] = 0;
            }

            tipoExecucao++;

            for (int i = 0; i < totalExecucoes; i++)
            {
                rbFixed.Checked = true;
                rbFixed_CheckedChanged(sender, e);
                btnExecutar_Click(sender, e);
                btnLimpar_Click(sender, e);
                btnCriarPop_Click(sender, e);

                for (int j = 0; j < resultadosExecucoes.Length; j++)
                {
                    somas[j] += resultadosExecucoes[j];
                    resultadosExecucoes[j] = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                resultados[i + 1, tipoExecucao + 1] = somas[i] / totalExecucoes + "";
                somas[i] = 0;
            }

            tipoExecucao++;

            for (int i = 0; i < totalExecucoes; i++)
            {
                rbFFMCR.Checked = true;
                rbFFMCR_CheckedChanged(sender, e);
                btnExecutar_Click(sender, e);
                btnLimpar_Click(sender, e);
                btnCriarPop_Click(sender, e);

                for (int j = 0; j < resultadosExecucoes.Length; j++)
                {
                    somas[j] += resultadosExecucoes[j];
                    resultadosExecucoes[j] = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                resultados[i + 1, tipoExecucao + 1] = somas[i] / totalExecucoes + "";
                somas[i] = 0;
            }

            tipoExecucao++;

            string caminho = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            String agora = DateTime.Now.Ticks + "";
            string nomeArquivo = "resultados_pop_"+ Configuracao.tamanhoPopulacao + " " + agora + ".csv";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(caminho, nomeArquivo)))
            {
                for (int i = 0; i < 7; i++)
                { 
                    outputFile.WriteLine(resultados[i, 0] + ";" + resultados[i, 1] + ";" + resultados[i, 2] + ";" + resultados[i, 3] + ";" + resultados[i, 4] + ";");
                }
            }
            MessageBox.Show("Arquivo " + nomeArquivo + " salvo com sucesso na sua Área de Trabalho", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            isExportacao = false;

            buttonLimpar.Enabled = true;
        }

        public void notifyInicioGeracao()
        {
            if (Configuracao.tipo != Configuracao.Tipo.FIXO)
            {
                if (Configuracao.tipo == Configuracao.Tipo.DHM_ILC)
                {
                    labelTaxaMutacao.Text = Convert.ToDecimal(1) - Convert.ToDecimal(populacao.geracao) / Convert.ToDecimal(evolucoes) + "";
                    labelTaxaCrossover.Text = Convert.ToDecimal(populacao.geracao) / Convert.ToDecimal(evolucoes) + "";
                }
                if (Configuracao.tipo == Configuracao.Tipo.ILM_DHC)
                {
                    labelTaxaCrossover.Text = Convert.ToDecimal(1) - Convert.ToDecimal(populacao.geracao) / Convert.ToDecimal(evolucoes) + "";
                    labelTaxaMutacao.Text = Convert.ToDecimal(populacao.geracao) / Convert.ToDecimal(evolucoes) + "";
                }
                labelTaxaMutacao.Refresh();
                labelTaxaCrossover.Refresh();
            }

            //Atualiza as taxas do algoritmo de acordo com a configuração selecionada
            crossover.taxaCrossover = Configuracao.taxaCrossover = float.Parse(labelTaxaCrossover.Text);
            mutacao.taxaMutacao = Configuracao.taxaMutacao = float.Parse(labelTaxaMutacao.Text);
        }

        public void notifyAtualizacaoFitness()
        {
            zedMedia.GraphPane.CurveList.Clear();
            zedMedia.GraphPane.GraphObjList.Clear();

            double mediaPop = populacao.getMediaPopulacao();
            mediaPopulacao.Add(populacao.geracao, mediaPop);

            double bestFitness = populacao.getMelhorIndividuo().aptidao;
            labelbMenorDistancia.Text = bestFitness.ToString();
            labelbMenorDistancia.Refresh();

            LineItem media = paneMedia.AddCurve("Média", mediaPopulacao, Color.Red, SymbolType.None);

            if (populacao.geracao % 6 == 0 && bestFitness < positivoInfinito)
            {
                positivoInfinito = bestFitness;
                g.Clear(Color.White);
                desenharLinhas(populacao, Color.Blue);
                desenharPontos();
            }

            if (isExportacao)
            {
                if (evolucoesSalvas.Contains(populacao.geracao))
                {
                    resultadosExecucoes[this.contagemEvolucao] = bestFitness;
                    this.contagemEvolucao++;
                }
            }

            zedMedia.AxisChange();
            zedMedia.Invalidate();
            zedMedia.Refresh();

            labelEvolucoes.Text = populacao.geracao.ToString();
            labelEvolucoes.Refresh();
        }
    }
}
