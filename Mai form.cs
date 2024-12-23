using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using QRCoder;

namespace QRCodeGeneratorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            // Collect data from text fields
            string qrData = $"Customer Name: {txtCustomerName.Text}\n" +
                            $"Product Desc.: {txtProductDesc.Text}\n" +
                            $"Batch Number: {txtBatchNumber.Text}\n" +
                            $"Thickness: {txtThickness.Text}\n" +
                            $"Width: {txtWidth.Text}\n" +
                            $"Weight: {txtWeight.Text}\n" +
                            $"Date/Shift: {txtDateShift.Text}";

            // Generate QR Code
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                // Display QR Code in PictureBox
                picQRCode.Image = qrCode.GetGraphic(5);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set font and layout
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Define positions for text
            int x = 100, y = 100;

            // Print each field
            e.Graphics.DrawString("WIP Details", new Font("Arial", 16, FontStyle.Bold), brush, x, y);
            y += 40;
            e.Graphics.DrawString($"Customer Name: {txtCustomerName.Text}", font, brush, x, y);
            y += 30;
            e.Graphics.DrawString($"Product Desc.: {txtProductDesc.Text}", font, brush, x, y);
            y += 30;
            e.Graphics.DrawString($"Batch Number: {txtBatchNumber.Text}", font, brush, x, y);
            y += 30;
            e.Graphics.DrawString($"Thickness: {txtThickness.Text}", font, brush, x, y);
            y += 30;
            e.Graphics.DrawString($"Width: {txtWidth.Text}", font, brush, x, y);
            y += 30;
            e.Graphics.DrawString($"Weight: {txtWeight.Text}", font, brush, x, y);
            y += 30;
            e.Graphics.DrawString($"Date/Shift: {txtDateShift.Text}", font, brush, x, y);
            y += 50;

            // Print QR Code
            if (picQRCode.Image != null)
            {
                e.Graphics.DrawImage(picQRCode.Image, x, y, 150, 150);
            }
        }
    }
}
