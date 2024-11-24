namespace FormACT002Tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.Muestratabla();
        }
        private void Muestratabla()
        {
            int n = Convert.ToInt32( this.textBoxNum.Text );
            string Tabla = "";

            for(int i = 1; i <= 10; i++)
            {
                Tabla = Tabla + n + "x" + i + "= " + (n * i) + "\n";
            }
            this.richTextBoxResultados.AppendText(Tabla);
        }
    }
}
