using System;
public class Program{

    public delegate void ExibirNumero(int num);
    public static void ImprimeNumero(int numero){
        Console.WriteLine("O numero é: " + numero);
    }

    public static void MediaNota(int nota){
        if(nota < 60){
            Console.WriteLine("Reprovado com a nota:" + nota);
        } else {
            Console.WriteLine("Aprovado com a nota:" + nota);
        }
    }

    public static void ExibirQuadrado(int numero){
        Console.WriteLine("O quadrado do numero" + numero + " é: " + numero*numero);
    }
    
    public static void Main(){
        ExibirNumero meuDelegate = ImprimeNumero;
        meuDelegate(10);

        meuDelegate += ExibirQuadrado;
        meuDelegate(2);

        meuDelegate += delegate (int num){
            Console.WriteLine("O dobro do numero" + num + " é: " + (num*2));
        };
        meuDelegate(3);

        Pessoa objPessoa = new Pessoa ("Lucas", 57);
        meuDelegate += MediaNota;

        meuDelegate(objPessoa.Nota);
    }

}
