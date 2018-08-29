namespace TC1.View
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblHello = new System.Windows.Forms.Label();
            this.btnToEnglish = new System.Windows.Forms.Button();
            this.btnToSpanish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(93, 70);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 73);
            this.lblHello.TabIndex = 2;
            // 
            // btnToEnglish
            // 
            this.btnToEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToEnglish.BackgroundImage")));
            this.btnToEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToEnglish.Location = new System.Drawing.Point(302, -1);
            this.btnToEnglish.Name = "btnToEnglish";
            this.btnToEnglish.Size = new System.Drawing.Size(37, 38);
            this.btnToEnglish.TabIndex = 3;
            this.btnToEnglish.UseVisualStyleBackColor = true;
            this.btnToEnglish.Click += new System.EventHandler(this.btnToEnglish_Click);
            // 
            // btnToSpanish
            // 
            this.btnToSpanish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToSpanish.BackgroundImage")));
            this.btnToSpanish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToSpanish.Location = new System.Drawing.Point(345, -1);
            this.btnToSpanish.Name = "btnToSpanish";
            this.btnToSpanish.Size = new System.Drawing.Size(37, 38);
            this.btnToSpanish.TabIndex = 4;
            this.btnToSpanish.UseVisualStyleBackColor = true;
            this.btnToSpanish.Click += new System.EventHandler(this.btnToSpanish_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 238);
            this.Controls.Add(this.btnToSpanish);
            this.Controls.Add(this.btnToEnglish);
            this.Controls.Add(this.lblHello);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnToEnglish;
        private System.Windows.Forms.Button btnToSpanish;
    }
}

