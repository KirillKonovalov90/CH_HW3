                                                  //Программа для вычисления расстояния между 2мя точками в трехмерном пространстве
                                                  //Использовал подсказанный Вами метод ввода, очень удобно, спасибо :)

double DistanceBetweenDots(int[] A, int[] B)
 {
     double AB;
     AB = Math.Sqrt(((A[0] - B[0]) * (A[0] - B[0])) + ((A[1] - B[1]) * (A[1] - B[1])) + ((A[2] - B[2]) * (A[2] - B[2])));
     return AB;
 }

Console.Write("Введите координаты точки A через пробел: ");
var dotA = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

Console.Write("Введите координаты точки B через пробел: ");
var dotB = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

Console.WriteLine(DistanceBetweenDots(dotA, dotB));