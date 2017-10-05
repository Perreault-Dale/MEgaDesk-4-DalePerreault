namespace MegaDesk_4_DalePerreault
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
            this.addQuote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuote = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.Location = new System.Drawing.Point(48, 79);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(192, 57);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "Add New Quote";
            this.addQuote.UseVisualStyleBackColor = true;
            this.addQuote.Click += new System.EventHandler(this.addQuoteClick);
            // 
            // viewQuote
            // 
            this.viewQuote.Location = new System.Drawing.Point(48, 189);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Size = new System.Drawing.Size(192, 57);
            this.viewQuote.TabIndex = 1;
            this.viewQuote.Text = "View Quotes";
            this.viewQuote.UseVisualStyleBackColor = true;
            this.viewQuote.Click += new System.EventHandler(this.viewQuoteClick);
            // 
            // searchQuote
            // 
            this.searchQuote.Location = new System.Drawing.Point(48, 299);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(192, 57);
            this.searchQuote.TabIndex = 2;
            this.searchQuote.Text = "Search Quotes";
            this.searchQuote.UseVisualStyleBackColor = true;
            this.searchQuote.Click += new System.EventHandler(this.searchQuoteClick);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(48, 409);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(192, 57);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exitApp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.addQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuote;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

