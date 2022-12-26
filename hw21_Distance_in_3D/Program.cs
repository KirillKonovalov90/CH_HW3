                                                  //Программа для вычисления расстояния между 2мя точками в трехмерном пространстве
                                                  //Использовал подсказанный Вами метод ввода, очень удобно, спасибо :)

double DistanceBetweenDots(int dotA0, int dotA1, int dotA2, int dotB0, int dotB1, int dotB2)
 {
     double AB;
     int[] A = new int[] {dotA0, dotA1, dotA2};
     int[] B = new int[] {dotB0, dotB1, dotB2};
     AB = Math.Sqrt(((A[0] - B[0]) * (A[0] - B[0])) + ((A[1] - B[1]) * (A[1] - B[1])) + ((A[2] - B[2]) * (A[2] - B[2])));
     return AB;
 }

Console.Write("Введите координаты точки A через пробел: ");
var dotA = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

Console.Write("Введите координаты точки B через пробел: ");
var dotB = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

Console.WriteLine(DistanceBetweenDots(dotA[0], dotA[1], dotA[2], dotB[0], dotB[1], dotB[2]));