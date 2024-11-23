namespace EsThread__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private Label numero()
        {
            if (radioButton1.Checked == true)
                return number1;
            if (radioButton2.Checked == true)
                return number2;
            if (radioButton3.Checked == true)
                return number3;
            else
                return null;
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            Label label = numero();
            int valore = Convert.ToInt16(label.Text);
            while (true)
            {

                Thread.Sleep(1000);

                label.Text = (valore - 1).ToString();
                valore--;
            }
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            Label label = numero();
            int valore = Convert.ToInt16(label.Text);
            while (true)
            {

                Thread.Sleep(1000);
                valore++;
                label.Text = valore.ToString();
            }
        }
        private void ThreadMeno(object a)
        {
            btnMeno_Click(a, new EventArgs());
        }
        private void ThreadPiu(object a)
        {
            btnPiu_Click(a, new EventArgs());
        }
        private void btnThreadmeno_Click(object sender, EventArgs e)
        {
            Thread threadMeno = new Thread(ThreadMeno);
            threadMeno.Start(numero());
        }

        private void btnThreadPiu_Click(object sender, EventArgs e)
        {
            Thread threadPiu = new Thread(ThreadPiu);
            threadPiu.Start(numero());
        }
    }
}