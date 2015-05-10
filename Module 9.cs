using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

namespace Module9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Student> studentList = new List<Student>(); //creating new Student type Generic List

        int index = 0; //while iterating over the student list, this variable keeps track of the index numer


        //the button, textbox and label names may vary from what is shown in the demo
        //please make sure your xaml file contains the same names for them before you compile this code



        //if 'Create Student'  button clicked
        //Event handler creates a Student object using values from the text boxes on the form

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //instantiating new student object
            Student student1 = new Student();

            //assigning attributes 
            student1.FirstName = txtFirstName.Text;
            student1.LastName = txtLastName.Text;
            student1.Country = txtCountry.Text;

            //Adding the newly created Student object to the List<Student>
            studentList.Add(student1);

            //Just an optional add-on
            MessageBox.Show("Student created");

            //clearing the input fields (Textboxes)
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCountry.Text = "";

            //literally takes the indexer to the default position (last element)
            index = studentList.Count();

        }

        //Event handler for the previous(<) button
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            index = index - 1; //assigns previous index number

            if (index >= 0) //sanity check: if index is in range
            {
                txtFirstName.Text = studentList.ElementAt(index).FirstName;
                txtLastName.Text = studentList.ElementAt(index).LastName;
                txtCountry.Text = studentList.ElementAt(index).Country;
            }

            else //if reached the left limit (to avoid the  error caused by out of range index number)
            {
                MessageBox.Show("No more items");
                index = 0;
            }
        }

        //Event handler for the next (>) button 
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            index = index + 1; //assigns next index number

            if (index < studentList.Count()) //sanity check: if index is in range
            {
                txtFirstName.Text = studentList.ElementAt(index).FirstName;
                txtLastName.Text = studentList.ElementAt(index).LastName;
                txtCountry.Text = studentList.ElementAt(index).Country;
            }
            else //if reached the right limit (to avoid the  error caused by out of range index number)
            {
                MessageBox.Show("No more items");
                index = studentList.Count();
            }
        }


    }


    //the good ol' Student class 
    class Student
    {


        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }


        private string _country;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }


    }


}
