namespace WIPDetails
{
    partial class WIPDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.productDescBox = new System.Windows.Forms.TextBox();
            this.batchNumberBox = new System.Windows.Forms.TextBox();
            this.thicknessBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.dateShiftBox = new System.Windows.Forms.TextBox();
            this.topCoatColorBox = new System.Windows.Forms.TextBox();
            this.bottomCoatColorBox = new System.Windows.Forms.TextBox();
            this.processRouteBox = new System.Windows.Forms.TextBox();
            this.qrCodeBox = new System.Windows.Forms.PictureBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            
            // Labels
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblBatchNumber = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDateShift = new System.Windows.Forms.Label();
            this.lblTopCoat = new System.Windows.Forms.Label();
            this.lblBottomCoat = new System.Windows.Forms.Label();
            this.lblProcessRoute = new System.Windows.Forms.Label();
            
            // Main TableLayoutPanel
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            
            // Button Panel
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            
            // Set form properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "WIPDetailsForm";
            this.Text = "WIP Details";
            
            // Initialize controls
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).BeginInit();
            
            // Set label texts
            this.lblCustomerName.Text = "Customer Name:";
            this.lblProductDesc.Text = "Product Desc.:";
            this.lblBatchNumber.Text = "Batch Number:";
            this.lblThickness.Text = "Thickness:";
            this.lblWidth.Text = "Width:";
            this.lblWeight.Text = "Weight:";
            this.lblDateShift.Text = "Date/Shift:";
            this.lblTopCoat.Text = "Top Coat Color:";
            this.lblBottomCoat.Text = "Bottom Coat Color:";
            this.lblProcessRoute.Text = "Process Route:";
            
            // Set default textbox values
            this.customerNameBox.Text = "TATA BLUESCOPE STEEL PRIVATE LIMITE";
            this.productDescBox.Text = "PPGL C Y550PL HPL3 0.50BMT(0.58TPT)X610";
            this.batchNumberBox.Text = "K4C1072100";
            this.thicknessBox.Text = "0.500 MM";
            this.widthBox.Text = "1235 MM";
            this.weightBox.Text = "15.160 MT";
            this.dateShiftBox.Text = "22-DEC-24/B";
            this.topCoatColorBox.Text = "ROYAL LIGHT BLUE TSL 245";
            this.bottomCoatColorBox.Text = "7035/TSL-629B";
            this.processRouteBox.Text = "CCL CRS (P-M2-TR-QA-GL-QA-C-QA-R-QA-PACK)";
            
            // Configure QR Code PictureBox
            this.qrCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrCodeBox.Location = new System.Drawing.Point(600, 20);
            this.qrCodeBox.Size = new System.Drawing.Size(150, 150);
            this.qrCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            
            // Configure buttons
            this.generateButton.Text = "Generate QR Code";
            this.generateButton.Size = new System.Drawing.Size(120, 30);
            this.printButton.Text = "Print Form";
            this.printButton.Size = new System.Drawing.Size(120, 30);
            
            // Add controls to form
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.buttonPanel);
            
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox productDescBox;
        private System.Windows.Forms.TextBox batchNumberBox;
        private System.Windows.Forms.TextBox thicknessBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox dateShiftBox;
        private System.Windows.Forms.TextBox topCoatColorBox;
        private System.Windows.Forms.TextBox bottomCoatColorBox;
        private System.Windows.Forms.TextBox processRouteBox;
        private System.Windows.Forms.PictureBox qrCodeBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblBatchNumber;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDateShift;
        private System.Windows.Forms.Label lblTopCoat;
        private System.Windows.Forms.Label lblBottomCoat;
        private System.Windows.Forms.Label lblProcessRoute;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
    }
}