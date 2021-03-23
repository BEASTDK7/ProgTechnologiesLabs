
namespace LW__14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtonDateTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBoxX = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxY = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxB = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemV3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelTask2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelClock,
            this.toolStripDropDownButtonDateTime});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(854, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabelState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(775, 17);
            this.toolStripStatusLabelState.Spring = true;
            this.toolStripStatusLabelState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripDropDownButtonDateTime
            // 
            this.toolStripDropDownButtonDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonDateTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTime,
            this.toolStripMenuItemDate});
            this.toolStripDropDownButtonDateTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDateTime.Image")));
            this.toolStripDropDownButtonDateTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonDateTime.Name = "toolStripDropDownButtonDateTime";
            this.toolStripDropDownButtonDateTime.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButtonDateTime.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemTime
            // 
            this.toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            this.toolStripMenuItemTime.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemTime.Text = "Текущее время";
            this.toolStripMenuItemTime.Click += new System.EventHandler(this.toolStripMenuItemTime_Click);
            // 
            // toolStripMenuItemDate
            // 
            this.toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            this.toolStripMenuItemDate.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemDate.Text = "Текущая дата";
            this.toolStripMenuItemDate.Click += new System.EventHandler(this.toolStripMenuItemDate_Click);
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Enabled = true;
            this.timerDateTimeUpdate.Interval = 1000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.timerDateTimeUpdate_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxX,
            this.toolStripTextBoxY,
            this.toolStripTextBoxZ,
            this.toolStripComboBoxA,
            this.toolStripComboBoxB});
            this.menuStrip1.Location = new System.Drawing.Point(146, 97);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBoxX
            // 
            this.toolStripTextBoxX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTextBoxX.Name = "toolStripTextBoxX";
            this.toolStripTextBoxX.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripTextBoxY
            // 
            this.toolStripTextBoxY.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTextBoxY.Name = "toolStripTextBoxY";
            this.toolStripTextBoxY.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripTextBoxZ
            // 
            this.toolStripTextBoxZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTextBoxZ.Name = "toolStripTextBoxZ";
            this.toolStripTextBoxZ.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripComboBoxA
            // 
            this.toolStripComboBoxA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripComboBoxA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toolStripComboBoxA.Name = "toolStripComboBoxA";
            this.toolStripComboBoxA.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripComboBoxB
            // 
            this.toolStripComboBoxB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripComboBoxB.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.toolStripComboBoxB.Name = "toolStripComboBoxB";
            this.toolStripComboBoxB.Size = new System.Drawing.Size(121, 25);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(146, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(564, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Решить!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(301, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(408, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(517, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(643, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "b";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabelTask2});
            this.statusStrip1.Location = new System.Drawing.Point(146, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(319, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemV1,
            this.toolStripMenuItemV2,
            this.toolStripMenuItemV3});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(223, 24);
            this.toolStripDropDownButton1.Text = "Вариант расчёта выражения";
            // 
            // toolStripMenuItemV1
            // 
            this.toolStripMenuItemV1.Name = "toolStripMenuItemV1";
            this.toolStripMenuItemV1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemV1.Text = "Вариант 1";
            this.toolStripMenuItemV1.Click += new System.EventHandler(this.toolStripMenuItemV1_Click);
            // 
            // toolStripMenuItemV2
            // 
            this.toolStripMenuItemV2.Name = "toolStripMenuItemV2";
            this.toolStripMenuItemV2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemV2.Text = "Вариант 2";
            this.toolStripMenuItemV2.Click += new System.EventHandler(this.toolStripMenuItemV2_Click);
            // 
            // toolStripMenuItemV3
            // 
            this.toolStripMenuItemV3.Name = "toolStripMenuItemV3";
            this.toolStripMenuItemV3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemV3.Text = "Вариант 3";
            this.toolStripMenuItemV3.Click += new System.EventHandler(this.toolStripMenuItemV3_Click);
            // 
            // toolStripStatusLabelTask2
            // 
            this.toolStripStatusLabelTask2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabelTask2.Name = "toolStripStatusLabelTask2";
            this.toolStripStatusLabelTask2.Size = new System.Drawing.Size(79, 21);
            this.toolStripStatusLabelTask2.Text = "Результат";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(146, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LW__14.Properties.Resources.Task1;
            this.pictureBox1.Location = new System.Drawing.Point(201, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 62);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(146, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 160);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задание 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LW__14.Properties.Resources.Task2;
            this.pictureBox2.Location = new System.Drawing.Point(384, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 120);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDateTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDate;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxX;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxY;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxZ;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxA;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemV1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemV2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemV3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTask2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

