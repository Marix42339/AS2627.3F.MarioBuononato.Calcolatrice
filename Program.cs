namespace AS2627._3F.MarioBuononato.Calcolatrice;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
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
=======
        Console.WriteLine("MarioBuononato.3F.29/10/26.Calcolatrice.in classe");
        Console.WriteLine("Dati 2 numeri e l'operazione forniti dall'utente calcolare il risultato");

        int n1,n2;
        int operazione,risultato=0,resto=0;
        bool operazioneCorretta=true;
        Console.WriteLine("inserisci l'operazione tra: \n+ = 1\n- = 2\nx = 3\n: = 4\n");
        operazione=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci i 2 numeri: ");
        n1=Convert.ToInt32(Console.ReadLine());
        n2=Convert.ToInt32(Console.ReadLine());
        switch(operazione)
        {
            case 1:
                risultato=n1+n2;
                break;
            case 2:
                risultato=n1-n2;
                break;
            case 3:
                risultato=n1*n2;
                break;
            case 4:
                if(n2==0)
                {
                    Console.WriteLine("Il risultato è tendente all'infinito");
                    operazioneCorretta=false;
                }
                else
                {
                    risultato=n1/n2;
                    resto=n1%n2;
                }
                break;
            default:
                Console.WriteLine("l'opzione che hai inserito sulle operazioni non è nell'elenco");
                operazioneCorretta=false;
                break;
        }
        if(operazioneCorretta)
        {
            if(operazione==4) Console.WriteLine($"Il risultato è: {risultato} il resto è: {resto}");
            else Console.WriteLine($"Il risultato è uguale a: {risultato}");
>>>>>>> fffd1df86907eda0ccb861105403c0441b6d3339
        }
    }    
}
