Console.Clear();
//e meio que uma string so que diferente.
double m, cm, km;
Console.Write("Entre com a medida (em metros): ");
//converte (Convert.ToDouble)um valor de um tipo de dado para um número de ponto flutuante.
m = Convert.ToDouble(Console.ReadLine());
//pelo que endenti ele cria uma forma de calculo entre cm km e m
cm = m *100;
km = m /1000;
Console.WriteLine("--- Equivalência ---");
Console.WriteLine($"{m} m");
Console.WriteLine($"{cm} cm");
Console.WriteLine($"{km} km");
