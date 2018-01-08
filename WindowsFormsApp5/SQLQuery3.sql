SELECT Teachers.Surname, Teachers.Name, Teachers.Patronymic, Courses.Course_Name, Marks.Mark
FROM Courses JOIN Marks ON Courses.Id_Course = Marks.Id_Course
JOIN Teachers ON Marks.Id_Teacher = Teachers.Id_Teacher
WHERE Marks.Id_Stud = 101