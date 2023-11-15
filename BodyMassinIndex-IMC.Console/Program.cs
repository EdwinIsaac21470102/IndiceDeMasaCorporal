using BodyMassIndex.Models;

string? nombre;
double peso;
double estatura;
double imc;

Persona persona;

Console.WriteLine("Aplicacion que calcule el indice de masa corporal de una persona ");

//Obtener datos de entrada 
//Datos a obtener: Nombre, Peso y la estatura de la persona 
Console.WriteLine("Proporcione el nombre de la persona: "); 
nombre = Console.ReadLine();

peso = ReadDouble("Proporcione el peso de la persona en Kilogramos: ");

estatura = ReadDouble("Proporcione la estatura en metros de la persona: ");

persona = new Persona(nombre, peso, estatura);

//Calcular indice de masa corporal 
imc = CalculadoraIMC.IndiceDeMasaCorporal(persona.Peso, persona.Estatura);

Console.WriteLine($"El indice de masa corporal de {nombre}: {imc:F4}");

//determinar la situacion nutricional de la persona 
Console.WriteLine($"La situacion nutricional de {persona.Nombre} es {CalculadoraIMC.SituacionNutricionalComoTexto(imc)}");

double ReadDouble(string s)
{
    Console.WriteLine(s);
    string? linea = Console.ReadLine();
    return Convert.ToDouble(linea);
}
