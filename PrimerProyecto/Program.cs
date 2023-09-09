// See https://aka.ms/new-console-template for more information


//1. Hola Mundo
Console.WriteLine("Hola Mundo en C#");

// 2. Ingreso de Datos
String nombre;
Console.WriteLine("Ingresa tu nombre");
nombre =Console.ReadLine();
Console.WriteLine("El nombre ingresado es {0}",nombre);

// 3. Calculadora
Decimal primerNumero,segundoNumero, resultadoSuma, resultadoResta, resultadoMulti, resultadoDiv;
Console.WriteLine("Ingresa el primer número");
primerNumero = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el segundo número");
segundoNumero = Decimal.Parse(Console.ReadLine());

resultadoSuma = primerNumero + segundoNumero;
Console.WriteLine("La suma es: {0}", resultadoSuma);

resultadoResta = primerNumero - segundoNumero;
Console.WriteLine("La resta es: {0}", resultadoResta);

resultadoMulti = primerNumero * segundoNumero;
Console.WriteLine("La multiplicación es: {0}", resultadoMulti);

resultadoDiv = primerNumero / segundoNumero;
Console.WriteLine("La División es: {0}", resultadoDiv);

