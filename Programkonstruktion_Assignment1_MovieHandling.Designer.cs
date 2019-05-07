namespace SYSA14_Biljettbokning
{
    partial class Programkonstruktion_Assignment1_MovieHandling
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearchForAMovie = new System.Windows.Forms.Button();
            this.btnSearchForAllMovies = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUppdateMovieInfo = new System.Windows.Forms.Button();
            this.btnRegisterOfMovie = new System.Windows.Forms.Button();
            this.lblFeedbackEventPerformed = new System.Windows.Forms.Label();
            this.lblFeedbackMovieDuration = new System.Windows.Forms.Label();
            this.lblFeedBackMovieName = new System.Windows.Forms.Label();
            this.lblFeedbackMovieID = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.lblMovieType = new System.Windows.Forms.Label();
            this.lblMovieDuration = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieSeatCapacity = new System.Windows.Forms.Label();
            this.movieDateStop = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.radioBtnMovieName = new System.Windows.Forms.RadioButton();
            this.radioBtnMovieID = new System.Windows.Forms.RadioButton();
            this.lblSearchForMovie = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFeedbackGenre = new System.Windows.Forms.Label();
            this.lblFeedbackMovieSeatCapacity = new System.Windows.Forms.Label();
            this.lblFeedbackMovieDateStart = new System.Windows.Forms.Label();
            this.lblFeedbackMovieDateStop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Tillbaka";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 486);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1158, 254);
            this.dataGridView.TabIndex = 42;
            // 
            // btnSearchForAMovie
            // 
            this.btnSearchForAMovie.Location = new System.Drawing.Point(322, 386);
            this.btnSearchForAMovie.Name = "btnSearchForAMovie";
            this.btnSearchForAMovie.Size = new System.Drawing.Size(162, 38);
            this.btnSearchForAMovie.TabIndex = 41;
            this.btnSearchForAMovie.Text = "Sök";
            this.btnSearchForAMovie.UseVisualStyleBackColor = true;
            // 
            // btnSearchForAllMovies
            // 
            this.btnSearchForAllMovies.Location = new System.Drawing.Point(150, 332);
            this.btnSearchForAllMovies.Name = "btnSearchForAllMovies";
            this.btnSearchForAllMovies.Size = new System.Drawing.Size(132, 34);
            this.btnSearchForAllMovies.TabIndex = 40;
            this.btnSearchForAllMovies.Text = "Visa alla filmer";
            this.btnSearchForAllMovies.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(150, 372);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(132, 52);
            this.btnDeleteMovie.TabIndex = 39;
            this.btnDeleteMovie.Text = "Borttagning av film";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnUppdateMovieInfo
            // 
            this.btnUppdateMovieInfo.Location = new System.Drawing.Point(12, 372);
            this.btnUppdateMovieInfo.Name = "btnUppdateMovieInfo";
            this.btnUppdateMovieInfo.Size = new System.Drawing.Size(132, 52);
            this.btnUppdateMovieInfo.TabIndex = 38;
            this.btnUppdateMovieInfo.Text = "Uppdatera filminformation";
            this.btnUppdateMovieInfo.UseVisualStyleBackColor = true;
            // 
            // btnRegisterOfMovie
            // 
            this.btnRegisterOfMovie.Location = new System.Drawing.Point(12, 332);
            this.btnRegisterOfMovie.Name = "btnRegisterOfMovie";
            this.btnRegisterOfMovie.Size = new System.Drawing.Size(132, 34);
            this.btnRegisterOfMovie.TabIndex = 37;
            this.btnRegisterOfMovie.Text = "Registrera ny film";
            this.btnRegisterOfMovie.UseVisualStyleBackColor = true;
            // 
            // lblFeedbackEventPerformed
            // 
            this.lblFeedbackEventPerformed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackEventPerformed.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblFeedbackEventPerformed.Location = new System.Drawing.Point(8, 461);
            this.lblFeedbackEventPerformed.Name = "lblFeedbackEventPerformed";
            this.lblFeedbackEventPerformed.Size = new System.Drawing.Size(1159, 22);
            this.lblFeedbackEventPerformed.TabIndex = 36;
            this.lblFeedbackEventPerformed.Text = "Temp feedback text Event Performed";
            // 
            // lblFeedbackMovieDuration
            // 
            this.lblFeedbackMovieDuration.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieDuration.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieDuration.Location = new System.Drawing.Point(503, 125);
            this.lblFeedbackMovieDuration.Name = "lblFeedbackMovieDuration";
            this.lblFeedbackMovieDuration.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieDuration.TabIndex = 34;
            this.lblFeedbackMovieDuration.Text = "Temp feedback text address";
            // 
            // lblFeedBackMovieName
            // 
            this.lblFeedBackMovieName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBackMovieName.ForeColor = System.Drawing.Color.Red;
            this.lblFeedBackMovieName.Location = new System.Drawing.Point(503, 97);
            this.lblFeedBackMovieName.Name = "lblFeedBackMovieName";
            this.lblFeedBackMovieName.Size = new System.Drawing.Size(672, 22);
            this.lblFeedBackMovieName.TabIndex = 33;
            this.lblFeedBackMovieName.Text = "Temp feedback text name";
            // 
            // lblFeedbackMovieID
            // 
            this.lblFeedbackMovieID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieID.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieID.Location = new System.Drawing.Point(503, 69);
            this.lblFeedbackMovieID.Name = "lblFeedbackMovieID";
            this.lblFeedbackMovieID.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieID.TabIndex = 24;
            this.lblFeedbackMovieID.Text = "Temp feedback text ID";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(202, 97);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerName.TabIndex = 32;
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(202, 125);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerAddress.TabIndex = 31;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(202, 69);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(282, 22);
            this.textBoxCustomerID.TabIndex = 29;
            // 
            // lblMovieType
            // 
            this.lblMovieType.AutoSize = true;
            this.lblMovieType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieType.Location = new System.Drawing.Point(14, 155);
            this.lblMovieType.Name = "lblMovieType";
            this.lblMovieType.Size = new System.Drawing.Size(66, 22);
            this.lblMovieType.TabIndex = 28;
            this.lblMovieType.Text = "Genre:";
            // 
            // lblMovieDuration
            // 
            this.lblMovieDuration.AutoSize = true;
            this.lblMovieDuration.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDuration.Location = new System.Drawing.Point(12, 125);
            this.lblMovieDuration.Name = "lblMovieDuration";
            this.lblMovieDuration.Size = new System.Drawing.Size(176, 22);
            this.lblMovieDuration.TabIndex = 27;
            this.lblMovieDuration.Text = "Filmens längd (min):";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(13, 97);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(129, 22);
            this.lblMovieName.TabIndex = 26;
            this.lblMovieName.Text = "Filmens namn:";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(14, 69);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(105, 22);
            this.lblMovieID.TabIndex = 25;
            this.lblMovieID.Text = "Filmens ID:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(14, 213);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(108, 22);
            this.lblMovieStartDate.TabIndex = 43;
            this.lblMovieStartDate.Text = "Biopremiär:";
            // 
            // lblMovieSeatCapacity
            // 
            this.lblMovieSeatCapacity.AutoSize = true;
            this.lblMovieSeatCapacity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieSeatCapacity.Location = new System.Drawing.Point(12, 185);
            this.lblMovieSeatCapacity.Name = "lblMovieSeatCapacity";
            this.lblMovieSeatCapacity.Size = new System.Drawing.Size(120, 22);
            this.lblMovieSeatCapacity.TabIndex = 45;
            this.lblMovieSeatCapacity.Text = "Antal platser:";
            // 
            // movieDateStop
            // 
            this.movieDateStop.AutoSize = true;
            this.movieDateStop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDateStop.Location = new System.Drawing.Point(12, 243);
            this.movieDateStop.Name = "movieDateStop";
            this.movieDateStop.Size = new System.Drawing.Size(127, 22);
            this.movieDateStop.TabIndex = 47;
            this.movieDateStop.Text = "Sista spelning:";
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Crime",
            "Drama (Default)",
            "Sci-fi",
            "Thriller"});
            this.comboBox1.Location = new System.Drawing.Point(202, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 49;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "150",
            "200",
            "250",
            "300"});
            this.comboBox2.Location = new System.Drawing.Point(202, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 24);
            this.comboBox2.TabIndex = 50;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 22);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(202, 243);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(282, 22);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // radioBtnMovieName
            // 
            this.radioBtnMovieName.AutoSize = true;
            this.radioBtnMovieName.Location = new System.Drawing.Point(322, 359);
            this.radioBtnMovieName.Name = "radioBtnMovieName";
            this.radioBtnMovieName.Size = new System.Drawing.Size(162, 21);
            this.radioBtnMovieName.TabIndex = 54;
            this.radioBtnMovieName.Text = "Sök via filmens namn";
            this.radioBtnMovieName.UseVisualStyleBackColor = true;
            // 
            // radioBtnMovieID
            // 
            this.radioBtnMovieID.AutoSize = true;
            this.radioBtnMovieID.Checked = true;
            this.radioBtnMovieID.Location = new System.Drawing.Point(322, 332);
            this.radioBtnMovieID.Name = "radioBtnMovieID";
            this.radioBtnMovieID.Size = new System.Drawing.Size(140, 21);
            this.radioBtnMovieID.TabIndex = 55;
            this.radioBtnMovieID.TabStop = true;
            this.radioBtnMovieID.Text = "Sök via filmens ID";
            this.radioBtnMovieID.UseVisualStyleBackColor = true;
            // 
            // lblSearchForMovie
            // 
            this.lblSearchForMovie.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchForMovie.ForeColor = System.Drawing.Color.Red;
            this.lblSearchForMovie.Location = new System.Drawing.Point(503, 344);
            this.lblSearchForMovie.Name = "lblSearchForMovie";
            this.lblSearchForMovie.Size = new System.Drawing.Size(667, 22);
            this.lblSearchForMovie.TabIndex = 56;
            this.lblSearchForMovie.Text = "Temp feedback search";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(501, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(188, 32);
            this.lblInfo.TabIndex = 57;
            this.lblInfo.Text = "Filmhantering";
            // 
            // lblFeedbackGenre
            // 
            this.lblFeedbackGenre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackGenre.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackGenre.Location = new System.Drawing.Point(503, 155);
            this.lblFeedbackGenre.Name = "lblFeedbackGenre";
            this.lblFeedbackGenre.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackGenre.TabIndex = 58;
            this.lblFeedbackGenre.Text = "Temp feedback text genre";
            // 
            // lblFeedbackMovieSeatCapacity
            // 
            this.lblFeedbackMovieSeatCapacity.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieSeatCapacity.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieSeatCapacity.Location = new System.Drawing.Point(503, 185);
            this.lblFeedbackMovieSeatCapacity.Name = "lblFeedbackMovieSeatCapacity";
            this.lblFeedbackMovieSeatCapacity.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieSeatCapacity.TabIndex = 59;
            this.lblFeedbackMovieSeatCapacity.Text = "Temp feedback text antal platser";
            // 
            // lblFeedbackMovieDateStart
            // 
            this.lblFeedbackMovieDateStart.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieDateStart.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieDateStart.Location = new System.Drawing.Point(503, 215);
            this.lblFeedbackMovieDateStart.Name = "lblFeedbackMovieDateStart";
            this.lblFeedbackMovieDateStart.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieDateStart.TabIndex = 60;
            this.lblFeedbackMovieDateStart.Text = "Temp feedback text Premiär";
            // 
            // lblFeedbackMovieDateStop
            // 
            this.lblFeedbackMovieDateStop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackMovieDateStop.ForeColor = System.Drawing.Color.Red;
            this.lblFeedbackMovieDateStop.Location = new System.Drawing.Point(503, 243);
            this.lblFeedbackMovieDateStop.Name = "lblFeedbackMovieDateStop";
            this.lblFeedbackMovieDateStop.Size = new System.Drawing.Size(672, 22);
            this.lblFeedbackMovieDateStop.TabIndex = 61;
            this.lblFeedbackMovieDateStop.Text = "Temp feedback text sista spelning";
            // 
            // Programkonstruktion_Assignment1_MovieHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lblFeedbackMovieDateStop);
            this.Controls.Add(this.lblFeedbackMovieDateStart);
            this.Controls.Add(this.lblFeedbackMovieSeatCapacity);
            this.Controls.Add(this.lblFeedbackGenre);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSearchForMovie);
            this.Controls.Add(this.radioBtnMovieID);
            this.Controls.Add(this.radioBtnMovieName);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.movieDateStop);
            this.Controls.Add(this.lblMovieSeatCapacity);
            this.Controls.Add(this.lblMovieStartDate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSearchForAMovie);
            this.Controls.Add(this.btnSearchForAllMovies);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUppdateMovieInfo);
            this.Controls.Add(this.btnRegisterOfMovie);
            this.Controls.Add(this.lblFeedbackEventPerformed);
            this.Controls.Add(this.lblFeedbackMovieDuration);
            this.Controls.Add(this.lblFeedBackMovieName);
            this.Controls.Add(this.lblFeedbackMovieID);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.lblMovieType);
            this.Controls.Add(this.lblMovieDuration);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.btnBack);
            this.Name = "Programkonstruktion_Assignment1_MovieHandling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programkonstruktion uppgift 1 - Filmhantering";
            this.Load += new System.EventHandler(this.Programkonstruktion_Assignment1_MovieHandling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSearchForAMovie;
        private System.Windows.Forms.Button btnSearchForAllMovies;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUppdateMovieInfo;
        private System.Windows.Forms.Button btnRegisterOfMovie;
        private System.Windows.Forms.Label lblFeedbackEventPerformed;
        private System.Windows.Forms.Label lblFeedbackMovieDuration;
        private System.Windows.Forms.Label lblFeedBackMovieName;
        private System.Windows.Forms.Label lblFeedbackMovieID;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label lblMovieType;
        private System.Windows.Forms.Label lblMovieDuration;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieSeatCapacity;
        private System.Windows.Forms.Label movieDateStop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioBtnMovieName;
        private System.Windows.Forms.RadioButton radioBtnMovieID;
        private System.Windows.Forms.Label lblSearchForMovie;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFeedbackGenre;
        private System.Windows.Forms.Label lblFeedbackMovieSeatCapacity;
        private System.Windows.Forms.Label lblFeedbackMovieDateStart;
        private System.Windows.Forms.Label lblFeedbackMovieDateStop;
    }
}