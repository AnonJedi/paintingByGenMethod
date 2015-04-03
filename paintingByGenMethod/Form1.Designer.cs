namespace paintingByGenMethod
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.samplePictureBox = new System.Windows.Forms.PictureBox();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoadBar = new System.Windows.Forms.ProgressBar();
            this.openPaint = new System.Windows.Forms.OpenFileDialog();
            this.CntrLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.samplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // samplePictureBox
            // 
            this.samplePictureBox.Location = new System.Drawing.Point(0, -1);
            this.samplePictureBox.Name = "samplePictureBox";
            this.samplePictureBox.Size = new System.Drawing.Size(574, 558);
            this.samplePictureBox.TabIndex = 0;
            this.samplePictureBox.TabStop = false;
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(581, -1);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(574, 558);
            this.myPictureBox.TabIndex = 1;
            this.myPictureBox.TabStop = false;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.LoadButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadButton.Location = new System.Drawing.Point(12, 563);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 23);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Download pic";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Location = new System.Drawing.Point(128, 563);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(65, 65);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = ">";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(1067, 605);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoadBar
            // 
            this.LoadBar.Location = new System.Drawing.Point(12, 605);
            this.LoadBar.Maximum = 50;
            this.LoadBar.Name = "LoadBar";
            this.LoadBar.Size = new System.Drawing.Size(100, 23);
            this.LoadBar.Step = 1;
            this.LoadBar.TabIndex = 5;
            // 
            // openPaint
            // 
            this.openPaint.FileName = "openFileDialog1";
            // 
            // CntrLbl
            // 
            this.CntrLbl.AutoSize = true;
            this.CntrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CntrLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CntrLbl.Location = new System.Drawing.Point(199, 590);
            this.CntrLbl.Name = "CntrLbl";
            this.CntrLbl.Size = new System.Drawing.Size(0, 20);
            this.CntrLbl.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1154, 640);
            this.Controls.Add(this.CntrLbl);
            this.Controls.Add(this.LoadBar);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.samplePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital painting";
            ((System.ComponentModel.ISupportInitialize)(this.samplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox samplePictureBox;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ProgressBar LoadBar;
        private System.Windows.Forms.OpenFileDialog openPaint;
        private System.Windows.Forms.Label CntrLbl;
    }
}

