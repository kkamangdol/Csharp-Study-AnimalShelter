namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {

         // DateTime birthday = new DateTime(2000, 1, 1);

            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 1)); //������ ���� birthday �־ ����
            cus.Address = "123 Wilshire Blvd";

            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age .ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
          //bool test = cus.IsQualified;

            //���� ��¥�� �ð� ����
            //DateTime date = new DateTime(2022, 9, 21);

            //���� ��¥�� �ð� ����
            //DateTime current = DateTime.Now;
        }
    }
}