/*using System.Reflection.Metadata.Ecma335;

void Mensagem()
{
    Console.WriteLine("olá Mundo");
}

Mensagem();

void Escreva(string msg)
{
    Console.WriteLine(msg);
}

Escreva("Oi Laura");
Escreva("Deixa de ser retardada");
Escreva("tu so me humilha");



string minhaMsg = "Até mesmo variáveis";
Escreva(minhaMsg);

void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade} anos");
}

MostrarIdade("Laura", 15);
MostrarIdade("Lukas", 16);
MostrarIdade("Dayanne", 17);

void CalcularIdade(String nome, int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}

CalcularIdade("Kaynho", 2007);
*/
 

 void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
 }

 Soma(10,8);

 void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
 }

 Subtracao(10,8);

 void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
 }

 Multiplicacao(10,8);

 void Divisao(float a, float b){

if(b == 0){
    Console.WriteLine("Erro de divisao por zero");
    return;
}


    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
 }

 Divisao(10,8);

 //variaveis globais
 float a;
 float b;

 void DigitarAeB(string operacao){
    Console.WriteLine(operacao);
    Console.WriteLine($"digite o valor de a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine($"digite o valor de b:");
    b = float.Parse(Console.ReadLine());
 }  

 //MENU
 Console.WriteLine("--- CALCULADORA ---");
 Console.WriteLine("1 - Soma");
 Console.WriteLine("2 - Subtracao");
 Console.WriteLine("3 - Multiplicacao");
 Console.WriteLine("4 - Divisao");
 Console.WriteLine("5 - Sair");
 Console.WriteLine("-------------------");
 Console.WriteLine("Digite a opção desejada:");
 
 int opcao = int.Parse(Console.ReadLine());

 if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
 }
 else if(opcao == 2){
    DigitarAeB("Subtracao");
    Subtracao(a,b);
 }
    else if(opcao == 3){
        DigitarAeB("Multiplicacao");
        Multiplicacao(a,b);
    }
    else if(opcao == 4){
        DigitarAeB("Divisao");
        Divisao(a,b);
    }
    else if(opcao == 5){
        DigitarAeB("Saindo...");
        }
        else{
            Console.WriteLine("Opção Inválida");
        }
 