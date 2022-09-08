![image](https://user-images.githubusercontent.com/98191980/189137234-4edabf74-6684-4192-bdfc-4f3627f6215d.png)

<img src="https://img.shields.io/static/v1?label=by&message=Alura&color=blue&style=for-the-badge"> <img src="https://img.shields.io/static/v1?label=Tech&message=.NET 6.0&color=e75988&style=for-the-badge&logo=.NET"> <img src="https://img.shields.io/static/v1?label=Tech&message=C%23&color=e75988&style=for-the-badge&logo=csharp">

- `Notebook:` [Google Docs](https://docs.google.com/document/d/1roxiTZyPmtrW8M-B47ulFp88TmDjd6ZlzUObIjP9a4k/edit?usp=sharing)
- `Notion:` [Notion](https://steady-rocket-ff7.notion.site/C-f99db19e90a144dbb9bf928194732ab4)

### Criando a primeira classe

- Como criar um projeto do tipo Console usando o Visual Studio 2022, que nos pemite cuidar dos arquivos .CS em só um lugar e já traz recursos de autocomplete e execução do nosso código;
- A sintaxe básica de uma classe usando a linguagem C#. A classe irá representar algo existente no mundo real que seja importante para o desenvolvimento da aplicação;
- Criar objetos a partir da definição de uma classe usando o operador new e como utilizar este objeto dentro do seu programa.

### Entendendo tipos

- Para manipular os valores dos campos de um objeto, nós indicamos o objeto através do operador ponto (.) e acessamos o campo para inserir um valor usando o operador de igualdade (=);
- Valores padrão para campos de uma classe são definidos de maneira automática, o que permite declarar o campo sem a necessidade de inserir um valor;
- Atribuímos uma referência a uma variável fazendo ela apontar para um espaço na memória que contém um objeto;
- Os tipos por referência só apontam para um objeto criado na memória do computador.

### Comportamentos de uma classe

- Criamos métodos que recebem parâmetros e retornam algum valor para simular os comportamentos (operações) de uma classe;
- Quando desenvolvemos um método, ele recebe como parâmetro uma referência para um objeto;
- Como criar um método que não retorna nenhum valor, mas que encapsula uma ação existente no mundo real usando a palavra reservada void.

### Namespace e compor classes

- Como adicionar uma nova classe ao projeto usando as facilidades oferecidas pela IDE do Visual Studio Community, tal qual criar uma classe com base em um modelo com a sintaxe básica;
- Podemos organizar a estrutura do nosso projeto usando os namespaces;
- Utilizamos a diretiva using e o nome completo qualificado para usar uma classe do projeto que esteja em um namespace;
- Utilizamos o conceito de composição para criar classes compostas por outras classes;
- Entendemos que as referências nulas no nosso código apontarão para espaços em memória que não contenham um objeto;
- Verificamos se uma referência está nula para evitar erros como “Exceção Sem Tratamento — System.NullReferenceException: 'Referência de objeto não definida para uma instância de um objeto”.

### Propriedades

- Restringimos a visibilidade de campos de uma classe para que não sejam acessados de outros pontos do código;
- Criamos métodos públicos para manipulação de campos privados, aplicando uma boa prática e implementando o conceito de encapsulamento de campos de uma classe;
- A sintaxe utilizada pelo C# para definir uma propriedade, que facilita a criação de operações para leitura e escrita de informação em um objeto;
- As propriedades autoimplementadas podem ajudar na legibilidade do código.

### Construtor e membro estático

- Métodos construtores são chamados quando criamos um objeto usando o operador new. Por meio deles, podemos informar os valores dos campos no momento da criação do objeto;
- Construtores explícitos são definidos por quem desenvolve e construtores implícitos são criados pelo próprio .NET quando não definimos explicitamente;
- A palavra reservada static é utilizada para definir um campo ou propriedade como membro de uma classe. Assim conseguimos compartilhar informações com todos os objetos de uma classe.
