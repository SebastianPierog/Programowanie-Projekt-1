namespace Projekt_1
{
    partial class frmAddEditPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.pizzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPizzaDataSet = new Projekt_1.dbPizzaDataSet();
            this.txtNazwaPizzy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCenaJednostkowa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSkladniki = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pizzeTableAdapter = new Projekt_1.dbPizzaDataSetTableAdapters.PizzeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(272, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pizzeBindingSource
            // 
            this.pizzeBindingSource.DataMember = "Pizze";
            this.pizzeBindingSource.DataSource = this.dbPizzaDataSet;
            // 
            // dbPizzaDataSet
            // 
            this.dbPizzaDataSet.DataSetName = "dbPizzaDataSet";
            this.dbPizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNazwaPizzy
            // 
            this.txtNazwaPizzy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pizzeBindingSource, "NazwaPizzy", true));
            this.txtNazwaPizzy.Location = new System.Drawing.Point(137, 38);
            this.txtNazwaPizzy.Name = "txtNazwaPizzy";
            this.txtNazwaPizzy.Size = new System.Drawing.Size(210, 20);
            this.txtNazwaPizzy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa Pizzy";
            // 
            // txtIlosc
            // 
            this.txtIlosc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pizzeBindingSource, "Ilosc", true));
            this.txtIlosc.Location = new System.Drawing.Point(137, 77);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(210, 20);
            this.txtIlosc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilosc";
            // 
            // txtCenaJednostkowa
            // 
            this.txtCenaJednostkowa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pizzeBindingSource, "CenaJednostkowa", true));
            this.txtCenaJednostkowa.Location = new System.Drawing.Point(137, 117);
            this.txtCenaJednostkowa.Name = "txtCenaJednostkowa";
            this.txtCenaJednostkowa.Size = new System.Drawing.Size(210, 20);
            this.txtCenaJednostkowa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena Jednostkowa";
            // 
            // txtSkladniki
            // 
            this.txtSkladniki.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pizzeBindingSource, "Składniki", true));
            this.txtSkladniki.Location = new System.Drawing.Point(137, 155);
            this.txtSkladniki.Name = "txtSkladniki";
            this.txtSkladniki.Size = new System.Drawing.Size(210, 20);
            this.txtSkladniki.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Składniki";
            // 
            // pizzeTableAdapter
            // 
            this.pizzeTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddEditPizza
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.txtSkladniki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCenaJednostkowa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazwaPizzy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddEditPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj/Edytuj Pizze";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditPizza_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNazwaPizzy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCenaJednostkowa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSkladniki;
        private System.Windows.Forms.Label label5;
        private dbPizzaDataSet dbPizzaDataSet;
        private System.Windows.Forms.BindingSource pizzeBindingSource;
        private dbPizzaDataSetTableAdapters.PizzeTableAdapter pizzeTableAdapter;
    }
}