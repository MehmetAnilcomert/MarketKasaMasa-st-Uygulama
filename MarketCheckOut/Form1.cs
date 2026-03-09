using MarketCheckOut.BasketFeature;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MarketCheckOut
{
    public partial class Form1 : Form
    {
        private BasketViewModel vm = new BasketViewModel();

        private string selectedProductName;
        private decimal selectedProductPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Grid ve binding
            sepetGrid.AutoGenerateColumns = true;
            sepetGrid.DataSource = vm.Products;
            sepetGrid.AllowUserToAddRows = false;

            // Silme butonu
            if (!sepetGrid.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.Text = "Sil";
                deleteButton.UseColumnTextForButtonValue = true;
                sepetGrid.Columns.Add(deleteButton);
            }

            // Toplam label güncelle
            vm.PropertyChanged += (s, ev) =>
            {
                if (ev.PropertyName == nameof(vm.Total))
                    lbToplamBakiye.Text = $"{vm.Total:C2}";
            };

            txtMiktar.Text = "1";
            btnDomates.Tag = 18m;
            btnBiber.Tag = 34m;
            btnPatlican.Tag = 27m;
            btnGazoz.Tag = 25m;
            btnBaklava.Tag = 250m;
            btnPeynirHelva.Tag = 200m;
            btnDondurma.Tag = 500m;
            btnChocolate.Tag = 100m;
            btnSoda.Tag = 49m;
        }

        // Tüm ürün butonları tek metotla handle ediliyor
        private void btnUrun_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            selectedProductName = btn.Text;
            selectedProductPrice = Convert.ToDecimal(btn.Tag);

            gbMiktar.Visible = true;

            txtMiktar.Focus();
            txtMiktar.SelectAll();
        }

        // Kaydet butonu: miktarı al ve sepete ekle
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMiktar.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Geçerli bir miktar girin!");
                return;
            }

            if (selectedProductName == null)
                return;

            vm.AddProduct(selectedProductName, selectedProductPrice, qty);

            CancelProductSelection();
        }

        // Silme butonu
        private void sepetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sepetGrid.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                var product = (Product)sepetGrid.Rows[e.RowIndex].DataBoundItem;
                if (MessageBox.Show("Ürünü silmek istiyor musunuz?", "Onay",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vm.RemoveProduct(product);
                }
            }
        }

        // Miktar textbox validation
        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            string input = txtMiktar.Text;
            if (Regex.IsMatch(input, "[^0-9]"))
            {
                MessageBox.Show("Yalnızca rakam girebilirsiniz!");
                if (input.Length > 0)
                    txtMiktar.Text = input.Remove(input.Length - 1);
                txtMiktar.Focus();
                txtMiktar.SelectAll();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            CancelProductSelection();
        }

        private void CancelProductSelection()
        {
            selectedProductName = null;
            selectedProductPrice = 0;

            txtMiktar.Text = "1";

            gbMiktar.Visible = false;
        }

        private void btnKredi_Click(object sender, EventArgs e)
        {
            ShowMessage("Kredi kartı ile ödeme gerçekleştirildi");
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            ShowMessage("Nakit olarak ödeme gerçekleştirildi");
        }

        private void ShowMessage(string message)
        {
            if (vm.Products.Count > 0)
            {
                vm.RemoveAllProducts();
                MessageBox.Show(message, "Ödeme Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sepette ürün bulunamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}