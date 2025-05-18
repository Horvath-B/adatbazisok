namespace InsertParancsGenerator
{
    partial class UserControl5
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
            vetelIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vevoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uzletkotoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kocsiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fizetesiModDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vetelBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vetelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(3, 348);
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
            button1.Location = new Point(588, 348);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Hozzaad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(381, 348);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(282, 348);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(93, 23);
            textBox3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vetelIDDataGridViewTextBoxColumn, vevoDataGridViewTextBoxColumn, uzletkotoDataGridViewTextBoxColumn, kocsiDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn, fizetesiModDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vetelBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 339);
            dataGridView1.TabIndex = 16;
            // 
            // vetelIDDataGridViewTextBoxColumn
            // 
            vetelIDDataGridViewTextBoxColumn.DataPropertyName = "VetelID";
            vetelIDDataGridViewTextBoxColumn.HeaderText = "VetelID";
            vetelIDDataGridViewTextBoxColumn.Name = "vetelIDDataGridViewTextBoxColumn";
            // 
            // vevoDataGridViewTextBoxColumn
            // 
            vevoDataGridViewTextBoxColumn.DataPropertyName = "Vevo";
            vevoDataGridViewTextBoxColumn.HeaderText = "Vevo";
            vevoDataGridViewTextBoxColumn.Name = "vevoDataGridViewTextBoxColumn";
            // 
            // uzletkotoDataGridViewTextBoxColumn
            // 
            uzletkotoDataGridViewTextBoxColumn.DataPropertyName = "Uzletkoto";
            uzletkotoDataGridViewTextBoxColumn.HeaderText = "Uzletkoto";
            uzletkotoDataGridViewTextBoxColumn.Name = "uzletkotoDataGridViewTextBoxColumn";
            // 
            // kocsiDataGridViewTextBoxColumn
            // 
            kocsiDataGridViewTextBoxColumn.DataPropertyName = "Kocsi";
            kocsiDataGridViewTextBoxColumn.HeaderText = "Kocsi";
            kocsiDataGridViewTextBoxColumn.Name = "kocsiDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // fizetesiModDataGridViewTextBoxColumn
            // 
            fizetesiModDataGridViewTextBoxColumn.DataPropertyName = "FizetesiMod";
            fizetesiModDataGridViewTextBoxColumn.HeaderText = "FizetesiMod";
            fizetesiModDataGridViewTextBoxColumn.Name = "fizetesiModDataGridViewTextBoxColumn";
            // 
            // vetelBindingSource
            // 
            vetelBindingSource.DataSource = typeof(Vetel);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(84, 348);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 23);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(183, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(93, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox5.Location = new Point(480, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 23);
            textBox5.TabIndex = 23;
            // 
            // UserControl5
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
            Name = "UserControl5";
            Size = new Size(666, 374);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vetelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vetelIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vevoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uzletkotoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kocsiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fizetesiModDataGridViewTextBoxColumn;
        private BindingSource vetelBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
    }
}
