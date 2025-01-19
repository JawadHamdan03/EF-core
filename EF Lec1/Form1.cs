using EF_Lec1.Models;

namespace EF_Lec1
{
    public partial class Form1 : Form
    {
        ItidbContext DB;

        public Form1()
        {
            InitializeComponent();
            DB = new ItidbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = DB.Students.ToList();
            List<Department> departments = DB.Departments.ToList();


            Students_GV.DataSource = students.Select(s => new { ID = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, DepID = s.DeptId }).ToList();
            DepComboBox.DataSource = departments.ToList();
            DepComboBox.DisplayMember = "Name";
            DepComboBox.ValueMember = "Id";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = SearchTextBox.Lines[0].ToString();
            var students = DB.Students.ToList();

            var qr = students.Where(s => s.Name.ToLower() == name.ToLower()).ToList();
            Students_GV.DataSource = qr.Select(s => new { ID = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, DepID = s.DeptId }).ToList(); ;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

            var students = DB.Students.ToList();

            Students_GV.DataSource = students.Select(s => new { ID = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, DepID = s.DeptId }).ToList();
        }

        private void AddStuButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Id = Convert.ToInt32(IDtextBox.Text),
                Age = Convert.ToInt32(AgetextBox.Text),
                Name = NametextBox.Text,
                Address = AddresstextBox.Text,
                DeptId = Convert.ToInt32(DepComboBox.SelectedValue)
            };

            DB.Students.Add(student);
            DB.SaveChanges();


            IDtextBox.Text = "";
            AgetextBox.Text = "";
            NametextBox.Text = "";
            AddresstextBox.Text = "";
            DepComboBox.Text = "1";
            Students_GV.DataSource = DB.Students.Select(s=> new {ID=s.Id, Name=s.Name,Age=s.Age,Address=s.Address,DeptId=s.DeptId}).ToList();

        }
    }
}
