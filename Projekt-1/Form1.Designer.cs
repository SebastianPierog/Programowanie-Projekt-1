namespace Projekt_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dbPizzaDataSet = new Projekt_1.dbPizzaDataSet();
            this.pizzeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeTableAdapter = new Projekt_1.dbPizzaDataSetTableAdapters.PizzeTableAdapter();
            this.NazwaPizzy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.składnikiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "&Usun";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.składnikiDataGridViewTextBoxColumn,
            this.NazwaPizzy,
            this.CenaJednostkowa});
            this.dataGridView.DataSource = this.pizzeBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 397);
            this.dataGridView.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(632, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(551, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dbPizzaDataSet
            // 
            this.dbPizzaDataSet.DataSetName = "dbPizzaDataSet";
            this.dbPizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzeBindingSource1
            // 
            this.pizzeBindingSource1.DataMember = "Pizze";
            this.pizzeBindingSource1.DataSource = this.dbPizzaDataSet;
            // 
            // pizzeTableAdapter
            // 
            this.pizzeTableAdapter.ClearBeforeFill = true;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            // 
            // składnikiDataGridViewTextBoxColumn
            // 
            this.składnikiDataGridViewTextBoxColumn.DataPropertyName = "Składniki";
            this.składnikiDataGridViewTextBoxColumn.HeaderText = "Składniki";
            this.składnikiDataGridViewTextBoxColumn.Name = "składnikiDataGridViewTextBoxColumn";
            // 
            // pizzeBindingSource
            // 
            this.pizzeBindingSource.DataSource = typeof(Projekt_1.Pizze);
            // 
            // pizzaEntitiesBindingSource
            // 
            this.pizzaEntitiesBindingSource.DataSource = typeof(Projekt_1.PizzaEntities);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPizzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource pizzeBindingSource;
        private System.Windows.Forms.BindingSource pizzaEntitiesBindingSource;
        private dbPizzaDataSet dbPizzaDataSet;
        private System.Windows.Forms.BindingSource pizzeBindingSource1;
        private dbPizzaDataSetTableAdapters.PizzeTableAdapter pizzeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaPizzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn składnikiDataGridViewTextBoxColumn;
    }
}

