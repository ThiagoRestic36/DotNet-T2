// See https://aka.ms/new-console-template for more information
Console.WriteLine("Questão 02. Tipos de Dados:");

/*
sbyte armazena valores de -128 a 127
byte armazena valores de 0 a 255
short armazena valores de -32768 a 32767
ushort armazena valores de 0 a 65535
int armazena valores de -2147483648 a 2147483647
uint armazena valores de 0 a 4294967295
long armazena valores de -9223372036854775808 a 9223372036854775807
ulong armazena valores de 0 a 18446744073709551615
*/
int tipoInteiro = int.MaxValue;
int tipoInteiro2 = int.MinValue;
sbyte ValorMi = sbyte.MinValue;
sbyte maxValue = sbyte.MaxValue;
byte maxbyte = byte.MaxValue;
byte minbyte = byte.MinValue;
short maxsh = short.MaxValue;
short minsh = short.MinValue;
ushort maxus = ushort.MaxValue;
ushort minus = ushort.MinValue;
uint maxui = uint.MaxValue;
uint minui = uint.MinValue;
long maxlo = long.MaxValue;
long minlo = long.MinValue;
ulong maxul = ulong.MaxValue;
ulong minul = ulong.MinValue;
//Exemplo

Console.WriteLine("Valor maximo de int: " + tipoInteiro);
Console.WriteLine("Valor minimo de tipo int: " + tipoInteiro2);
Console.WriteLine("O valor mínimo de sbyte é: " + ValorMi);
Console.WriteLine("O valor máximo de sbyte é: " + maxValue);
Console.WriteLine("O valor máximo de um byte é: " + maxbyte);
Console.WriteLine("O valor mínimo de um byte é: " + minbyte);
Console.WriteLine("O valor máximo de um short é: " + maxsh);
Console.WriteLine("O valor mínimo de um short é: " + minsh);
Console.WriteLine("O valor máximo de um ushort é: " + maxus);
Console.WriteLine("O valor mínimo de um ushort é: " + minus);
Console.WriteLine("O valor máximo de um uint é: " + maxui);
Console.WriteLine("O valor mínimo de um uint é: " + minui);
Console.WriteLine("O valor máximo de um long é: " + maxlo);
Console.WriteLine("O valor mínimo de um long é: " + minlo);
Console.WriteLine("O valor máximo de um ulong é: " + maxul);
Console.WriteLine("O valor mínimo de um ulong é: " + minul);