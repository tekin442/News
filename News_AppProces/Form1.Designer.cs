namespace News_AppProces
{
    partial class Form1
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
            this.btnAppProcess = new System.Windows.Forms.Button();
            this.lblExplain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAppProcess
            // 
            this.btnAppProcess.AllowDrop = true;
            this.btnAppProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAppProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppProcess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAppProcess.Location = new System.Drawing.Point(31, 127);
            this.btnAppProcess.Name = "btnAppProcess";
            this.btnAppProcess.Size = new System.Drawing.Size(443, 45);
            this.btnAppProcess.TabIndex = 0;
            this.btnAppProcess.Text = "Değişiklikleri Yansıt";
            this.btnAppProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAppProcess.UseVisualStyleBackColor = true;
            this.btnAppProcess.Click += new System.EventHandler(this.btnAppProcess_Click);
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(34, 86);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(0, 13);
            this.lblExplain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uygulama Kodu:";
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(145, 42);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(329, 20);
            this.txtGuid.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 423);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.btnAppProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppProcess;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuid;
    }
}

