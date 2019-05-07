namespace SYSA14_Biljettbokning
{
    partial class Programkonstruktion_Assignment1_CustomerHandling
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.lblFeedbackCustomerID = new System.Windows.Forms.Label();
            this.lblFeedBackCustomerName = new System.Windows.Forms.Label();
            this.lblFeedbackCustomerAddress = new System.Windows.Forms.Label();
            this.lblFeedbackCustomerEmail = new System.Windows.Forms.Label();
            this.lblFeedbackEventPerformed = new System.Windows.Forms.Label();
            this.btnRegisterOfCustomer = new System.Windows.Forms.Button();
            this.btnUppdateCustomerInfo = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnSearchForCustomer = new System.Windows.Forms.Button();
            this.btnShowAllCustomers = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.radioBtnSearchViaID = new System.Windows.Forms.RadioButton();
            this.radioBtnSearchViaName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Tillbaka";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(12, 114);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(173, 22);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Kundens idnummer:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(13, 154);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(136, 22);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Kundens namn:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(12, 191);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(144, 22);
            this.lblCustomerAddress.TabIndex = 8;
            this.lblCustomerAddress.Text = "Kundens adress:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(14, 226);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(135, 22);
            this.lblCustomerEmail.TabIndex = 9;
            this.lblCustomerEmail.Text = "Kundens email:";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(202, 114);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerID.TabIndex = 10;
            // 
            // textBoxCustomerEmail
            // 
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(202, 226);
            this.textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerEmail.TabIndex = 11;
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(202, 191);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerAddress.TabIndex = 12;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(202, 154);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerName.TabIndex = 13;
            // 
            // lblFeedbackCustomerID
            // 
            this.lblFeedbackCustomerID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackCustomerID.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackCustomerID.Location = new System.Drawing.Point(503, 114);
            this.lblFeedbackCustomerID.Name = "lblFeedbackCustomerID";
            this.lblFeedbackCustomerID.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackCustomerID.TabIndex = 0;
            this.lblFeedbackCustomerID.Text = "Temp feedback text ID";
            // 
            // lblFeedBackCustomerName
            // 
            this.lblFeedBackCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBackCustomerName.ForeColor = System.Drawing.Color.Red;
            this.lblFeedBackCustomerName.Location = new System.Drawing.Point(503, 154);
            this.lblFeedBackCustomerName.Name = "lblFeedBackCustomerName";
            this.lblFeedBackCustomerName.Size = new System.Drawing.Size(672, 22);
            this.lblFeedBackCustomerName.TabIndex = 14;
            this.lblFeedBackCustomerName.Text = "Temp feedback text name";
            // 
            // lblFeedbackCustomerAddress
            // 
            this.lblFeedbackCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackCustomerAddress.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackCustomerAddress.Location = new System.Drawing.Point(503, 191);
            this.lblFeedbackCustomerAddress.Name = "lblFeedbackCustomerAddress";
            this.lblFeedbackCustomerAddress.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackCustomerAddress.TabIndex = 15;
            this.lblFeedbackCustomerAddress.Text = "Temp feedback text address";
            // 
            // lblFeedbackCustomerEmail
            // 
            this.lblFeedbackCustomerEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackCustomerEmail.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackCustomerEmail.Location = new System.Drawing.Point(503, 226);
            this.lblFeedbackCustomerEmail.Name = "lblFeedbackCustomerEmail";
            this.lblFeedbackCustomerEmail.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackCustomerEmail.TabIndex = 16;
            this.lblFeedbackCustomerEmail.Text = "Temp feedback text email";
            // 
            // lblFeedbackEventPerformed
            // 
            this.lblFeedbackEventPerformed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackEventPerformed.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblFeedbackEventPerformed.Location = new System.Drawing.Point(8, 462);
            this.lblFeedbackEventPerformed.Name = "lblFeedbackEventPerformed";
            this.lblFeedbackEventPerformed.Size = new System.Drawing.Size(1159, 22);
            this.lblFeedbackEventPerformed.TabIndex = 17;
            this.lblFeedbackEventPerformed.Text = "Temp feedback text Event Performed";
            // 
            // btnRegisterOfCustomer
            // 
            this.btnRegisterOfCustomer.Location = new System.Drawing.Point(12, 298);
            this.btnRegisterOfCustomer.Name = "btnRegisterOfCustomer";
            this.btnRegisterOfCustomer.Size = new System.Drawing.Size(162, 52);
            this.btnRegisterOfCustomer.TabIndex = 18;
            this.btnRegisterOfCustomer.Text = "Registrera ny kund";
            this.btnRegisterOfCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterOfCustomer.Click += new System.EventHandler(this.BtnRegisterOfCustomer_Click);
            // 
            // btnUppdateCustomerInfo
            // 
            this.btnUppdateCustomerInfo.Location = new System.Drawing.Point(12, 366);
            this.btnUppdateCustomerInfo.Name = "btnUppdateCustomerInfo";
            this.btnUppdateCustomerInfo.Size = new System.Drawing.Size(162, 52);
            this.btnUppdateCustomerInfo.TabIndex = 19;
            this.btnUppdateCustomerInfo.Text = "Uppdatera kundinformation";
            this.btnUppdateCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(202, 298);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(162, 52);
            this.btnDeleteCustomer.TabIndex = 20;
            this.btnDeleteCustomer.Text = "Borttagning av kund";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // btnSearchForCustomer
            // 
            this.btnSearchForCustomer.Location = new System.Drawing.Point(393, 366);
            this.btnSearchForCustomer.Name = "btnSearchForCustomer";
            this.btnSearchForCustomer.Size = new System.Drawing.Size(172, 52);
            this.btnSearchForCustomer.TabIndex = 21;
            this.btnSearchForCustomer.Text = "Sök";
            this.btnSearchForCustomer.UseVisualStyleBackColor = true;
            this.btnSearchForCustomer.Click += new System.EventHandler(this.BtnSearchForCustomer_Click);
            // 
            // btnShowAllCustomers
            // 
            this.btnShowAllCustomers.Location = new System.Drawing.Point(202, 366);
            this.btnShowAllCustomers.Name = "btnShowAllCustomers";
            this.btnShowAllCustomers.Size = new System.Drawing.Size(162, 52);
            this.btnShowAllCustomers.TabIndex = 22;
            this.btnShowAllCustomers.Text = "Vias alla kunder";
            this.btnShowAllCustomers.UseVisualStyleBackColor = true;
            this.btnShowAllCustomers.Click += new System.EventHandler(this.BtnShowAllCustomers_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 487);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1158, 254);
            this.dataGridView.TabIndex = 23;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(501, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(203, 32);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Kundhantering";
            // 
            // radioBtnSearchViaID
            // 
            this.radioBtnSearchViaID.AutoSize = true;
            this.radioBtnSearchViaID.Checked = true;
            this.radioBtnSearchViaID.Location = new System.Drawing.Point(393, 298);
            this.radioBtnSearchViaID.Name = "radioBtnSearchViaID";
            this.radioBtnSearchViaID.Size = new System.Drawing.Size(150, 21);
            this.radioBtnSearchViaID.TabIndex = 25;
            this.radioBtnSearchViaID.TabStop = true;
            this.radioBtnSearchViaID.Text = "Sök via kundens ID";
            this.radioBtnSearchViaID.UseVisualStyleBackColor = true;
            // 
            // radioBtnSearchViaName
            // 
            this.radioBtnSearchViaName.AutoSize = true;
            this.radioBtnSearchViaName.Location = new System.Drawing.Point(393, 329);
            this.radioBtnSearchViaName.Name = "radioBtnSearchViaName";
            this.radioBtnSearchViaName.Size = new System.Drawing.Size(172, 21);
            this.radioBtnSearchViaName.TabIndex = 26;
            this.radioBtnSearchViaName.Text = "Sök via kundens namn";
            this.radioBtnSearchViaName.UseVisualStyleBackColor = true;
            // 
            // Programkonstruktion_Assignment1_CustomerHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.radioBtnSearchViaName);
            this.Controls.Add(this.radioBtnSearchViaID);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnShowAllCustomers);
            this.Controls.Add(this.btnSearchForCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUppdateCustomerInfo);
            this.Controls.Add(this.btnRegisterOfCustomer);
            this.Controls.Add(this.lblFeedbackEventPerformed);
            this.Controls.Add(this.lblFeedbackCustomerEmail);
            this.Controls.Add(this.lblFeedbackCustomerAddress);
            this.Controls.Add(this.lblFeedBackCustomerName);
            this.Controls.Add(this.lblFeedbackCustomerID);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.textBoxCustomerEmail);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnBack);
            this.Name = "Programkonstruktion_Assignment1_CustomerHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programkonstruktion uppgift 1 - Kundhantering";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label lblFeedbackCustomerID;
        private System.Windows.Forms.Label lblFeedBackCustomerName;
        private System.Windows.Forms.Label lblFeedbackCustomerAddress;
        private System.Windows.Forms.Label lblFeedbackCustomerEmail;
        private System.Windows.Forms.Label lblFeedbackEventPerformed;
        private System.Windows.Forms.Button btnRegisterOfCustomer;
        private System.Windows.Forms.Button btnUppdateCustomerInfo;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnSearchForCustomer;
        private System.Windows.Forms.Button btnShowAllCustomers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radioBtnSearchViaID;
        private System.Windows.Forms.RadioButton radioBtnSearchViaName;
    }
}