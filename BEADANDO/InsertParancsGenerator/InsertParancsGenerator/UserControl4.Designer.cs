﻿namespace InsertParancsGenerator
{
    partial class UserControl4
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
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            autoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modellDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meghajtasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autoBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)autoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(3, 387);
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
            button1.Location = new Point(679, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Hozzaad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(402, 387);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { autoIDDataGridViewTextBoxColumn, modellDataGridViewTextBoxColumn, meghajtasDataGridViewTextBoxColumn, szinDataGridViewTextBoxColumn, arDataGridViewTextBoxColumn });
            dataGridView1.DataSource = autoBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(751, 378);
            dataGridView1.TabIndex = 16;
            // 
            // autoIDDataGridViewTextBoxColumn
            // 
            autoIDDataGridViewTextBoxColumn.DataPropertyName = "AutoID";
            autoIDDataGridViewTextBoxColumn.HeaderText = "AutoID";
            autoIDDataGridViewTextBoxColumn.Name = "autoIDDataGridViewTextBoxColumn";
            // 
            // modellDataGridViewTextBoxColumn
            // 
            modellDataGridViewTextBoxColumn.DataPropertyName = "Modell";
            modellDataGridViewTextBoxColumn.HeaderText = "Modell";
            modellDataGridViewTextBoxColumn.Name = "modellDataGridViewTextBoxColumn";
            // 
            // meghajtasDataGridViewTextBoxColumn
            // 
            meghajtasDataGridViewTextBoxColumn.DataPropertyName = "Meghajtas";
            meghajtasDataGridViewTextBoxColumn.HeaderText = "Meghajtas";
            meghajtasDataGridViewTextBoxColumn.Name = "meghajtasDataGridViewTextBoxColumn";
            // 
            // szinDataGridViewTextBoxColumn
            // 
            szinDataGridViewTextBoxColumn.DataPropertyName = "Szin";
            szinDataGridViewTextBoxColumn.HeaderText = "Szin";
            szinDataGridViewTextBoxColumn.Name = "szinDataGridViewTextBoxColumn";
            // 
            // arDataGridViewTextBoxColumn
            // 
            arDataGridViewTextBoxColumn.DataPropertyName = "Ar";
            arDataGridViewTextBoxColumn.HeaderText = "Ar";
            arDataGridViewTextBoxColumn.Name = "arDataGridViewTextBoxColumn";
            // 
            // autoBindingSource
            // 
            autoBindingSource.DataSource = typeof(Auto);
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(84, 387);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(190, 387);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox5.Location = new Point(296, 387);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 23;
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Name = "UserControl4";
            Size = new Size(757, 413);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)autoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felszereltsegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meghajtasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arDataGridViewTextBoxColumn;
        private BindingSource autoBindingSource;
    }
}
