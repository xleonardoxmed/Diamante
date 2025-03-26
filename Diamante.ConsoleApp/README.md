# Criador de Diamantes 

![](https://i.imgur.com/vad5v46.gif)

Este � um projeto em C# que permite ao usu�rio gerar um "diamante" formado por caracteres 'X'. O tamanho do diamante � baseado em um n�mero �mpar fornecido pelo usu�rio, sendo esse n�mero o ponto central do diamante. O programa tamb�m permite ao usu�rio gerar m�ltiplos diamantes at� que decida encerrar a execu��o.

## Funcionalidades

- Valida��o de Entrada: O programa solicita que o usu�rio insira um n�mero �mpar, que ser� utilizado para definir o tamanho do diamante. Caso o n�mero inserido seja inv�lido (n�o for �mpar ou for negativo), o sistema solicita novamente at� que uma entrada v�lida seja fornecida.

- Gera��o de Diamante: Com o n�mero fornecido, o programa gera e exibe um diamante de 'X', onde o maior n�mero de 'X' corresponde ao centro do diamante, e os outros n�meros diminuem simetricamente em torno dele.

- Rein�cio ou Encerramento: Ap�s gerar o diamante, o usu�rio tem a op��o de gerar um novo diamante ou encerrar o programa. O processo pode ser repetido quantas vezes o usu�rio desejar.

## Como Funciona?
- Iniciar o Programa: Ao iniciar, o programa exibir� uma mensagem de boas-vindas e solicitar� que voc� insira um n�mero �mpar para compor o centro do diamante.

- Validar a Entrada: Caso o n�mero inserido n�o seja �mpar ou seja inv�lido, o programa ir� pedir ao usu�rio para inserir um n�mero v�lido.

- Gerar o Diamante: Com o n�mero validado, o programa ir� gerar e exibir o diamante na tela.

- Escolher Reiniciar ou Encerrar: Ap�s a exibi��o do diamante, o programa perguntar� ao usu�rio se ele deseja gerar um novo diamante ou encerrar o programa.

## Exemplo de Execu��o
- Quando o usu�rio insere o n�mero 7, o programa gera o seguinte diamante:

```
		        X   
		       XXX		
		      XXXXX 
		     XXXXXXX
		      XXXXX 
		       XXX  
			X  
   ```

- Em seguida, o programa pergunta se o usu�rio deseja criar um novo diamante ou sair.

### Requisitos
- .NET 6 ou superior.

- Ambiente para execu��o de programas em C#.

# Como testar?

- Clone o Reposit�rio 
```
git clone https://github.com/xleonardoxmed/JogoDeAdivinhacao.ConsoleApp.git
```
- Navegue at� a pasta raiz da solu��o
```
cd Diamante
```
- Restaure as depend�ncias
```
dotnet restore
```
- Navegue at� a pasta do projeto
```
cd Diamante.ConsoleApp
```
- Execute o projeto
```
dotnet run
```

# Se divirta criando seu diamante!!!