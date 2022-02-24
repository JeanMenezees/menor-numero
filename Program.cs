using calc;

var calculadora = new Calculadora();
var numeros = new List<decimal> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

var resultado = calculadora.CacularMmc(numeros);

Console.WriteLine("O menor número divisível pelos numeros de 1 a 20 é: " + resultado);