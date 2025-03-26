# Criador de Diamantes 

![](https://i.imgur.com/vad5v46.gif)

Este é um projeto em C# que permite ao usuário gerar um "diamante" formado por caracteres 'X'. O tamanho do diamante é baseado em um número ímpar fornecido pelo usuário, sendo esse número o ponto central do diamante. O programa também permite ao usuário gerar múltiplos diamantes até que decida encerrar a execução.

## Funcionalidades

- Validação de Entrada: O programa solicita que o usuário insira um número ímpar, que será utilizado para definir o tamanho do diamante. Caso o número inserido seja inválido (não for ímpar ou for negativo), o sistema solicita novamente até que uma entrada válida seja fornecida.

- Geração de Diamante: Com o número fornecido, o programa gera e exibe um diamante de 'X', onde o maior número de 'X' corresponde ao centro do diamante, e os outros números diminuem simetricamente em torno dele.

- Reinício ou Encerramento: Após gerar o diamante, o usuário tem a opção de gerar um novo diamante ou encerrar o programa. O processo pode ser repetido quantas vezes o usuário desejar.

## Como Funciona?
- Iniciar o Programa: Ao iniciar, o programa exibirá uma mensagem de boas-vindas e solicitará que você insira um número ímpar para compor o centro do diamante.

- Validar a Entrada: Caso o número inserido não seja ímpar ou seja inválido, o programa irá pedir ao usuário para inserir um número válido.

- Gerar o Diamante: Com o número validado, o programa irá gerar e exibir o diamante na tela.

- Escolher Reiniciar ou Encerrar: Após a exibição do diamante, o programa perguntará ao usuário se ele deseja gerar um novo diamante ou encerrar o programa.

## Exemplo de Execução
- Quando o usuário insere o número 7, o programa gera o seguinte diamante:

```
		        X   
		       XXX		
		      XXXXX 
		     XXXXXXX
		      XXXXX 
		       XXX  
			X  
   ```

- Em seguida, o programa pergunta se o usuário deseja criar um novo diamante ou sair.

### Requisitos
- .NET 6 ou superior.

- Ambiente para execução de programas em C#.

# Como testar?

- Clone o Repositório 
```
git clone https://github.com/xleonardoxmed/JogoDeAdivinhacao.ConsoleApp.git
```
- Navegue até a pasta raiz da solução
```
cd Diamante
```
- Restaure as dependências
```
dotnet restore
```
- Navegue até a pasta do projeto
```
cd Diamante.ConsoleApp
```
- Execute o projeto
```
dotnet run
```

# Se divirta criando seu diamante!!!