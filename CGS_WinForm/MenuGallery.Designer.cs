namespace CGS_WinForm
{
    partial class MenuGallery
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSubArtPiece = new System.Windows.Forms.Panel();
            this.btnSellArtPieces = new System.Windows.Forms.Button();
            this.btnAddArtPieces = new System.Windows.Forms.Button();
            this.btnArtPiece = new System.Windows.Forms.Button();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnCurator = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlChilForm = new System.Windows.Forms.Panel();
            this.pnlCenterLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.pnlSubArtPiece.SuspendLayout();
            this.pnlChilForm.SuspendLayout();
            this.pnlCenterLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Controls.Add(this.pnlSubArtPiece);
            this.pnlSideBar.Controls.Add(this.btnArtPiece);
            this.pnlSideBar.Controls.Add(this.btnArtist);
            this.pnlSideBar.Controls.Add(this.btnCurator);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(225, 596);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(0, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(225, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlSubArtPiece
            // 
            this.pnlSubArtPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubArtPiece.Controls.Add(this.btnSellArtPieces);
            this.pnlSubArtPiece.Controls.Add(this.btnAddArtPieces);
            this.pnlSubArtPiece.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubArtPiece.Location = new System.Drawing.Point(0, 250);
            this.pnlSubArtPiece.Name = "pnlSubArtPiece";
            this.pnlSubArtPiece.Size = new System.Drawing.Size(225, 81);
            this.pnlSubArtPiece.TabIndex = 4;
            // 
            // btnSellArtPieces
            // 
            this.btnSellArtPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnSellArtPieces.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellArtPieces.FlatAppearance.BorderSize = 0;
            this.btnSellArtPieces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnSellArtPieces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellArtPieces.ForeColor = System.Drawing.Color.LightGray;
            this.btnSellArtPieces.Location = new System.Drawing.Point(0, 40);
            this.btnSellArtPieces.Name = "btnSellArtPieces";
            this.btnSellArtPieces.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSellArtPieces.Size = new System.Drawing.Size(225, 40);
            this.btnSellArtPieces.TabIndex = 1;
            this.btnSellArtPieces.Text = "Sell Art Piece";
            this.btnSellArtPieces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellArtPieces.UseVisualStyleBackColor = false;
            this.btnSellArtPieces.Click += new System.EventHandler(this.btnSellArtPieces_Click);
            // 
            // btnAddArtPieces
            // 
            this.btnAddArtPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnAddArtPieces.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddArtPieces.FlatAppearance.BorderSize = 0;
            this.btnAddArtPieces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnAddArtPieces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArtPieces.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddArtPieces.Location = new System.Drawing.Point(0, 0);
            this.btnAddArtPieces.Name = "btnAddArtPieces";
            this.btnAddArtPieces.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddArtPieces.Size = new System.Drawing.Size(225, 40);
            this.btnAddArtPieces.TabIndex = 0;
            this.btnAddArtPieces.Text = "Add Art Piece";
            this.btnAddArtPieces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArtPieces.UseVisualStyleBackColor = false;
            this.btnAddArtPieces.Click += new System.EventHandler(this.btnAddArtPieces_Click);
            // 
            // btnArtPiece
            // 
            this.btnArtPiece.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtPiece.FlatAppearance.BorderSize = 0;
            this.btnArtPiece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtPiece.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtPiece.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtPiece.Location = new System.Drawing.Point(0, 200);
            this.btnArtPiece.Name = "btnArtPiece";
            this.btnArtPiece.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnArtPiece.Size = new System.Drawing.Size(225, 50);
            this.btnArtPiece.TabIndex = 3;
            this.btnArtPiece.Text = "Art Pieces";
            this.btnArtPiece.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtPiece.UseVisualStyleBackColor = true;
            this.btnArtPiece.Click += new System.EventHandler(this.btnArtPiece_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtist.FlatAppearance.BorderSize = 0;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArtist.Location = new System.Drawing.Point(0, 150);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnArtist.Size = new System.Drawing.Size(225, 50);
            this.btnArtist.TabIndex = 2;
            this.btnArtist.Text = "Artists";
            this.btnArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnCurator
            // 
            this.btnCurator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurator.FlatAppearance.BorderSize = 0;
            this.btnCurator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurator.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurator.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCurator.Location = new System.Drawing.Point(0, 100);
            this.btnCurator.Name = "btnCurator";
            this.btnCurator.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCurator.Size = new System.Drawing.Size(225, 50);
            this.btnCurator.TabIndex = 1;
            this.btnCurator.Text = "Curators";
            this.btnCurator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurator.UseVisualStyleBackColor = true;
            this.btnCurator.Click += new System.EventHandler(this.btnCurator_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(225, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlChilForm
            // 
            this.pnlChilForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnlChilForm.Controls.Add(this.pnlCenterLogo);
            this.pnlChilForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChilForm.Location = new System.Drawing.Point(225, 0);
            this.pnlChilForm.Name = "pnlChilForm";
            this.pnlChilForm.Size = new System.Drawing.Size(709, 596);
            this.pnlChilForm.TabIndex = 1;
            // 
            // pnlCenterLogo
            // 
            this.pnlCenterLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenterLogo.Controls.Add(this.pictureBox1);
            this.pnlCenterLogo.Controls.Add(this.lblTitle);
            this.pnlCenterLogo.Location = new System.Drawing.Point(202, 213);
            this.pnlCenterLogo.Name = "pnlCenterLogo";
            this.pnlCenterLogo.Size = new System.Drawing.Size(300, 158);
            this.pnlCenterLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CGS_WinForm.Properties.Resources.CGSLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(-4, 135);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Computerized Gallery Systems";
            // 
            // MenuGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 596);
            this.Controls.Add(this.pnlChilForm);
            this.Controls.Add(this.pnlSideBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MenuGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuGallery";
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSubArtPiece.ResumeLayout(false);
            this.pnlChilForm.ResumeLayout(false);
            this.pnlCenterLogo.ResumeLayout(false);
            this.pnlCenterLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlSubArtPiece;
        private System.Windows.Forms.Button btnSellArtPieces;
        private System.Windows.Forms.Button btnAddArtPieces;
        private System.Windows.Forms.Button btnArtPiece;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnCurator;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlChilForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCenterLogo;
    }
}