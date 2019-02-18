using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    List<products> products = new List<products>
    {
        MessageBox.Show("Ready to Serve");
    }
    List<Product> shoppingCart = new List<Product>
    {
        final int CAPACITY = 15;
    }
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

    Boolean addProduct(Product prod)
    {
        if (products.size() < CAPACITY && findProduct(prod) == -1)
        {
            products.add(prod);
            this.GetType(products);
            ruturn true;
        }
        return false;
    }

    public class drinks : Form1, Inventory
    {
        public void JumpToProd(int x, int y);
    }

    public void Clear()
    {
        throw new System.Exception("Not yet created");
    }

    public void Update()
    {
        throw new System.Exception("Not yet created");
    }

    private String name;

    public string name()
    {
        throw new System.Exception("Not yet created");
    }


}
