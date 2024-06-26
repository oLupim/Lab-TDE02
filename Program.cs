// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
// Aluno tem anos e nota usando a concatenação e a interpolação de strings.
string nome = "Paulo";
int idade = 17;
double nota = 7.5;
Console.WriteLine($"{nome} tem {idade} anos e sua nota é: {nota}");


// Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
// escapes.
Console.WriteLine($"{nome}\n{idade}\n{nota}");

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (X) double
// ( ) long
// (X) decimal 
 

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// (X) int para long
// (X) double para long
// (X) double para float
// (X) decimal para float
// ( ) long para int
// (X) double para decimal
 

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings
Console.WriteLine("Escreva a 1º letra:");
string letra1 = Console.ReadLine();

Console.WriteLine("Escreva a 2º letra:");
string letra2 = Console.ReadLine();

Console.WriteLine("Escreva a 3º letra:");
string letra3 = Console.ReadLine();

Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
Console.WriteLine($"{letra3} {letra2} {letra1}");


// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical
 

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:
Console.WriteLine("Digite um número:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número:");
double num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
double subtracao = num1 - num2;
double multi = num1 * num2;
double expo = Math.Pow(num1,num2);
double divisao = num1 / num2;
double modulo = num1 % num2;

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multi);
Console.WriteLine(expo);
Console.WriteLine(divisao);
Console.WriteLine(modulo);
 

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)
Console.WriteLine("Login:");
string login = Console.ReadLine();

Console.WriteLine("Senha:");
int senha = Convert.ToInt32(Console.ReadLine());

string aviso = (login == "admin" || login == "maria" && senha == 123 ? "Login feito com sucesso" : "Login Inválido");
Console.WriteLine(aviso);

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Digite um número:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número:");
int y = Convert.ToInt32(Console.ReadLine());

int parX = x % 2;
int parY = y % 2;

string resultadoX = (parX == 0 ? "X é par" : "X Não é par");
string resultadoY = (parY == 0 ? "Y é par" : "Y Não é par");
Console.WriteLine(resultadoX);
Console.WriteLine(resultadoY);
