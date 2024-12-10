namespace _2024_12_10_S
{
    public partial class Form1 : Form
    {

        List<Hianyzas> lista = new List<Hianyzas>();


        public void betoltes()
        {

            FileStream fs = new FileStream("szeptember.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Hianyzas h = new Hianyzas(sr.ReadLine());
                lista.Add(h);
                rtbadat.Text = rtbadat.Text + h.Nev + ";" + h.Osztaly + ";" + h.Hanyadika + ";" + h.Igazolt + ";" + h.Nemigazolt + "\n";
                dgadat.Rows.Add(h.Nev, h.Osztaly, h.Hanyadika, h.Igazolt, h.Nemigazolt, h.NapiHianyzasSzamolas());

            }



            sr.Close();
            fs.Close();

            int max = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NapiHianyzasSzamolas() > lista[max].NapiHianyzasSzamolas())
                {
                    max = i;
                }


            }
            int listamax = lista[max].NapiHianyzasSzamolas();
            for (int i = 0;i < lista.Count; i++)
            {
                if (lista[i].NapiHianyzasSzamolas() >= 10 )
                {
                    rtbtanulo.Text = rtbtanulo.Text + lista[i].Nev;
                }
            }
            lboraszam.Text = "Órákszáma:" + lista[max].NapiHianyzasSzamolas().ToString();
        }

        public Form1()
        {
            InitializeComponent();
            betoltes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgadat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lboraszam_Click(object sender, EventArgs e)
        {

        }
    }
}
