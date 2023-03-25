namespace WindowsFormsApp1
{
    partial class fmGrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.demoEx2171DataSet = new WindowsFormsApp1.DemoEx2171DataSet();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportTableAdapter = new WindowsFormsApp1.DemoEx2171DataSetTableAdapters.transportTableAdapter();
            this.transportmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoEx2171DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoEx2171DataSet1 = new WindowsFormsApp1.DemoEx2171DataSet1();
            this.transportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportTableAdapter1 = new WindowsFormsApp1.DemoEx2171DataSet1TableAdapters.transportTableAdapter();
            this.transportcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemanufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEx2171DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEx2171DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEx2171DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 15.75F);
            this.label1.Location = new System.Drawing.Point(157, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Компания \"Мегадрайв\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.button1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(976, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 100);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportmodelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(280, 266);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportcolorDataGridViewTextBoxColumn,
            this.datemanufactureDataGridViewTextBoxColumn,
            this.currentpointlocationnumberDataGridViewTextBoxColumn,
            this.currentpointlocationaddressDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.transportBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(286, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(806, 266);
            this.dataGridView2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.логотип;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(374, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // demoEx2171DataSet
            // 
            this.demoEx2171DataSet.DataSetName = "DemoEx2171DataSet";
            this.demoEx2171DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataMember = "transport";
            this.transportBindingSource.DataSource = this.demoEx2171DataSet;
            // 
            // transportTableAdapter
            // 
            this.transportTableAdapter.ClearBeforeFill = true;
            // 
            // transportmodelDataGridViewTextBoxColumn
            // 
            this.transportmodelDataGridViewTextBoxColumn.DataPropertyName = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.HeaderText = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.Name = "transportmodelDataGridViewTextBoxColumn";
            // 
            // demoEx2171DataSetBindingSource
            // 
            this.demoEx2171DataSetBindingSource.DataSource = this.demoEx2171DataSet;
            this.demoEx2171DataSetBindingSource.Position = 0;
            // 
            // demoEx2171DataSet1
            // 
            this.demoEx2171DataSet1.DataSetName = "DemoEx2171DataSet1";
            this.demoEx2171DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBindingSource1
            // 
            this.transportBindingSource1.DataMember = "transport";
            this.transportBindingSource1.DataSource = this.demoEx2171DataSet1;
            // 
            // transportTableAdapter1
            // 
            this.transportTableAdapter1.ClearBeforeFill = true;
            // 
            // transportcolorDataGridViewTextBoxColumn
            // 
            this.transportcolorDataGridViewTextBoxColumn.DataPropertyName = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.HeaderText = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.Name = "transportcolorDataGridViewTextBoxColumn";
            // 
            // datemanufactureDataGridViewTextBoxColumn
            // 
            this.datemanufactureDataGridViewTextBoxColumn.DataPropertyName = "date_manufacture";
            this.datemanufactureDataGridViewTextBoxColumn.HeaderText = "date_manufacture";
            this.datemanufactureDataGridViewTextBoxColumn.Name = "datemanufactureDataGridViewTextBoxColumn";
            // 
            // currentpointlocationnumberDataGridViewTextBoxColumn
            // 
            this.currentpointlocationnumberDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.HeaderText = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.Name = "currentpointlocationnumberDataGridViewTextBoxColumn";
            // 
            // currentpointlocationaddressDataGridViewTextBoxColumn
            // 
            this.currentpointlocationaddressDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.HeaderText = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.Name = "currentpointlocationaddressDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // fmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 478);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmGrid";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmGrid_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEx2171DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEx2171DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoEx2171DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DemoEx2171DataSet demoEx2171DataSet;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private DemoEx2171DataSetTableAdapters.transportTableAdapter transportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource demoEx2171DataSetBindingSource;
        private DemoEx2171DataSet1 demoEx2171DataSet1;
        private System.Windows.Forms.BindingSource transportBindingSource1;
        private DemoEx2171DataSet1TableAdapters.transportTableAdapter transportTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemanufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}