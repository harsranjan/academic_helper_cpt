namespace harshbasiccalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTtl;
        float n1;
        float n2;
        String option;
        float result;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            n1 = float.Parse(txtBox.Text);

            txtBox.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            n1 = float.Parse(txtBox.Text);

            txtBox.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            n1 = float.Parse(txtBox.Text);

            txtBox.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            n1 = float.Parse(txtBox.Text);

            txtBox.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            n2 = float.Parse(txtBox.Text);

            if (option == "+")
                result = n1 + n2;

            if (option == "-")
                result = n1 - n2;

            if (option == "*")
                result = n1 * n2;

            if (option == "/")
                result = n1 / n2;

            txtBox.Text = result + "";

            if (option == "/" && n2 == 0)
                txtBox.Text = "Can't Divide By zero";

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtBox.Clear();

            result = (0);
            n1 = (0);
            n2 = (0);

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + btnPoint.Text;
        }
    }
}