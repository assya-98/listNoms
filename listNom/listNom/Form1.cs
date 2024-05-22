namespace listNom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalut_Click(object sender, EventArgs e)
        {
            string prenom = txtPrenom.Text;

            if (prenom.Length > 0)
            {
                MessageBox.Show($"HELLO {prenom}", "Bonjour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Le champs ne peut pas etre vide", "ERREUR UTILISATEUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
