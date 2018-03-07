using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkDemo;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal=new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                Stock = Convert.ToInt32(tbxStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Added !");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                // ID değişmediği için Data Gridden alıyoruz 
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                //Diğerlerini Update 'den alıyoruz
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                Stock = Convert.ToInt32(tbxStockUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated....");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                
            });
            LoadProducts();
            MessageBox.Show("Deleted...");
        }

        private void SearchProducts(string key)
        {
            
            //dgwProducts.DataSource=_productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
            //Direk veritabanından Çekmek için

            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;


        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetById(7);
        }
    }
}
