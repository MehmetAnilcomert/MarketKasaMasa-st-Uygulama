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
            ((System.ComponentModel.ISupportInitialize)sepetGrid).BeginInit();
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
            btnPatlican.Click += button3_Click_1;
            // 
            // btnKredi
            // 
            btnKredi.Font = new Font("Segoe UI", 16.2F);
            btnKredi.Location = new Point(12, 646);
            btnKredi.Name = "btnKredi";
            btnKredi.Size = new Size(202, 141);
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
            // 
            // btnNakit
            // 
            btnNakit.Font = new Font("Segoe UI", 16.2F);
            btnNakit.Location = new Point(220, 646);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(202, 141);
            btnNakit.TabIndex = 7;
            btnNakit.TabStop = false;
            btnNakit.Text = "Nakit";
            btnNakit.UseVisualStyleBackColor = true;
            // 
            // sepetGrid
            // 
            sepetGrid.BackgroundColor = Color.RosyBrown;
            sepetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sepetGrid.Location = new Point(649, 12);
            sepetGrid.Name = "sepetGrid";
            sepetGrid.RowHeadersWidth = 51;
            sepetGrid.Size = new Size(678, 634);
            sepetGrid.TabIndex = 8;
            sepetGrid.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(828, 649);
            label1.Name = "label1";
            label1.Size = new Size(430, 138);
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
            btnDondurma.Click += button11_Click;
            // 
            // lbToplamBakiye
            // 
            lbToplamBakiye.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbToplamBakiye.ForeColor = Color.ForestGreen;
            lbToplamBakiye.Location = new Point(975, 709);
            lbToplamBakiye.Name = "lbToplamBakiye";
            lbToplamBakiye.Size = new Size(218, 62);
            lbToplamBakiye.TabIndex = 13;
            lbToplamBakiye.Text = "0.00";
            lbToplamBakiye.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 799);
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
    }
}
