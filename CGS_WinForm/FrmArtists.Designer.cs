namespace CGS_WinForm
{
    partial class FrmArtists
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
            this.btnArtistView = new System.Windows.Forms.Button();
            this.btnArtistSave = new System.Windows.Forms.Button();
            this.btnArtistAdd = new System.Windows.Forms.Button();
            this.rtbArtists = new System.Windows.Forms.RichTextBox();
            this.txtArtID = new System.Windows.Forms.TextBox();
            this.txtArtLName = new System.Windows.Forms.TextBox();
            this.txtArtFName = new System.Windows.Forms.TextBox();
            this.lblArtID = new System.Windows.Forms.Label();
            this.lblArtLName = new System.Windows.Forms.Label();
            this.lblArtFName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArtistView
            // 
            this.btnArtistView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnArtistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnArtistView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnArtistView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtistView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtistView.Location = new System.Drawing.Point(12, 409);
            this.btnArtistView.Name = "btnArtistView";
            this.btnArtistView.Size = new System.Drawing.Size(115, 26);
            this.btnArtistView.TabIndex = 19;
            this.btnArtistView.Text = "View Artists";
            this.btnArtistView.UseVisualStyleBackColor = false;
            // 
            // btnArtistSave
            // 
            this.btnArtistSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnArtistSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnArtistSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtistSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtistSave.Location = new System.Drawing.Point(180, 280);
            this.btnArtistSave.Name = "btnArtistSave";
            this.btnArtistSave.Size = new System.Drawing.Size(115, 26);
            this.btnArtistSave.TabIndex = 18;
            this.btnArtistSave.Text = "Save Curator";
            this.btnArtistSave.UseVisualStyleBackColor = false;
            // 
            // btnArtistAdd
            // 
            this.btnArtistAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnArtistAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnArtistAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtistAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtistAdd.Location = new System.Drawing.Point(180, 238);
            this.btnArtistAdd.Name = "btnArtistAdd";
            this.btnArtistAdd.Size = new System.Drawing.Size(115, 26);
            this.btnArtistAdd.TabIndex = 17;
            this.btnArtistAdd.Text = "Add Curator";
            this.btnArtistAdd.UseVisualStyleBackColor = false;
            // 
            // rtbArtists
            // 
            this.rtbArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.rtbArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbArtists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbArtists.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbArtists.ForeColor = System.Drawing.Color.LightGray;
            this.rtbArtists.Location = new System.Drawing.Point(0, 441);
            this.rtbArtists.Name = "rtbArtists";
            this.rtbArtists.Size = new System.Drawing.Size(725, 194);
            this.rtbArtists.TabIndex = 16;
            this.rtbArtists.Text = "";
            // 
            // txtArtID
            // 
            this.txtArtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArtID.Location = new System.Drawing.Point(180, 187);
            this.txtArtID.MaxLength = 5;
            this.txtArtID.Name = "txtArtID";
            this.txtArtID.Size = new System.Drawing.Size(155, 26);
            this.txtArtID.TabIndex = 15;
            // 
            // txtArtLName
            // 
            this.txtArtLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtLName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtLName.Location = new System.Drawing.Point(180, 130);
            this.txtArtLName.Name = "txtArtLName";
            this.txtArtLName.Size = new System.Drawing.Size(155, 26);
            this.txtArtLName.TabIndex = 14;
            // 
            // txtArtFName
            // 
            this.txtArtFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtFName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtFName.Location = new System.Drawing.Point(180, 74);
            this.txtArtFName.Name = "txtArtFName";
            this.txtArtFName.Size = new System.Drawing.Size(155, 26);
            this.txtArtFName.TabIndex = 13;
            // 
            // lblArtID
            // 
            this.lblArtID.AutoSize = true;
            this.lblArtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtID.Location = new System.Drawing.Point(57, 189);
            this.lblArtID.Name = "lblArtID";
            this.lblArtID.Size = new System.Drawing.Size(64, 20);
            this.lblArtID.TabIndex = 12;
            this.lblArtID.Text = "Artist ID";
            // 
            // lblArtLName
            // 
            this.lblArtLName.AutoSize = true;
            this.lblArtLName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtLName.Location = new System.Drawing.Point(57, 133);
            this.lblArtLName.Name = "lblArtLName";
            this.lblArtLName.Size = new System.Drawing.Size(83, 20);
            this.lblArtLName.TabIndex = 11;
            this.lblArtLName.Text = "Last name";
            // 
            // lblArtFName
            // 
            this.lblArtFName.AutoSize = true;
            this.lblArtFName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtFName.Location = new System.Drawing.Point(57, 77);
            this.lblArtFName.Name = "lblArtFName";
            this.lblArtFName.Size = new System.Drawing.Size(81, 20);
            this.lblArtFName.TabIndex = 10;
            this.lblArtFName.Text = "First name";
            // 
            // FrmArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(725, 635);
            this.Controls.Add(this.btnArtistView);
            this.Controls.Add(this.btnArtistSave);
            this.Controls.Add(this.btnArtistAdd);
            this.Controls.Add(this.rtbArtists);
            this.Controls.Add(this.txtArtID);
            this.Controls.Add(this.txtArtLName);
            this.Controls.Add(this.txtArtFName);
            this.Controls.Add(this.lblArtID);
            this.Controls.Add(this.lblArtLName);
            this.Controls.Add(this.lblArtFName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmArtists";
            this.Text = "FrmArtists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArtistView;
        private System.Windows.Forms.Button btnArtistSave;
        private System.Windows.Forms.Button btnArtistAdd;
        private System.Windows.Forms.RichTextBox rtbArtists;
        private System.Windows.Forms.TextBox txtArtID;
        private System.Windows.Forms.TextBox txtArtLName;
        private System.Windows.Forms.TextBox txtArtFName;
        private System.Windows.Forms.Label lblArtID;
        private System.Windows.Forms.Label lblArtLName;
        private System.Windows.Forms.Label lblArtFName;
    }
}