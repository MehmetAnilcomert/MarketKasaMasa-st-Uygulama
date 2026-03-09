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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplam();

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDomates_click(object sender, EventArgs e)
        {
            Product domates = new Product(products.Count+1, "Domates", 2, 18);
            products.Add(domates);
            SepetiGoster();
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
    }
}
