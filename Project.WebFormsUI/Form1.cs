using Project.Business.Abstract;
using Project.Business.Concrete;
using Project.DataAccess.Concrete.EntityFramework;
using Project.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        IProductService _productService;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
