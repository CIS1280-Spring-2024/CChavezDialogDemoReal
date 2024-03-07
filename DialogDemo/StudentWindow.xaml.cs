using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DialogDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {

        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public StudentWindow() : this(new Student())
        {
        }

        public StudentWindow(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            student.FirstName = txbFirstName.Text;
            student.LastName = txbLastName.Text;
            student.StudentNumber = txbStudentNum.Text;
            student.Major = txbMajor.Text;

            List<Assignment> scores = new List<Assignment>();
            foreach (Assignment score in lbScores.Items)
            {
                scores.Add(score);
            }
            student.Scores = scores;
            txbResults.Text = student.ToString();

            DialogResult = true;
            Close();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assign = new Assignment();
            assign.Title = txbTitle.Text;
            assign.Score = int.Parse(txbScore.Text);
            lbScores.Items.Add(assign);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}