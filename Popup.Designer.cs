namespace CGNotify
{
    partial class Popup
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
            this.btnHide = new System.Windows.Forms.Button();
            this.lblNotify = new System.Windows.Forms.Label();
            this.btnLaunchBrowserContainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Red;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(309, -1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(23, 23);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "X";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotify.Location = new System.Drawing.Point(13, 20);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(232, 16);
            this.lblNotify.TabIndex = 3;
            this.lblNotify.Text = "You have new survey requests";
            // 
            // btnLaunchBrowserContainer
            // 
            this.btnLaunchBrowserContainer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchBrowserContainer.Location = new System.Drawing.Point(16, 52);
            this.btnLaunchBrowserContainer.Name = "btnLaunchBrowserContainer";
            this.btnLaunchBrowserContainer.Size = new System.Drawing.Size(134, 29);
            this.btnLaunchBrowserContainer.TabIndex = 4;
            this.btnLaunchBrowserContainer.Text = "Go to surveys";
            this.btnLaunchBrowserContainer.UseVisualStyleBackColor = true;
            this.btnLaunchBrowserContainer.Click += new System.EventHandler(this.btnLaunchBrowserContainer_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(331, 137);
            this.ControlBox = false;
            this.Controls.Add(this.btnLaunchBrowserContainer);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.btnHide);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CGNotify";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Button btnLaunchBrowserContainer;
    }
}

