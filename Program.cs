// See https://aka.ms/new-console-template for more information
Console.WriteLine("** DESCUENTO DE UN PRODUCTO **");
Console.WriteLine(" ");

double precio;
int cantidad;

Console.WriteLine("Ingrese el precio del producto: C$");
precio=double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad a solicitar del producto: ");
cantidad=int.Parse(Console.ReadLine());

double importe = precio * cantidad;
double descuento = 11 / 100 * importe;

Console.WriteLine("El importe es de: "+importe.ToString("0.00"));
Console.WriteLine("El importe con descuento es de: "+descuento.ToString("0.00"));
