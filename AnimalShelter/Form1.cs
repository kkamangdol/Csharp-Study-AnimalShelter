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

            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 1)); //위에서 만들어서 birthday 넣어도 가능
            cus.Address = "123 Wilshire Blvd";

            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age .ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
          //bool test = cus.IsQualified;

            //임의 날짜와 시간 생성
            //DateTime date = new DateTime(2022, 9, 21);

            //현재 날짜와 시간 생성
            //DateTime current = DateTime.Now;
        }
    }
}