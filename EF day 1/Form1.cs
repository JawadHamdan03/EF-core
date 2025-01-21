using EF_Lec1.Models;
using Microsoft.EntityFrameworkCore;

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

            //var qr = from s in students
            //         join d in departments
            //         on s.DeptId equals d.Id
            //         select new { ID = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, Department=d.Name };
            //Students_GV.DataSource = qr.ToList();

            Students_GV.DataSource = DB.Students.Include(s => s.Dept).Select(s=> new {Id=s.Id,Name = s.Name,Age=s.Age,Address=s.Address,Department=s.Dept.Name }).ToList();

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

            var qr = DB.Students.Include(s => s.Dept).Select(s => new { Id = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, Department = s.Dept.Name });

            var qr2 = qr.Where(s => s.Name.ToLower().Contains( name.ToLower())).ToList();
            Students_GV.DataSource = qr2.Select(s => new { ID = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, Department = s.Department }).ToList(); ;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            var students = DB.Students.ToList();
            Students_GV.DataSource = DB.Students.Include(s => s.Dept).Select(s => new { Id = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, Department = s.Dept.Name }).ToList();

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

            Students_GV.DataSource = DB.Students.Include(s => s.Dept).Select(s => new { Id = s.Id, Name = s.Name, Age = s.Age, Address = s.Address, Department = s.Dept.Name }).ToList();

        }
    }
}
