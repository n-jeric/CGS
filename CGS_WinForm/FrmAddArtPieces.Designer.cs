namespace CGS_WinForm
{
    partial class FrmAddArtPieces
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
            this.btnArtPieceView = new System.Windows.Forms.Button();
            this.btnArtPieceAdd = new System.Windows.Forms.Button();
            this.rtbArtPieces = new System.Windows.Forms.RichTextBox();
            this.txtArtPieceYear = new System.Windows.Forms.TextBox();
            this.txtArtPieceTitle = new System.Windows.Forms.TextBox();
            this.txtArtPieceID = new System.Windows.Forms.TextBox();
            this.lblArtPieceYear = new System.Windows.Forms.Label();
            this.lblArtPieceTitle = new System.Windows.Forms.Label();
            this.lblArtPieceID = new System.Windows.Forms.Label();
            this.txtArtPieceValue = new System.Windows.Forms.TextBox();
            this.lblArtPieceValue = new System.Windows.Forms.Label();
            this.txtArtPieceArtID = new System.Windows.Forms.TextBox();
            this.lblArtPieceArtID = new System.Windows.Forms.Label();
            this.txtArtPieceCurID = new System.Windows.Forms.TextBox();
            this.lblArtPieceCurID = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rdBtnStorage = new System.Windows.Forms.RadioButton();
            this.rdBtnDisplay = new System.Windows.Forms.RadioButton();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArtPieceView
            // 
            this.btnArtPieceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArtPieceView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnArtPieceView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnArtPieceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtPieceView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtPieceView.Location = new System.Drawing.Point(582, 370);
            this.btnArtPieceView.Name = "btnArtPieceView";
            this.btnArtPieceView.Size = new System.Drawing.Size(115, 26);
            this.btnArtPieceView.TabIndex = 19;
            this.btnArtPieceView.Text = "View ArtPieces";
            this.btnArtPieceView.UseVisualStyleBackColor = false;
            // 
            // btnArtPieceAdd
            // 
            this.btnArtPieceAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnArtPieceAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnArtPieceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtPieceAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtPieceAdd.Location = new System.Drawing.Point(220, 318);
            this.btnArtPieceAdd.Name = "btnArtPieceAdd";
            this.btnArtPieceAdd.Size = new System.Drawing.Size(115, 26);
            this.btnArtPieceAdd.TabIndex = 17;
            this.btnArtPieceAdd.Text = "Add ArtPiece";
            this.btnArtPieceAdd.UseVisualStyleBackColor = false;
            // 
            // rtbArtPieces
            // 
            this.rtbArtPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.rtbArtPieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbArtPieces.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbArtPieces.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbArtPieces.ForeColor = System.Drawing.Color.LightGray;
            this.rtbArtPieces.Location = new System.Drawing.Point(0, 402);
            this.rtbArtPieces.Name = "rtbArtPieces";
            this.rtbArtPieces.Size = new System.Drawing.Size(709, 194);
            this.rtbArtPieces.TabIndex = 16;
            this.rtbArtPieces.Text = "";
            // 
            // txtArtPieceYear
            // 
            this.txtArtPieceYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceYear.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArtPieceYear.Location = new System.Drawing.Point(180, 147);
            this.txtArtPieceYear.MaxLength = 4;
            this.txtArtPieceYear.Name = "txtArtPieceYear";
            this.txtArtPieceYear.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceYear.TabIndex = 15;
            // 
            // txtArtPieceTitle
            // 
            this.txtArtPieceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceTitle.Location = new System.Drawing.Point(180, 103);
            this.txtArtPieceTitle.Name = "txtArtPieceTitle";
            this.txtArtPieceTitle.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceTitle.TabIndex = 14;
            // 
            // txtArtPieceID
            // 
            this.txtArtPieceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceID.Location = new System.Drawing.Point(180, 59);
            this.txtArtPieceID.MaxLength = 5;
            this.txtArtPieceID.Name = "txtArtPieceID";
            this.txtArtPieceID.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceID.TabIndex = 13;
            // 
            // lblArtPieceYear
            // 
            this.lblArtPieceYear.AutoSize = true;
            this.lblArtPieceYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPieceYear.Location = new System.Drawing.Point(57, 143);
            this.lblArtPieceYear.Name = "lblArtPieceYear";
            this.lblArtPieceYear.Size = new System.Drawing.Size(41, 20);
            this.lblArtPieceYear.TabIndex = 12;
            this.lblArtPieceYear.Text = "Year";
            // 
            // lblArtPieceTitle
            // 
            this.lblArtPieceTitle.AutoSize = true;
            this.lblArtPieceTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPieceTitle.Location = new System.Drawing.Point(57, 105);
            this.lblArtPieceTitle.Name = "lblArtPieceTitle";
            this.lblArtPieceTitle.Size = new System.Drawing.Size(35, 20);
            this.lblArtPieceTitle.TabIndex = 11;
            this.lblArtPieceTitle.Text = "Title";
            // 
            // lblArtPieceID
            // 
            this.lblArtPieceID.AutoSize = true;
            this.lblArtPieceID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPieceID.Location = new System.Drawing.Point(57, 62);
            this.lblArtPieceID.Name = "lblArtPieceID";
            this.lblArtPieceID.Size = new System.Drawing.Size(92, 20);
            this.lblArtPieceID.TabIndex = 10;
            this.lblArtPieceID.Text = "ArtPiece ID";
            // 
            // txtArtPieceValue
            // 
            this.txtArtPieceValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArtPieceValue.Location = new System.Drawing.Point(180, 191);
            this.txtArtPieceValue.Name = "txtArtPieceValue";
            this.txtArtPieceValue.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceValue.TabIndex = 21;
            // 
            // lblArtPieceValue
            // 
            this.lblArtPieceValue.AutoSize = true;
            this.lblArtPieceValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPieceValue.Location = new System.Drawing.Point(57, 193);
            this.lblArtPieceValue.Name = "lblArtPieceValue";
            this.lblArtPieceValue.Size = new System.Drawing.Size(52, 20);
            this.lblArtPieceValue.TabIndex = 20;
            this.lblArtPieceValue.Text = "Value";
            // 
            // txtArtPieceArtID
            // 
            this.txtArtPieceArtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceArtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceArtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceArtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArtPieceArtID.Location = new System.Drawing.Point(180, 235);
            this.txtArtPieceArtID.MaxLength = 5;
            this.txtArtPieceArtID.Name = "txtArtPieceArtID";
            this.txtArtPieceArtID.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceArtID.TabIndex = 23;
            // 
            // lblArtPieceArtID
            // 
            this.lblArtPieceArtID.AutoSize = true;
            this.lblArtPieceArtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPieceArtID.Location = new System.Drawing.Point(57, 237);
            this.lblArtPieceArtID.Name = "lblArtPieceArtID";
            this.lblArtPieceArtID.Size = new System.Drawing.Size(64, 20);
            this.lblArtPieceArtID.TabIndex = 22;
            this.lblArtPieceArtID.Text = "Artist ID";
            // 
            // txtArtPieceCurID
            // 
            this.txtArtPieceCurID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceCurID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceCurID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceCurID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArtPieceCurID.Location = new System.Drawing.Point(180, 279);
            this.txtArtPieceCurID.MaxLength = 5;
            this.txtArtPieceCurID.Name = "txtArtPieceCurID";
            this.txtArtPieceCurID.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceCurID.TabIndex = 25;
            // 
            // lblArtPieceCurID
            // 
            this.lblArtPieceCurID.AutoSize = true;
            this.lblArtPieceCurID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPieceCurID.Location = new System.Drawing.Point(57, 281);
            this.lblArtPieceCurID.Name = "lblArtPieceCurID";
            this.lblArtPieceCurID.Size = new System.Drawing.Size(85, 20);
            this.lblArtPieceCurID.TabIndex = 24;
            this.lblArtPieceCurID.Text = "Curator ID";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rdBtnStorage);
            this.gbStatus.Controls.Add(this.rdBtnDisplay);
            this.gbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbStatus.Location = new System.Drawing.Point(413, 59);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 100);
            this.gbStatus.TabIndex = 26;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rdBtnStorage
            // 
            this.rdBtnStorage.AutoSize = true;
            this.rdBtnStorage.Location = new System.Drawing.Point(18, 57);
            this.rdBtnStorage.Name = "rdBtnStorage";
            this.rdBtnStorage.Size = new System.Drawing.Size(109, 25);
            this.rdBtnStorage.TabIndex = 1;
            this.rdBtnStorage.TabStop = true;
            this.rdBtnStorage.Tag = "S";
            this.rdBtnStorage.Text = "In Storage";
            this.rdBtnStorage.UseVisualStyleBackColor = true;
            // 
            // rdBtnDisplay
            // 
            this.rdBtnDisplay.AutoSize = true;
            this.rdBtnDisplay.Location = new System.Drawing.Point(18, 27);
            this.rdBtnDisplay.Name = "rdBtnDisplay";
            this.rdBtnDisplay.Size = new System.Drawing.Size(110, 25);
            this.rdBtnDisplay.TabIndex = 0;
            this.rdBtnDisplay.TabStop = true;
            this.rdBtnDisplay.Tag = "D";
            this.rdBtnDisplay.Text = "On Display";
            this.rdBtnDisplay.UseVisualStyleBackColor = true;
            // 
            // FrmAddArtPieces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(709, 596);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.txtArtPieceCurID);
            this.Controls.Add(this.lblArtPieceCurID);
            this.Controls.Add(this.txtArtPieceArtID);
            this.Controls.Add(this.lblArtPieceArtID);
            this.Controls.Add(this.txtArtPieceValue);
            this.Controls.Add(this.lblArtPieceValue);
            this.Controls.Add(this.btnArtPieceView);
            this.Controls.Add(this.btnArtPieceAdd);
            this.Controls.Add(this.rtbArtPieces);
            this.Controls.Add(this.txtArtPieceYear);
            this.Controls.Add(this.txtArtPieceTitle);
            this.Controls.Add(this.txtArtPieceID);
            this.Controls.Add(this.lblArtPieceYear);
            this.Controls.Add(this.lblArtPieceTitle);
            this.Controls.Add(this.lblArtPieceID);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddArtPieces";
            this.Text = "FrmAddArtPieces";
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArtPieceView;
        private System.Windows.Forms.Button btnArtPieceAdd;
        private System.Windows.Forms.RichTextBox rtbArtPieces;
        private System.Windows.Forms.TextBox txtArtPieceYear;
        private System.Windows.Forms.TextBox txtArtPieceTitle;
        private System.Windows.Forms.TextBox txtArtPieceID;
        private System.Windows.Forms.Label lblArtPieceYear;
        private System.Windows.Forms.Label lblArtPieceTitle;
        private System.Windows.Forms.Label lblArtPieceID;
        private System.Windows.Forms.TextBox txtArtPieceValue;
        private System.Windows.Forms.Label lblArtPieceValue;
        private System.Windows.Forms.TextBox txtArtPieceArtID;
        private System.Windows.Forms.Label lblArtPieceArtID;
        private System.Windows.Forms.TextBox txtArtPieceCurID;
        private System.Windows.Forms.Label lblArtPieceCurID;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rdBtnStorage;
        private System.Windows.Forms.RadioButton rdBtnDisplay;
    }
}