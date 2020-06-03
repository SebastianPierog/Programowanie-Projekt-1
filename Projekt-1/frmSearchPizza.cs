using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projekt_1
{
    
    public partial class frmSearchPizza : Form
    {
        PizzaEntities szukamy;
        

        public frmSearchPizza(object p)
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            szukamy = new PizzaEntities();
            string Box = txtSearch.Text;
            List<Pizze> Pizzunia = new List<Pizze>();

            Pizzunia = szukamy.Pizze.ToList();

            string x = Pizzunia[0].NazwaPizzy;

            List<Pizze> Znalezione = new List<Pizze>();

            for (int i = 0; i < Pizzunia.Count; i++)
            {
                if (Pizzunia[i].NazwaPizzy == Box)
                {
                    Znalezione.Add(Pizzunia[i]);

                }
            }

             pizzeBindingSource.DataSource = Znalezione;
        }

  
    }
}
