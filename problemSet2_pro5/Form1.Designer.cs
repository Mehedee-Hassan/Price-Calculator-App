using System.Windows.Forms;

namespace problemSet2_pro5
{
    partial class PriceCalculatorForm
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
            this.productDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameGridViewColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceGridViewColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPricePerItemGridViewColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameAndPriceComboBox = new System.Windows.Forms.ComboBox();
            this.selectProductLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.numbetOfItemsLabel = new System.Windows.Forms.Label();
            this.payTitleLabel = new System.Windows.Forms.Label();
            this.addToDataGridViewButton = new System.Windows.Forms.Button();
            this.numbetOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.payValueLabel = new System.Windows.Forms.Label();
            this.productDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsDataGridView)).BeginInit();
            this.productDetailsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDetailsDataGridView
            // 
            this.productDetailsDataGridView.AllowUserToAddRows = false;
            this.productDetailsDataGridView.AllowUserToDeleteRows = false;
            this.productDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameGridViewColumnTitle,
            this.unitPriceGridViewColumnTitle,
            this.totalPricePerItemGridViewColumnTitle});
            this.productDetailsDataGridView.Location = new System.Drawing.Point(10, 179);
            this.productDetailsDataGridView.Name = "productDetailsDataGridView";
            this.productDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDetailsDataGridView.Size = new System.Drawing.Size(343, 203);
            this.productDetailsDataGridView.TabIndex = 0;
            this.productDetailsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDetailsDataGridView_CellContentDoubleClick);
            this.productDetailsDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productDetailsDataGridView_MouseDoubleClick);
            // 
            // productNameGridViewColumnTitle
            // 
            this.productNameGridViewColumnTitle.HeaderText = "Product Name";
            this.productNameGridViewColumnTitle.Name = "productNameGridViewColumnTitle";
            // 
            // unitPriceGridViewColumnTitle
            // 
            this.unitPriceGridViewColumnTitle.HeaderText = "Unit Price";
            this.unitPriceGridViewColumnTitle.Name = "unitPriceGridViewColumnTitle";
            // 
            // totalPricePerItemGridViewColumnTitle
            // 
            this.totalPricePerItemGridViewColumnTitle.HeaderText = "Item Total Price ";
            this.totalPricePerItemGridViewColumnTitle.Name = "totalPricePerItemGridViewColumnTitle";
            // 
            // productNameAndPriceComboBox
            // 
            this.productNameAndPriceComboBox.FormattingEnabled = true;
            this.productNameAndPriceComboBox.Items.AddRange(new object[] {
            "Monitor [5000 Tk]",
            "Mouse [300 Tk]",
            "KeyBoard [500 Tk]",
            "PenDrive [800 Tk]",
            "Processor [18000 Tk]"});
            this.productNameAndPriceComboBox.Location = new System.Drawing.Point(104, 31);
            this.productNameAndPriceComboBox.Name = "productNameAndPriceComboBox";
            this.productNameAndPriceComboBox.Size = new System.Drawing.Size(221, 21);
            this.productNameAndPriceComboBox.TabIndex = 1;
            this.productNameAndPriceComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameAndPriceComboBox_SelectedIndexChanged_1);
            // 
            // selectProductLabel
            // 
            this.selectProductLabel.AutoSize = true;
            this.selectProductLabel.Location = new System.Drawing.Point(6, 34);
            this.selectProductLabel.Name = "selectProductLabel";
            this.selectProductLabel.Size = new System.Drawing.Size(77, 13);
            this.selectProductLabel.TabIndex = 2;
            this.selectProductLabel.Text = "Select Product";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(137, 450);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 34);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // numbetOfItemsLabel
            // 
            this.numbetOfItemsLabel.AutoSize = true;
            this.numbetOfItemsLabel.Location = new System.Drawing.Point(6, 77);
            this.numbetOfItemsLabel.Name = "numbetOfItemsLabel";
            this.numbetOfItemsLabel.Size = new System.Drawing.Size(92, 13);
            this.numbetOfItemsLabel.TabIndex = 2;
            this.numbetOfItemsLabel.Text = "Number Of Items :";
            // 
            // payTitleLabel
            // 
            this.payTitleLabel.AutoSize = true;
            this.payTitleLabel.Location = new System.Drawing.Point(124, 25);
            this.payTitleLabel.Name = "payTitleLabel";
            this.payTitleLabel.Size = new System.Drawing.Size(31, 13);
            this.payTitleLabel.TabIndex = 2;
            this.payTitleLabel.Text = "Pay :";
            // 
            // addToDataGridViewButton
            // 
            this.addToDataGridViewButton.Location = new System.Drawing.Point(247, 70);
            this.addToDataGridViewButton.Name = "addToDataGridViewButton";
            this.addToDataGridViewButton.Size = new System.Drawing.Size(78, 26);
            this.addToDataGridViewButton.TabIndex = 3;
            this.addToDataGridViewButton.Text = "Add";
            this.addToDataGridViewButton.UseVisualStyleBackColor = true;
            this.addToDataGridViewButton.Click += new System.EventHandler(this.addToDataGridViewButton_Click_1);
            // 
            // numbetOfItemsTextBox
            // 
            this.numbetOfItemsTextBox.Location = new System.Drawing.Point(104, 74);
            this.numbetOfItemsTextBox.Name = "numbetOfItemsTextBox";
            this.numbetOfItemsTextBox.Size = new System.Drawing.Size(113, 20);
            this.numbetOfItemsTextBox.TabIndex = 4;
            // 
            // payValueLabel
            // 
            this.payValueLabel.AutoSize = true;
            this.payValueLabel.Location = new System.Drawing.Point(167, 25);
            this.payValueLabel.Name = "payValueLabel";
            this.payValueLabel.Size = new System.Drawing.Size(13, 13);
            this.payValueLabel.TabIndex = 2;
            this.payValueLabel.Text = "0";
            // 
            // productDetailsGroupBox
            // 
            this.productDetailsGroupBox.Controls.Add(this.updateButton);
            this.productDetailsGroupBox.Controls.Add(this.productNameAndPriceComboBox);
            this.productDetailsGroupBox.Controls.Add(this.numbetOfItemsTextBox);
            this.productDetailsGroupBox.Controls.Add(this.selectProductLabel);
            this.productDetailsGroupBox.Controls.Add(this.addToDataGridViewButton);
            this.productDetailsGroupBox.Controls.Add(this.numbetOfItemsLabel);
            this.productDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.productDetailsGroupBox.Name = "productDetailsGroupBox";
            this.productDetailsGroupBox.Size = new System.Drawing.Size(341, 152);
            this.productDetailsGroupBox.TabIndex = 5;
            this.productDetailsGroupBox.TabStop = false;
            this.productDetailsGroupBox.Text = "Product Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payValueLabel);
            this.groupBox2.Controls.Add(this.payTitleLabel);
            this.groupBox2.Location = new System.Drawing.Point(10, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Price";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(247, 111);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 24);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // PriceCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.productDetailsGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.productDetailsDataGridView);
            this.Name = "PriceCalculatorForm";
            this.Text = "Price Calculator";
            this.Load += new System.EventHandler(this.PriceCalculatorForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsDataGridView)).EndInit();
            this.productDetailsGroupBox.ResumeLayout(false);
            this.productDetailsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameGridViewColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceGridViewColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPricePerItemGridViewColumnTitle;
        private System.Windows.Forms.ComboBox productNameAndPriceComboBox;
        private System.Windows.Forms.Label selectProductLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label numbetOfItemsLabel;
        private System.Windows.Forms.Label payTitleLabel;
        private System.Windows.Forms.Button addToDataGridViewButton;
        private System.Windows.Forms.TextBox numbetOfItemsTextBox;
        private System.Windows.Forms.Label payValueLabel;
        private System.Windows.Forms.GroupBox productDetailsGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private Button updateButton;
    }
}

