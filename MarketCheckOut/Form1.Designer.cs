namespace MarketCheckOut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDomates = new Button();
            btnBiber = new Button();
            btnPatlican = new Button();
            btnKredi = new Button();
            btnPeynirHelva = new Button();
            btnBaklava = new Button();
            btnGazoz = new Button();
            btnNakit = new Button();
            sepetGrid = new DataGridView();
            label1 = new Label();
            btnSoda = new Button();
            btnChocolate = new Button();
            btnDondurma = new Button();
            lbToplamBakiye = new Label();
            btnKapat = new Button();
            gbMiktar = new GroupBox();
            txtMiktar = new TextBox();
            btnVazgec = new Button();
            btnKaydet = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)sepetGrid).BeginInit();
            gbMiktar.SuspendLayout();
            SuspendLayout();
            // 
            // btnDomates
            // 
            btnDomates.Font = new Font("Segoe UI", 16.2F);
            btnDomates.Location = new Point(12, 12);
            btnDomates.Name = "btnDomates";
            btnDomates.Size = new Size(191, 181);
            btnDomates.TabIndex = 0;
            btnDomates.TabStop = false;
            btnDomates.Text = "Domates";
            btnDomates.UseVisualStyleBackColor = true;
            btnDomates.Click += btnDomates_click;
            // 
            // btnBiber
            // 
            btnBiber.Font = new Font("Segoe UI", 16.2F);
            btnBiber.Location = new Point(209, 12);
            btnBiber.Name = "btnBiber";
            btnBiber.Size = new Size(191, 181);
            btnBiber.TabIndex = 1;
            btnBiber.TabStop = false;
            btnBiber.Text = "Biber";
            btnBiber.UseVisualStyleBackColor = true;
            btnBiber.Click += btnBiber_Click;
            // 
            // btnPatlican
            // 
            btnPatlican.Font = new Font("Segoe UI", 16.2F);
            btnPatlican.Location = new Point(406, 12);
            btnPatlican.Name = "btnPatlican";
            btnPatlican.Size = new Size(191, 181);
            btnPatlican.TabIndex = 2;
            btnPatlican.TabStop = false;
            btnPatlican.Text = "Patlıcan";
            btnPatlican.UseVisualStyleBackColor = true;
            btnPatlican.Click += btnPatlican_Click;
            // 
            // btnKredi
            // 
            btnKredi.Font = new Font("Segoe UI", 16.2F);
            btnKredi.Location = new Point(12, 649);
            btnKredi.Name = "btnKredi";
            btnKredi.Size = new Size(191, 138);
            btnKredi.TabIndex = 3;
            btnKredi.TabStop = false;
            btnKredi.Text = "Kredi Kartı";
            btnKredi.UseVisualStyleBackColor = true;
            btnKredi.Click += button4_Click;
            // 
            // btnPeynirHelva
            // 
            btnPeynirHelva.Font = new Font("Segoe UI", 16.2F);
            btnPeynirHelva.Location = new Point(406, 199);
            btnPeynirHelva.Name = "btnPeynirHelva";
            btnPeynirHelva.Size = new Size(191, 181);
            btnPeynirHelva.TabIndex = 6;
            btnPeynirHelva.TabStop = false;
            btnPeynirHelva.Text = "Peynir Helvası (350 gr.)";
            btnPeynirHelva.UseVisualStyleBackColor = true;
            btnPeynirHelva.Click += btnPeynirHelva_Click;
            // 
            // btnBaklava
            // 
            btnBaklava.Font = new Font("Segoe UI", 16.2F);
            btnBaklava.Location = new Point(209, 199);
            btnBaklava.Name = "btnBaklava";
            btnBaklava.Size = new Size(191, 181);
            btnBaklava.TabIndex = 5;
            btnBaklava.TabStop = false;
            btnBaklava.Text = "Baklava";
            btnBaklava.UseVisualStyleBackColor = true;
            btnBaklava.Click += btnBaklava_Click;
            // 
            // btnGazoz
            // 
            btnGazoz.Font = new Font("Segoe UI", 16.2F);
            btnGazoz.Location = new Point(12, 199);
            btnGazoz.Name = "btnGazoz";
            btnGazoz.Size = new Size(191, 181);
            btnGazoz.TabIndex = 4;
            btnGazoz.TabStop = false;
            btnGazoz.Text = "Gazoz";
            btnGazoz.UseVisualStyleBackColor = true;
            btnGazoz.Click += btnGazoz_Click;
            // 
            // btnNakit
            // 
            btnNakit.Font = new Font("Segoe UI", 16.2F);
            btnNakit.Location = new Point(209, 649);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(191, 138);
            btnNakit.TabIndex = 7;
            btnNakit.TabStop = false;
            btnNakit.Text = "Nakit";
            btnNakit.UseVisualStyleBackColor = true;
            // 
            // sepetGrid
            // 
            sepetGrid.AllowUserToOrderColumns = true;
            sepetGrid.BackgroundColor = Color.RosyBrown;
            sepetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sepetGrid.Location = new Point(681, 12);
            sepetGrid.Name = "sepetGrid";
            sepetGrid.RowHeadersWidth = 51;
            sepetGrid.Size = new Size(681, 634);
            sepetGrid.TabIndex = 8;
            sepetGrid.TabStop = false;
            sepetGrid.CellContentClick += sepetGrid_CellContentClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(898, 649);
            label1.Name = "label1";
            label1.Size = new Size(360, 138);
            label1.TabIndex = 9;
            label1.Text = "Toplam Bakiye:";
            // 
            // btnSoda
            // 
            btnSoda.Font = new Font("Segoe UI", 16.2F);
            btnSoda.Location = new Point(406, 386);
            btnSoda.Name = "btnSoda";
            btnSoda.Size = new Size(191, 181);
            btnSoda.TabIndex = 12;
            btnSoda.TabStop = false;
            btnSoda.Text = "Sade Soda";
            btnSoda.UseVisualStyleBackColor = true;
            btnSoda.Click += btnSoda_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.Font = new Font("Segoe UI", 16.2F);
            btnChocolate.Location = new Point(209, 386);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(191, 181);
            btnChocolate.TabIndex = 11;
            btnChocolate.TabStop = false;
            btnChocolate.Text = "Çikolata";
            btnChocolate.UseVisualStyleBackColor = true;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // btnDondurma
            // 
            btnDondurma.Font = new Font("Segoe UI", 16.2F);
            btnDondurma.Location = new Point(12, 386);
            btnDondurma.Name = "btnDondurma";
            btnDondurma.Size = new Size(191, 181);
            btnDondurma.TabIndex = 10;
            btnDondurma.TabStop = false;
            btnDondurma.Text = "Dondurma";
            btnDondurma.UseVisualStyleBackColor = true;
            btnDondurma.Click += btnDondurma_Click;
            // 
            // lbToplamBakiye
            // 
            lbToplamBakiye.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbToplamBakiye.ForeColor = Color.ForestGreen;
            lbToplamBakiye.Location = new Point(1045, 709);
            lbToplamBakiye.Name = "lbToplamBakiye";
            lbToplamBakiye.Size = new Size(148, 62);
            lbToplamBakiye.TabIndex = 13;
            lbToplamBakiye.Text = "0.00";
            lbToplamBakiye.Click += label2_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(192, 64, 0);
            btnKapat.Font = new Font("Segoe UI", 16.2F);
            btnKapat.ForeColor = SystemColors.ButtonFace;
            btnKapat.Location = new Point(406, 649);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(191, 141);
            btnKapat.TabIndex = 14;
            btnKapat.TabStop = false;
            btnKapat.Text = "Formu Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // gbMiktar
            // 
            gbMiktar.Controls.Add(txtMiktar);
            gbMiktar.Controls.Add(btnVazgec);
            gbMiktar.Controls.Add(btnKaydet);
            gbMiktar.Controls.Add(label2);
            gbMiktar.Location = new Point(532, 353);
            gbMiktar.Name = "gbMiktar";
            gbMiktar.Size = new Size(243, 214);
            gbMiktar.TabIndex = 15;
            gbMiktar.TabStop = false;
            gbMiktar.Visible = false;
            gbMiktar.Enter += groupBox1_Enter;
            // 
            // txtMiktar
            // 
            txtMiktar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMiktar.Location = new Point(42, 48);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(142, 38);
            txtMiktar.TabIndex = 0;
            txtMiktar.Text = "1";
            txtMiktar.TextAlign = HorizontalAlignment.Center;
            txtMiktar.TextChanged += txtMiktar_Changed;
            // 
            // btnVazgec
            // 
            btnVazgec.BackColor = Color.OrangeRed;
            btnVazgec.ForeColor = SystemColors.ButtonHighlight;
            btnVazgec.Location = new Point(57, 160);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(116, 36);
            btnVazgec.TabIndex = 2;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = false;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(57, 109);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(116, 36);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.Location = new Point(81, 13);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 0;
            label2.Text = "Miktar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 799);
            Controls.Add(gbMiktar);
            Controls.Add(btnKapat);
            Controls.Add(lbToplamBakiye);
            Controls.Add(btnSoda);
            Controls.Add(btnChocolate);
            Controls.Add(btnDondurma);
            Controls.Add(label1);
            Controls.Add(sepetGrid);
            Controls.Add(btnNakit);
            Controls.Add(btnPeynirHelva);
            Controls.Add(btnBaklava);
            Controls.Add(btnGazoz);
            Controls.Add(btnKredi);
            Controls.Add(btnPatlican);
            Controls.Add(btnBiber);
            Controls.Add(btnDomates);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnadoluTat1071 Market";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sepetGrid).EndInit();
            gbMiktar.ResumeLayout(false);
            gbMiktar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDomates;
        private Button btnBiber;
        private Button btnPatlican;
        private Button btnKredi;
        private Button btnPeynirHelva;
        private Button btnBaklava;
        private Button btnGazoz;
        private Button btnNakit;
        private DataGridView sepetGrid;
        private Label label1;
        private Button btnSoda;
        private Button btnChocolate;
        private Button btnDondurma;
        private Label lbToplamBakiye;
        private Button btnKapat;
        private GroupBox gbMiktar;
        private Button btnVazgec;
        private Button btnKaydet;
        private Label label2;
        private TextBox txtMiktar;
    }
}
