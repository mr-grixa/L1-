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
            this.vScrollBar2_0 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2_100 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxY = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Xaverage = new System.Windows.Forms.Label();
            this.Yaverage = new System.Windows.Forms.Label();
            this.stdDevX = new System.Windows.Forms.Label();
            this.stdDevY = new System.Windows.Forms.Label();
            this.modeX = new System.Windows.Forms.Label();
            this.modeY = new System.Windows.Forms.Label();
            this.medianX = new System.Windows.Forms.Label();
            this.medianY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).BeginInit();
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
            this.pictureBoxMain.Location = new System.Drawing.Point(70, 90);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            // 
            // pictureBoxGraf1
            // 
            this.pictureBoxGraf1.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraf1.Location = new System.Drawing.Point(341, 44);
            this.pictureBoxGraf1.Name = "pictureBoxGraf1";
            this.pictureBoxGraf1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxGraf1.TabIndex = 3;
            this.pictureBoxGraf1.TabStop = false;
            // 
            // vScrollBar1_25
            // 
            this.vScrollBar1_25.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1_25.Location = new System.Drawing.Point(361, 164);
            this.vScrollBar1_25.Maximum = 109;
            this.vScrollBar1_25.Name = "vScrollBar1_25";
            this.vScrollBar1_25.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar1_25.TabIndex = 4;
            this.vScrollBar1_25.Value = 75;
            this.vScrollBar1_25.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar1_75
            // 
            this.vScrollBar1_75.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1_75.Location = new System.Drawing.Point(401, 164);
            this.vScrollBar1_75.Maximum = 109;
            this.vScrollBar1_75.Name = "vScrollBar1_75";
            this.vScrollBar1_75.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar1_75.TabIndex = 5;
            this.vScrollBar1_75.Value = 25;
            this.vScrollBar1_75.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar1_50
            // 
            this.vScrollBar1_50.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1_50.Location = new System.Drawing.Point(381, 164);
            this.vScrollBar1_50.Maximum = 109;
            this.vScrollBar1_50.Name = "vScrollBar1_50";
            this.vScrollBar1_50.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar1_50.TabIndex = 6;
            this.vScrollBar1_50.Value = 50;
            this.vScrollBar1_50.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar2_50
            // 
            this.vScrollBar2_50.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar2_50.Location = new System.Drawing.Point(504, 164);
            this.vScrollBar2_50.Maximum = 109;
            this.vScrollBar2_50.Name = "vScrollBar2_50";
            this.vScrollBar2_50.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar2_50.TabIndex = 10;
            this.vScrollBar2_50.Value = 50;
            this.vScrollBar2_50.ValueChanged += new System.EventHandler(this.ScrolChanged2);
            // 
            // vScrollBar2_75
            // 
            this.vScrollBar2_75.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar2_75.Location = new System.Drawing.Point(524, 164);
            this.vScrollBar2_75.Maximum = 109;
            this.vScrollBar2_75.Name = "vScrollBar2_75";
            this.vScrollBar2_75.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar2_75.TabIndex = 9;
            this.vScrollBar2_75.Value = 25;
            this.vScrollBar2_75.ValueChanged += new System.EventHandler(this.ScrolChanged2);
            // 
            // vScrollBar2_25
            // 
            this.vScrollBar2_25.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar2_25.Location = new System.Drawing.Point(484, 164);
            this.vScrollBar2_25.Maximum = 109;
            this.vScrollBar2_25.Name = "vScrollBar2_25";
            this.vScrollBar2_25.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar2_25.TabIndex = 8;
            this.vScrollBar2_25.Value = 75;
            this.vScrollBar2_25.ValueChanged += new System.EventHandler(this.ScrolChanged2);
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
            this.comboBoxX.Location = new System.Drawing.Point(12, 164);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(49, 21);
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
            this.comboBoxY.Location = new System.Drawing.Point(150, 64);
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
            this.vScrollBar1_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1_0.Location = new System.Drawing.Point(341, 164);
            this.vScrollBar1_0.Maximum = 109;
            this.vScrollBar1_0.Name = "vScrollBar1_0";
            this.vScrollBar1_0.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar1_0.TabIndex = 14;
            this.vScrollBar1_0.Value = 100;
            this.vScrollBar1_0.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar1_100
            // 
            this.vScrollBar1_100.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1_100.Location = new System.Drawing.Point(421, 164);
            this.vScrollBar1_100.Maximum = 109;
            this.vScrollBar1_100.Name = "vScrollBar1_100";
            this.vScrollBar1_100.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar1_100.TabIndex = 15;
            this.vScrollBar1_100.ValueChanged += new System.EventHandler(this.ScrolChanged1);
            // 
            // vScrollBar2_0
            // 
            this.vScrollBar2_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar2_0.Location = new System.Drawing.Point(464, 164);
            this.vScrollBar2_0.Maximum = 109;
            this.vScrollBar2_0.Name = "vScrollBar2_0";
            this.vScrollBar2_0.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar2_0.TabIndex = 16;
            this.vScrollBar2_0.Value = 100;
            this.vScrollBar2_0.ValueChanged += new System.EventHandler(this.ScrolChanged2);
            // 
            // vScrollBar2_100
            // 
            this.vScrollBar2_100.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar2_100.Location = new System.Drawing.Point(544, 164);
            this.vScrollBar2_100.Maximum = 109;
            this.vScrollBar2_100.Name = "vScrollBar2_100";
            this.vScrollBar2_100.Size = new System.Drawing.Size(17, 127);
            this.vScrollBar2_100.TabIndex = 17;
            this.vScrollBar2_100.ValueChanged += new System.EventHandler(this.ScrolChanged2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Y2";
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.BackColor = System.Drawing.Color.White;
            this.pictureBoxX.Location = new System.Drawing.Point(70, 290);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(200, 50);
            this.pictureBoxX.TabIndex = 20;
            this.pictureBoxX.TabStop = false;
            // 
            // pictureBoxY
            // 
            this.pictureBoxY.BackColor = System.Drawing.Color.White;
            this.pictureBoxY.Location = new System.Drawing.Point(270, 90);
            this.pictureBoxY.Name = "pictureBoxY";
            this.pictureBoxY.Size = new System.Drawing.Size(50, 200);
            this.pictureBoxY.TabIndex = 21;
            this.pictureBoxY.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "среднее";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "средне-квадратическое отклонение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "мода";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "медиана";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Y";
            // 
            // Xaverage
            // 
            this.Xaverage.AutoSize = true;
            this.Xaverage.Location = new System.Drawing.Point(457, 346);
            this.Xaverage.Name = "Xaverage";
            this.Xaverage.Size = new System.Drawing.Size(49, 13);
            this.Xaverage.TabIndex = 30;
            this.Xaverage.Text = "среднее";
            // 
            // Yaverage
            // 
            this.Yaverage.AutoSize = true;
            this.Yaverage.Location = new System.Drawing.Point(512, 346);
            this.Yaverage.Name = "Yaverage";
            this.Yaverage.Size = new System.Drawing.Size(49, 13);
            this.Yaverage.TabIndex = 31;
            this.Yaverage.Text = "среднее";
            // 
            // stdDevX
            // 
            this.stdDevX.AutoSize = true;
            this.stdDevX.Location = new System.Drawing.Point(457, 359);
            this.stdDevX.Name = "stdDevX";
            this.stdDevX.Size = new System.Drawing.Size(49, 13);
            this.stdDevX.TabIndex = 32;
            this.stdDevX.Text = "среднее";
            // 
            // stdDevY
            // 
            this.stdDevY.AutoSize = true;
            this.stdDevY.Location = new System.Drawing.Point(512, 359);
            this.stdDevY.Name = "stdDevY";
            this.stdDevY.Size = new System.Drawing.Size(49, 13);
            this.stdDevY.TabIndex = 33;
            this.stdDevY.Text = "среднее";
            // 
            // modeX
            // 
            this.modeX.AutoSize = true;
            this.modeX.Location = new System.Drawing.Point(457, 372);
            this.modeX.Name = "modeX";
            this.modeX.Size = new System.Drawing.Size(49, 13);
            this.modeX.TabIndex = 34;
            this.modeX.Text = "среднее";
            // 
            // modeY
            // 
            this.modeY.AutoSize = true;
            this.modeY.Location = new System.Drawing.Point(512, 372);
            this.modeY.Name = "modeY";
            this.modeY.Size = new System.Drawing.Size(49, 13);
            this.modeY.TabIndex = 35;
            this.modeY.Text = "среднее";
            // 
            // medianX
            // 
            this.medianX.AutoSize = true;
            this.medianX.Location = new System.Drawing.Point(457, 385);
            this.medianX.Name = "medianX";
            this.medianX.Size = new System.Drawing.Size(49, 13);
            this.medianX.TabIndex = 36;
            this.medianX.Text = "среднее";
            // 
            // medianY
            // 
            this.medianY.AutoSize = true;
            this.medianY.Location = new System.Drawing.Point(512, 385);
            this.medianY.Name = "medianY";
            this.medianY.Size = new System.Drawing.Size(49, 13);
            this.medianY.TabIndex = 37;
            this.medianY.Text = "среднее";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.medianY);
            this.Controls.Add(this.medianX);
            this.Controls.Add(this.modeY);
            this.Controls.Add(this.modeX);
            this.Controls.Add(this.stdDevY);
            this.Controls.Add(this.stdDevX);
            this.Controls.Add(this.Yaverage);
            this.Controls.Add(this.Xaverage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar2_100);
            this.Controls.Add(this.vScrollBar2_0);
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
            this.Controls.Add(this.UpDownCout);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.pictureBoxY);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "Form1";
            this.Text = "Щербинин Григорий 201-325";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.VScrollBar vScrollBar2_0;
        private System.Windows.Forms.VScrollBar vScrollBar2_100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Xaverage;
        private System.Windows.Forms.Label Yaverage;
        private System.Windows.Forms.Label stdDevX;
        private System.Windows.Forms.Label stdDevY;
        private System.Windows.Forms.Label modeX;
        private System.Windows.Forms.Label modeY;
        private System.Windows.Forms.Label medianX;
        private System.Windows.Forms.Label medianY;
    }
}

