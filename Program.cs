namespace AddressBookDay28
{


    public class FileIO
    {
        public void Display(string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        static void Main(string[] args)
        {
            FileIO f = new FileIO();
            string path = @"C:\Users\Dell\source\repos\AddressBookDay28\AddressBookDay28\Address.txt";
            Console.Write("How many Contact You Have To Add:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //Accepting Details From User
                Console.WriteLine("Enter Details For " + i + " Contact");
                Console.Write("Enter First Name:");
                string firstname = Console.ReadLine();

                Console.Write("Enter Last Name:");
                string lastname = Console.ReadLine();

                Console.Write("Enter Address:");
                string address = Console.ReadLine();

                Console.Write("Enter City:");
                string city = Console.ReadLine();

                Console.Write("Enter State:");
                string state = Console.ReadLine();

                Console.Write("Enter ZipCode:");
                int zipcode = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Mobile Number:");
                long mobnum = Convert.ToInt64(Console.ReadLine());

                //Adding Details
                Console.WriteLine("Contact Added To Main.txt File");
                Console.WriteLine("\n");

                //adding details of user to file given
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("First Name:" + firstname);
                    sw.WriteLine("Last Name:" + lastname);
                    sw.WriteLine("Address:" + address);
                    sw.WriteLine("City:" + city);
                    sw.WriteLine("State:" + state);
                    sw.WriteLine("ZipCode:" + zipcode);
                    sw.WriteLine("Mobile Number:" + mobnum);
                    sw.WriteLine("\n");
                    sw.Close();
                }
            }

            Console.WriteLine("---------------------------------Data Inside File Is---------------------------------");
            //displaying file data
            f.Display(path);
        }
    }
}
