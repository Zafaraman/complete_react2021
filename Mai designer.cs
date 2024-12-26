namespace WIPDetailsApplication
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            
            // Customer Name
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            
            // Product Description
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            
            // Batch Number
            this.lblBatchNumber = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            
            // Thickness
            this.lblThickness = new System.Windows.Forms.Label();
            this.txtThickness = new System.Windows.Forms.TextBox();
            
            // Width
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            
            // Surface Finish
            this.lblSurfaceFinish = new System.Windows.Forms.Label();
            this.txtSurfaceFinish = new System.Windows.Forms.TextBox();
            
            // Right side controls
            this.lblMotherBatch = new System.Windows.Forms.Label();
            this.txtMotherBatch = new System.Windows.Forms.TextBox();
            
            this.lblCustomerGrade = new System.Windows.Forms.Label();
            this.txtCustomerGrade = new System.Windows.Forms.TextBox();
            
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            
            this.lblDateShift = new System.Windows.Forms.Label();
            this.txtDateShift = new System.Windows.Forms.TextBox();
            
            // QR Code
            this.picBoxQRCode = new System.Windows.Forms.PictureBox();
            
            // Process Information
            this.lblPreviousStageRemarks = new System.Windows.Forms.Label();
            this.txtPreviousStageRemarks = new System.Windows.Forms.TextBox();
            
            this.lblProcessRoute = new System.Windows.Forms.Label();
            this.txtProcessRoute = new System.Windows.Forms.TextBox();
            
            this.lblCurrentWorkcenter = new System.Windows.Forms.Label();
            this.txtCurrentWorkcenter = new System.Windows.Forms.TextBox();
            
            this.lblNextWorkcenter = new System.Windows.Forms.Label();
            this.txtNextWorkcenter = new System.Windows.Forms.TextBox();
            
            this.lblTopCoatColor = new System.Windows.Forms.Label();
            this.txtTopCoatColor = new System.Windows.Forms.TextBox();
            
            this.lblBottomCoatColor = new System.Windows.Forms.Label();
            this.txtBottomCoatColor = new System.Windows.Forms.TextBox();
            
            // IEO Group Box
            this.grpIEO = new System.Windows.Forms.GroupBox();
            this.lblNoOfSheet = new System.Windows.Forms.Label();
            this.txtNoOfSheet = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();

            // Initialize Layout
            this.InitializeLayout();

            // Set form properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Name = "WIPDetailsForm";
            this.Text = "WIP Details";
            this.ResumeLayout(false);
        }

        private void InitializeLayout()
        {
            // Main Layout
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // Header
            this.lblTitle.Text = "WIP Details";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerPanel.Controls.Add(this.lblTitle);
            
            // Left Column Controls
            this.SetupLeftColumnControls();
            
            // Right Column Controls
            this.SetupRightColumnControls();
            
            // Add panels to form
            this.Controls.Add(this.mainLayoutPanel);
        }

        private void SetupLeftColumnControls()
        {
            // Customer Name
            this.lblCustomerName.Text = "Customer Name";
            this.txtCustomerName.Text = "TATA BLUESCOPE STEEL PRIVATE LIMITE";
            this.txtCustomerName.ReadOnly = true;
            
            // Product Description
            this.lblProductDesc.Text = "Product Desc.";
            this.txtProductDesc.Text = "PPGL C Y550PL HPL3 0.50BMT(0.58TPT)X610";
            this.txtProductDesc.ReadOnly = true;
            
            // Continue setting up other left column controls...
        }

        private void SetupRightColumnControls()
        {
            // Mother Batch
            this.lblMotherBatch.Text = "Mother Batch";
            this.txtMotherBatch.ReadOnly = true;
            
            // Customer Grade
            this.lblCustomerGrade.Text = "Customer Grade";
            this.txtCustomerGrade.ReadOnly = true;
            
            // Continue setting up other right column controls...
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.TextBox txtProductDesc;
        // ... continue declaring all other controls
    }
}