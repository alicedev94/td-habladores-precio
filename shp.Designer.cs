namespace phApp
{
    partial class shp
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codebars = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lista4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(2, 56);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 30;
			this.dataGridView1.RowTemplate.Height = 33;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(350, 180);
			this.dataGridView1.TabIndex = 16;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.price1,
            this.codebars,
            this.firname,
            this.garantia,
            this.lista4});
			this.dataGridView2.Location = new System.Drawing.Point(392, 56);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowHeadersWidth = 20;
			this.dataGridView2.RowTemplate.Height = 33;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(350, 180);
			this.dataGridView2.TabIndex = 17;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// ItemCode
			// 
			this.ItemCode.HeaderText = "ItemCode";
			this.ItemCode.MinimumWidth = 8;
			this.ItemCode.Name = "ItemCode";
			this.ItemCode.ReadOnly = true;
			this.ItemCode.Width = 150;
			// 
			// ItemName
			// 
			this.ItemName.HeaderText = "ItemName";
			this.ItemName.MinimumWidth = 8;
			this.ItemName.Name = "ItemName";
			this.ItemName.ReadOnly = true;
			this.ItemName.Width = 580;
			// 
			// price1
			// 
			this.price1.HeaderText = "price1";
			this.price1.MinimumWidth = 8;
			this.price1.Name = "price1";
			this.price1.ReadOnly = true;
			this.price1.Visible = false;
			this.price1.Width = 150;
			// 
			// codebars
			// 
			this.codebars.HeaderText = "codebars";
			this.codebars.MinimumWidth = 8;
			this.codebars.Name = "codebars";
			this.codebars.ReadOnly = true;
			this.codebars.Visible = false;
			this.codebars.Width = 150;
			// 
			// firname
			// 
			this.firname.HeaderText = "firname";
			this.firname.MinimumWidth = 8;
			this.firname.Name = "firname";
			this.firname.ReadOnly = true;
			this.firname.Visible = false;
			this.firname.Width = 150;
			// 
			// garantia
			// 
			this.garantia.HeaderText = "garantia";
			this.garantia.MinimumWidth = 8;
			this.garantia.Name = "garantia";
			this.garantia.ReadOnly = true;
			this.garantia.Visible = false;
			this.garantia.Width = 150;
			// 
			// lista4
			// 
			this.lista4.HeaderText = "lista4";
			this.lista4.MinimumWidth = 8;
			this.lista4.Name = "lista4";
			this.lista4.ReadOnly = true;
			this.lista4.Visible = false;
			this.lista4.Width = 150;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(265, 33);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(89, 23);
			this.comboBox1.TabIndex = 26;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(2, 34);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 23);
			this.textBox1.TabIndex = 25;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(144)))));
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-84, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(905, 24);
			this.panel1.TabIndex = 27;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(144)))));
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(811, -1);
			this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(24, 23);
			this.button6.TabIndex = 25;
			this.button6.Text = "x";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Snow;
			this.label3.Location = new System.Drawing.Point(10, 5);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 15);
			this.label3.TabIndex = 24;
			this.label3.Text = "TEC-AL-0001 Habladores Pequeños";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(356, 182);
			this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 20);
			this.button4.TabIndex = 31;
			this.button4.Text = "<<";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(356, 158);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(32, 20);
			this.button3.TabIndex = 30;
			this.button3.Text = "<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(356, 134);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 20);
			this.button2.TabIndex = 29;
			this.button2.Text = ">>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(356, 110);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 20);
			this.button1.TabIndex = 28;
			this.button1.Text = ">";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(690, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 33;
			this.label2.Text = "VOLVER";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(392, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 15);
			this.label1.TabIndex = 32;
			this.label1.Text = "HABLADORES SELECCIONADOS";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(655, 240);
			this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 20);
			this.button5.TabIndex = 34;
			this.button5.Text = "Generar.PDF";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(392, 240);
			this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(106, 20);
			this.button7.TabIndex = 35;
			this.button7.Text = "Importar .Excel";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// shp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 268);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximumSize = new System.Drawing.Size(752, 268);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(752, 268);
			this.Name = "shp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TI.DAKA HABLADORES PEQUEÑOS";
			this.Load += new System.EventHandler(this.shp_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shp_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shp_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shp_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn price1;
        private DataGridViewTextBoxColumn codebars;
        private DataGridViewTextBoxColumn firname;
        private DataGridViewTextBoxColumn garantia;
        private DataGridViewTextBoxColumn lista4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button6;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button button7;
        private OpenFileDialog openFileDialog1;
    }
}