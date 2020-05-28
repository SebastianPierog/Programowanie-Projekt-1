using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Projekt_1
{
    public partial class frmAddEditPizza : Form
    {
        PizzaEntities db;
        public frmAddEditPizza(Pizze obj)
        {
            InitializeComponent();
            db = new PizzaEntities();
            if(obj == null)
            {
                pizzeBindingSource.DataSource = new Pizze();
                db.Pizze.Add(pizzeBindingSource.Current as Pizze);
            }
            else
            {
                pizzeBindingSource.DataSource = obj;
                db.Pizze.Attach(pizzeBindingSource.Current as Pizze);
            }
        }

        private void frmAddEditPizza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtNazwaPizzy.Text))
                {
                    MessageBox.Show("Proszę wprowadzić nazwę Pizzy!", "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNazwaPizzy.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
