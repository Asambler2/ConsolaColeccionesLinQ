

using ConsolaColeccionesLinQ;

int[] ElArray = [5,2,67,123,4,9,23];

var consulta = from numero in ElArray.Distinct() where (numero % 2 == 0 && numero > 1) orderby numero descending select numero;

ElArray.Append(8);

foreach (int elNumero in consulta)
{
    Console.WriteLine(elNumero);
}

List<Tablon> Balsa = 
[
    new Tablon() {dureza = 8 , madera = "Pino"},
    new Tablon() {dureza = 20 , madera = "Roble"},
    new Tablon() {dureza = 16 , madera = "Abedul"}
];

var consulta2 = from item in Balsa where (item.dureza > 2) orderby (item.madera) select (item);

IEnumerable<string> consulta3;
consulta3 = Balsa.Where (item => item.dureza > 15).OrderBy (item => item.madera).Select (item => item.madera);

foreach (string madera in consulta3)
{
    Console.WriteLine(madera);
}

foreach (Tablon tabla in consulta2)
{
    Console.WriteLine(tabla.dureza);
    Console.WriteLine(tabla.madera);
}