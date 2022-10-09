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
    public partial class FrmAddArtPieces : Form
    {
        Gallery gallery;
        public FrmAddArtPieces()
        {
            InitializeComponent();
        }
        public FrmAddArtPieces(Gallery gallery)
        {
            InitializeComponent();
            this.gallery = gallery;
        }
        private void FrmAddArtPieces_Load(object sender, EventArgs e)
        {
            ActiveControl = txtArtPieceID;
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
            if (msg.Contains("Error")) { txtArtPieceID.Focus(); return; }
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
        private Status StatusCheck()
        {
            Status status;
            if (rbStorage.Checked)
            {
                status = Status.O;
            }
            else
            {
                status = Status.D;
            }
            return status;
        }

        private void btnArtPieceAdd_Click(object sender, EventArgs e)
        {
            Status status = StatusCheck();

            if (ValidateForm())
            {
                string msg = gallery.AddArtPiece(txtArtPieceID.Text.Trim(), txtArtPieceTitle.Text.Trim(), Convert.ToInt32(txtArtPieceYear.Text.Trim()), Convert.ToDouble(txtArtPieceValue.Text.Trim()), txtArtPieceArtID.Text.Trim(), txtArtPieceCurID.Text.Trim(), status);
                MessageBox.Show(msg);
                Clear(msg);
            }
        }

        private void btnArtPieceView_Click(object sender, EventArgs e)
        {
            rtbArtPieces.Clear();
            rtbArtPieces.AppendText(gallery.ListPieces());
        }
    }
}
