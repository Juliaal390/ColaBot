# ColaBot

### PASSO 01

 Substituir a Connection String abaixo, inserindo o nome do seu servidor e o nome do banco de dados a ser criado
```json
  "ConnectionStrings": {
    "DataBase": "Server=NOME_DO_SERVIDOR;Database=NOME_DO_BANCO;Trusted_Connection=True;TrustServerCertificate=True;"
  },
```
### PASSO 02

 No Chatling.ai (https://app.chatling.ai/), depois de criado o seu chatbot, entre no Dashboard do projeto > Website widget. Selecione a opção Inline (Width: 100%; Height: 500px) e copie o código gerado. Após isso, vá na pasta Views > Chat > Index.cshtml e cole o código no arquivo.

 ### PASSO 03

 No Visual Studio 2022, vá em Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes e crie uma migration: </br>
 ```prompt
  Add-Migration Usuarios </br>
  Update-Database
```

 ### PASSO 04

 Vá no SQL Server e insira um nome, email e senha na tabela Usuarios: </br>
 ```sql
 INSERT INTO Usuarios VALUES </br>
('Geral', 'geral@colabot.com', '123456'); </br>

select * from usuarios



