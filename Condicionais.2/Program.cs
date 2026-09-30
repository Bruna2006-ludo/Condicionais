// Crie uma variável chamada "idade" e atribua o valor de 18 a ela.
var idade = 18;

// Crie uma variável chamada "valorIngresso" e atribua o valor 30.00 a ela.
double valorIngresso = 30.00;

// Crie uma variável chamada "clienteVIP" e atribua um valor que indique que o usuário é VIP.
bool clienteVIP = true;

// Crie uma variável chamada "ehEstudante".
bool ehEstudante = true;

// Verifica se o cliente é VIP.
if (clienteVIP)
{
    // Cliente VIP paga 40% do valor do ingresso.
    valorIngresso = valorIngresso * 0.4;
}

// Caso não seja VIP, verifica se é criança, idoso ou estudante.
else if (idade <= 7 || idade >= 60 || ehEstudante)
{
    // Criança, idoso ou estudante paga metade do ingresso.
    valorIngresso = valorIngresso * 0.5;
}

// Exibe o valor final do ingresso.
Console.WriteLine($"O valor do ingresso a pagar é R$ {valorIngresso}!");

