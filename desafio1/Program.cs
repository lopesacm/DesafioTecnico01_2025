Console.WriteLine("Me fale um pouco sobre o seu personagem favorito: ");
Console.WriteLine("Primeiro me fale o nome dele: ");
string nome = Console.ReadLine();

Console.WriteLine("Agora me fale a comida favorita dele: ");
string comida = Console.ReadLine();

Console.WriteLine("Me conte um pouco mais, me fale a idade dele: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Nossa, bela iadade, mas em que ano ele nasceu? ");
int nasceu = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a altura do seu persoangem em centímetros?");
float altura = int.Parse(Console.ReadLine());

Console.WriteLine("Sendo um pouco invesiva, mas quanto você acha que o ele teria na conta do banco?(Adicione os centavos)");
double dinheiro = double.Parse(Console.ReadLine());

Console.WriteLine("Agora que já temos essas informações, crie um nome de usuário para ele, que contenha no minímo um caracter especial: ");
char usuario = char.Parse(Console.ReadLine());

Console.WriteLine("Indique abaixo o email do seu personagem, que precisaobrigatoriamente conter um caracter especial: ");
char email = char.Parse(Console.ReadLine());

Console.WriteLine("Crie uma senha para o seu personagem, que obrigatriamente precisa ter a seguinte estrutura: 1,111...");
Console.WriteLine("Você pode utilizar outros números, mas precisa ter um algarismo antes da vírgula e no mínimo oito e no máximo dezesseis depois dela: ");
double senha = double.Parse(Console.ReadLine());

Console.WriteLine("Parabéns, sua conta foi criada!");

Console.WriteLine("Aqui estão as informações pessoais do seu perosnagem: ");
Console.WriteLine($"A comida favorita dele é: {comida}");
Console.WriteLine($"A idade dele é: {idade}");
Console.WriteLine($"Ele nasceu em: {nasceu}");
Console.WriteLine($"A altura dele é: {altura}");
Console.WriteLine($"Você acha que ele teria {comida} reais em sua conta do banco!");

Console.WriteLine("Agora irei te mostrar alguma sinformações da conta dele: ");
Console.WriteLine($"Nome do seu persoangem: {nome}");
Console.WriteLine($"Nome de usuário: {usuario}");
Console.WriteLine($"Email: {email}");
Console.WriteLine($"Senha: {senha}");









