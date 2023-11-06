using CodeeloUI.SupportClasses.Animation.Animator;
using Org.BouncyCastle.Asn1.Crmf;
using ProgressBarSample;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorOfCalorie
{
    public partial class Form1 : Form
    {
        Person person = new Person(0, 0, 0, " ");
        private List<Food> FoodList;
        private List<FoodOut> FoodListOut;

        private string fileFood = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\Food.json";
        private string fileFoodOut = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\FoodOut.json";
        private string filePerson = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\Person.json";

        public Form1()
        {
            InitializeComponent();
            FoodList = new List<Food>();
            FoodListOut = new List<FoodOut>();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            SaveOut();
            UpdateFoodList();
            UpdateFoodListOut();
            try
            {
                textAge.Text = person.Age.ToString();
                textHeight.Text = person.Height.ToString();
                textWeight.Text = person.Weight.ToString();
                if (person.Gender == "������")
                {
                    radioMan.Checked = true;
                    radioNoMan.Checked = false;
                }
                else
                {
                    radioMan.Checked = false;
                    radioNoMan.Checked = true;
                }
            }
            catch { }
            codeeloButton2.PerformClick();
            codeeloButton1.PerformClick();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveUp();
            base.OnFormClosing(e);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!File.Exists(fileFood))
            {
                using (File.Create(fileFood)) { }
            }

            if (!File.Exists(fileFoodOut))
            {
                using (File.Create(fileFoodOut)) { }
            }

            if (!File.Exists(filePerson))
            {
                using (File.Create(filePerson)) { }
            }
        }

        private void UpdateFoodList()
        {
            listBox1.Items.Clear();
            foreach (var Food in FoodList)
            {
                listBox1.Items.Add($"{Food.Name} - 100 �, {Food.Calories} ����");
            }
            listBox2.Items.Clear();
            foreach (var Food in FoodList)
            {
                listBox2.Items.Add($"{Food.Name} - 100 �, {Food.Calories} ����");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static int TakeCal(List<Food> FoodList, string prod)
        {
            foreach (Food food in FoodList)
            {
                if (food.Name.Equals(prod, StringComparison.OrdinalIgnoreCase))
                {

                    return food.Calories;

                }
            }
            return 0;
        }

        private void UpdateFoodListOut()
        {
            listBox3.Items.Clear();
            foreach (var FoodOut in FoodListOut)
            {
                listBox3.Items.Add($"{FoodOut.Name} - {FoodOut.Gram} �, {FoodOut.Cal} ����");
            }
        }



        private void codeeloButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textHeight.Text) &&
                !string.IsNullOrEmpty(textWeight.Text) &&
                !string.IsNullOrEmpty(textAge.Text))
            {
                int height = int.Parse(textHeight.Text);
                int weight = int.Parse(textWeight.Text);
                int age = int.Parse(textAge.Text);
                if (radioMan.Checked == true && radioNoMan.Checked == true)
                {
                    MessageBox.Show("������ ���� �����.");
                    textHeight.Text = "";
                    textWeight.Text = "";
                    textAge.Text = "";
                    radioMan.Checked = false;
                    radioNoMan.Checked = false;
                }
                else if (radioMan.Checked == false && radioNoMan.Checked == false)
                {
                    MessageBox.Show("������ �����.");
                    textHeight.Text = "";
                    textWeight.Text = "";
                    textAge.Text = "";
                    radioMan.Checked = false;
                    radioNoMan.Checked = false;
                }
                string gender = radioMan.Checked ? "������" : "Ƴ���";



                person.Height = height;
                person.Weight = weight;
                person.Age = age;
                person.Gender = gender;
                person.CalculateDailyCalorieNeeds();
                double DailyCalorieNeeds = person.DailyCalorieNeeds;

            }
            else
            {
                MessageBox.Show("��������� �� ���� ��� ���������� ������.");
                textHeight.Text = "";
                textWeight.Text = "";
                textAge.Text = "";
                radioMan.Checked = false;
                radioNoMan.Checked = false;
            }
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textName.Text) && !string.IsNullOrEmpty(textCal.Text))
            {
                string name = textName.Text;
                int cal = int.Parse(textCal.Text);

                Food food = new Food(name, cal);
                FoodList.Add(food);
                UpdateFoodList();

                textName.Text = "";
                textCal.Text = "";
            }
            else
            {
                MessageBox.Show("��������� ������ ���� ��� ��������� ��������.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                FoodList.RemoveAt(selectedIndex);
                UpdateFoodList();
            }
            else
            {
                MessageBox.Show("������� ������� ��� ���������.");
            }
        }

        private void btnAdd1_Click_1(object sender, EventArgs e)
        {
            string prod_e = listBox2.SelectedItem?.ToString();
            string[] spice = prod_e.Split(' ');
            string prod = spice.Length > 0 ? spice[0] : "";

            if (prod != null && !string.IsNullOrEmpty(textGram.Text))
            {
                double gram = double.Parse(textGram.Text);
                double calprod = (TakeCal(FoodList, prod) / 100) * gram;
                FoodOut foodout = new FoodOut(prod, gram, calprod);

                FoodListOut.Add(foodout);
                UpdateFoodListOut();
                textGram.Text = "";
            }
            else
            {
                MessageBox.Show("������� ������� �� ������ ������� ����.");
            }
        }

        private void btnDel1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.SelectedIndex >= 0)
                {
                    FoodOut foodout = FoodListOut[listBox3.SelectedIndex];


                    FoodListOut.Remove(foodout);

                    UpdateFoodListOut();
                }
                else
                {

                    MessageBox.Show("������� ������� ��� ���������.");
                }
            }
            catch
            {
                MessageBox.Show("������� ������� ��� ���������.");
            }
        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            double calall = 0;
            foreach (FoodOut prod in FoodListOut)
            {
                calall += prod.Cal;
            }
            UpdateProgressBar(calall);
        }
        private void UpdateProgressBar(double calall)
        {


            double call = person.DailyCalorieNeeds;


            int progres = (int)((double)calall / call * 100);

            ProgressBar1.Value = progres;
        }

        private void SaveUp()
        {
            string jsonFood = JsonSerializer.Serialize(FoodList);
            File.WriteAllText(fileFood, jsonFood);

            string jsonFoodOut = JsonSerializer.Serialize(FoodListOut);
            File.WriteAllText(fileFoodOut, jsonFoodOut);

            string jsonPerson = JsonSerializer.Serialize(person);
            File.WriteAllText(filePerson, jsonPerson);
        }
        private void SaveOut()
        {
            if (File.Exists(fileFood))
            {

                string jsonFood = File.ReadAllText(fileFood);
                FoodList = JsonSerializer.Deserialize<List<Food>>(jsonFood);
            }

            if (File.Exists(fileFoodOut))
            {
                string jsonFoodOut = File.ReadAllText(fileFoodOut);
                FoodListOut = JsonSerializer.Deserialize<List<FoodOut>>(jsonFoodOut);
            }

            if (File.Exists(filePerson))
            {
                string jsonPerson = File.ReadAllText(filePerson);
                person = JsonSerializer.Deserialize<Person>(jsonPerson);

            }
        }


    }
}