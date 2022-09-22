using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {

            /*
                        // for��
                        // 1��
                        int i = 0;
                        for(int j = 1; j <= 10; j = j+1)
                        {
                            i = j + i;
                        }

                        // 2��0
                        for (int j = 1; j <= 10; j++)
                        {
                            i += j;  
                        }

                        sum = sum + 10; = sum += 10;
                        sum = sum / 10; = sum /= 10;
            */

            /*
                        // �迭 �߿�!!!! new �ʼ�
                        int numberOne = 1; //�Ѱ��� ������
                        int[] numberArray = new int[5]; //�������� ������
                        numberArray[0] = 1;
                        numberArray[1] = 2;       // 1�� ���
                        numberArray[2] = 3;
                        numberArray[3] = 4;
                        numberArray[4] = 5;

                        int[] numberArray2 = new int[] { 1, 2, 3, 4, 5 };         // 2�� ���

                        int[] numberArray3 = { 1, 2, 3, 4, 5 };       // 3�� ���          

                        Customer customerOne;
                        Customer[] customerArray = new Customer[5];
                        customerArray[0] = new Customer("first", "last", new DateTime(2000, 1, 1));
                        customerArray[1] = new Customer("first", "last", new DateTime(2000, 1, 1));         // 1�� ���
                        customerArray[2] = new Customer("first", "last", new DateTime(2000, 1, 1));
                        customerArray[3] = new Customer("first", "last", new DateTime(2000, 1, 1));
                        customerArray[4] = new Customer("first", "last", new DateTime(2000, 1, 1));

                        Customer[] customerArray2 =
                        {
                            new Customer("first", "last", new DateTime(2000, 1, 1)),
                            new Customer("first", "last", new DateTime(2000, 1, 1)),
                            new Customer("first", "last", new DateTime(2000, 1, 1)),            // 3�����
                            new Customer("first", "last", new DateTime(2000, 1, 1)),
                            new Customer("first", "last", new DateTime(2000, 1, 1))
                        };
            */


            // DateTime birthday = new DateTime(2000, 1, 1);

            // Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 1)); //������ ���� birthday �־ ����
            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            // cus.Address = "123 Wilshire Blvd";

            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);

            CustomerArrayIndex++;
            //bool test = cus.IsQualified;

            //���� ��¥�� �ð� ����
            //DateTime date = new DateTime(2022, 9, 21);

            //���� ��¥�� �ð� ����
            //DateTime current = DateTime.Now;
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstname = CustomerList.SelectedItem.ToString();

            for (int index = 0; index < CustomerArrayIndex; index++)
            {
                if (CustomerArray[index].FirstName == firstname)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add("Hi");
            arrayList.Add(new Customer("First", "Last", new DateTime(2000, 2, 2)));

            arrayList.Insert(2, 2);

            arrayList.Remove(2);
            arrayList.RemoveAt(1);

            int sum = 0;
            for (int index = 0; index < arrayList.Count; index++)
            {
                int num = (int)arrayList[index];
                sum += num;
            }

            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);

            int sum2 = 0;
            for (int index = 0; index < intList.Count; index++)
            {
                int value = intList[index];
                sum2 += value;
            }

            foreach (int value in intList)
            {
                sum += value;
            }

            
        }
    }
}