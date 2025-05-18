namespace InsertParancsGenerator
{
    partial class UserControl6
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
            modellIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felszereltsegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modellBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modellBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(3, 354);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Kiír";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(421, 354);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Hozzaad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(296, 354);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(190, 354);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { modellIDDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, tipusDataGridViewTextBoxColumn, felszereltsegDataGridViewTextBoxColumn });
            dataGridView1.DataSource = modellBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 289);
            dataGridView1.TabIndex = 16;
            // 
            // modellIDDataGridViewTextBoxColumn
            // 
            modellIDDataGridViewTextBoxColumn.DataPropertyName = "ModellID";
            modellIDDataGridViewTextBoxColumn.HeaderText = "ModellID";
            modellIDDataGridViewTextBoxColumn.Name = "modellIDDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            tipusDataGridViewTextBoxColumn.DataPropertyName = "Tipus";
            tipusDataGridViewTextBoxColumn.HeaderText = "Tipus";
            tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            // 
            // felszereltsegDataGridViewTextBoxColumn
            // 
            felszereltsegDataGridViewTextBoxColumn.DataPropertyName = "Felszereltseg";
            felszereltsegDataGridViewTextBoxColumn.HeaderText = "Felszereltseg";
            felszereltsegDataGridViewTextBoxColumn.Name = "felszereltsegDataGridViewTextBoxColumn";
            // 
            // modellBindingSource
            // 
            modellBindingSource.DataSource = typeof(Modell);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(84, 355);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Name = "UserControl6";
            Size = new Size(499, 380);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modellBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn modellIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felszereltsegDataGridViewTextBoxColumn;
        private BindingSource modellBindingSource;
        private TextBox textBox1;
    }
}
