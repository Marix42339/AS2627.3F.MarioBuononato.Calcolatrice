namespace AS2627._3F.MarioBuononato.Calcolatrice;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("MarioBuononato.3F.29/10/26.Calcolatrice.in classe");
        Console.WriteLine("Dati 2 numeri e l'operazione forniti dall'utente calcolare il risultato");

=======
>>>>>>> be2a8389d92f0ff54cb778ceee7ac9bee2751336
        int n1,n2;
        int operazione,risultato=0,resto=0;
        bool operazioneCorretta=true;
        Console.WriteLine("inserisci l'operazione tra: \n+ = 1\n- = 2\nx = 3\n: = 4\n");
        operazione=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci i 2 numeri: ");
        n1=Convert.ToInt32(Console.ReadLine());
        n2=Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD
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
=======
        switch(operazione){
            case 1:{
            risultato=n1+n2;
            break;
            }
            case 2:{
            risultato=n1-n2;
            break;
            }
            case 3:{
            risultato=n1*n2;
            break;
            }
            case 4:{
            if(n2==0){
                Console.WriteLine("Il risultato è tendente all'infinito");
                operazioneCorretta=false;
            }
            else{
                risultato=n1/n2;
                resto=n1%n2;
            }
            break;
            }
            default:{
            Console.WriteLine("l'opzione che hai inserito sulle operazioni non è nell'elenco");
            operazioneCorretta=false;
            break;
            }
        }
        if(operazioneCorretta){
            if(operazione==4){
                Console.WriteLine($"Il risultato è: {risultato} il resto è: {resto}");
                }
            else{
                Console.WriteLine($"Il risultato è uguale a: {risultato}");
                }
>>>>>>> be2a8389d92f0ff54cb778ceee7ac9bee2751336
        }
    }    
}
