

using System.Runtime.InteropServices.JavaScript;
using EjerciciosLinQ;

int[] arrayDeEnteros = [1, 4, 5, 6, 1, 2, 6, 7];

Console.WriteLine("1.Mostrar aquellos que son mayores que 2");

var MayorDos =  from numero in arrayDeEnteros where numero > 2 select numero;

foreach (int digito in MayorDos)
{
    Console.WriteLine(digito + ", ");
}

Console.WriteLine("2. Mostrar aquellos que son menores que 5");

var MenorCinco = from numero in arrayDeEnteros where numero < 5 select numero;

foreach (int digito in MenorCinco)
{
    Console.WriteLine(digito + ", ");
}

Console.WriteLine("3. Mostrar aquellos que son mayores que 2 pero ordenados de mayor a menor.");

var MayorDosDescending = from numero in arrayDeEnteros where numero > 2 orderby numero descending select numero;

foreach (int digito in MayorDosDescending)
{
    Console.WriteLine(digito + ", ");
}

Console.WriteLine("4. Mostrar aquellos números que son únicos.");

var Distintos = from numero in arrayDeEnteros.Distinct() select numero;

foreach (int digito in Distintos)
{
    Console.WriteLine(digito + ", ");
}

Console.WriteLine("5. Mostrar los números pares.");

var Pares = from numero in arrayDeEnteros where numero % 2 == 0 select numero;

foreach (int digito in Pares)
{
    Console.WriteLine(digito + ", ");
}

Console.WriteLine("6. Mostrar los números pares mayores de 4 ordenados de menor a mayor");

var PareMayoresCuatros = from numero in arrayDeEnteros where numero % 2 == 0 && numero > 4 orderby numero select numero;

foreach (int digito in PareMayoresCuatros)
{
    Console.WriteLine(digito + ", ");
}

string[] arrayDeCadenas = ["Alberto", "Jacinto", "Adrian", "Merche", "Eva", "Maria"];

Console.WriteLine("1. Ordenar la lista alfabeticamente.");

var Ordenados = from cadena in arrayDeCadenas  orderby cadena select cadena;

foreach (string cadena in Ordenados)
{
    Console.WriteLine(cadena + ", ");
}

Console.WriteLine("2. Ordenar la lista alfabeticamente al reves.");

var Descen = from cadena in arrayDeCadenas orderby cadena descending select cadena;

foreach (string cadena in Descen)
{
    Console.WriteLine(cadena + ", ");
}
Console.WriteLine("3. Ordenar la lista por el número de caracteres de cada palabra.");

var NumChar = from cadena in arrayDeCadenas orderby cadena.Length select cadena;

foreach (string cadena in NumChar)
{
    Console.WriteLine(cadena + ", ");
}

Console.WriteLine("4. Seleccionar aquellas cadenas que comiencen por a y terminen por o u n.");

var Indice = from cadena in arrayDeCadenas where cadena.ToLower().StartsWith('a') && (cadena.EndsWith('o') || cadena.EndsWith('n')) select cadena;

foreach (string cadena in Indice)
{
    Console.WriteLine(cadena + ", ");
}
Console.WriteLine("5. Seleccionar aquellas cadenas cuya longitud sea mas de 4 caracteres");

var Longitud = from cadena in arrayDeCadenas where cadena.Length > 4 select cadena;

foreach (string cadena in Longitud)
{
    Console.WriteLine(cadena + ", ");
}

List<Persona> Gente =
[
    new Persona() { nombre = "Manolo", fechaNacimiento = new DateTime(2011, 6, 10), sueldo = 2400 },
    new Persona() { nombre = "Ana", fechaNacimiento = new DateTime(1982, 7, 27), sueldo = 3200 },
    new Persona() { nombre = "Felipe", fechaNacimiento = new DateTime(1995, 6, 29), sueldo = 2100 },
    new Persona() { nombre = "Ambrosio", fechaNacimiento = new DateTime(1994, 6, 28), sueldo = 2000 },
    new Persona() { nombre = "Raquel", fechaNacimiento = new DateTime(2000, 5, 25), sueldo = 1500 },
    new Persona() { nombre = "Luisa ", fechaNacimiento = new DateTime(2002, 2, 20), sueldo = 1600 },
    new Persona() { nombre = "Ernesto ", fechaNacimiento = new DateTime(2010, 1, 10), sueldo = 600 }
];


Console.WriteLine("1.Ordenar la colección por sueldo de menos a más.");

var OrdenarSueldo = from persona in Gente orderby persona.sueldo select persona;

foreach (Persona persona in OrdenarSueldo)
{
    Console.WriteLine(persona.nombre + ", " + persona.fechaNacimiento + ", " + persona.sueldo);
}

Console.WriteLine("2. Seleccionar aquellos que sean mayores de edad.");

var MayoresEdad = from persona in Gente where (System.DateTime.Now.AddYears(-18) > persona.fechaNacimiento) select persona;

foreach (Persona persona in MayoresEdad)
{
    Console.WriteLine(persona.nombre + ", " + persona.fechaNacimiento + ", " + persona.sueldo);
}

Console.WriteLine("3. Ordenar por edad de más joven a menos joven.");

var OrdenarFecha = from persona in Gente orderby persona.fechaNacimiento descending select persona;

foreach (Persona persona in OrdenarFecha)
{
    Console.WriteLine(persona.nombre + ", " + persona.fechaNacimiento + ", " + persona.sueldo);
}

Console.WriteLine("4. Seleccionar aquellos cuyo nombre comienza por A o por E");

var PersonaIndice = from persona in Gente where persona.nombre.ToLower().StartsWith('a') || persona.nombre.ToLower().StartsWith('e') select persona;

foreach (Persona persona in PersonaIndice)
{
    Console.WriteLine(persona.nombre + ", " + persona.fechaNacimiento + ", " + persona.sueldo);
}
Console.WriteLine("5. Saber cual es el sueldo total.");

var SumaSueldo = from persona in Gente select persona;

double suma = 0;

foreach (Persona persona in SumaSueldo)
{
    suma += persona.sueldo;
}

Console.WriteLine("La suma es: " + suma);

Console.WriteLine("6. Saber cual es el sueldo medio.");

var SueldoMedio = from persona in Gente select persona;

double average = 0;

foreach (Persona persona in SueldoMedio)
{
    average += persona.sueldo;
}

average = Math.Round(average / SueldoMedio.Count(), 2);

Console.WriteLine("Sueldo medio: " + average);

Console.WriteLine("7. Ordenar por sueldo, para aquellos mayores de edad que tienen un sueldo par.");

var ordenar = from persona in Gente where persona.sueldo % 2 == 0 && (System.DateTime.Now.AddYears(-18) > persona.fechaNacimiento)  orderby persona.sueldo select persona;

foreach (Persona persona in ordenar)
{
    Console.WriteLine(persona.nombre + ", " + persona.fechaNacimiento + ", " + persona.sueldo);
}












