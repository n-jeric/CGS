﻿namespace CGS_WinForm
{
    partial class FrmCurators
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
            this.lblCurFName = new System.Windows.Forms.Label();
            this.lblCurLName = new System.Windows.Forms.Label();
            this.lblCurID = new System.Windows.Forms.Label();
            this.txtCurFName = new System.Windows.Forms.TextBox();
            this.txtCurLName = new System.Windows.Forms.TextBox();
            this.txtCurID = new System.Windows.Forms.TextBox();
            this.rtbCurators = new System.Windows.Forms.RichTextBox();
            this.btnCurAdd = new System.Windows.Forms.Button();
            this.btnCurSave = new System.Windows.Forms.Button();
            this.btnCurView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurFName
            // 
            this.lblCurFName.AutoSize = true;
            this.lblCurFName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurFName.Location = new System.Drawing.Point(57, 77);
            this.lblCurFName.Name = "lblCurFName";
            this.lblCurFName.Size = new System.Drawing.Size(81, 20);
            this.lblCurFName.TabIndex = 0;
            this.lblCurFName.Text = "First name";
            // 
            // lblCurLName
            // 
            this.lblCurLName.AutoSize = true;
            this.lblCurLName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurLName.Location = new System.Drawing.Point(57, 133);
            this.lblCurLName.Name = "lblCurLName";
            this.lblCurLName.Size = new System.Drawing.Size(83, 20);
            this.lblCurLName.TabIndex = 1;
            this.lblCurLName.Text = "Last name";
            // 
            // lblCurID
            // 
            this.lblCurID.AutoSize = true;
            this.lblCurID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurID.Location = new System.Drawing.Point(57, 189);
            this.lblCurID.Name = "lblCurID";
            this.lblCurID.Size = new System.Drawing.Size(85, 20);
            this.lblCurID.TabIndex = 2;
            this.lblCurID.Text = "Curator ID";
            // 
            // txtCurFName
            // 
            this.txtCurFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtCurFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurFName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurFName.Location = new System.Drawing.Point(180, 74);
            this.txtCurFName.Name = "txtCurFName";
            this.txtCurFName.Size = new System.Drawing.Size(155, 26);
            this.txtCurFName.TabIndex = 3;
            // 
            // txtCurLName
            // 
            this.txtCurLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtCurLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurLName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurLName.Location = new System.Drawing.Point(180, 130);
            this.txtCurLName.Name = "txtCurLName";
            this.txtCurLName.Size = new System.Drawing.Size(155, 26);
            this.txtCurLName.TabIndex = 4;
            // 
            // txtCurID
            // 
            this.txtCurID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtCurID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCurID.Location = new System.Drawing.Point(180, 187);
            this.txtCurID.MaxLength = 5;
            this.txtCurID.Name = "txtCurID";
            this.txtCurID.Size = new System.Drawing.Size(155, 26);
            this.txtCurID.TabIndex = 5;
            // 
            // rtbCurators
            // 
            this.rtbCurators.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.rtbCurators.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCurators.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbCurators.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCurators.ForeColor = System.Drawing.Color.LightGray;
            this.rtbCurators.Location = new System.Drawing.Point(0, 441);
            this.rtbCurators.Name = "rtbCurators";
            this.rtbCurators.Size = new System.Drawing.Size(725, 194);
            this.rtbCurators.TabIndex = 6;
            this.rtbCurators.Text = "";
            // 
            // btnCurAdd
            // 
            this.btnCurAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnCurAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCurAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCurAdd.Location = new System.Drawing.Point(180, 238);
            this.btnCurAdd.Name = "btnCurAdd";
            this.btnCurAdd.Size = new System.Drawing.Size(115, 26);
            this.btnCurAdd.TabIndex = 7;
            this.btnCurAdd.Text = "Add Curator";
            this.btnCurAdd.UseVisualStyleBackColor = false;
            // 
            // btnCurSave
            // 
            this.btnCurSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnCurSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCurSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCurSave.Location = new System.Drawing.Point(180, 280);
            this.btnCurSave.Name = "btnCurSave";
            this.btnCurSave.Size = new System.Drawing.Size(115, 26);
            this.btnCurSave.TabIndex = 8;
            this.btnCurSave.Text = "Save Curator";
            this.btnCurSave.UseVisualStyleBackColor = false;
            // 
            // btnCurView
            // 
            this.btnCurView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCurView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnCurView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCurView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCurView.Location = new System.Drawing.Point(12, 409);
            this.btnCurView.Name = "btnCurView";
            this.btnCurView.Size = new System.Drawing.Size(115, 26);
            this.btnCurView.TabIndex = 9;
            this.btnCurView.Text = "View Curators";
            this.btnCurView.UseVisualStyleBackColor = false;
            // 
            // FrmCurators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(725, 635);
            this.Controls.Add(this.btnCurView);
            this.Controls.Add(this.btnCurSave);
            this.Controls.Add(this.btnCurAdd);
            this.Controls.Add(this.rtbCurators);
            this.Controls.Add(this.txtCurID);
            this.Controls.Add(this.txtCurLName);
            this.Controls.Add(this.txtCurFName);
            this.Controls.Add(this.lblCurID);
            this.Controls.Add(this.lblCurLName);
            this.Controls.Add(this.lblCurFName);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCurators";
            this.Text = "FrmCurators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurFName;
        private System.Windows.Forms.Label lblCurLName;
        private System.Windows.Forms.Label lblCurID;
        private System.Windows.Forms.TextBox txtCurFName;
        private System.Windows.Forms.TextBox txtCurLName;
        private System.Windows.Forms.TextBox txtCurID;
        private System.Windows.Forms.RichTextBox rtbCurators;
        private System.Windows.Forms.Button btnCurAdd;
        private System.Windows.Forms.Button btnCurSave;
        private System.Windows.Forms.Button btnCurView;
    }
}