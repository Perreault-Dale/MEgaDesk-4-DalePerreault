namespace MegaDesk_4_DalePerreault
{
    partial class DisplayQuote
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
            this.viewOrdersGridView = new System.Windows.Forms.DataGridView();
            this.custNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskMaterials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewOrdersGridView
            // 
            this.viewOrdersGridView.AllowUserToAddRows = false;
            this.viewOrdersGridView.AllowUserToDeleteRows = false;
            this.viewOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameColumn,
            this.deskWidth,
            this.deskDepth,
            this.deskDrawers,
            this.deskMaterials,
            this.orderDate,
            this.deskPrice});
            this.viewOrdersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewOrdersGridView.Location = new System.Drawing.Point(0, 0);
            this.viewOrdersGridView.Name = "viewOrdersGridView";
            this.viewOrdersGridView.ReadOnly = true;
            this.viewOrdersGridView.RowTemplate.Height = 28;
            this.viewOrdersGridView.Size = new System.Drawing.Size(747, 529);
            this.viewOrdersGridView.TabIndex = 0;
            // 
            // custNameColumn
            // 
            this.custNameColumn.HeaderText = "Name";
            this.custNameColumn.Name = "custNameColumn";
            this.custNameColumn.ReadOnly = true;
            // 
            // deskWidth
            // 
            this.deskWidth.HeaderText = "Width";
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.ReadOnly = true;
            // 
            // deskDepth
            // 
            this.deskDepth.HeaderText = "Depth";
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.ReadOnly = true;
            // 
            // deskDrawers
            // 
            this.deskDrawers.HeaderText = "Drawers";
            this.deskDrawers.Name = "deskDrawers";
            this.deskDrawers.ReadOnly = true;
            // 
            // deskMaterials
            // 
            this.deskMaterials.HeaderText = "Surface";
            this.deskMaterials.Name = "deskMaterials";
            this.deskMaterials.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // deskPrice
            // 
            this.deskPrice.HeaderText = "Price";
            this.deskPrice.Name = "deskPrice";
            this.deskPrice.ReadOnly = true;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 529);
            this.Controls.Add(this.viewOrdersGridView);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisPlayQuote_closing);
            ((System.ComponentModel.ISupportInitialize)(this.viewOrdersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewOrdersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskPrice;
    }
}