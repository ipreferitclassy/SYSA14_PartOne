namespace SYSA14_Biljettbokning
{
    partial class Programkonstruktion_Assignment1_BookingHandling
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
            this.radioBtnSearchViaCustomerName = new System.Windows.Forms.RadioButton();
            this.radioBtnSearchViaCustomerID = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblFeedbackEventPerformed = new System.Windows.Forms.Label();
            this.lblFeedbackMovieName = new System.Windows.Forms.Label();
            this.lblFeedbackMovieID = new System.Windows.Forms.Label();
            this.lblFeedBackCustomerName = new System.Windows.Forms.Label();
            this.lblFeedbackCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.radioBtnSearchViaMovieName = new System.Windows.Forms.RadioButton();
            this.radioBtnSearchViaMovieID = new System.Windows.Forms.RadioButton();
            this.buttonGeneralSearch = new System.Windows.Forms.Button();
            this.btnShowAllCustomers = new System.Windows.Forms.Button();
            this.btnShowAllMovies = new System.Windows.Forms.Button();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.lblInfoPickDateForMovie = new System.Windows.Forms.Label();
            this.dateTimePickerForMoive = new System.Windows.Forms.DateTimePicker();
            this.lblFeedbackBooking = new System.Windows.Forms.Label();
            this.lblFeedbackGeneralSearch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Tillbaka";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // radioBtnSearchViaCustomerName
            // 
            this.radioBtnSearchViaCustomerName.AutoSize = true;
            this.radioBtnSearchViaCustomerName.Location = new System.Drawing.Point(12, 240);
            this.radioBtnSearchViaCustomerName.Name = "radioBtnSearchViaCustomerName";
            this.radioBtnSearchViaCustomerName.Size = new System.Drawing.Size(172, 21);
            this.radioBtnSearchViaCustomerName.TabIndex = 47;
            this.radioBtnSearchViaCustomerName.Text = "Sök via kundens namn";
            this.radioBtnSearchViaCustomerName.UseVisualStyleBackColor = true;
            // 
            // radioBtnSearchViaCustomerID
            // 
            this.radioBtnSearchViaCustomerID.AutoSize = true;
            this.radioBtnSearchViaCustomerID.Checked = true;
            this.radioBtnSearchViaCustomerID.Location = new System.Drawing.Point(12, 209);
            this.radioBtnSearchViaCustomerID.Name = "radioBtnSearchViaCustomerID";
            this.radioBtnSearchViaCustomerID.Size = new System.Drawing.Size(150, 21);
            this.radioBtnSearchViaCustomerID.TabIndex = 46;
            this.radioBtnSearchViaCustomerID.TabStop = true;
            this.radioBtnSearchViaCustomerID.Text = "Sök via kundens ID";
            this.radioBtnSearchViaCustomerID.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 423);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1158, 340);
            this.dataGridView.TabIndex = 45;
            // 
            // lblFeedbackEventPerformed
            // 
            this.lblFeedbackEventPerformed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackEventPerformed.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblFeedbackEventPerformed.Location = new System.Drawing.Point(8, 398);
            this.lblFeedbackEventPerformed.Name = "lblFeedbackEventPerformed";
            this.lblFeedbackEventPerformed.Size = new System.Drawing.Size(1159, 22);
            this.lblFeedbackEventPerformed.TabIndex = 39;
            this.lblFeedbackEventPerformed.Text = "Temp feedback text Event Performed";
            // 
            // lblFeedbackMovieName
            // 
            this.lblFeedbackMovieName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieName.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieName.Location = new System.Drawing.Point(494, 162);
            this.lblFeedbackMovieName.Name = "lblFeedbackMovieName";
            this.lblFeedbackMovieName.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieName.TabIndex = 38;
            this.lblFeedbackMovieName.Text = "Temp feedback text movie name";
            // 
            // lblFeedbackMovieID
            // 
            this.lblFeedbackMovieID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieID.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieID.Location = new System.Drawing.Point(494, 134);
            this.lblFeedbackMovieID.Name = "lblFeedbackMovieID";
            this.lblFeedbackMovieID.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieID.TabIndex = 37;
            this.lblFeedbackMovieID.Text = "Temp feedback text movie ID";
            // 
            // lblFeedBackCustomerName
            // 
            this.lblFeedBackCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBackCustomerName.ForeColor = System.Drawing.Color.Red;
            this.lblFeedBackCustomerName.Location = new System.Drawing.Point(494, 106);
            this.lblFeedBackCustomerName.Name = "lblFeedBackCustomerName";
            this.lblFeedBackCustomerName.Size = new System.Drawing.Size(672, 22);
            this.lblFeedBackCustomerName.TabIndex = 36;
            this.lblFeedBackCustomerName.Text = "Temp feedback text name";
            // 
            // lblFeedbackCustomerID
            // 
            this.lblFeedbackCustomerID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackCustomerID.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackCustomerID.Location = new System.Drawing.Point(494, 78);
            this.lblFeedbackCustomerID.Name = "lblFeedbackCustomerID";
            this.lblFeedbackCustomerID.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackCustomerID.TabIndex = 27;
            this.lblFeedbackCustomerID.Text = "Temp feedback text ID";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(198, 106);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerName.TabIndex = 35;
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(198, 134);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(282, 22);
            this.textBoxMovieID.TabIndex = 34;
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(198, 162);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(282, 22);
            this.textBoxMovieName.TabIndex = 33;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(198, 78);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerID.TabIndex = 32;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(8, 162);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(129, 22);
            this.lblMovieName.TabIndex = 31;
            this.lblMovieName.Text = "Filmens namn:";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(8, 134);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(166, 22);
            this.lblMovieID.TabIndex = 30;
            this.lblMovieID.Text = "Filmens idnummer:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(8, 106);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(136, 22);
            this.lblCustomerName.TabIndex = 29;
            this.lblCustomerName.Text = "Kundens namn:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(8, 78);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(173, 22);
            this.lblCustomerID.TabIndex = 28;
            this.lblCustomerID.Text = "Kundens idnummer:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(497, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(246, 32);
            this.lblInfo.TabIndex = 48;
            this.lblInfo.Text = "Bokningshantering";
            // 
            // radioBtnSearchViaMovieName
            // 
            this.radioBtnSearchViaMovieName.AutoSize = true;
            this.radioBtnSearchViaMovieName.Location = new System.Drawing.Point(198, 240);
            this.radioBtnSearchViaMovieName.Name = "radioBtnSearchViaMovieName";
            this.radioBtnSearchViaMovieName.Size = new System.Drawing.Size(162, 21);
            this.radioBtnSearchViaMovieName.TabIndex = 51;
            this.radioBtnSearchViaMovieName.Text = "Sök via filmens namn";
            this.radioBtnSearchViaMovieName.UseVisualStyleBackColor = true;
            // 
            // radioBtnSearchViaMovieID
            // 
            this.radioBtnSearchViaMovieID.AutoSize = true;
            this.radioBtnSearchViaMovieID.Location = new System.Drawing.Point(198, 209);
            this.radioBtnSearchViaMovieID.Name = "radioBtnSearchViaMovieID";
            this.radioBtnSearchViaMovieID.Size = new System.Drawing.Size(140, 21);
            this.radioBtnSearchViaMovieID.TabIndex = 50;
            this.radioBtnSearchViaMovieID.Text = "Sök via filmens ID";
            this.radioBtnSearchViaMovieID.UseVisualStyleBackColor = true;
            // 
            // buttonGeneralSearch
            // 
            this.buttonGeneralSearch.Location = new System.Drawing.Point(12, 298);
            this.buttonGeneralSearch.Name = "buttonGeneralSearch";
            this.buttonGeneralSearch.Size = new System.Drawing.Size(358, 30);
            this.buttonGeneralSearch.TabIndex = 49;
            this.buttonGeneralSearch.Text = "Sök";
            this.buttonGeneralSearch.UseVisualStyleBackColor = true;
            // 
            // btnShowAllCustomers
            // 
            this.btnShowAllCustomers.Location = new System.Drawing.Point(12, 334);
            this.btnShowAllCustomers.Name = "btnShowAllCustomers";
            this.btnShowAllCustomers.Size = new System.Drawing.Size(172, 30);
            this.btnShowAllCustomers.TabIndex = 52;
            this.btnShowAllCustomers.Text = "Visa alla kunder";
            this.btnShowAllCustomers.UseVisualStyleBackColor = true;
            // 
            // btnShowAllMovies
            // 
            this.btnShowAllMovies.Location = new System.Drawing.Point(198, 334);
            this.btnShowAllMovies.Name = "btnShowAllMovies";
            this.btnShowAllMovies.Size = new System.Drawing.Size(172, 30);
            this.btnShowAllMovies.TabIndex = 53;
            this.btnShowAllMovies.Text = "Visa alla filmer";
            this.btnShowAllMovies.UseVisualStyleBackColor = true;
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBooking.Location = new System.Drawing.Point(490, 298);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(183, 30);
            this.btnMakeBooking.TabIndex = 54;
            this.btnMakeBooking.Text = "Boka biljett";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            // 
            // lblInfoPickDateForMovie
            // 
            this.lblInfoPickDateForMovie.AutoSize = true;
            this.lblInfoPickDateForMovie.Location = new System.Drawing.Point(487, 239);
            this.lblInfoPickDateForMovie.Name = "lblInfoPickDateForMovie";
            this.lblInfoPickDateForMovie.Size = new System.Drawing.Size(186, 17);
            this.lblInfoPickDateForMovie.TabIndex = 55;
            this.lblInfoPickDateForMovie.Text = "Välj datum för biljettbokning:";
            // 
            // dateTimePickerForMoive
            // 
            this.dateTimePickerForMoive.Location = new System.Drawing.Point(490, 266);
            this.dateTimePickerForMoive.Name = "dateTimePickerForMoive";
            this.dateTimePickerForMoive.Size = new System.Drawing.Size(183, 22);
            this.dateTimePickerForMoive.TabIndex = 56;
            // 
            // lblFeedbackBooking
            // 
            this.lblFeedbackBooking.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackBooking.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackBooking.Location = new System.Drawing.Point(679, 239);
            this.lblFeedbackBooking.Name = "lblFeedbackBooking";
            this.lblFeedbackBooking.Size = new System.Drawing.Size(491, 49);
            this.lblFeedbackBooking.TabIndex = 57;
            this.lblFeedbackBooking.Text = "Temp feedback text movie name";
            // 
            // lblFeedbackGeneralSearch
            // 
            this.lblFeedbackGeneralSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackGeneralSearch.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackGeneralSearch.Location = new System.Drawing.Point(8, 271);
            this.lblFeedbackGeneralSearch.Name = "lblFeedbackGeneralSearch";
            this.lblFeedbackGeneralSearch.Size = new System.Drawing.Size(481, 22);
            this.lblFeedbackGeneralSearch.TabIndex = 58;
            this.lblFeedbackGeneralSearch.Text = "Temp feedback text movie name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 30);
            this.button1.TabIndex = 59;
            this.button1.Text = "Visa kundens bokningar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 30);
            this.button2.TabIndex = 60;
            this.button2.Text = "Visa filmens bokningar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(490, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 30);
            this.button3.TabIndex = 61;
            this.button3.Text = "Visa alla bokningar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Programkonstruktion_Assignment1_BookingHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFeedbackGeneralSearch);
            this.Controls.Add(this.lblFeedbackBooking);
            this.Controls.Add(this.dateTimePickerForMoive);
            this.Controls.Add(this.lblInfoPickDateForMovie);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.btnShowAllMovies);
            this.Controls.Add(this.btnShowAllCustomers);
            this.Controls.Add(this.radioBtnSearchViaMovieName);
            this.Controls.Add(this.radioBtnSearchViaMovieID);
            this.Controls.Add(this.buttonGeneralSearch);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.radioBtnSearchViaCustomerName);
            this.Controls.Add(this.radioBtnSearchViaCustomerID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblFeedbackEventPerformed);
            this.Controls.Add(this.lblFeedbackMovieName);
            this.Controls.Add(this.lblFeedbackMovieID);
            this.Controls.Add(this.lblFeedBackCustomerName);
            this.Controls.Add(this.lblFeedbackCustomerID);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnBack);
            this.Name = "Programkonstruktion_Assignment1_BookingHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programkonstruktion uppgift 1 - Bokningshantering";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton radioBtnSearchViaCustomerName;
        private System.Windows.Forms.RadioButton radioBtnSearchViaCustomerID;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblFeedbackEventPerformed;
        private System.Windows.Forms.Label lblFeedbackMovieName;
        private System.Windows.Forms.Label lblFeedbackMovieID;
        private System.Windows.Forms.Label lblFeedBackCustomerName;
        private System.Windows.Forms.Label lblFeedbackCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radioBtnSearchViaMovieName;
        private System.Windows.Forms.RadioButton radioBtnSearchViaMovieID;
        private System.Windows.Forms.Button buttonGeneralSearch;
        private System.Windows.Forms.Button btnShowAllCustomers;
        private System.Windows.Forms.Button btnShowAllMovies;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label lblInfoPickDateForMovie;
        private System.Windows.Forms.DateTimePicker dateTimePickerForMoive;
        private System.Windows.Forms.Label lblFeedbackBooking;
        private System.Windows.Forms.Label lblFeedbackGeneralSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}