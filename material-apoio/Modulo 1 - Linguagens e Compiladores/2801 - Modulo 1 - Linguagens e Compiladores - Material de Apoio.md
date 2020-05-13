# Linguagens e Compiladores

Uma das profissões mais requisitadas do mundo, o desenvolvedor ou programador é a pessoa que consegue escrever instruções que o computador consegue processar através de uma linguagem de programação.

## O que é uma linguagem de programação?

A comunicação é algo presente em todo o mundo, desde os animais até as máquinas. Com os computadores isto não é diferente, para que ele execute alguma ação, precisamos informar todos os passos que ele deve executar.

Assim como nós, os computadores também utilizam uma linguagem para se comunicar, baseada em zeros e um, também chamada de binária (Ou linguagem binária).

Sempre que precisamos enviar uma instrução para o computador, temos que usar sua linguagem para que ele nos entenda, ou seja, somente zeros e um.

O que uma linguagem de programação faz, é intermediar esta comunicação, como um interprete, e traduzir o que falamos para um formato que o computador entende.

Então temos um arquivo texto que nós humanos conseguimos ler e que será traduzido para um arquivo binário que o computador consegue entender.

Este processo de “tradução” é conhecido como **_compilação_** e veremos muito este termo por aqui.

Existem diversas linguagens de programação, com diversos compiladores, que trabalham de diferentes formas para atender ambos mundos.

## Níveis de acesso

Sempre que falamos em enviar instruções ao computador, nos referimos a instruções a nível de máquina, ou diretamente ao hardware (Processador, Memória, Disco...).

Estas instruções sempre serão no formato binário, afinal o computador não fala outra língua, então dizemos que estas instruções são de baixo nível.

Quanto maior o nível de detalhe da instrução, mais baixo terá de ser o nível a ser adentrado utilizando alguma linguagem de programação.

As linguagens mais novas como C#, Java e demais, são consideradas linguagens de alto nível, justamente por prover uma abstração aos níveis mais baixos.

Então se você precisa escrever um valor específico em um local específico da memória por exemplo, você precisa de mais liberdade, e terá muito mais trabalho.

