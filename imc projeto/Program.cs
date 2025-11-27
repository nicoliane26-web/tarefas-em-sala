using System.ComponentModel.Design;

double pesoEmKg;
double alturaEmMetros;
double imc;

Console.WriteLine("Digite o peso: ");
pesoEmKg = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura:");
alturaEmMetros = Convert.ToDouble(Console.ReadLine());

if (alturaEmMetros == 0)
{
    Console.WriteLine("A altura deve ser maior que zero.");
    return;
}
double alturaAoQuadrado = alturaEmMetros * alturaEmMetros;

imc = pesoEmKg / alturaAoQuadrado;

double imcFormatado = Math.Round(imc, 2);

Console.WriteLine($"O IMC calculado é: {imcFormatado}");

if (imcFormatado < 18.5)
{
    Console.WriteLine("Magro");
}else if (imcFormatado >= 18.5 && imcFormatado <= 24.9)
{
    Console.WriteLine("Normal");
}
else if (imcFormatado >= 25.0 && imcFormatado <= 29.9)
{
    Console.WriteLine("Sobrepeso");

}
else
{
    Console.WriteLine("Obesidade");

}
