namespace Projekt_1
{
    partial class frmSearchPizza
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
            this.pizzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPizzaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPizzaDataSet = new Projekt_1.dbPizzaDataSet();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.pizzeTableAdapter = new Projekt_1.dbPizzaDataSetTableAdapters.PizzeTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazwaPizzy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzeBindingSource
            // 
            this.pizzeBindingSource.DataMember = "Pizze";
            this.pizzeBindingSource.DataSource = this.dbPizzaDataSetBindingSource;
            // 
            // dbPizzaDataSetBindingSource
            // 
            this.dbPizzaDataSetBindingSource.DataSource = this.dbPizzaDataSet;
            this.dbPizzaDataSetBindingSource.Position = 0;
            // 
            // dbPizzaDataSet
            // 
            this.dbPizzaDataSet.DataSetName = "dbPizzaDataSet";
            this.dbPizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(378, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(261, 10);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 1;
            this.btnSearch1.Text = "&Szukaj";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // pizzeTableAdapter
            // 
            this.pizzeTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwaPizzy,
            this.CenaJednostkowa,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.pizzeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 225);
            this.dataGridView1.TabIndex = 4;
            // 
            // NazwaPizzy
            // 
            this.NazwaPizzy.DataPropertyName = "NazwaPizzy";
            this.NazwaPizzy.HeaderText = "NazwaPizzy";
            this.NazwaPizzy.Name = "NazwaPizzy";
            // 
            // CenaJednostkowa
            // 
            this.CenaJednostkowa.DataPropertyName = "CenaJednostkowa";
            this.CenaJednostkowa.HeaderText = "CenaJednostkowa";
            this.CenaJednostkowa.Name = "CenaJednostkowa";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ilosc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ilosc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Składniki";
            this.dataGridViewTextBoxColumn2.HeaderText = "Składniki";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmSearchPizza
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch);
            this.MaximizeBox = false;
            this.Name = "frmSearchPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchPizza";
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource dbPizzaDataSetBindingSource;
        private dbPizzaDataSet dbPizzaDataSet;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.BindingSource pizzeBindingSource;
        private dbPizzaDataSetTableAdapters.PizzeTableAdapter pizzeTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaPizzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}