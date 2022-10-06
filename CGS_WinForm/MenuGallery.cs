using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnArtPiece_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubArtPiece);
        }

        private void btnCurator_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmCurators());
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new FrmArtists());
        }

        private void btnAddArtists_Click(object sender, EventArgs e)
        {
           OpenChildForm(new FrmAddArtPieces());
        }

        private void btnSellArtPieces_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChilForm.Controls.Add(childForm);
            pnlChilForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
