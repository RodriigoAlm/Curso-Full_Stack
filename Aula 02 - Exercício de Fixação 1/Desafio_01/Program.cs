DateTime agora = DateTime.Now;

int dia = agora.Day;
int hora = agora.Hour;
int minuto = agora.Minute;
int segundo = agora.Second;

dia = dia * 86400;
hora = hora * 3600;
minuto = minuto * 60;

double resultado = dia + hora + minuto + segundo;

Console.WriteLine($"\nSeus dias em minutos é igual a {resultado} de segundos.\n");
