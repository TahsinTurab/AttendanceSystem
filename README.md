# AttendanceSystem_Console_Application
This is a console Based Attendance System using C#

The system will initially ask for username and password.
There will be three types of users.
      - Admin
      - Teacher
      - Student
      
Features:     
      1. Admin can login and create:
            - Teacher (Name, Username, Password)
            - Course (Course Name, Fees)
            - Student (Name, Username, Password)
      2. Admin can assign a teacher in a course
      3. Admin can assign students in a course.
      4. Admin can set class schedule for a course
        Class schedule consists of day and time and total number of classes.
        For example, Sunday 8PM - 10PM, Monday 7PM - 9PM, 20 Classes.
              
      5. Students can login and give attendance in the course he/she is enrolled in.
      6. Students can’t give attendance outside of date & class time.
      7. Teachers can check attendance reports of any course
         Report will contain the Student name, and check mark on each class date if the student is present or cross if the student was absent. 

All features are done in a console based program using a database.
