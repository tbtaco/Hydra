namespace Hydra
{
    partial class HydraHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HydraHead));
            this.uxAttack = new System.Windows.Forms.Button();
            this.uxLabel1 = new System.Windows.Forms.Label();
            this.uxLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAttack
            // 
            this.uxAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAttack.Location = new System.Drawing.Point(286, 13);
            this.uxAttack.Name = "uxAttack";
            this.uxAttack.Size = new System.Drawing.Size(226, 74);
            this.uxAttack.TabIndex = 0;
            this.uxAttack.Text = "Attack!";
            this.uxAttack.UseVisualStyleBackColor = true;
            this.uxAttack.Click += new System.EventHandler(this.uxAttack_Click);
            // 
            // uxLabel1
            // 
            this.uxLabel1.AutoSize = true;
            this.uxLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel1.Location = new System.Drawing.Point(13, 16);
            this.uxLabel1.Name = "uxLabel1";
            this.uxLabel1.Size = new System.Drawing.Size(236, 31);
            this.uxLabel1.TabIndex = 1;
            this.uxLabel1.Text = "Chop One Off And";
            // 
            // uxLabel2
            // 
            this.uxLabel2.AutoSize = true;
            this.uxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel2.Location = new System.Drawing.Point(10, 51);
            this.uxLabel2.Name = "uxLabel2";
            this.uxLabel2.Size = new System.Drawing.Size(270, 31);
            this.uxLabel2.TabIndex = 2;
            this.uxLabel2.Text = "Two Take Its Place...";
            // 
            // HydraHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(524, 99);
            this.Controls.Add(this.uxAttack);
            this.Controls.Add(this.uxLabel2);
            this.Controls.Add(this.uxLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HydraHead";
            this.ShowInTaskbar = false;
            this.Text = "Hydra.exe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HydraHead_FormClosing);
            this.Load += new System.EventHandler(this.HydraHead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAttack;
        private System.Windows.Forms.Label uxLabel1;
        private System.Windows.Forms.Label uxLabel2;
    }
}