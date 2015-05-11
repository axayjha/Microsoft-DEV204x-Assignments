private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
{
    Student newStudent = new Student();
    newStudent.FirstName = txtFirstName.Text;
    newStudent.LastName = txtLastName.Text;
    newStudent.City = txtCity.Text;
    

    Task newTask = new Task(() => AddToCollection(newStudent));
    newTask.Start();

    ClearForm();
    
}


private void AddToCollection(Student student)
{
    // This line of code is intended to simulate network or database latency
    // It causes a non-responsive UI
    // Do not remove this line of code as a way of completing the assignment
    // You MUST use a C# task to get credit
    Thread.Sleep(5000);
    students.Add(student);
    int count = students.Count;
    MessageBox.Show("Student created successfully.  Collection contains " + count.ToString() + " Student(s).");
}