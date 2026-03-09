namespace MarketCheckOut
{
    public partial class Form1 : Form
    {
        decimal toplamBakiye = 0;
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplam();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SepetiGoster()
        {
            sepetGrid.DataSource = "";
            sepetGrid.DataSource = products;

            sepetGrid.Columns[0].Visible = false;
            sepetGrid.Columns[1].HeaderText = "Ürün Adı";
            sepetGrid.Columns[2].HeaderText = "Ürün Miktarı";
            sepetGrid.Columns[3].HeaderText = "Birim Fiyatı";
            sepetGrid.Columns[4].HeaderText = "Toplam Fiyatı";

            SepetToplam();
        }

        private void SepetToplam()
        {
            decimal toplam = 0;
            foreach (var item in products)
            {
                toplam += item.TotalPrice;
            }
            lbToplamBakiye.Text = String.Format("{0:C2}", toplam);
        }

        private void AddToBasket(string _name, int _quantity, decimal _unitPrice)
        {
            Product product = new Product(products.Count + 1, _name, _quantity, _unitPrice);
            products.Add(product);
            SepetiGoster();
        }

        // -------------- Ürün ekleme kısmı ---------------------
        private void btnDomates_click(object sender, EventArgs e)
        {
            AddToBasket("Domates", 2, 18);
        }

        private void btnBiber_Click(object sender, EventArgs e)
        {
            AddToBasket("Biber", 5, 34);
        }

        private void btnPatlican_Click(object sender, EventArgs e)
        {
            AddToBasket("Patlıcan", 3, 27);
        }

        private void btnGazoz_Click(object sender, EventArgs e)
        {
            AddToBasket("Gazoz", 1, 25);
        }

        private void btnBaklava_Click(object sender, EventArgs e)
        {
            AddToBasket("Baklava", 1, 250);
        }

        private void btnPeynirHelva_Click(object sender, EventArgs e)
        {
            AddToBasket("Peynir Helvası (350 gr.)", 1, 200);
        }

        private void btnDondurma_Click(object sender, EventArgs e)
        {
            AddToBasket("Dondurma", 1, 500);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            AddToBasket("Çikolata", 5, 100);
        }

        private void btnSoda_Click(object sender, EventArgs e)
        {
            AddToBasket("Sade Soda", 6, 49);
        }
    }
}
