Dictionary<string, int> produtosEstoque = new Dictionary<string, int>();
produtosEstoque.Add("Batata", 50);
produtosEstoque.Add("Maça", 70);
produtosEstoque.Add("Goiaba", 50);

void LogoDoMercado()
{
    Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*");
    Console.WriteLine("Mercado da Lari");
    Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*");
}

void MenuPrincipal()
{
    LogoDoMercado();
    Console.WriteLine("\nDigite 1 para adicionar um produto ao estoque");
    Console.WriteLine("Digite 2 para adicionar a quantidade de produto no estoque");
    Console.WriteLine("Digite 3 para exibir os itens do estoque ");
    Console.WriteLine("Digite 4 para exibir a quantidade de itens de um produto do estoque");
    Console.WriteLine("Digite 5 para exibir o estoque completo");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistroDeProduto();
            break;
        case 2:
            RegistrarQuantidadeDeProduto();
            break;
        case 3:
            ExibirProdutosDoEstoque();
            break;
        case 4:
            ExibirQuantidadeDeProduto();
            break;
        case 5:
            ExibirTodoOEstoque();
            break;
        case -1:
            Console.WriteLine("\nObrigada por usar o programa =D");
            Thread.Sleep(1500);
            break;
        default:
            Console.WriteLine("\nOpção inválida, tente novamente");
            Thread.Sleep(1500);
            Console.Clear();
            MenuPrincipal();
            break;
    }

}
void TituloDaSecao(string nomeDaSecao)
{
    int quantidadeDeLetras = nomeDaSecao.Length;
    string asteriscos = string.Empty.PadLeft((quantidadeDeLetras), '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(nomeDaSecao);
    Console.WriteLine(asteriscos + "\n");
}
void RegistroDeProduto()
{
    Console.Clear();
    TituloDaSecao("Registro de Produto");
    Console.Write("Digite o nome do produto que deseja registrar no estoque: ");
    string produto = Console.ReadLine()!;
    produtosEstoque.Add(produto, 0);
    Console.WriteLine("Produto " + produto + " registrado com sucesso");
    Thread.Sleep(1500);
    Console.Clear();
    MenuPrincipal();
}
void RegistrarQuantidadeDeProduto()
{
    Console.Clear();
    TituloDaSecao("Registro de quantidade");
    Console.Write("Informe qual produto deseja adicionar a quantidade em estoque: ");
    string produtoQuantidade = Console.ReadLine()!;
    if (produtosEstoque.ContainsKey(produtoQuantidade))
    {
        Console.Write("Quantidade de " + produtoQuantidade + " no estoque: ");
        int quantidade = int.Parse(Console.ReadLine())!;
        produtosEstoque[produtoQuantidade] = quantidade;
        Thread.Sleep(2000);
        Console.WriteLine("\nO estoque possui " + quantidade + " unidades de " + produtoQuantidade + " no estoque");
        Thread.Sleep(2000);
        Console.Clear();
        MenuPrincipal();
    }
    else
    {
        Console.WriteLine("O produto " + produtoQuantidade + " ainda não foi adicionado ao estoque.\nVolte ao menu e registre o produto.");
        Thread.Sleep(3500);
        Console.Clear();
        MenuPrincipal();
    }
}
void ExibirProdutosDoEstoque()
{
    Console.Clear();
    TituloDaSecao("Produtos em estoque");
    int i = 1;
    foreach(string produtos in produtosEstoque.Keys)
    {
        Console.WriteLine(i + " - " + produtos);
        i++;
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}
void ExibirQuantidadeDeProduto()
{
    Console.Clear();
    TituloDaSecao("Quantidade de determinado produto no estoque");
    Console.Write("Digite o produto que você deseja pesquisar no estoque: ");
    string produtoSelecionado = Console.ReadLine()!;
    if (produtosEstoque.ContainsKey(produtoSelecionado))
    {
        Console.WriteLine("\nO produto " + produtoSelecionado + " possui " + produtosEstoque[produtoSelecionado] + " unidades");
    }
    else
    {
        Console.WriteLine("\nO produto " + produtoSelecionado + " ainda não foi adicionado ao estoque.\nVolte ao menu e registre o produto.");
        Thread.Sleep(3500);
        Console.Clear();
        MenuPrincipal();
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}
void ExibirTodoOEstoque()
{
    Console.Clear();
    TituloDaSecao("Estoque completo");
    int contador = 1;
    foreach (string item in produtosEstoque.Keys)
    {
        int estoque = produtosEstoque[item];
        Console.WriteLine(contador + " - " + item + ":" + estoque);

        contador++;
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}
MenuPrincipal();