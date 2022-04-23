
namespace Gestiune_librarie
{
    partial class CartiImprumutate
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabelImprumutBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabelImprumutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelImprumutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.imprumutDataSet = new Gestiune_librarie.ImprumutDataSet();
            this.imprumutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imprumutTableAdapter = new Gestiune_librarie.ImprumutDataSetTableAdapters.ImprumutTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelImprumutBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelImprumutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelImprumutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 636);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.imprumutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 542);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabelImprumutBindingSource2
            // 
            this.tabelImprumutBindingSource2.DataMember = "TabelImprumut";
            // 
            // tabelImprumutBindingSource
            // 
            this.tabelImprumutBindingSource.DataMember = "TabelImprumut";
            // 
            // tabelImprumutBindingSource1
            // 
            this.tabelImprumutBindingSource1.DataMember = "TabelImprumut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabelul cu cartile imprumutate";
            // 
            // imprumutDataSet
            // 
            this.imprumutDataSet.DataSetName = "ImprumutDataSet";
            this.imprumutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imprumutBindingSource
            // 
            this.imprumutBindingSource.DataMember = "Imprumut";
            this.imprumutBindingSource.DataSource = this.imprumutDataSet;
            // 
            // imprumutTableAdapter
            // 
            this.imprumutTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenume";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenume";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Titlu";
            this.dataGridViewTextBoxColumn4.HeaderText = "Titlu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_limita";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data_limita";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // CartiImprumutate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(793, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CartiImprumutate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carti Imprumutate";
            this.Load += new System.EventHandler(this.CartiImprumutate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelImprumutBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelImprumutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelImprumutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource tabelImprumutBindingSource;
      
        private System.Windows.Forms.BindingSource tabelImprumutBindingSource2;
        private System.Windows.Forms.BindingSource tabelImprumutBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalimitaDataGridViewTextBoxColumn;
        private ImprumutDataSet imprumutDataSet;
        private System.Windows.Forms.BindingSource imprumutBindingSource;
        private ImprumutDataSetTableAdapters.ImprumutTableAdapter imprumutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}