namespace AS2627._3F.MarioBuononato.Calcolatrice;

class Program
{
    static void Main(string[] args)
    {
        int numero1,numero2;
        int risultato = 0,resto = 0;
        string operazione;
        bool operazioneCorretta = true;
        Console.WriteLine("inserisci l'operazione tra: \n< Addizione: + >\n < Sottrazione: - >\n < Moltiplicazione: * >\n < Divisione: / >\n < Potenza: ^ >\n < valore assoluto: | >\n ");
        operazione = Console.ReadLine();
        if(operazione == "|")
        {
            Console.WriteLine("inserisci un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if(numero1<0) risultato = numero1 * (-1);
            else Console.WriteLine($"Il numero {numero1} è già positivo");
            Console.WriteLine($"il numero assoluto di {numero1} è: {risultato}");
        }
        else
        {
            Console.WriteLine("Inserisci i 2 numeri interi: ");
            numero1=Convert.ToInt32(Console.ReadLine());
            numero2=Convert.ToInt32(Console.ReadLine());
            switch(operazione)
            {
                case "+":
                    risultato = numero1 + numero2;
                    break;
                case "-":
                    risultato = numero1 - numero2;
                    break;
                case "*":
                    risultato = numero1 * numero2;
                    break;
                case "/":
                    if(numero2 == 0)
                    {
                        Console.WriteLine("Il risultato è tendente all'infinito");
                        operazioneCorretta = false;
                    }
                    else
                    {
                        risultato = numero1 / numero2;
                        resto = numero1 % numero2;
                    }
                    break;
                case "^":
                    risultato = Math.Pow(numero1, numero2);
                    break;
                default:
                    Console.WriteLine("Il carattere che hai inserito non è un'operazione");
                    operazioneCorretta=false;
                    break;
            }
        }
        if(operazioneCorretta)
        {
            if(operazione == "/")
            {
                Console.WriteLine($"Il risultato è: {risultato} il resto è: {resto}");
            }
            else
            {
                Console.WriteLine($"Il risultato è uguale a: {risultato}");
            }
        }
    }    
}
