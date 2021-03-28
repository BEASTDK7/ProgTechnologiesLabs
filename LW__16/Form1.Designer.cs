
namespace LW__16
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvRaw = new System.Windows.Forms.DataGridView();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(12, 385);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(180, 32);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить данные";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvRaw
            // 
            this.dgvRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaw.Location = new System.Drawing.Point(12, 12);
            this.dgvRaw.Name = "dgvRaw";
            this.dgvRaw.Size = new System.Drawing.Size(468, 367);
            this.dgvRaw.TabIndex = 1;
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(486, 12);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.Size = new System.Drawing.Size(450, 367);
            this.dgvSummary.TabIndex = 2;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDlg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 425);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.dgvRaw);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "ИНС191 Кошевой ЛР16";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvRaw;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}

