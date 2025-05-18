namespace InsertParancsGenerator
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            meghajtasIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uzemanyagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fajtaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hengerurtartalomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meghajtasBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)meghajtasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(3, 299);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Kiír";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(631, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Hozzaad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(379, 300);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(92, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(284, 300);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 23);
            textBox3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { meghajtasIDDataGridViewTextBoxColumn, uzemanyagDataGridViewTextBoxColumn, fajtaDataGridViewTextBoxColumn, tipusDataGridViewTextBoxColumn, hengerurtartalomDataGridViewTextBoxColumn, loeroDataGridViewTextBoxColumn });
            dataGridView1.DataSource = meghajtasBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 289);
            dataGridView1.TabIndex = 16;
            // 
            // meghajtasIDDataGridViewTextBoxColumn
            // 
            meghajtasIDDataGridViewTextBoxColumn.DataPropertyName = "MeghajtasID";
            meghajtasIDDataGridViewTextBoxColumn.HeaderText = "MeghajtasID";
            meghajtasIDDataGridViewTextBoxColumn.Name = "meghajtasIDDataGridViewTextBoxColumn";
            // 
            // uzemanyagDataGridViewTextBoxColumn
            // 
            uzemanyagDataGridViewTextBoxColumn.DataPropertyName = "Uzemanyag";
            uzemanyagDataGridViewTextBoxColumn.HeaderText = "Uzemanyag";
            uzemanyagDataGridViewTextBoxColumn.Name = "uzemanyagDataGridViewTextBoxColumn";
            // 
            // fajtaDataGridViewTextBoxColumn
            // 
            fajtaDataGridViewTextBoxColumn.DataPropertyName = "Fajta";
            fajtaDataGridViewTextBoxColumn.HeaderText = "Fajta";
            fajtaDataGridViewTextBoxColumn.Name = "fajtaDataGridViewTextBoxColumn";
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            tipusDataGridViewTextBoxColumn.DataPropertyName = "Tipus";
            tipusDataGridViewTextBoxColumn.HeaderText = "Tipus";
            tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            // 
            // hengerurtartalomDataGridViewTextBoxColumn
            // 
            hengerurtartalomDataGridViewTextBoxColumn.DataPropertyName = "Hengerurtartalom";
            hengerurtartalomDataGridViewTextBoxColumn.HeaderText = "Hengerurtartalom";
            hengerurtartalomDataGridViewTextBoxColumn.Name = "hengerurtartalomDataGridViewTextBoxColumn";
            // 
            // loeroDataGridViewTextBoxColumn
            // 
            loeroDataGridViewTextBoxColumn.DataPropertyName = "Loero";
            loeroDataGridViewTextBoxColumn.HeaderText = "Loero";
            loeroDataGridViewTextBoxColumn.Name = "loeroDataGridViewTextBoxColumn";
            // 
            // meghajtasBindingSource
            // 
            meghajtasBindingSource.DataSource = typeof(Meghajtas);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(94, 300);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(189, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox5.Location = new Point(477, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(89, 23);
            textBox5.TabIndex = 23;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Name = "UserControl3";
            Size = new Size(709, 365);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)meghajtasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn meghajtasIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uzemanyagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fajtaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hengerurtartalomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loeroDataGridViewTextBoxColumn;
        private BindingSource meghajtasBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
    }
}
