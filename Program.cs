// int[] scores = { 45, 90, 30, 75, 60, 20 };
// int passingScore = 60;
// int PassedCount = 0;
// foreach (int score in scores)
// {
//     if (score >= passingScore)
//     {
//         PassedCount++;
//     }
// }
// int[] passed = new int[PassedCount];
// int index = 0;
// foreach (int score in scores)
// {
//     if (score >= passingScore)
//     {
//         passed[index] = score;
//         index++;
//     }
// }
// foreach (int score in passed)
// {
//     Console.WriteLine(score);
// }
// int studentCount = 0;
// for (int i=0; i < scores.Length;i++)
// {
//     if (scores[i] < passingScore)
//     {
//         studentCount++;
//     }
// }
// Console.WriteLine($"несдало {studentCount}");

// int[,] grades = {
//     { 4, 5, 3 },
//     { 5, 5, 4 },
//     { 3, 4, 4 }
// };
// int bestStudent = 0;
// double highestAverage = 0;
// for (int student = 0; student < grades.GetLength(0); student++) {
//     int sum = 0;
//     for (int subject = 0; subject < grades.GetLength(1); subject++) {
//         sum += grades[student, subject];
//     }
//     double average = (double)sum / grades.GetLength(1);
//     Console.WriteLine($"Студент {student + 1}: средний балл {average}");
//     if (average > highestAverage) {
//         highestAverage = average;
//         bestStudent = student + 1;
//     }
// }
// Console.WriteLine($"Лучший студент: {bestStudent} (средний балл: {highestAverage})");

// string[] subjects = { "Численные методы", "Архитектура аппаратных средств", "Физическая культура" };
// string[] backup = new string[subjects.Length];
// Array.Copy(subjects, backup, subjects.Length);
// subjects[0] = "Основы алгоритмизации и программирования";
// Console.WriteLine(backup[0]);