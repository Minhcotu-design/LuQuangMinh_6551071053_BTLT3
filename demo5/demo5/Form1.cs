using System.Drawing;
namespace demo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;

            txtNhapTen.Focus();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhapTen.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhapTen.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font,
                lblLapTrinh.Font.Style ^ FontStyle.Bold
            );

            txtNhapTen.Font = new Font(
                txtNhapTen.Font,
                txtNhapTen.Font.Style ^ FontStyle.Bold
            );
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font,
                lblLapTrinh.Font.Style ^ FontStyle.Italic
            );

            txtNhapTen.Font = new Font(
                txtNhapTen.Font,
                txtNhapTen.Font.Style ^ FontStyle.Italic
            );
        }

        private void chkUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font,
                lblLapTrinh.Font.Style ^ FontStyle.Underline
            );

            txtNhapTen.Font = new Font(
                txtNhapTen.Font,
                txtNhapTen.Font.Style ^ FontStyle.Underline
            );
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
