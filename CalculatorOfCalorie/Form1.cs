using CodeeloUI.SupportClasses.Animation.Animator;
using Org.BouncyCastle.Asn1.Crmf;
using ProgressBarSample;
using System;
using System.Text.Json;
using Syncfusion.Windows.Forms.Chart;
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
        private List<double> DayCaloriesList = new List<double>();

        private string fileFood = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\Food.json";
        private string fileFoodOut = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\FoodOut.json";
        private string filePerson = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\Person.json";
        private string fileDayCalories = "C:\\Users\\Lenovo\\source\\repos\\CalculatorOfCalorie\\CalculatorOfCalorie\\DayCalories.json";

        public Form1()
        {
            InitializeComponent();
            FoodList = new List<Food>();
            FoodListOut = new List<FoodOut>();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            SaveOut();
            UpdateProgressBar(0);
            UpdateDayCaloriesList();
            UpdateFoodList();
            UpdateFoodListOut();
            chartControl1 = chartControl1;
            try
            {
                textAge.Text = person.Age.ToString();
                textHeight.Text = person.Height.ToString();
                textWeight.Text = person.Weight.ToString();
                if (person.Gender == "Чоловік")
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
                listBox1.Items.Add($"{Food.Name} - 100 г, {Food.Calories} ккал");
            }
            listBox2.Items.Clear();
            foreach (var Food in FoodList)
            {
                listBox2.Items.Add($"{Food.Name} - 100 г, {Food.Calories} ккал");
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
                listBox3.Items.Add($"{FoodOut.Name} - {FoodOut.Gram} г, {Math.Round(FoodOut.Cal, 2)} ккал");
            }
        }
        private void UpdateDayCaloriesList()
        {
            listBox4.Items.Clear();
            foreach (double DayCalories in DayCaloriesList)
            {
                double roundedCalories = Math.Round(DayCalories, 2);
                listBox4.Items.Add($"{roundedCalories.ToString()} ккал");
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
                    MessageBox.Show("Оберіть одку стать.");
                    textHeight.Text = "";
                    textWeight.Text = "";
                    textAge.Text = "";
                    radioMan.Checked = false;
                    radioNoMan.Checked = false;
                }
                else if (radioMan.Checked == false && radioNoMan.Checked == false)
                {
                    MessageBox.Show("Оберіть стать.");
                    textHeight.Text = "";
                    textWeight.Text = "";
                    textAge.Text = "";
                    radioMan.Checked = false;
                    radioNoMan.Checked = false;
                }
                string gender = radioMan.Checked ? "Чоловік" : "Жінка";



                person.Height = height;
                person.Weight = weight;
                person.Age = age;
                person.Gender = gender;
                person.CalculateDailyCalorieNeeds();

            }
            else
            {
                MessageBox.Show("Заповніть всі поля для збереження данних.");
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
                MessageBox.Show("Заповніть обидва поля для додавання продукту.");
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
                MessageBox.Show("Виберіть продукт для виделення.");
            }
        }

        private void btnAdd1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string prod_e = listBox2.SelectedItem?.ToString();
                string[] spice = prod_e.Split(' ');
                string prod = spice.Length > 0 ? spice[0] : "";

                if (prod != null && !string.IsNullOrEmpty(textGram.Text))
                {
                    double gram = double.Parse(textGram.Text);
                    double calprod = (gram / 100) * TakeCal(FoodList, prod);
                    FoodOut foodout = new FoodOut(prod, gram, calprod);

                    FoodListOut.Add(foodout);
                    UpdateFoodListOut();
                    textGram.Text = "";
                }

                else
                {
                    MessageBox.Show("Виберіть продукт та вкажіть кількість грімів.");
                }
            }
            catch { MessageBox.Show("Виберіть продукт та вкажіть кількість грімів."); }
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

                    MessageBox.Show("Виберіть продукт для виделення.");
                }
            }
            catch
            {
                MessageBox.Show("Виберіть продукт для виделення.");
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
        public void UpdateProgressBar(double calall)
        {
            try
            {
                person.CalculateDailyCalorieNeeds();
                double call = person.DailyCalorieNeeds;
                textProgressBar1.Maximum = Convert.ToInt32(call);
                textProgressBar1.Value = Convert.ToInt32(calall);
            }
            catch { }
        }

        private void SaveUp()
        {
            string jsonFood = JsonSerializer.Serialize(FoodList);
            File.WriteAllText(fileFood, jsonFood);

            string jsonFoodOut = JsonSerializer.Serialize(FoodListOut);
            File.WriteAllText(fileFoodOut, jsonFoodOut);

            string jsonPerson = JsonSerializer.Serialize(person);
            File.WriteAllText(filePerson, jsonPerson);

            string jsonCaloriesList = JsonSerializer.Serialize(DayCaloriesList);
            File.WriteAllText(fileDayCalories, jsonCaloriesList);
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
            if (File.Exists(fileDayCalories))
            {
                string jsonCaloriesList = File.ReadAllText(fileDayCalories);
                DayCaloriesList = JsonSerializer.Deserialize<List<double>>(jsonCaloriesList);

                UpdateDayCaloriesList();
                UpdateChart();
            }
        }



        private void btnSaveDay_Click(object sender, EventArgs e)
        {
            double calall = 0;
            foreach (FoodOut prod in FoodListOut)
            {
                calall += prod.Cal;
            }

            SaveCalories(calall);

            UpdateProgressBar(calall);

            UpdateChart();
            UpdateDayCaloriesList();
        }
        private void UpdateChart()
        {
            double calall = 0;
            foreach (FoodOut prod in FoodListOut)
            {
                calall += prod.Cal;
            }
            ChartSeries series = null;

            foreach (ChartSeries existingSeries in chartControl1.Series)
            {
                if (existingSeries.Name == "Калорій споживано за день")
                {
                    series = existingSeries;
                    break;
                }
            }

            if (series == null)
            {
                series = new ChartSeries("Калорій споживано за день");
                chartControl1.Series.Add(series);
            }

            series.Points.Clear();

            for (int i = Math.Max(0, DayCaloriesList.Count - 10); i < DayCaloriesList.Count; i++)
            {
                series.Points.Add(i + 1, DayCaloriesList[i]);
            }
        }
        private void SaveCalories(double calories)
        {
            DayCaloriesList.Add(calories);
            UpdateDayCaloriesList();
        }
        private void RemoveCalories(int index)
        {
            if (index >= 0 && index < DayCaloriesList.Count)
            {
                DayCaloriesList.RemoveAt(index);
            }
            UpdateDayCaloriesList();
        }
        private void codeeloButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox4.SelectedIndex >= 0)
                {
                    int selectedIndex = listBox4.SelectedIndex;

                    RemoveCalories(selectedIndex);

                    UpdateChart();
                    UpdateFoodListOut();
                }
                else
                {

                    MessageBox.Show("Виберіть точку для виделення.");
                }
            }
            catch
            {
                MessageBox.Show("Виберіть точку для виделення.");
            }
        }
    }
}