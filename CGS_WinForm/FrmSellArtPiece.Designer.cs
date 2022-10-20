namespace CGS_WinForm
{
    partial class FrmSellArtPiece
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSellArtPieceID = new System.Windows.Forms.TextBox();
            this.lblSellArtPieceID = new System.Windows.Forms.Label();
            this.btnSellArtPieceView = new System.Windows.Forms.Button();
            this.btnSellArtPiece = new System.Windows.Forms.Button();
            this.txtArtPieceEstimate = new System.Windows.Forms.TextBox();
            this.lblSellArtpieceEstimate = new System.Windows.Forms.Label();
            this.dataGridViewSellAP = new System.Windows.Forms.DataGridView();
            this.btnArtPiecesForSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellAP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSellArtPieceID
            // 
            this.txtSellArtPieceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtSellArtPieceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellArtPieceID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellArtPieceID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSellArtPieceID.Location = new System.Drawing.Point(180, 59);
            this.txtSellArtPieceID.MaxLength = 5;
            this.txtSellArtPieceID.Name = "txtSellArtPieceID";
            this.txtSellArtPieceID.Size = new System.Drawing.Size(155, 26);
            this.txtSellArtPieceID.TabIndex = 1;
            // 
            // lblSellArtPieceID
            // 
            this.lblSellArtPieceID.AutoSize = true;
            this.lblSellArtPieceID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellArtPieceID.Location = new System.Drawing.Point(57, 62);
            this.lblSellArtPieceID.Name = "lblSellArtPieceID";
            this.lblSellArtPieceID.Size = new System.Drawing.Size(92, 20);
            this.lblSellArtPieceID.TabIndex = 0;
            this.lblSellArtPieceID.Text = "ArtPiece ID";
            // 
            // btnSellArtPieceView
            // 
            this.btnSellArtPieceView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSellArtPieceView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnSellArtPieceView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSellArtPieceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellArtPieceView.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSellArtPieceView.Location = new System.Drawing.Point(220, 104);
            this.btnSellArtPieceView.Name = "btnSellArtPieceView";
            this.btnSellArtPieceView.Size = new System.Drawing.Size(115, 26);
            this.btnSellArtPieceView.TabIndex = 2;
            this.btnSellArtPieceView.Text = "View ArtPiece";
            this.btnSellArtPieceView.UseVisualStyleBackColor = false;
            this.btnSellArtPieceView.Click += new System.EventHandler(this.btnSellArtPieceView_Click);
            // 
            // btnSellArtPiece
            // 
            this.btnSellArtPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnSellArtPiece.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSellArtPiece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellArtPiece.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSellArtPiece.Location = new System.Drawing.Point(220, 245);
            this.btnSellArtPiece.Name = "btnSellArtPiece";
            this.btnSellArtPiece.Size = new System.Drawing.Size(115, 26);
            this.btnSellArtPiece.TabIndex = 5;
            this.btnSellArtPiece.Text = "Sell ArtPiece";
            this.btnSellArtPiece.UseVisualStyleBackColor = false;
            this.btnSellArtPiece.Click += new System.EventHandler(this.btnSellArtPiece_Click);
            // 
            // txtArtPieceEstimate
            // 
            this.txtArtPieceEstimate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txtArtPieceEstimate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtPieceEstimate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtPieceEstimate.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArtPieceEstimate.Location = new System.Drawing.Point(180, 203);
            this.txtArtPieceEstimate.MaxLength = 5;
            this.txtArtPieceEstimate.Name = "txtArtPieceEstimate";
            this.txtArtPieceEstimate.Size = new System.Drawing.Size(155, 26);
            this.txtArtPieceEstimate.TabIndex = 4;
            // 
            // lblSellArtpieceEstimate
            // 
            this.lblSellArtpieceEstimate.AutoSize = true;
            this.lblSellArtpieceEstimate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellArtpieceEstimate.Location = new System.Drawing.Point(57, 206);
            this.lblSellArtpieceEstimate.Name = "lblSellArtpieceEstimate";
            this.lblSellArtpieceEstimate.Size = new System.Drawing.Size(69, 20);
            this.lblSellArtpieceEstimate.TabIndex = 3;
            this.lblSellArtpieceEstimate.Text = "Estimate";
            // 
            // dataGridViewSellAP
            // 
            this.dataGridViewSellAP.AllowUserToAddRows = false;
            this.dataGridViewSellAP.AllowUserToDeleteRows = false;
            this.dataGridViewSellAP.AllowUserToResizeRows = false;
            this.dataGridViewSellAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSellAP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.dataGridViewSellAP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSellAP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSellAP.ColumnHeadersHeight = 30;
            this.dataGridViewSellAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSellAP.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSellAP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSellAP.EnableHeadersVisualStyles = false;
            this.dataGridViewSellAP.Location = new System.Drawing.Point(0, 402);
            this.dataGridViewSellAP.Name = "dataGridViewSellAP";
            this.dataGridViewSellAP.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewSellAP.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSellAP.RowHeadersVisible = false;
            this.dataGridViewSellAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSellAP.Size = new System.Drawing.Size(709, 194);
            this.dataGridViewSellAP.TabIndex = 16;
            this.dataGridViewSellAP.TabStop = false;
            // 
            // btnArtPiecesForSale
            // 
            this.btnArtPiecesForSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArtPiecesForSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnArtPiecesForSale.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnArtPiecesForSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtPiecesForSale.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtPiecesForSale.Location = new System.Drawing.Point(11, 370);
            this.btnArtPiecesForSale.Name = "btnArtPiecesForSale";
            this.btnArtPiecesForSale.Size = new System.Drawing.Size(115, 26);
            this.btnArtPiecesForSale.TabIndex = 17;
            this.btnArtPiecesForSale.Text = "View ArtPiece";
            this.btnArtPiecesForSale.UseVisualStyleBackColor = false;
            this.btnArtPiecesForSale.Click += new System.EventHandler(this.btnArtPiecesForSale_Click);
            // 
            // FrmSellArtPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(709, 596);
            this.Controls.Add(this.btnArtPiecesForSale);
            this.Controls.Add(this.dataGridViewSellAP);
            this.Controls.Add(this.txtArtPieceEstimate);
            this.Controls.Add(this.lblSellArtpieceEstimate);
            this.Controls.Add(this.btnSellArtPieceView);
            this.Controls.Add(this.btnSellArtPiece);
            this.Controls.Add(this.txtSellArtPieceID);
            this.Controls.Add(this.lblSellArtPieceID);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSellArtPiece";
            this.Text = "FrmSellArtPiece";
            this.Load += new System.EventHandler(this.FrmSellArtPiece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSellAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSellArtPieceID;
        private System.Windows.Forms.Label lblSellArtPieceID;
        private System.Windows.Forms.Button btnSellArtPieceView;
        private System.Windows.Forms.Button btnSellArtPiece;
        private System.Windows.Forms.TextBox txtArtPieceEstimate;
        private System.Windows.Forms.Label lblSellArtpieceEstimate;
        private System.Windows.Forms.DataGridView dataGridViewSellAP;
        private System.Windows.Forms.Button btnArtPiecesForSale;
    }
}