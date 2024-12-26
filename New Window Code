namespace QRCodeGeneratorApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtDateShift;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtDateShift = new System.Windows.Forms.TextBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            
            // TextBoxes
            this.txtCustomerName.Location = new System.Drawing.Point(30, 30);
            this.txtCustomerName.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerName.PlaceholderText = "Customer Name";
            
            this.txtProductDesc.Location = new System.Drawing.Point(30, 70);
            this.txtProductDesc.Size = new System.Drawing.Size(200, 22);
            this.txtProductDesc.PlaceholderText = "Product Desc.";

            this.txtBatchNumber.Location = new System.Drawing.Point(30, 110);
            this.txtBatchNumber.Size = new System.Drawing.Size(200, 22);
            this.txtBatchNumber.PlaceholderText = "Batch Number";

            this.txtThickness.Location = new System.Drawing.Point(30, 150);
            this.txtThickness.Size = new System.Drawing.Size(200, 22);
            this.txtThickness.PlaceholderText = "Thickness";

            this.txtWidth.Location = new System.Drawing.Point(30, 190);
            this.txtWidth.Size = new System.Drawing.Size(200, 22);
            this.txtWidth.PlaceholderText = "Width";

            this.txtWeight.Location = new System.Drawing.Point(30, 230);
            this.txtWeight.Size = new System.Drawing.Size(200, 22);
            this.txtWeight.PlaceholderText = "Weight";

            this.txtDateShift.Location = new System.Drawing.Point(30, 270);
            this.txtDateShift.Size = new System.Drawing.Size(200, 22);
            this.txtDateShift.PlaceholderText = "Date/Shift";

            // PictureBox
            this.picQRCode.Location = new System.Drawing.Point(260, 30);
            this.picQRCode.Size = new System.Drawing.Size(200, 200);
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Buttons
            this.btnGenerateQRCode.Location = new System.Drawing.Point(30, 320);
            this.btnGenerateQRCode.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateQRCode.Text = "Generate QR Code";
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);

            this.btnPrint.Location = new System.Drawing.Point(200, 320);
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // Print Preview Dialog
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

            // Form
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.txtBatchNumber);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtDateShift);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.btnPrint);
            this.Name = "MainForm";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
