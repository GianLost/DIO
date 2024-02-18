// DESCRIÇÃO :
// Neste desafio, aplicaremos conceitos essenciais de programação, seu objetivo é desenvolver uma solução simulando o registro de usuário em uma aplicação. Assegure que o código tenha uma sintaxe clara e organizada, com nomenclaturas significativas para variáveis como email, nomeUsuario, senha que será o local de armazenamento das informações de registro. Escolha tipos de dados apropriados, como o String para representar o email, nomeUsuario e senha. Certifique-se de tratar senha como strings para operações específicas.

// ENTRADA :
// Como entrada receberemos três informações referente ao emailCadastro(String), nomeUsuario(String) e senha(String).

// SAÍDA :
// Construa uma mensagem de saída formatada corretamente, como nessa estrutura: ' registroNome + ", verifique o email: " + registroEmail + " para ativar." '

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
string Email;
string NomeUsuario;
string Senha;

// Obtém o email e nome do usuário a partir da entrada do console
Console.WriteLine("Informe o seu nome :");
string registroNome = Console.ReadLine();

Console.WriteLine("Informe o seu email :");
string registroEmail = Console.ReadLine();

Console.WriteLine("Informe a sua senha :");
string registroSenha = Console.ReadLine();

Email = registroEmail;
NomeUsuario = registroNome;
Senha = registroSenha;

// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
Console.WriteLine($"{NomeUsuario} verifique o email: {Email} para ativar.");