Veja uma simples comparação entre uma linguagem de baixo nível (Assembly) e uma de alto nível (C#).

```assembly
			global    _start

		    section   .text
_start:   	mov rax, 1
			mov rdi, 1
			rsi, message
			mov rdx, 13
			syscall
			mov rax, 60
			xor rdi, rdi
			syscall

			section   .data
message:	db        "Hello, World", 10
```

<small>Exemplo escrito em Assembly (Fonte: https://cs.lmu.edu/~ray/notes/x86assembly/).</small>

```csharp
namespace  ConsoleApp1
{
	class  Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
		}
	}
}
```

<small>Exemplo escrito em C#.</small>

Justamente por este motivo, optamos por linguagens de alto nível, por fornecer um acesso à tudo que precisamos a nível de hardware já pronto.

## Linguagens Compiladas

Podemos dizer que uma linguagem é compilada quando existe o processo de **compilação** da mesma, dada por um compilador.

Este processo consiste em receber um arquivo texto, normalmente otimizado para leitura de humanos e convertê-lo para binário.

Este processo possui várias vantagens descritas mais adiante aqui e também faz uma espécie de validação e otimização do nosso código.

## Linguagens Interpretadas

Existem também as linguagens chamadas de interpretadas, que são arquivos de texto, lidos e interpretados por um intérprete em **tempo de execução**.

> **Tempo de execução** é o que acontece durante a execução do código pelo computador ou interpretador.

Um ótimo exemplo de linguagem interpretada é o **JavaScript**, uma linguagem simples e popular, usada principalmente nos navegadores.

O que ocorre neste caso é que o navegador é escrito em uma linguagem de alto nível e possui um **interpretador** que lê e executa um arquivo de texto do JavaScript.

Embora atualmente hajam diversas otimizações para o JavaScript, sua principal definição ainda é uma linguagem interpretada.

## Compilar ou Interpretar?

Muito provavelmente você utilizará linguagens compiladas e interpretadas em sua carreira, o mundo do desenvolvimento é muito vasto para ser atendido por apenas uma linguagem.

Porém, é importante saber os pontos principais de cada uma para estar preparado perante os desafios que encontrará.

### Compilação ou Interpretação

Um dos principais problemas das linguagens interpretadas é a detecção erros apenas em tempo de execução. Enquanto as linguagens compiladas verificam se há erros antes de fazer a compilação, nas interpretadas isto não ocorre.

Como não temos a oportunidade de executar uma verificação (Tempo de Compilação), qualquer erro que ocorrer será apresentado diretamente na execução do código.

Vamos supor que durante a escrita do código, um desenvolvedor esqueceu de colocar um ";" no final de uma linha, um erro clássico que todos já cometemos.

No caso da linguagem compilada, ao tentar criar o arquivo final (Compilar), seria apresentado o erro e o processo de compilação falharia.

> **Arquivo Final** é o resultado do código escrito, passado ou não por um compilador. Comumente chamamos este de **Programa**.

No caso da linguagem interpretada, não há este processo intermediário de compilação, então só conseguiríamos detectar o possível erro quando de fato o arquivo final (Texto) fosse executado.

### Tamanho do Arquivo

Você provavelmente já utilizou algum arquivo compactado como o **ZIP**, mas você sabe o que ocorre nos arquivos para serem compactados?

O algorítimo de compactação varia de acordo com cada formato, mas no geral são removidos comentários, linhas em branco e espaços desnecessários dos arquivos para economizar espaço.

Um arquivo menor significa maior rapidez na sua transferência, menos consumo de banda de rede no seu Download e por aí vai.

Se analisarmos novamente o exemplo anterior, escrito em C#, podemos notar que conseguimos reduzir bastante este arquivo.

```csharp
// Eu sou um comentário
namespace  ConsoleApp1
{
	class  Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
		}
	}
}
```

<small>Arquivo com código em C#.</small>

Note que temos vários espaços em branco, quebra de linhas e um comentário no topo do arquivo. Tudo isto poderia ser reduzido para este arquivo abaixo.

```csharp
namespace  ConsoleApp1{class  Program {static void Main(string[] args){Console.WriteLine("Hello World")}}}
```

<small>Exemplo escrito em C#.</small>

Somente com esta mudança inicial já teríamos salvo alguns **bytes** e estamos falando de apenas um arquivo. Em um cenário real, um programa pode ter centenas de milhares de linhas de código.

Se notarmos, o código ficou praticamente ilegível para nós humanos, porém para o computador ele é totalmente válido.

A **identação**, espaços e comentários que colocamos não são necessários para o compilador. Para saber onde uma instrução termina por exemplo, ele buscará pelo ";" e não pela quebra de linha de um texto.

> **Identação** é o nome que damos aos espaçamentos que tornam o código mais organizado e nossa leitura mais amena.

Nas linguagens compiladas, o código final é transformado em binário, ou seja, apenas zeros e um, e nada mais. Isto torna o arquivo ainda mais compacto, porém seria impossível sua leitura.

Por mais que possamos remover todas as identações, espaços em branco e comentários dos arquivos de uma linguagem compilada (Arquivos Texto), eles nunca serão convertidos apenas para zeros e um (Compilação), ou seja, há um limite na otimização do tamanho dos arquivos de linguagens interpretadas.

Portanto, podemos concluir que o tamanho dos programas escritos em linguagens compiladas são menores do que os escritos em linguagens interpretadas.

### Múltiplos Arquivos

Um programa dificilmente será escrito em um único arquivo. Normalmente segmentamos nossos programas em vários arquivos para facilitar sua manutenção, legibilidade e trabalho em equipe.

Desta forma, é comum finalizar um programa com dezenas e até milhares de arquivos, que juntos e somente juntos formam um programa.

Durante o processo de compilação, todos estes arquivos são juntados, tendo como resultado apenas um arquivo final, compactado conforme vimos anteriormente.

Nas linguagens interpretadas isto não acontece e normalmente temos mais de um arquivo compondo o programa, provavelmente distribuídos na mesma pasta da **aplicação**.

> **Programa, Sistema ou Aplicação?** Tanto faz, os termos se referem todos ao resultado final do seu código.

Múltiplos arquivos também tomam mais tempo para serem carregados. Você já deve ter notado que a cópia de um arquivo grande em seu sistema operacional demora bem menos que a cópia de vários arquivos pequenos.

Isto ocorre pois toda leitura e escrita de arquivo em disco tem um processo, que toma alguns milissegundos para ser executada, ou seja, quanto mais arquivos, maior o acumulo destes processos em execução e consequentemente maior o tempo de execução.

### Tempo de Execução

Enquanto um arquivo compilado tem sua leitura otimizada (Traduzida) para a linguagem de máquina, a linguagem interpretada não.

O que ocorre com a linguagem interpretada é que esta tradução está sendo feita em tempo de execução e não é tão otimizada quanto a compilada.

Por este motivo, é comum ter uma performance maior em aplicações compiladas ao invés das interpretadas, ou seja, linguagens compiladas tendem a ser mais rápidas.

## Tipagem

Podemos classificar as diferentes linguagens que temos de diversas formas e dentre elas pela sua tipagem, ou checagem por tipos.

Quando dizemos que uma linguagem é **tipada** ou **fortemente tipada** estamos nos referindo ao uso de restrições a nível de escrita de código e otimização de execução da aplicação.

Por exemplo, podemos dizer que a idade de uma pessoa deve ser no formato **número inteiro**, afinal não temos nenhuma informação possível que não seja um número para uma idade.

Isto também é chamado de **tipo de dado** e veremos com calma todos os tipos que o C# possui aqui, porém, para exemplificar, vamos ler o código abaixo.

```csharp
int idade;
```

No C# sempre devemos informar o tipo da informação que desejamos armazenar, e o caso acima este é feito pela palavra `int`;

Este mesmo código, escrito em JavaScript, que não é uma linguagem tipada, ficaria assim.

```js
let idade;
```

Note que utilizamos o `let` para definir uma **variável**, ou seja, não informamos o tipo deste dados.

> No desenvolvimento temos sempre **variáveis** que podem ter seu valor alterado depois de criadas e **constantes** que uma vez definidas não podem ser alteradas.

Desta forma, enquanto no C# não podemos informar um valor diferente de um número para a `idade`, no JavaScript isto é permitido.

Este código abaixo por exemplo, não funcionaria em C#.

```csharp
int idade;
idade = "Teste";
```

Quando tentássemos executar este programa, o compilador acusaria um erro, dizendo que a idade não pode receber um valor diferente de um número.

Porém, no exemplo escrito em JavaScript, esta conversão seria plenamente possível, como podemos ver no código abaixo.

```js
let idade;
idade = 25;
idade = "Teste";
```

Isto ocorre pois no JavaScript possui uma tipagem padrão para todos os tipos, definida pelo `let` ou `var`, ou seja, independente da informação armazenada, o tipo é sempre o mesmo.

### Vantagens da Tipagem

Se podemos ter apenas um tipo para tudo, isto parece muito mais fácil, correto? E de fato é uma ótima liberdade não ter que se preocupar com tipos.

Porém, quando temos grandes sistemas, com diversas divisões e milhares de arquivos, ter um tipo especifico pode ajudar muito.

Por exemplo, dado um valor, sabemos o que ele espera e assim podemos preenchê-lo da forma correta. Se não temos uma tipagem, não temos uma padronização.

Além disso durante a execução do seu código, esta tipagem influencia na alocação de memória. Todo dado que vai para lá precisa de uma **alocação** prévia.

Em suma, alocamos e desalocamos espaço na memória do computador o tempo todo, e definir quais tipos estes dados terão, otimiza este processo.

Vamos imaginar que temos uma memória com dez mil espaços e desejamos alocar dados nela durante a execução da nossa aplicação.

O que será executado a nível de máquina é a alocação de uma série destes espaços, que o executor da aplicação determinará, baseado no tipo de dado da informação.

Desta forma, vamos tomar como base o tipo **número inteiro** definido pela palavra `int` que vimos no código anterior.

Os tipos inteiros não permitem o uso de pontuação, ou seja, não podemos atribuir um valor como **10.2** ou **15.8**, apenas **10** ou **15**.

Para a atribuição de números no C# temos várias opções como `int`, `float`, `double` e `decimal`. Todos eles armazenam números, sendo que o `float`, `double` e `decimal` permitem armazenarmos números com reais (com ponto).

O que difere um tipo de dado de outro geralmente é o conteúdo que podemos armazenar nele, porém, o custo de seu armazenamento na memória também varia.

Enquanto o `int` ocupa um espaço menor, o `decimal` por exemplo ocupa mais que o dobro, como podemos ver na tabela abaixo.

| Tipo    | Tamanho |
| ------- | :-----: |
| int     | 32-bit  |
| float   | 32 bit  |
| double  | 64 bit  |
| decimal | 128 bit |

Isto significa que nas linguagens tipadas, podemos **otimizar** o uso de memória que nossa aplicação requer, especificando o tipo de dados corretamente.

Nas linguagens que não possuem um tipo, a alocação em memória sempre será a padrão, variando de linguagem para linguagem e não permitindo uma otimização.

Não se preocupe com os tipos agora, veremos tudo com calma mais adiante aqui.
