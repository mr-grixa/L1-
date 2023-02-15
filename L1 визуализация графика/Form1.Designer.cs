namespace L1_визуализация_графика
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.generate = new System.Windows.Forms.Button();
            this.UpDownCout = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.pictureBoxGraf1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1_25 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1_75 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1_50 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2_50 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2_75 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2_25 = new System.Windows.Forms.VScrollBar();
            this.pictureBoxGraf2 = new System.Windows.Forms.PictureBox();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1_0 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1_100 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 12);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(131, 26);
            this.generate.TabIndex = 0;
            this.generate.Text = "Сгенерировать";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // UpDownCout
            // 
            this.UpDownCout.Location = new System.Drawing.Point(150, 17);
            this.UpDownCout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDownCout.Name = "UpDownCout";
            this.UpDownCout.Size = new System.Drawing.Size(120, 20);
            this.UpDownCout.TabIndex = 1;
            this.UpDownCout.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 44);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            // 
            // pictureBoxGraf1
            // 
            this.pictureBoxGraf1.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraf1.Location = new System.Drawing.Point(316, 44);
            this.pictureBoxGraf1.Name = "pictureBoxGraf1";
            this.pictureBoxGraf1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxGraf1.TabIndex = 3;
            this.pictureBoxGraf1.TabStop = false;
            // 
            // vScrollBar1_25
            // 
            this.vScrollBar1_25.Location = new System.Drawing.Point(336, 164);
            this.vScrollBar1_25.Maximum = 109;
            this.vScrollBar1_25.Name = "vScrollBar1_25";
            this.vScrollBar1_25.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1_25.TabIndex = 4;
            this.vScrollBar1_25.Value = 75;
            this.vScrollBar1_25.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar1_75
            // 
            this.vScrollBar1_75.Location = new System.Drawing.Point(376, 164);
            this.vScrollBar1_75.Maximum = 109;
            this.vScrollBar1_75.Name = "vScrollBar1_75";
            this.vScrollBar1_75.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1_75.TabIndex = 5;
            this.vScrollBar1_75.Value = 25;
            this.vScrollBar1_75.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar1_50
            // 
            this.vScrollBar1_50.Location = new System.Drawing.Point(356, 164);
            this.vScrollBar1_50.Maximum = 109;
            this.vScrollBar1_50.Name = "vScrollBar1_50";
            this.vScrollBar1_50.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1_50.TabIndex = 6;
            this.vScrollBar1_50.Value = 50;
            this.vScrollBar1_50.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar2_50
            // 
            this.vScrollBar2_50.Location = new System.Drawing.Point(506, 164);
            this.vScrollBar2_50.Maximum = 109;
            this.vScrollBar2_50.Name = "vScrollBar2_50";
            this.vScrollBar2_50.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar2_50.TabIndex = 10;
            // 
            // vScrollBar2_75
            // 
            this.vScrollBar2_75.Location = new System.Drawing.Point(547, 164);
            this.vScrollBar2_75.Maximum = 109;
            this.vScrollBar2_75.Name = "vScrollBar2_75";
            this.vScrollBar2_75.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar2_75.TabIndex = 9;
            // 
            // vScrollBar2_25
            // 
            this.vScrollBar2_25.Location = new System.Drawing.Point(464, 164);
            this.vScrollBar2_25.Maximum = 109;
            this.vScrollBar2_25.Name = "vScrollBar2_25";
            this.vScrollBar2_25.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar2_25.TabIndex = 8;
            // 
            // pictureBoxGraf2
            // 
            this.pictureBoxGraf2.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraf2.Location = new System.Drawing.Point(464, 44);
            this.pictureBoxGraf2.Name = "pictureBoxGraf2";
            this.pictureBoxGraf2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxGraf2.TabIndex = 7;
            this.pictureBoxGraf2.TabStop = false;
            // 
            // comboBoxX
            // 
            this.comboBoxX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Items.AddRange(new object[] {
            "X1",
            "X2",
            "Y1",
            "Y2"});
            this.comboBoxX.Location = new System.Drawing.Point(48, 250);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(121, 21);
            this.comboBoxX.TabIndex = 11;
            this.comboBoxX.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // comboBoxY
            // 
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
            "X1",
            "X2",
            "Y1",
            "Y2"});
            this.comboBoxY.Location = new System.Drawing.Point(212, 123);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(58, 21);
            this.comboBoxY.TabIndex = 12;
            this.comboBoxY.SelectedIndexChanged += new System.EventHandler(this.comboBoxY_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dX1,
            this.dX2,
            this.dY1,
            this.dY2});
            this.dataGridView1.Location = new System.Drawing.Point(570, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 375);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dX1
            // 
            this.dX1.HeaderText = "X1";
            this.dX1.Name = "dX1";
            this.dX1.Width = 50;
            // 
            // dX2
            // 
            this.dX2.HeaderText = "X2";
            this.dX2.Name = "dX2";
            this.dX2.Width = 50;
            // 
            // dY1
            // 
            this.dY1.HeaderText = "Y1";
            this.dY1.Name = "dY1";
            this.dY1.Width = 50;
            // 
            // dY2
            // 
            this.dY2.HeaderText = "Y2";
            this.dY2.Name = "dY2";
            this.dY2.Width = 50;
            // 
            // vScrollBar1_0
            // 
            this.vScrollBar1_0.Location = new System.Drawing.Point(316, 164);
            this.vScrollBar1_0.Maximum = 109;
            this.vScrollBar1_0.Name = "vScrollBar1_0";
            this.vScrollBar1_0.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1_0.TabIndex = 14;
            this.vScrollBar1_0.Value = 100;
            this.vScrollBar1_0.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar1_100
            // 
            this.vScrollBar1_100.Location = new System.Drawing.Point(396, 164);
            this.vScrollBar1_100.Maximum = 109;
            this.vScrollBar1_100.Name = "vScrollBar1_100";
            this.vScrollBar1_100.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1_100.TabIndex = 15;
            this.vScrollBar1_100.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.vScrollBar1_100);
            this.Controls.Add(this.vScrollBar1_0);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxX);
            this.Controls.Add(this.vScrollBar2_50);
            this.Controls.Add(this.vScrollBar2_75);
            this.Controls.Add(this.vScrollBar2_25);
            this.Controls.Add(this.pictureBoxGraf2);
            this.Controls.Add(this.vScrollBar1_50);
            this.Controls.Add(this.vScrollBar1_75);
            this.Controls.Add(this.vScrollBar1_25);
            this.Controls.Add(this.pictureBoxGraf1);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.UpDownCout);
            this.Controls.Add(this.generate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.NumericUpDown UpDownCout;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox pictureBoxGraf1;
        private System.Windows.Forms.VScrollBar vScrollBar1_25;
        private System.Windows.Forms.VScrollBar vScrollBar1_75;
        private System.Windows.Forms.VScrollBar vScrollBar1_50;
        private System.Windows.Forms.VScrollBar vScrollBar2_50;
        private System.Windows.Forms.VScrollBar vScrollBar2_75;
        private System.Windows.Forms.VScrollBar vScrollBar2_25;
        private System.Windows.Forms.PictureBox pictureBoxGraf2;
        private System.Windows.Forms.ComboBox comboBoxX;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dY2;
        private System.Windows.Forms.VScrollBar vScrollBar1_0;
        private System.Windows.Forms.VScrollBar vScrollBar1_100;
    }
}

