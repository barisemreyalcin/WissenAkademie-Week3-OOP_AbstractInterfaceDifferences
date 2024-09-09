// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StaticClassSample;

Mathematics.Sum(2, 5); // static method

Mathematics math = new Mathematics();
math.Sums(5, 2, 5); // static method değil
Console.WriteLine(Mathematics.Pi); // Değişmeden önceki değer (Constructor içindeki atamayı yok varsay)

//Console.WriteLine(Mathematics.Pi); // Instance olmadan ulaşım sağladım

Mathematics math1 = new Mathematics();
Mathematics math2 = new Mathematics();

Console.WriteLine(Mathematics.Pi); // Değişmeden önceki değer (Constructor içindeki atamayı yok varsay)
math1.ChangePi(3); // Kalıcı değişiklik (Constructor içindeki atamayı yok varsay)
Mathematics math3 = new Mathematics();
Mathematics math4 = new Mathematics();
Console.WriteLine(Mathematics.Pi); // Değişimden sonraki değer (Constructor içindeki atamayı yok varsay)