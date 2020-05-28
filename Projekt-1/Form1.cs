using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_1
{
    public partial class Form1 : Form
    {
        PizzaEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new PizzaEntities();
            pizzeBindingSource.DataSource = db.Pizze.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(frmAddEditPizza frm = new frmAddEditPizza(null))
            { 
                if (frm.ShowDialog() == DialogResult.OK)
                    pizzeBindingSource.DataSource = db.Pizze.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pizzeBindingSource.Current == null)
                return;
            using (frmAddEditPizza frm = new frmAddEditPizza(pizzeBindingSource.Current as Pizze))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    pizzeBindingSource.DataSource = db.Pizze.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (pizzeBindingSource.Current != null)
            {
                if(MessageBox.Show("Czy na pewno chcesz to usunąć?", "Wiadomość", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Pizze.Remove(pizzeBindingSource.Current as Pizze);
                    pizzeBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }
    }
}
