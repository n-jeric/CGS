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
    public partial class FrmCurators : Form
    {
        Gallery gallery;
        public FrmCurators()
        {
            InitializeComponent();
        }
        public FrmCurators(Gallery gallery)
        {
            InitializeComponent();
            this.gallery = gallery;
        }
        private void FrmCurators_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCurFName;
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
            if (msg.Contains("Error")) { txtCurID.Focus(); return; }
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

        private void btnCurAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string msg = gallery.AddCurator(txtCurID.Text.Trim(), txtCurFName.Text.Trim(), txtCurLName.Text.Trim());

                MessageBox.Show(msg);
                Clear(msg);
            }
        }

        private void btnCurView_Click(object sender, EventArgs e)
        {
            DataTable table = gallery.CuratorDataTable();
            dataGridViewCur.DataSource = table;
            dataGridViewCur.Columns["Commission"].DefaultCellStyle.Format = "C2";
        }

        private void btnCurSave_Click(object sender, EventArgs e)
        {
            string msg = gallery.WriteCurator(MenuGallery.dirPath);
            MessageBox.Show(msg);
        }
    }
}
