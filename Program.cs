namespace AS2627._3F.MarioBuononato.Calcolatrice;

class Program
{
    static void Main(string[] args)
    {
        int numero1,numero2;
        double risultato = 0;
        int resto = 0;
        string operazione;
        bool operazioneCorretta = true;
        Console.WriteLine("inserisci l'operazione tra: \n< Addizione: + >\n < Sottrazione: - >\n < Moltiplicazione: * >\n < Divisione: / >\n < Potenza: ^ >\n < valore assoluto: | >\n < fattoriale: ! >");
        operazione = Console.ReadLine();
        if(operazione == "|" || operazione == "!")
        { 
            Console.WriteLine("inserisci un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            if(operazione == "|")
            {
                if(numero1<0) 
                {
                risultato = -(numero1);  
                }
                else 
                {
                Console.WriteLine($"Il numero {numero1} è già positivo");
                risultato = numero1;
                }
            }
            else
            {
                if(numero1<0)
                {
                    Console.WriteLine("Il fattoriale non è definito per numeri negativi.");
                    operazioneCorretta = false;
                }
                else
                {
                risultato = 1;
                for(int i=1; i<=numero1; i++)
                {
                    risultato *= i;
                }
                }
            }
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
                    risultato = 1;
                    if(numero2 >= 0)
                    {
                        for(int i=1; i<=numero2; i++)
                        {   
                        risultato *= numero1;
                        }
                    }
                    else
                    {
                        if (numero1 == 0 )
                        {
                        Console.WriteLine("Errore: non è possibile elevare 0 a una potenza negativa.");
                        operazioneCorretta = false;
                        }
                        else
                        {
                        for (int i = -1; i >= numero2; i--)
                        {
                            risultato *= numero1;
                        }
                        risultato = 1.0 / risultato;
                        }
                    }
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
                Console.WriteLine($"Il risultato è: {risultato:0.###} il resto è: {resto}");
            }
            else
            {
                Console.WriteLine($"Il risultato è uguale a: {risultato:0.###}");
            }
        }
    }
}