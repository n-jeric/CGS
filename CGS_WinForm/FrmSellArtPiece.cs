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
    public partial class FrmSellArtPiece : Form
    {
        Gallery gallery;
        public FrmSellArtPiece()
        {
            InitializeComponent();
        }
        public FrmSellArtPiece(Gallery gallery)
        {
            InitializeComponent();
            this.gallery = gallery;
        }
        private void FrmSellArtPiece_Load(object sender, EventArgs e)
        {
            ActiveControl = txtSellArtPieceID;
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
            if (msg.Contains("Error")) { txtSellArtPieceID.Focus(); return; }
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
        private void btnSellArtPieceView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSellArtPieceID.Text))
            {
                MessageBox.Show("Enter ArtPiece ID");
                return;
            }

            DataTable dt = gallery.ArtPiecesForSaleDataTable(txtSellArtPieceID.Text.Trim());

            if (dt != null && dt.Rows.Count>0)
            {
                dataGridViewSellAP.DataSource = dt;
                dataGridViewSellAP.Columns["Value"].DefaultCellStyle.Format = "C2";
                dataGridViewSellAP.Columns["Estimate"].DefaultCellStyle.Format = "C2";
            }
            else
            {
                MessageBox.Show("ArtPiece not available for sale");
            }

        }
        private void btnSellArtPiece_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string msg = gallery.SellArtPiece(txtSellArtPieceID.Text.Trim(), Convert.ToDouble(txtArtPieceEstimate.Text.Trim()));
                MessageBox.Show(msg);
                Clear(msg);

            }
        }

        private void btnArtPiecesForSale_Click(object sender, EventArgs e)
        {
            DataTable table = gallery.ArtPiecesForSaleDataTable();
            dataGridViewSellAP.DataSource = table;
            dataGridViewSellAP.Columns["Value"].DefaultCellStyle.Format = "C2";
            dataGridViewSellAP.Columns["Estimate"].DefaultCellStyle.Format = "C2";
        }
    }
}
