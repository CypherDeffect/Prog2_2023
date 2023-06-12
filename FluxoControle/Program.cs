string password = "samurai";
string retorno = string.Empty;

if(password.Length < 10)
{
    retorno = @"Sua senha é muito curta.
                Use ao menos 10 caracteres";
} else if (password.Length >= 15)
{
    retorno = @"Sua senha é muito grande.
                Use entre 10 caracteres 15 caracteres";
} else
{
    retorno = @"Sua senha está de acordo";
}

Console.WriteLine(retorno);

// Checagem de valor e tipo
/*
    Em JavaScript podemos fazer assim:
    var a = "1";
    var b = 1;
    (a == b) retornará True
    (a === b) retornará false
*/

object o = "3";
int j = 4;
if(o is int i)
{
    Console.WriteLine($"{i} x {j} = {i*j}");
} else
{
    Console.WriteLine(@"o não é um inteiro,
                        portanto não é possível");
}