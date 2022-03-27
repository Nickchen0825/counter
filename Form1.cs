namespace counter
{
    public partial class btn_addnumber2 : Form
    {
        decimal i = 0;
        Int64 j,k;
        List<student> abc = new List<student>();


        public btn_addnumber2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if(text.Text=="0")
            { text.Text = "1"; }
            else
            {
                string one = text.Text + "1";
                text.Text = one;
            }
           
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "2"; }
            else
            {
                string one = text.Text + "2";
                text.Text = one;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "3"; }
            else
            {
                string one = text.Text + "3";
                text.Text = one;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "4"; }
            else
            {
                string one = text.Text + "4";
                text.Text = one;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "5"; }
            else
            {
                string one = text.Text + "5";
                text.Text = one;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "6"; }
            else
            {
                string one = text.Text + "6";
                text.Text = one;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "7"; }
            else
            {
                string one = text.Text + "7";
                text.Text = one;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "8"; }
            else
            {
                string one = text.Text + "8";
                text.Text = one;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "9"; }
            else
            {
                string one = text.Text + "9";
                text.Text = one;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (text.Text == "0")
            { text.Text = "0"; }
            else
            {
                string one = text.Text + "0";
                text.Text = one;
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            /*i = i/ System.Convert.ToDecimal(text.Text);
            text.Text = "0";
            label.Text = i.ToString();*/
            action();
            j = 1;
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            /*i =  System.Convert.ToDecimal(text.Text) * i;
            text.Text = "0";
            label.Text = i.ToString();*/
            action();
            j = 2;
        }

        private void btn_diviend_Click(object sender, EventArgs e)
        {
            /*i = i%  System.Convert.ToDecimal(text.Text) ;
            text.Text = "0";
            label.Text = i.ToString();*/
            action();
            j = 3;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            text.Text = "0";
            i = 0;
            label.Text = i.ToString();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            /*i =  System.Convert.ToDecimal(text.Text) + i;
            text.Text = "0";
            label.Text = i.ToString();*/
            action();
            j = 4;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            /* i = i- System.Convert.ToDecimal(text.Text) ;
             text.Text = "0";
             label.Text = i.ToString();*/
            action();
            j = 5;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            //string test = "10.2552";
            //decimal testde = System.Convert.ToDecimal(test);
            //int i = 10;
            string one = text.Text + ".";
            text.Text = one;


        }

        private void btn_equel_Click(object sender, EventArgs e)
        {
            if(j==1)
            {label.Text= (System.Convert.ToDecimal(label.Text) / System.Convert.ToDecimal(text.Text)).ToString(); }
            else if(j==2)
            { label.Text = (System.Convert.ToDecimal(label.Text) *  System.Convert.ToDecimal(text.Text)).ToString(); }
            else if(j ==3)
            { label.Text = ( System.Convert.ToDecimal(label.Text) %  System.Convert.ToDecimal(text.Text)).ToString(); }
            else if(j==4)
            { label.Text = ( System.Convert.ToDecimal(label.Text) +  System.Convert.ToDecimal(text.Text)).ToString(); }
            else if(j==5)
            { label.Text = ( System.Convert.ToDecimal(label.Text) -  System.Convert.ToDecimal(text.Text)).ToString(); }
            text.Text = "0";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < abc.Count; k++)
            {
                if (abc[k].ID == txtbox_studentnumber.Text)
                {
                    MessageBox.Show("­«½Æ¤F");
                    return; 
                }
            }
                student efg = new student(txtbox_studentnumber.Text, System.Convert.ToDecimal(txtbox_chinese.Text) ,System.Convert.ToDecimal(txtbox_english.Text), System.Convert.ToDecimal(txtbox_math.Text), System.Convert.ToDecimal(txtbox_total.Text), System.Convert.ToDecimal(txtbox_average.Text));
            abc.Add(efg);
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            for(int k=0;k<abc.Count;k++)
            {
                if(abc[k].ID==txtbox_studentnumber.Text)
                {
                    abc.RemoveAt(k);
                    student efg = new student(txtbox_studentnumber.Text, System.Convert.ToDecimal(txtbox_chinese.Text), System.Convert.ToDecimal(txtbox_english.Text), System.Convert.ToDecimal(txtbox_math.Text), System.Convert.ToDecimal(txtbox_total.Text), System.Convert.ToDecimal(txtbox_average.Text));
                    abc.Add(efg);
                    return;
                }
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < abc.Count; k++)
            {
                if (abc[k].ID == txtbox_studentnumber.Text)
                {
                    txtbox_chinese.Text = abc[k].chi.ToString();
                    txtbox_english.Text = abc[k].eng.ToString();
                    txtbox_math.Text = abc[k].math.ToString();
                    txtbox_total.Text = abc[k].total.ToString();
                    txtbox_average.Text = abc[k].average.ToString();
                    return;
                }
            }
        }

        

        private void btn_addnumber_Click_1(object sender, EventArgs e)
        {
            txtbox_total.Text = label.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox_average.Text = label.Text;
        }

        private void action()
        {
            if( System.Convert.ToDecimal(label.Text)==0)
            { label.Text = text.Text;
                text.Text = "0";
            }
         
            else 
            {
                if (j == 1)
                { label.Text = ( System.Convert.ToDecimal(label.Text) /  System.Convert.ToDecimal(text.Text)).ToString(); }
                else if (j == 2)
                { label.Text = ( System.Convert.ToDecimal(label.Text) *  System.Convert.ToDecimal(text.Text)).ToString(); }
                else if (j == 3)
                { label.Text = ( System.Convert.ToDecimal(label.Text) %  System.Convert.ToDecimal(text.Text)).ToString(); }
                else if (j == 4)
                { label.Text = ( System.Convert.ToDecimal(label.Text) +  System.Convert.ToDecimal(text.Text)).ToString(); }
                else if (j == 5)
                { label.Text = ( System.Convert.ToDecimal(label.Text) -  System.Convert.ToDecimal(text.Text)).ToString();
                  
                }
                text.Text = "0";
            }

        }

    }

    public struct student { 
        public string ID;
        public decimal chi;
        public decimal eng;
        public decimal math;
        public decimal total;
        public decimal average;
        public student(string id, decimal Chi, decimal Eng, decimal Math,decimal Total,
            decimal Average)
        { 
            ID = id; chi = Chi; eng = Eng; math = Math;total = Total; average = Average;
        }
    }
}