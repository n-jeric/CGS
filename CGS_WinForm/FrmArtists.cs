using CGS_WinLibrary;
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
    public partial class FrmArtists : Form
    {
        Gallery gallery;
        public FrmArtists()
        {
            InitializeComponent();
        }
        public FrmArtists(Gallery gallery)
        {
            InitializeComponent();
            this.gallery = gallery;
        }
        private void FrmArtists_Load(object sender, EventArgs e)
        {
            ActiveControl = txtArtFName;
        }
        private bool ValidateForm()
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrWhiteSpace(t.Text)))
            {
                MessageBox.Show("Fields cannot be empty");
                return false;
            }
            return true;
        }
        private void Clear(string msg)
        {
            if (msg.Contains("Error")) { txtArtID.Focus(); return; }
            else
            {
                Action<Control.ControlCollection> clearAll = null;
                clearAll = (controls) =>
                {
                    foreach (Control control in controls)
                    {
                        if (control is TextBox)
                        {
                            (control as TextBox).Clear();
                        }
                        else
                        {
                            clearAll(control.Controls);
                        }
                    }
                };
                clearAll(Controls);
            }
        }

        private void btnArtistAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string msg = gallery.AddArtist(txtArtID.Text.Trim(), txtArtFName.Text.Trim(), txtArtLName.Text.Trim());
                MessageBox.Show(msg);
                Clear(msg);
            }
        }

        private void btnArtistView_Click(object sender, EventArgs e)
        {
            rtbArtists.Clear();
            rtbArtists.AppendText(gallery.ListArtists());
        }

        private void btnArtistSave_Click(object sender, EventArgs e)
        {

        }
    }
}
