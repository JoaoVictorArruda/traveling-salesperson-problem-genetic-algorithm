namespace traveling_salesperson_problem_genetic_algorithm
{
    partial class ConfiguracaoForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExecuteAndExport = new System.Windows.Forms.Button();
            this.botaoExportarMelhorIndiv = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.zedMedia = new ZedGraph.ZedGraphControl();
            this.labelbMenorDistancia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEvolucoes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.buttonCriarPop = new System.Windows.Forms.Button();
            this.groupBoxConfiguracao = new System.Windows.Forms.GroupBox();
            this.rbFFMCR = new System.Windows.Forms.RadioButton();
            this.rbILM_DHC = new System.Windows.Forms.RadioButton();
            this.rbFixed = new System.Windows.Forms.RadioButton();
            this.rbDHM_ILC = new System.Windows.Forms.RadioButton();
            this.labelTamannhoTorneio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEvolucao = new System.Windows.Forms.MaskedTextBox();
            this.labelTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.labelTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.labelTamamnhoPop = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelQtdeCidades = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbComplex = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxConfiguracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnExecuteAndExport);
            this.panel1.Controls.Add(this.botaoExportarMelhorIndiv);
            this.panel1.Controls.Add(this.buttonExportar);
            this.panel1.Controls.Add(this.buttonTxt);
            this.panel1.Controls.Add(this.zedMedia);
            this.panel1.Controls.Add(this.labelbMenorDistancia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelEvolucoes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonLimpar);
            this.panel1.Controls.Add(this.buttonExecutar);
            this.panel1.Controls.Add(this.buttonCriarPop);
            this.panel1.Controls.Add(this.groupBoxConfiguracao);
            this.panel1.Controls.Add(this.labelTamannhoTorneio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelEvolucao);
            this.panel1.Controls.Add(this.labelTaxaMutacao);
            this.panel1.Controls.Add(this.labelTaxaCrossover);
            this.panel1.Controls.Add(this.labelTamamnhoPop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1447, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 680);
            this.panel1.TabIndex = 0;
            // 
            // btnExecuteAndExport
            // 
            this.btnExecuteAndExport.Enabled = false;
            this.btnExecuteAndExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuteAndExport.Location = new System.Drawing.Point(288, 188);
            this.btnExecuteAndExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecuteAndExport.Name = "btnExecuteAndExport";
            this.btnExecuteAndExport.Size = new System.Drawing.Size(164, 50);
            this.btnExecuteAndExport.TabIndex = 24;
            this.btnExecuteAndExport.Text = "Executar e Exportar Resultados";
            this.btnExecuteAndExport.UseVisualStyleBackColor = true;
            this.btnExecuteAndExport.Click += new System.EventHandler(this.btnExecuteAndExport_Click);
            // 
            // botaoExportarMelhorIndiv
            // 
            this.botaoExportarMelhorIndiv.Enabled = false;
            this.botaoExportarMelhorIndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExportarMelhorIndiv.Location = new System.Drawing.Point(254, 249);
            this.botaoExportarMelhorIndiv.Margin = new System.Windows.Forms.Padding(2);
            this.botaoExportarMelhorIndiv.Name = "botaoExportarMelhorIndiv";
            this.botaoExportarMelhorIndiv.Size = new System.Drawing.Size(198, 37);
            this.botaoExportarMelhorIndiv.TabIndex = 23;
            this.botaoExportarMelhorIndiv.Text = "Exportar Melhor Individuo";
            this.botaoExportarMelhorIndiv.UseVisualStyleBackColor = true;
            this.botaoExportarMelhorIndiv.Click += new System.EventHandler(this.btnExportarMelhorIndiv_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(253, 623);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(175, 50);
            this.buttonExportar.TabIndex = 22;
            this.buttonExportar.Text = "Exportar Localidades";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // buttonTxt
            // 
            this.buttonTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTxt.Location = new System.Drawing.Point(41, 623);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(167, 50);
            this.buttonTxt.TabIndex = 21;
            this.buttonTxt.Text = "Importar Localidades";
            this.buttonTxt.UseVisualStyleBackColor = true;
            this.buttonTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // zedMedia
            // 
            this.zedMedia.Location = new System.Drawing.Point(14, 365);
            this.zedMedia.Name = "zedMedia";
            this.zedMedia.ScrollGrace = 0D;
            this.zedMedia.ScrollMaxX = 0D;
            this.zedMedia.ScrollMaxY = 0D;
            this.zedMedia.ScrollMaxY2 = 0D;
            this.zedMedia.ScrollMinX = 0D;
            this.zedMedia.ScrollMinY = 0D;
            this.zedMedia.ScrollMinY2 = 0D;
            this.zedMedia.Size = new System.Drawing.Size(448, 242);
            this.zedMedia.TabIndex = 20;
            // 
            // labelbMenorDistancia
            // 
            this.labelbMenorDistancia.AutoSize = true;
            this.labelbMenorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbMenorDistancia.Location = new System.Drawing.Point(176, 330);
            this.labelbMenorDistancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbMenorDistancia.Name = "labelbMenorDistancia";
            this.labelbMenorDistancia.Size = new System.Drawing.Size(32, 22);
            this.labelbMenorDistancia.TabIndex = 19;
            this.labelbMenorDistancia.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Menor Distância:";
            // 
            // labelEvolucoes
            // 
            this.labelEvolucoes.AutoSize = true;
            this.labelEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvolucoes.Location = new System.Drawing.Point(126, 308);
            this.labelEvolucoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvolucoes.Name = "labelEvolucoes";
            this.labelEvolucoes.Size = new System.Drawing.Size(32, 22);
            this.labelEvolucoes.TabIndex = 17;
            this.labelEvolucoes.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Evoluções:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Enabled = false;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(345, 296);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(107, 34);
            this.buttonLimpar.TabIndex = 15;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Enabled = false;
            this.buttonExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecutar.Location = new System.Drawing.Point(288, 134);
            this.buttonExecutar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(164, 50);
            this.buttonExecutar.TabIndex = 14;
            this.buttonExecutar.Text = "Executar/Continuar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // buttonCriarPop
            // 
            this.buttonCriarPop.Enabled = false;
            this.buttonCriarPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarPop.Location = new System.Drawing.Point(288, 77);
            this.buttonCriarPop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCriarPop.Name = "buttonCriarPop";
            this.buttonCriarPop.Size = new System.Drawing.Size(164, 50);
            this.buttonCriarPop.TabIndex = 13;
            this.buttonCriarPop.Text = "Criar População";
            this.buttonCriarPop.UseVisualStyleBackColor = true;
            this.buttonCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // groupBoxConfiguracao
            // 
            this.groupBoxConfiguracao.Controls.Add(this.rbFFMCR);
            this.groupBoxConfiguracao.Controls.Add(this.rbILM_DHC);
            this.groupBoxConfiguracao.Controls.Add(this.rbFixed);
            this.groupBoxConfiguracao.Controls.Add(this.rbDHM_ILC);
            this.groupBoxConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConfiguracao.Location = new System.Drawing.Point(18, 145);
            this.groupBoxConfiguracao.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConfiguracao.Name = "groupBoxConfiguracao";
            this.groupBoxConfiguracao.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConfiguracao.Size = new System.Drawing.Size(212, 145);
            this.groupBoxConfiguracao.TabIndex = 12;
            this.groupBoxConfiguracao.TabStop = false;
            this.groupBoxConfiguracao.Text = "Configuração";
            // 
            // rbFFMCR
            // 
            this.rbFFMCR.AutoSize = true;
            this.rbFFMCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFFMCR.Location = new System.Drawing.Point(20, 110);
            this.rbFFMCR.Margin = new System.Windows.Forms.Padding(2);
            this.rbFFMCR.Name = "rbFFMCR";
            this.rbFFMCR.Size = new System.Drawing.Size(83, 24);
            this.rbFFMCR.TabIndex = 23;
            this.rbFFMCR.Text = "FFMCR";
            this.rbFFMCR.UseVisualStyleBackColor = true;
            this.rbFFMCR.CheckedChanged += new System.EventHandler(this.rbFFMCR_CheckedChanged);
            // 
            // rbILM_DHC
            // 
            this.rbILM_DHC.AutoSize = true;
            this.rbILM_DHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbILM_DHC.Location = new System.Drawing.Point(20, 56);
            this.rbILM_DHC.Margin = new System.Windows.Forms.Padding(2);
            this.rbILM_DHC.Name = "rbILM_DHC";
            this.rbILM_DHC.Size = new System.Drawing.Size(93, 24);
            this.rbILM_DHC.TabIndex = 14;
            this.rbILM_DHC.Text = "ILM/DHC";
            this.rbILM_DHC.UseVisualStyleBackColor = true;
            this.rbILM_DHC.CheckedChanged += new System.EventHandler(this.rbILM_DHC_CheckedChanged);
            // 
            // rbFixed
            // 
            this.rbFixed.AutoSize = true;
            this.rbFixed.Checked = true;
            this.rbFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFixed.Location = new System.Drawing.Point(20, 84);
            this.rbFixed.Margin = new System.Windows.Forms.Padding(2);
            this.rbFixed.Name = "rbFixed";
            this.rbFixed.Size = new System.Drawing.Size(56, 24);
            this.rbFixed.TabIndex = 15;
            this.rbFixed.TabStop = true;
            this.rbFixed.Text = "Fixo";
            this.rbFixed.UseVisualStyleBackColor = true;
            this.rbFixed.CheckedChanged += new System.EventHandler(this.rbFixed_CheckedChanged);
            // 
            // rbDHM_ILC
            // 
            this.rbDHM_ILC.AutoSize = true;
            this.rbDHM_ILC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbDHM_ILC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDHM_ILC.Location = new System.Drawing.Point(20, 28);
            this.rbDHM_ILC.Margin = new System.Windows.Forms.Padding(2);
            this.rbDHM_ILC.Name = "rbDHM_ILC";
            this.rbDHM_ILC.Size = new System.Drawing.Size(93, 24);
            this.rbDHM_ILC.TabIndex = 13;
            this.rbDHM_ILC.Text = "DHM/ILC";
            this.rbDHM_ILC.UseVisualStyleBackColor = false;
            this.rbDHM_ILC.CheckedChanged += new System.EventHandler(this.rbDHM_ILC_CheckedChanged);
            // 
            // labelTamannhoTorneio
            // 
            this.labelTamannhoTorneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamannhoTorneio.Location = new System.Drawing.Point(388, 26);
            this.labelTamannhoTorneio.Margin = new System.Windows.Forms.Padding(2);
            this.labelTamannhoTorneio.Mask = "0";
            this.labelTamannhoTorneio.Name = "labelTamannhoTorneio";
            this.labelTamannhoTorneio.Size = new System.Drawing.Size(29, 26);
            this.labelTamannhoTorneio.TabIndex = 11;
            this.labelTamannhoTorneio.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Torneio:";
            // 
            // labelEvolucao
            // 
            this.labelEvolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvolucao.Location = new System.Drawing.Point(146, 106);
            this.labelEvolucao.Margin = new System.Windows.Forms.Padding(2);
            this.labelEvolucao.Mask = "0000";
            this.labelEvolucao.Name = "labelEvolucao";
            this.labelEvolucao.Size = new System.Drawing.Size(122, 26);
            this.labelEvolucao.TabIndex = 7;
            this.labelEvolucao.Text = "1600";
            // 
            // labelTaxaMutacao
            // 
            this.labelTaxaMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxaMutacao.Location = new System.Drawing.Point(146, 77);
            this.labelTaxaMutacao.Margin = new System.Windows.Forms.Padding(2);
            this.labelTaxaMutacao.Mask = "0.000000";
            this.labelTaxaMutacao.Name = "labelTaxaMutacao";
            this.labelTaxaMutacao.Size = new System.Drawing.Size(122, 26);
            this.labelTaxaMutacao.TabIndex = 6;
            this.labelTaxaMutacao.Text = "0030";
            // 
            // labelTaxaCrossover
            // 
            this.labelTaxaCrossover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxaCrossover.Location = new System.Drawing.Point(146, 49);
            this.labelTaxaCrossover.Margin = new System.Windows.Forms.Padding(2);
            this.labelTaxaCrossover.Mask = "0.000000";
            this.labelTaxaCrossover.Name = "labelTaxaCrossover";
            this.labelTaxaCrossover.Size = new System.Drawing.Size(122, 26);
            this.labelTaxaCrossover.TabIndex = 5;
            this.labelTaxaCrossover.Text = "0900";
            // 
            // labelTamamnhoPop
            // 
            this.labelTamamnhoPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamamnhoPop.Location = new System.Drawing.Point(146, 20);
            this.labelTamamnhoPop.Margin = new System.Windows.Forms.Padding(2);
            this.labelTamamnhoPop.Mask = "00000";
            this.labelTamamnhoPop.Name = "labelTamamnhoPop";
            this.labelTamamnhoPop.Size = new System.Drawing.Size(122, 26);
            this.labelTamamnhoPop.TabIndex = 4;
            this.labelTamamnhoPop.Text = "400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evoluções:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taxa de Mutação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de Crossver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho Pop:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1457, 975);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantidade de Cidades:";
            // 
            // labelQtdeCidades
            // 
            this.labelQtdeCidades.AutoSize = true;
            this.labelQtdeCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdeCidades.Location = new System.Drawing.Point(1636, 975);
            this.labelQtdeCidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtdeCidades.Name = "labelQtdeCidades";
            this.labelQtdeCidades.Size = new System.Drawing.Size(19, 20);
            this.labelQtdeCidades.TabIndex = 2;
            this.labelQtdeCidades.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1458, 995);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Complexidade:";
            // 
            // lbComplex
            // 
            this.lbComplex.AutoSize = true;
            this.lbComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplex.Location = new System.Drawing.Point(1562, 995);
            this.lbComplex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComplex.Name = "lbComplex";
            this.lbComplex.Size = new System.Drawing.Size(16, 17);
            this.lbComplex.TabIndex = 4;
            this.lbComplex.Text = "0";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 1012);
            this.Controls.Add(this.lbComplex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelQtdeCidades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConfiguracaoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxConfiguracao.ResumeLayout(false);
            this.groupBoxConfiguracao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxConfiguracao;
        private System.Windows.Forms.RadioButton rbILM_DHC;
        private System.Windows.Forms.RadioButton rbDHM_ILC;
        private System.Windows.Forms.MaskedTextBox labelTamannhoTorneio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox labelEvolucao;
        private System.Windows.Forms.MaskedTextBox labelTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox labelTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox labelTamamnhoPop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.Button buttonCriarPop;
        private ZedGraph.ZedGraphControl zedMedia;
        private System.Windows.Forms.Label labelbMenorDistancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEvolucoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelQtdeCidades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbComplex;
        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.RadioButton rbFFMCR;
        private System.Windows.Forms.RadioButton rbFixed;
        private System.Windows.Forms.Button botaoExportarMelhorIndiv;
        private System.Windows.Forms.Button btnExecuteAndExport;
    }
}

