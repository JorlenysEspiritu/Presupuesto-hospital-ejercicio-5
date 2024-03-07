namespace Presupuesto_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagos_Click(object sender, EventArgs e)
        {
            int pag = int.Parse(txt_presupuesto.Text);
            
            double em = pag * 0.30;
            double ci = pag * 0.15;
            double su = pag * 0.25;
            double ad = pag * 0.18;
            double la = pag * 0.05;
            double im = pag * 0.07;
            txt_eme.Text = em.ToString();
            txt_cir.Text = ci.ToString();
            txt_sum.Text = su.ToString();
            txt_adm.Text = ad.ToString();
            txt_lab.Text = la.ToString();
            txt_ima.Text = im.ToString();

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txt_adm.Clear();
            txt_cir.Clear();
            txt_eme.Clear();
            txt_ima.Clear();
            txt_lab.Clear();
            txt_sum.Clear();
            txt_presupuesto.Clear();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}