namespace Tugas3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = String.Format("Halo {0}", nama);
            txtPesan2.Text = String.Format("Pendidikan Anda {0} ya?", pendidikan);
            txtPesan3.Text = String.Format("Anda seorang {0}, hebat !!!", pekerjaan);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstPekerjaan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}