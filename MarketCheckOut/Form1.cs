using System.ComponentModel;
using System.Text.RegularExpressions;

namespace MarketCheckOut
{
    public partial class Form1 : Form
    {
        decimal toplamBakiye = 0;
        BindingList<Product> products = new BindingList<Product>();

        Product product;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            sepetGrid.AutoGenerateColumns = true;

            sepetGrid.DataSource = products;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Sil";
            deleteButton.UseColumnTextForButtonValue = true;

            sepetGrid.Columns.Add(deleteButton);

            sepetGrid.Columns[0].Visible = false;

            SepetToplam();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SepetiGoster()
        {
            sepetGrid.DataSource = null;
            sepetGrid.DataSource = products;

            SepetToplam();
        }

        private void SepetToplam()
        {
            decimal toplam = products.Sum(p => p.TotalPrice);

            lbToplamBakiye.Text = String.Format("{0:C2}", toplam);
        }

        private void AddToBasket(string _name, decimal _unitPrice)
        {
            gbMiktar.Visible = true;
            BtnDurumDegis(false);

            product = new Product(products.Count + 1, _name, 1, _unitPrice);
        }

        // -------------- Ürün ekleme kısmı ---------------------
        private void btnDomates_click(object sender, EventArgs e)
        {
            AddToBasket("Domates", 18);
        }

        private void btnBiber_Click(object sender, EventArgs e)
        {
            AddToBasket("Biber", 34);
        }

        private void btnPatlican_Click(object sender, EventArgs e)
        {
            AddToBasket("Patlıcan", 27);
        }

        private void btnGazoz_Click(object sender, EventArgs e)
        {
            AddToBasket("Gazoz", 25);
        }

        private void btnBaklava_Click(object sender, EventArgs e)
        {
            AddToBasket("Baklava", 250);
        }

        private void btnPeynirHelva_Click(object sender, EventArgs e)
        {
            AddToBasket("Peynir Helvası (350 gr.)", 200);
        }

        private void btnDondurma_Click(object sender, EventArgs e)
        {
            AddToBasket("Dondurma", 500);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            AddToBasket("Çikolata", 100);
        }

        private void btnSoda_Click(object sender, EventArgs e)
        {
            AddToBasket("Sade Soda", 49);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtMiktar.Text);

            var existingProduct = products.FirstOrDefault(p => p.Name == product.Name);

            if (existingProduct != null)
            {
                existingProduct.Quantity += qty;
                existingProduct.TotalPrice = existingProduct.Quantity * existingProduct.UnitPrice;
            }
            else
            {
                product.Quantity = qty;
                product.TotalPrice = product.Quantity * product.UnitPrice;

                products.Add(product);
            }

            sepetGrid.Refresh();

            gbMiktar.Visible = false;
            BtnDurumDegis(true);

            SepetToplam();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            gbMiktar.Visible = false;
            BtnDurumDegis(true);
        }

        private void BtnDurumDegis(bool status)
        {
            txtMiktar.Text = "1";
            btnDomates.Enabled = status;
            btnBaklava.Enabled = status;
            btnChocolate.Enabled = status;
            btnBiber.Enabled = status;
            btnGazoz.Enabled = status;
            btnKredi.Enabled = status;
            btnPatlican.Enabled = status;
            btnPeynirHelva.Enabled = status;
            btnSoda.Enabled = status;
            btnNakit.Enabled = status;
            btnKapat.Enabled = status;
            btnDondurma.Enabled = status;
        }

        private void txtMiktar_Changed(object sender, EventArgs e)
        {
            string input = txtMiktar.Text;
            if (Regex.IsMatch(input, "[^0-9]"))
            {
                MessageBox.Show("Yalnızca rakam girebilirsiniz!");
                txtMiktar.Text = input.Remove(input.Length - 1);
                txtMiktar.Focus();
                txtMiktar.SelectAll();
            }
        }

        private void sepetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sepetGrid.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Ürünü silmek istiyor musunuz?",
                                   "Onay",
                                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    products.RemoveAt(e.RowIndex);

                    SepetToplam();
                }
            }
        }
    }
}
