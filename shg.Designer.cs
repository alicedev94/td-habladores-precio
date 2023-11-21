namespace phApp
{
    partial class shg
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
			this.firname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.id_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(5, 62);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 30;
			this.dataGridView1.RowTemplate.Height = 33;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(350, 180);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.firname,
            this.garantia,
            this.code,
            this.price1,
            this.price2,
            this.id_promo});
			this.dataGridView2.Location = new System.Drawing.Point(395, 62);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowHeadersWidth = 62;
			this.dataGridView2.RowTemplate.Height = 33;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(350, 180);
			this.dataGridView2.TabIndex = 13;
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
			this.ItemName.Width = 400;
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
			// code
			// 
			this.code.HeaderText = "code";
			this.code.MinimumWidth = 8;
			this.code.Name = "code";
			this.code.ReadOnly = true;
			this.code.Visible = false;
			this.code.Width = 150;
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
			// price2
			// 
			this.price2.HeaderText = "price2";
			this.price2.MinimumWidth = 8;
			this.price2.Name = "price2";
			this.price2.ReadOnly = true;
			this.price2.Visible = false;
			this.price2.Width = 150;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(5, 42);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 23);
			this.textBox1.TabIndex = 16;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(267, 42);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(89, 23);
			this.comboBox1.TabIndex = 17;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(359, 112);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 20);
			this.button1.TabIndex = 18;
			this.button1.Text = ">";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(359, 136);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 20);
			this.button2.TabIndex = 19;
			this.button2.Text = ">>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(359, 160);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(32, 20);
			this.button3.TabIndex = 20;
			this.button3.Text = "<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(359, 184);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 20);
			this.button4.TabIndex = 21;
			this.button4.Text = "<<";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(396, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 15);
			this.label1.TabIndex = 22;
			this.label1.Text = "HABLADORES SELECCIONADOS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(693, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 23;
			this.label2.Text = "VOLVER";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(657, 246);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 20);
			this.button5.TabIndex = 24;
			this.button5.Text = "Generar.PDF";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(144)))));
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(755, 26);
			this.panel1.TabIndex = 25;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(144)))));
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.Location = new System.Drawing.Point(731, 0);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
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
			this.label3.Size = new System.Drawing.Size(184, 15);
			this.label3.TabIndex = 24;
			this.label3.Text = "TEC-AL-0001 Habladores Grandes";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(396, 246);
			this.button7.Margin = new System.Windows.Forms.Padding(2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(123, 20);
			this.button7.TabIndex = 26;
			this.button7.Text = "Importar .Excel";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// id_promo
			// 
			this.id_promo.HeaderText = "id_promo";
			this.id_promo.Name = "id_promo";
			this.id_promo.ReadOnly = true;
			// 
			// shg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 268);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(752, 268);
			this.MinimumSize = new System.Drawing.Size(752, 268);
			this.Name = "shg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TI.DAKA HABLADORES GRANDES";
			this.Load += new System.EventHandler(this.shg_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shg_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shg_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shg_MouseUp);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button5;
        private Panel panel1;
        private Label label3;
        private Button button6;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn firname;
        private DataGridViewTextBoxColumn garantia;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn price1;
        private DataGridViewTextBoxColumn price2;
        private Button button7;
        private OpenFileDialog openFileDialog1;
		private DataGridViewTextBoxColumn id_promo;
	}
}