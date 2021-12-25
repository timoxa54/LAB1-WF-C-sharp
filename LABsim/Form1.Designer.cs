
namespace LABsim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SB1 = new System.Windows.Forms.HScrollBar();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.SB2 = new System.Windows.Forms.HScrollBar();
            this.labelSUM = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSizeUp = new System.Windows.Forms.Button();
            this.buttonSizeDown = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBoxSB = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMG = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SB1
            // 
            this.SB1.Location = new System.Drawing.Point(6, 81);
            this.SB1.Maximum = 109;
            this.SB1.Name = "SB1";
            this.SB1.Size = new System.Drawing.Size(140, 42);
            this.SB1.TabIndex = 1;
            this.SB1.Value = 1;
            this.SB1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.SB1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // TB1
            // 
            this.TB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB1.Location = new System.Drawing.Point(6, 44);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(140, 34);
            this.TB1.TabIndex = 2;
            this.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB2.Location = new System.Drawing.Point(152, 44);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(140, 34);
            this.TB2.TabIndex = 4;
            this.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SB2
            // 
            this.SB2.Location = new System.Drawing.Point(152, 74);
            this.SB2.Maximum = 109;
            this.SB2.Name = "SB2";
            this.SB2.Size = new System.Drawing.Size(140, 42);
            this.SB2.TabIndex = 3;
            this.SB2.Value = 1;
            this.SB2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB2_Scroll);
            // 
            // labelSUM
            // 
            this.labelSUM.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSUM.Location = new System.Drawing.Point(6, 123);
            this.labelSUM.Name = "labelSUM";
            this.labelSUM.Size = new System.Drawing.Size(286, 50);
            this.labelSUM.TabIndex = 5;
            this.labelSUM.Text = "SUM=";
            this.labelSUM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(6, 211);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(286, 62);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "Подождите 10 сек. после нажатия на кнопку";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(97, 276);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(109, 29);
            this.buttonTimer.TabIndex = 7;
            this.buttonTimer.Text = "Клик";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSizeUp
            // 
            this.buttonSizeUp.Location = new System.Drawing.Point(647, 44);
            this.buttonSizeUp.Name = "buttonSizeUp";
            this.buttonSizeUp.Size = new System.Drawing.Size(135, 29);
            this.buttonSizeUp.TabIndex = 8;
            this.buttonSizeUp.Text = "Размер окна +";
            this.buttonSizeUp.UseVisualStyleBackColor = true;
            this.buttonSizeUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSizeDown
            // 
            this.buttonSizeDown.Location = new System.Drawing.Point(647, 81);
            this.buttonSizeDown.Name = "buttonSizeDown";
            this.buttonSizeDown.Size = new System.Drawing.Size(135, 29);
            this.buttonSizeDown.TabIndex = 9;
            this.buttonSizeDown.Text = "Размер окна -";
            this.buttonSizeDown.UseVisualStyleBackColor = true;
            this.buttonSizeDown.Click += new System.EventHandler(this.buttonSizeDown_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(298, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Location = new System.Drawing.Point(360, 220);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(130, 29);
            this.buttonLoadPicture.TabIndex = 13;
            this.buttonLoadPicture.Text = "Загрузить фото";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 24);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "C#";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 24);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Java";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 24);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C/C++";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(559, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 125);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Языки программирования";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(70, 373);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 56);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxSB
            // 
            this.textBoxSB.Location = new System.Drawing.Point(75, 340);
            this.textBoxSB.Name = "textBoxSB";
            this.textBoxSB.Size = new System.Drawing.Size(125, 27);
            this.textBoxSB.TabIndex = 19;
            this.textBoxSB.TextChanged += new System.EventHandler(this.textBoxSB_TextChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(577, 255);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(192, 29);
            this.buttonCreate.TabIndex = 20;
            this.buttonCreate.Text = "Создать новую кнопку";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(424, 262);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 10);
            this.flowLayoutPanel1.TabIndex = 21;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "Вывести";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(274, 26);
            this.toolStripMenuItem4.Text = "Вывести ошибку";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(274, 26);
            this.toolStripMenuItem6.Text = "Вывести предупреждение";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.ToolStripMenuItemMG});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 24);
            this.toolStripMenuItem2.Text = "Информация";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem7.Text = "Разработчик";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // ToolStripMenuItemMG
            // 
            this.ToolStripMenuItemMG.Name = "ToolStripMenuItemMG";
            this.ToolStripMenuItemMG.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemMG.Text = "Проверяющий";
            this.ToolStripMenuItemMG.Click += new System.EventHandler(this.проверящийToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxSB);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoadPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSizeDown);
            this.Controls.Add(this.buttonSizeUp);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelSUM);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.SB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.SB1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar SB1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.HScrollBar SB2;
        private System.Windows.Forms.Label labelSUM;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSizeUp;
        private System.Windows.Forms.Button buttonSizeDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBoxSB;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMG;
    }
}

