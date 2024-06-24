# Basic Sales

Basic Sales é um aplicativo que permite que pequenos negócios mantenham, gerenciem, realizem vendas e gerem relatórios.

Esse aplicativo usa do **.NET 8**, **SQL Server Compact 4.0** e de outros recursos para entregar uma experiência fluida e suave aos usuários, com o foco em **minimizar o uso de recursos** e manter a simplicidade. 

## Funcionalidades Principais

- **Criação de Produtos**: Permite aos usuários criar seus próprios produtos e gerenciá-los de forma simples e eficaz de forma intuitiva e lógica.
  
- **Gestão de Estoque**: Mantém um controle básico do estoque de produtos, atualizando automaticamente com base nas vendas registradas e entradas e saídas de produtos.

- **Vendas Rápidas**: Disponibiliza para os usuários uma interface clara para realizar vendas, reembolsos e troca de produtos permitindo assim operações rápidas e capacidade de lidar com fluxo constante de trabalho.

- **Relatórios**: Gera relatórios simples que mostram o desempenho de vendas ao longo do tempo bem como relatórios para a visualização clara do estoque.

## Instalação para Desenvolvedores

Para configurar e executar este projeto localmente, siga estas etapas:

1. **Clone o repositório**:

   ```
   git clone https://github.com/FelipeRochaMartins/BasicSales.git
   ```

2. **Instale o Banco de Dados**:

   Instale o [SQL Server Compact 4.0 SP1](https://www.microsoft.com/pt-br/download/details.aspx?id=30709)

   
3. **Adicione a DLL**:
  
   Adicione nas ```references``` do BasicSales a seguinte DLL ```DBManager.dll```

   Para conseguir a mesma realize:

   1. Build a solução DBManager (Compilação).

   2. Clique com o botão direito em ```references``` e clique em adicionar.

   3. Entre na pasta ```bin``` da solução DBManager.

   4. Entre na pasta compilada (Release ou Debug).

   5. Selecione a DLL.

   6. Adicione ela.

4. **Execute a aplicação**



## Instalação para Usuários

1. Baixe o programa [SQL Server Compact 4.0 SP1](https://www.microsoft.com/pt-br/download/details.aspx?id=30709) e realize sua instalação na máquina.

2. Após isso baixe a pasta zipada [BasicSalesSetup.zip](https://github.com/FelipeRochaMartins/BasicSales/blob/master/BasicSalesSetup.zip) nos arquivos desse repositório.

3. Descompacte a pasta.

4. Realize a instalação por meio do arquivo ```BasicSalesSetup.msi```.

5. O ícone de atalho aparecerá na Área de Trabalho, aproveite o **Basic Sales**!

## Autor

- [**Felipe Rocha Martins**](https://github.com/FelipeRochaMartins) (*dev.feliperochamartins@gmail.com*)

## Licença

*Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](https://github.com/FelipeRochaMartins/BasicSales/blob/master/LICENSE) para mais detalhes.*
