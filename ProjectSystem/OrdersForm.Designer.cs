namespace ProjectSystem
{
    partial class OrdersForm
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
            listBoxOrders = new ListBox();
            SuspendLayout();
            // 
            // listBoxOrders
            // 
            listBoxOrders.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.ItemHeight = 23;
            listBoxOrders.Location = new Point(12, 44);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.ScrollAlwaysVisible = true;
            listBoxOrders.Size = new Size(776, 372);
            listBoxOrders.TabIndex = 0;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxOrders);
            MaximizeBox = false;
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Your order history";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOrders;
    }
}