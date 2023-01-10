using AttendenceSystem;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

Console.WriteLine("Welcome to Console Based Attendence System.");
int exit = 0;

while (exit==0)
{
    // Main Menu Section
    Console.WriteLine("Select Your Option: ");
    Console.WriteLine("1 : ADMIN");
    Console.WriteLine("2 : TEACHER");
    Console.WriteLine("3 : STUDENT");
    Console.WriteLine("4 : Exit");
    Console.Write("Enter your Option: ");
    int value = int.Parse(Console.ReadLine());

    int mainmenu = 0;

    // Main Menu Section End


    //Admin Section Start
    if (value == 1)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Administrative Segment");
        
        while (mainmenu == 0 && exit == 0)
        {
            Console.Write("Username: ");
            string AdminUserName = Console.ReadLine();
            Console.Write("Password: ");
            string AdminPassword = Console.ReadLine();

            if (AdminUserName == "Assignment3" && AdminPassword == "12345")
            {
                while (mainmenu==0 && exit == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Select an Option:");
                    Console.WriteLine("1 : Student Database");
                    Console.WriteLine("2 : Teacher Database");
                    Console.WriteLine("3 : Course Database");
                    Console.WriteLine("4 : Main Menu");
                    Console.WriteLine("5 : Exit");
                   

                    Console.Write("Enter your Option: ");
                    int adminValue = int.Parse(Console.ReadLine());
                    

                    // Student Database Operation ::: Admin Section
                    if (adminValue == 1)
                    {
                        while (mainmenu == 0 && exit == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select an option: ");
                            Console.WriteLine("1 : Add a Student");
                            Console.WriteLine("2 : Remove a Student");
                            Console.WriteLine("3 : Update Data of a Student");
                            Console.WriteLine("4 : Back to previous option");
                            Console.WriteLine("5 : Main Menu");
                            Console.WriteLine("6 : Exit");

                            Console.Write("Enter your option: ");
                            int stuValue = int.Parse(Console.ReadLine());

                            Student student = new Student();
                            DataBaseContext context = new DataBaseContext();


                            // Add a Student :: Student Database
                            if (stuValue == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Add a student: ");
                                
                                Console.Write("Enter Student Name: ");
                                string studentName = Console.ReadLine();
                                student.Name = studentName;
                                Console.Write("Enter Student's Username: ");
                                string studentUsername = Console.ReadLine();
                                student.UserName = studentUsername;
                                Console.Write("Enter Student's Password: ");
                                string studentPassword = Console.ReadLine();
                                student.Password = studentPassword;

                                context.Students.Add(student);
                                context.SaveChanges();
                                Console.WriteLine("Student Added!");

                                continue;
                            }
                            // End of Add a student


                            // Remove a student
                            else if (stuValue == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Remove a student: ");

                                Console.Write("Enter Student's Username: ");
                                string studentUsername = Console.ReadLine();

                                student = context.Students.Where(x => x.UserName == studentUsername).FirstOrDefault();
                                if (student != null)
                                {
                                    context.Students.Remove(student);
                                    context.SaveChanges();
                                    Console.WriteLine("Student Removed");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Username");
                                }
                                continue;
                            }
                            // End of Remove a student


                            // Update Existing student data
                            else if (stuValue == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Update Student Data: ");

                                Console.Write("Enter Student's Username: ");
                                string studentUsername = Console.ReadLine();

                                student = context.Students.Where(x => x.UserName == studentUsername).FirstOrDefault();

                                Console.WriteLine("Which Data do you want to update? ");
                                Console.WriteLine("1 : Name");
                                Console.WriteLine("2 : Username");
                                Console.WriteLine("3 : Password");

                                int updateStudent = int.Parse(Console.ReadLine());
                                
                                if (student != null)
                                {
                                    if(updateStudent == 1)
                                    {
                                        Console.Write("Enter New Name: ");
                                        string stuName = Console.ReadLine();
                                        student.Name = stuName;
                                        context.SaveChanges();
                                        Console.WriteLine("Name Updated");
                                    }
                                    else if(updateStudent == 2)
                                    {
                                        Console.Write("Enter New Username: ");
                                        string stuUsername = Console.ReadLine();
                                        student.UserName = stuUsername;
                                        context.SaveChanges();
                                        Console.WriteLine("Username Updated");
                                    }
                                    else if(updateStudent == 3)
                                    {
                                        Console.Write("Enter New Password: ");
                                        string stuPassword = Console.ReadLine();
                                        student.Password = stuPassword;
                                        context.SaveChanges();
                                        Console.WriteLine("Password Updated");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a vlaid Username!");
                                }

                                
                            }
                            // End of Update Existing Data


                            // Back to previous Option
                            else if (stuValue == 4)
                            {
                                break;
                            }

                            // Back to main menu
                            else if (stuValue == 5)
                            {
                                mainmenu = 1;

                            }

                            // Exit
                            else if (stuValue == 6)
                            {
                                Console.WriteLine("Thank You");
                                exit = 1;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option!");
                            }
                        }
                    }
                    // End of Student Database


                    // Teacher Database
                    else if (adminValue == 2)
                    {
                        while (mainmenu == 0 && exit == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select an option: ");
                            Console.WriteLine("1 : Add a Teacher");
                            Console.WriteLine("2 : Remove a Teacher");
                            Console.WriteLine("3 : Update Data of a Teacher");
                            Console.WriteLine("4 : Back to previous option");
                            Console.WriteLine("5 : Main Menu");
                            Console.WriteLine("6 : Exit");

                            Console.Write("Enter your option: ");
                            int TeacherValue = int.Parse(Console.ReadLine());

                            Teacher teacher = new Teacher();
                            DataBaseContext context = new DataBaseContext();


                            // Add a teacher

                            if (TeacherValue == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Add a teacher: ");

                                Console.Write("Enter Teacher Name: ");
                                string teacherName = Console.ReadLine();
                                teacher.Name = teacherName;
                                Console.Write("Enter teacher's Username: ");
                                string teacherUsername = Console.ReadLine();
                                teacher.UserName = teacherUsername;
                                Console.Write("Enter Student's Password: ");
                                string teacherPassword = Console.ReadLine();
                                teacher.Password = teacherPassword;

                                context.Teachers.Add(teacher);
                                context.SaveChanges();
                                Console.WriteLine("Teacher Added!");

                                continue;
                            }
                            //End of add a teacher

                            // Remove a teacher
                            else if (TeacherValue == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Remove a Teacher: ");

                                Console.Write("Enter Teacher's Username: ");
                                string teacherUsername = Console.ReadLine();

                                teacher = context.Teachers.Where(x => x.UserName == teacherUsername).FirstOrDefault();
                                if (teacher != null)
                                {
                                    context.Teachers.Remove(teacher);
                                    context.SaveChanges();
                                    Console.WriteLine("Teacher Removed");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Username");
                                }
                                continue;
                            }
                            //End of remove a teacher

                            // Update data of a existing teacher
                            else if (TeacherValue == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Update Teacher Data: ");

                                Console.Write("Enter Teacher's Username: ");
                                string teacherUsername = Console.ReadLine();

                                teacher = context.Teachers.Where(x => x.UserName == teacherUsername).FirstOrDefault();

                                Console.WriteLine("Which Data do you want to update? ");
                                Console.WriteLine("1 : Name");
                                Console.WriteLine("2 : Username");
                                Console.WriteLine("3 : Password");

                                int updateTeacher = int.Parse(Console.ReadLine());

                                if (teacher != null)
                                {
                                    if (updateTeacher == 1)
                                    {
                                        Console.Write("Enter New Name: ");
                                        string teacherName = Console.ReadLine();
                                        teacher.Name = teacherName;
                                        context.SaveChanges();
                                        Console.WriteLine("Name Updated");
                                    }
                                    else if (updateTeacher == 2)
                                    {
                                        Console.Write("Enter New Username: ");
                                        string stuUsername = Console.ReadLine();
                                        teacher.UserName = teacherUsername;
                                        context.SaveChanges();
                                        Console.WriteLine("Username Updated");
                                    }
                                    else if (updateTeacher == 3)
                                    {
                                        Console.Write("Enter New Password: ");
                                        string teacherPassword = Console.ReadLine();
                                        teacher.Password = teacherPassword;
                                        context.SaveChanges();
                                        Console.WriteLine("Password Updated");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a vlaid Username!");
                                }


                            }
                            // Update data of an existing teacher

                            // Back
                            else if (TeacherValue == 4)
                            {
                                break;
                            }

                            //Main menu
                            else if (TeacherValue == 5)
                            {
                                mainmenu = 1;

                            }

                            //exit
                            else if (TeacherValue == 6)
                            {
                                Console.WriteLine("Thank You");
                                exit = 1;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option!");
                            }
                        }

                    }
                    // End of teacher Database


                    // Start of course Database
                    else if (adminValue == 3)
                    {
                        while (mainmenu == 0 && exit == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Select an option: ");
                            Console.WriteLine("1 : Add a Course");
                            Console.WriteLine("2 : Remove a Course");
                            Console.WriteLine("3 : Update Data of a Course");
                            Console.WriteLine("4 : Set Class Schedule for a Course");
                            Console.WriteLine("5 : Assign Students to a Course");
                            Console.WriteLine("6 : Assign Teacher to a Course");
                            Console.WriteLine("7 : Back to previous option");
                            Console.WriteLine("8 : Main Menu");
                            Console.WriteLine("9 : Exit");

                            Console.Write("Enter your option: ");
                            int courseValue = int.Parse(Console.ReadLine());

                            Course course = new Course();
                            DataBaseContext context = new DataBaseContext();

                            // Add a course
                            if (courseValue == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Add a course: ");

                                Console.Write("Enter course Name: ");
                                string courseName = Console.ReadLine();
                                course.CourseName = courseName;
                                Console.Write("Enter Fees: ");
                                int courseFees = int.Parse(Console.ReadLine());
                                course.Fees = courseFees;


                                context.Courses.Add(course);
                                context.SaveChanges();
                                Console.WriteLine("Course Added!");

                                continue;
                            }
                            // End of add a course

                            // Remove a course
                            else if (courseValue == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Remove a course: ");

                                Console.Write("Enter course name: ");
                                string courseName = Console.ReadLine();

                                course = context.Courses.Where(x => x.CourseName == courseName).FirstOrDefault();
                                if (course != null)
                                {
                                    context.Courses.Remove(course);
                                    context.SaveChanges();
                                    Console.WriteLine("Course Removed");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Course Name");
                                }
                                continue;
                            } 
                            //End of remove a course


                            // Update data of an existing course
                            else if (courseValue == 3)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Update Course Data: ");

                                Console.Write("Enter Course Name : ");
                                string courseName = Console.ReadLine();

                                course = context.Courses.Where(x => x.CourseName == courseName).FirstOrDefault();

                                Console.WriteLine("Which Data do you want to update? ");
                                Console.WriteLine("1 : Course Name");
                                Console.WriteLine("2 : Fees");


                                int updateCourse = int.Parse(Console.ReadLine());

                                if (course != null)
                                {
                                    if (updateCourse == 1)
                                    {
                                        Console.Write("Enter New Course Name: ");
                                        string newCourseName = Console.ReadLine();
                                        course.CourseName = newCourseName;
                                        context.SaveChanges();
                                        Console.WriteLine("Course Name Updated");
                                    }
                                    else if (updateCourse == 2)
                                    {
                                        Console.Write("Enter New Fees: ");
                                        int newFees = int.Parse(Console.ReadLine());
                                        course.Fees = newFees;
                                        context.SaveChanges();
                                        Console.WriteLine("Fees Updated");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Please enter a valid option!");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a valid Username!");
                                }


                            }
                            // End of Update data of a course


                            // Set Class Schedule for a course
                            else if (courseValue == 4)
                            {

                                Console.WriteLine("");
                                Console.WriteLine("Set Class Schedule for a course: ");
                                Console.Write("Enter Course Name: ");
                                string courseName = Console.ReadLine();
                                Course existingCourse = context.Courses.Where(x => x.CourseName == courseName).FirstOrDefault();
                                if (existingCourse != null)
                                {
                                    Console.Write("Enter Day: ");
                                    string classDay = Console.ReadLine();
                                    Console.Write("Enter Class Starting Time: ");
                                    DateTime classTime = Convert.ToDateTime(Console.ReadLine());
                                    string classTimeStirng1 = classTime.ToShortTimeString();
                                    Console.Write("Enter Class Ending Time: ");
                                    classTime = Convert.ToDateTime(Console.ReadLine());
                                    string classTimeStirng2 = classTime.ToShortTimeString();
                                    Console.Write("Enter total number of classes: ");
                                    int classNumber = int.Parse(Console.ReadLine());
                                    //ClassSchedule Schedule = new ClassSchedule(); 
                                    existingCourse.ClassSchedules = new List<ClassSchedule>
                                    {
                                        new ClassSchedule{Day = classDay, StartingTime = classTimeStirng1, EndingTime = classTimeStirng2, TotalNumberOfClasses = classNumber}
                                    };


                                    //context.ClassSchedules.Add(Schedule);
                                    context.SaveChanges();
                                    Console.WriteLine("Class Schedule Added");
                                }
                                else
                                {
                                    Console.WriteLine("Enter a valid Course Name!");
                                }
                            }
                            // End of set class schedule

                            // Assign Student to a course
                            else if (courseValue == 5)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Enter Students to a Course");
                                Console.Write("Enter the Course Name: ");
                                string courseName = Console.ReadLine();
                                Course existingCourse = context.Courses.Where(x => x.CourseName == courseName).Include(y => y.ClassSchedules).FirstOrDefault();
                                if (existingCourse != null)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("\nSelect an Option:");
                                        Console.WriteLine($"1 : Assign a student to course {courseName}");
                                        Console.WriteLine("2 : Back");
                                        Console.Write("Enter an Option: ");
                                        int No = int.Parse(Console.ReadLine());
                                        if (No == 1)
                                        {
                                            Console.Write("Enter the Username of a student: ");
                                            string stuUsername = Console.ReadLine();
                                            Student existingStudent1 = context.Students.Where(x => x.UserName == stuUsername).FirstOrDefault();


                                            if (existingStudent1 != null)
                                            {
                                                CourseStudent courseStudent1 = new CourseStudent();
                                                courseStudent1.Student = existingStudent1;
                                                Console.Write("Enter Enroll Date (YYYY-MM-DD): ");
                                                DateTime enrollDate = Convert.ToDateTime(Console.ReadLine());
                                                courseStudent1.EnrollDate = enrollDate;

                                                existingCourse.Students = new List<CourseStudent>();
                                                existingCourse.Students.Add(courseStudent1);
                                                context.SaveChanges();
                                                Console.WriteLine("Student Assigned");
                                                No--;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Enter a valid Student Username");
                                            }
                                        }
                                        else if (No == 2) break;
                                        else Console.WriteLine("Please Enter a Valid Option.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Enter a valid Course Name");
                                }
                            }
                            // End of assign students


                            // Assign teacher to a course
                            else if (courseValue == 6)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Assign Teachers to a Course");
                                Console.Write("Enter the Course Name: ");
                                string courseName = Console.ReadLine();
                                Course existingCourse = context.Courses.Where(x => x.CourseName == courseName).Include(y => y.ClassSchedules).FirstOrDefault();
                                if (existingCourse != null)
                                {
                                    

                                    while (true)
                                    {
                                        Console.WriteLine("\nSelect an Option:");
                                        Console.WriteLine($"1 : Assign a teacher to course {courseName}");
                                        Console.WriteLine("2 : Back");
                                        Console.Write("Enter an Option: ");
                                        int No = int.Parse(Console.ReadLine());
                                        if (No == 1)
                                        {
                                            Console.Write("Enter the Username of a teacher: ");
                                            string teacherUsername = Console.ReadLine();
                                            Teacher existingTeacher1 = context.Teachers.Where(x => x.UserName == teacherUsername).FirstOrDefault();


                                            if (existingTeacher1 != null)
                                            {
                                                CourseTeacher courseTeacher1 = new CourseTeacher();
                                                courseTeacher1.Teacher = existingTeacher1;


                                                existingCourse.Teachers = new List<CourseTeacher>();
                                                existingCourse.Teachers.Add(courseTeacher1);
                                                context.SaveChanges();
                                                Console.WriteLine("Teacher Assigned");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Enter a valid Teacher Username");
                                            }
                                        }
                                        else if (No == 2) break;
                                        else Console.WriteLine("Please Enter a Valid Option.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Enter a valid Course Name");
                                }
                            }
                            //End of assign teacher

                            //back
                            else if (courseValue == 7)
                            {
                                break;
                            }

                            //main menu
                            else if (courseValue == 8)
                            {
                                mainmenu = 1;

                            }

                            //exit
                            else if (courseValue == 9)
                            {
                                Console.WriteLine("Thank You");
                                exit = 1;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option!");
                            }
                        }
                    }

                    //main menu
                    else if (adminValue == 4)
                    {
                        mainmenu = 1;
                    }

                    //exit
                    else if (adminValue == 5)
                    {
                        Console.WriteLine("Thank You");
                        exit = 1;
                    }
                    
                    else
                    {
                        Console.WriteLine("Please Enter a valid Option");
                        continue;
                    }
                }
 
            }
            else
            {
                Console.WriteLine("Incorrect Username or Password!");
            }
        }
    }
    // End of Admin Section

    // Teacher Section Start
    else if (value == 2)
    {

        Console.WriteLine("");
        Console.WriteLine("Welcome to the teacher segment");
        Console.Write("Username : ");
        string teacherUsername = Console.ReadLine();
        Console.Write("Password : ");
        string teacherPassword = Console.ReadLine();

        Teacher teacher = new Teacher();
        DataBaseContext context = new DataBaseContext();
        teacher = context.Teachers.Where(x => x.UserName == teacherUsername && x.Password == teacherPassword).FirstOrDefault();

        if(teacher != null)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Select an Option: ");
                Console.WriteLine("1 : Course Attendence Report");
                Console.WriteLine("2 : Student's Individiual Attendence Report for a Course");
                Console.WriteLine("3 : Back");
                Console.Write("Enter Your Option: ");
                int teacherOption = int.Parse(Console.ReadLine());

                // Course Attendence Report
                if (teacherOption == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Which course attendence report do you want to see?");
                    Console.Write("Enter Course Name: ");
                    string courseName = Console.ReadLine();
                    Course existingCourse = context.Courses.Where(x => x.CourseName == courseName).FirstOrDefault();
                    if(existingCourse != null)
                    {
                        Console.WriteLine("");
                        dynamic existingCourse2 = context.Courses.Where(x => x.CourseName == courseName)
                        .Include(y => y.ClassSchedules)
                        .Include(z => z.Students)
                        .ThenInclude(i => i.Student)
                        .FirstOrDefault();

                        Console.WriteLine($"Course Name : {courseName}");
                        Console.WriteLine("");

                        foreach (var s in existingCourse2.Students)
                        {
                            // Console.WriteLine(s.Student.Name);
                            string stuName = s.Student.UserName;
                            Console.WriteLine("");
                            Console.WriteLine($"____{stuName}'s Attendence Report____");
                            Console.WriteLine("");
                           
                            List<AttendenceSheet> attendenceList = context.AttenantsSheets.Where(x => x.CourseName == courseName).ToList();
                            List<AttendenceSheet> attendenceSheet1 = context.AttenantsSheets.Where(x => x.CourseName == courseName && x.StudentName == stuName).ToList();
                            int j = 0;
                            string previous = "";
                            for (int i = 0; i < attendenceList.Count; i++)
                            {
                                if (attendenceList[i].Date != previous)
                                {
                                    previous = attendenceList[i].Date;
                                    if (j < attendenceSheet1.Count && attendenceSheet1[j].Date == attendenceList[i].Date)
                                    {
                                        Console.WriteLine($"{attendenceList[i].Date}  --->  ✓ ");
                                        j++;

                                    }
                                    else
                                    {
                                        Console.WriteLine($"{attendenceList[i].Date}  --->  X ");
                                    }
                                }
                            }
                            Console.WriteLine("-----------------------------------------");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid Course Name.");
                    }
                }

                //End of Course Attendence Report


                // Individual Attendence Report
                else if (teacherOption == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Which course attendence report do you want to see?");
                    Console.Write("Enter Course Name: ");
                    string courseName = Console.ReadLine();
                    Course existingCourse = context.Courses.Where(x => x.CourseName == courseName).FirstOrDefault();
                    if (existingCourse != null)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Which student's attendence report do you want to see?");
                        Console.Write("Enter student's Username: ");
                        string stuName = Console.ReadLine();
                        Student existingStudent = context.Students.Where(x => x.UserName == stuName).FirstOrDefault();
                        if (existingStudent != null)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"____{stuName}'s Attendence Report____");
                            Console.WriteLine("");
                            Console.WriteLine($"Course Name : {courseName}");
                            Console.WriteLine("");
                            List<AttendenceSheet> attendenceList = context.AttenantsSheets.Where(x => x.CourseName == courseName).ToList();
                            List<AttendenceSheet> attendenceSheet1 = context.AttenantsSheets.Where(x => x.CourseName == courseName && x.StudentName == stuName).ToList();
                            int j = 0;
                            string previous = "";
                            for (int i = 0; i < attendenceList.Count; i++)
                            {
                                if (attendenceList[i].Date != previous)
                                {
                                    previous = attendenceList[i].Date;
                                    if (j < attendenceSheet1.Count && attendenceSheet1[j].Date == attendenceList[i].Date)
                                    {
                                        Console.WriteLine($"{attendenceList[i].Date}  --->  ✓ ");
                                        j++;

                                    }
                                    else
                                    {
                                        Console.WriteLine($"{attendenceList[i].Date}  --->  X ");
                                    }
                                }
                            }
                            Console.WriteLine("-----------------------------------------");
                            //cnt = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please Enter a valid student's Username.");
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid course name.");
                        Console.WriteLine("");
                    }
                }
                //End of individiual attendence report

                //back
                else if (teacherOption == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter a valid Option");
                    Console.WriteLine("");

                }
            }
            
        }
        else
        {
            Console.WriteLine("Invalid Username or Password!!");
        }
    }
    // Teacher Section End


    // Student Section Start 
    else if (value == 3)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the student segment");
        Console.Write("Username : ");
        string stuUsername = Console.ReadLine();
        Console.Write("Password : ");
        string stuPassword = Console.ReadLine();

        Student student = new Student();
        DataBaseContext context = new DataBaseContext();
        student = context.Students.Where(x => x.UserName == stuUsername && x.Password == stuPassword).FirstOrDefault();
        if(student != null)
        {
            Console.WriteLine("");
            Console.WriteLine("Your Attendence Please");
            Console.Write("Enter Your Course Name: ");
            string courseName = Console.ReadLine();

            Course course = context.Courses.Where(x => x.CourseName == courseName).FirstOrDefault();
            int courseId = course.Id;

            int studentId = student.Id;

            
            //CourseStudent existingStudent = context.Courses.Where(x => x.Id == courseId && x.StudentId == studentId);
            //Student existingStudent1 = context.Courses.Where(x => x.Id == 1).FirstOrDefault(); 


            dynamic existingCourse2 = context.Courses.Where(x => x.CourseName == courseName)
                                             .Include(y => y.ClassSchedules)
                                             .Include(z => z.Students)
                                             .ThenInclude(i => i.Student)
                                             .FirstOrDefault();

            int findCourse = 0;
            foreach (var s in existingCourse2.Students)
            {
                
                if(s.Student.Id == studentId)
                {
                    findCourse = 1;
                    break;
                }
            } 

            if(findCourse == 0)
            {
                Console.WriteLine("You arn't a student of this course! Enter a valid Course.");
            }
            else
            {
                AttendenceSheet attendenceCount = new AttendenceSheet();
                DateTime now = DateTime.Now;
                string day = now.DayOfWeek.ToString();
                string time = now.ToString("t");
                string date = now.ToString("d");
                time = DateTime.ParseExact("01:00 PM", "h:mm tt", CultureInfo.InvariantCulture).ToString("HH:mm");
                //Console.WriteLine(date);
                int findDay = 0;
                int onTime = 0;


                Course existingCourse = context.Courses.Where(x => x.CourseName == courseName).Include(y => y.ClassSchedules).FirstOrDefault();
                //Console.WriteLine($"{stuUsername}");

                foreach (var s in existingCourse.ClassSchedules)
                {
                    
                   if(String.Compare(s.Day, day) == 0)
                    {
                        findDay = 1;
                    }

                    string sT = s.StartingTime;
                    string sE = s.EndingTime;
                    sT = DateTime.ParseExact("01:00 PM", "h:mm tt", CultureInfo.InvariantCulture).ToString("HH:mm");
                    sE = DateTime.ParseExact("01:00 PM", "h:mm tt", CultureInfo.InvariantCulture).ToString("HH:mm");

                    if (String.Compare(time, sT) >=0 && String.Compare(time, sE) <= 0)
                    {
                        onTime = 1;
                    }
                }
                //Console.WriteLine(findDay);
                //Console.WriteLine(onTime);
                if (onTime == 1 && findDay == 1)
                {
                    AttendenceSheet newAttendence = new AttendenceSheet();
                    newAttendence.StudentId = studentId;
                    newAttendence.CourseId = courseId;
                    newAttendence.CourseName = courseName;
                    newAttendence.StudentName = stuUsername;
                    newAttendence.Date = date;

                    context.AttenantsSheets.Add(newAttendence);
                    context.SaveChanges();

                    Console.WriteLine("Your Attendence has been recorded!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Your Class is not helding at this moment!");
                    Console.WriteLine("");
                }

            }



        }
        else
        {
            Console.WriteLine("Invalid Username or Password!!");
        }
    }

    //Student Section End
    else if(value == 4)
    {
        Console.WriteLine("Thank You");
        exit = 1;
    }
    else
    {
        Console.WriteLine("Please Enter a valid option!");
    }
}