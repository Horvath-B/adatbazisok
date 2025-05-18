namespace InsertParancsGenerator
{
    partial class UserControl2
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
            uzletkotoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fizetesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uzletkotoBindingSource = new BindingSource(components);
            vetelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uzletkotoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vetelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(3, 299);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Kiír";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(296, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Hozzaad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(190, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(84, 298);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { uzletkotoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, fizetesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = uzletkotoBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(369, 289);
            dataGridView1.TabIndex = 10;
            // 
            // uzletkotoIDDataGridViewTextBoxColumn
            // 
            uzletkotoIDDataGridViewTextBoxColumn.DataPropertyName = "UzletkotoID";
            uzletkotoIDDataGridViewTextBoxColumn.HeaderText = "UzletkotoID";
            uzletkotoIDDataGridViewTextBoxColumn.Name = "uzletkotoIDDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // fizetesDataGridViewTextBoxColumn
            // 
            fizetesDataGridViewTextBoxColumn.DataPropertyName = "Fizetes";
            fizetesDataGridViewTextBoxColumn.HeaderText = "Fizetes";
            fizetesDataGridViewTextBoxColumn.Name = "fizetesDataGridViewTextBoxColumn";
            // 
            // uzletkotoBindingSource
            // 
            uzletkotoBindingSource.DataSource = typeof(Uzletkoto);
            // 
            // vetelBindingSource
            // 
            vetelBindingSource.DataSource = typeof(Vetel);
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(374, 327);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uzletkotoBindingSource).EndInit();
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
        private DataGridViewTextBoxColumn uzletkotoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fizetesDataGridViewTextBoxColumn;
        private BindingSource uzletkotoBindingSource;
        private BindingSource vetelBindingSource;
    }
}
