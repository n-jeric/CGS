using CGS_WinLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_WinForm
{
    public partial class MenuGallery : Form
    {
        public MenuGallery()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        
        Gallery gallery = new Gallery();
        internal static string dirPath = @".\TextFolder\";

        private void MenuGallery_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        #region SubMenu Display
        private void CustomizeDesign()
        {
            pnlSubArtPiece.Visible = false;
        }
        private void HideSubMenu()
        {
            if (pnlSubArtPiece.Visible == true)
            {
                pnlSubArtPiece.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region ChildForms
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChilForm.Controls.Add(childForm);
            pnlChilForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Buttons
        private void btnCurator_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmCurators(gallery));
        }
        private void btnArtist_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmArtists(gallery));
        }
        private void btnArtPiece_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubArtPiece);
        }
        private void btnAddArtPieces_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAddArtPieces(gallery));
        }
        private void btnSellArtPieces_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSellArtPiece(gallery));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app.?",
              "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2).ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                activeForm?.Close();
            }
        }
        #endregion


    }
}
