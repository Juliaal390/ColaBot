# ColaBot

### PASSO 01

 Substituir a Connection String abaixo, inserindo o nome do seu servidor e o nome do banco de dados a ser criado
```json
  "ConnectionStrings": {
    "DataBase": "Server=NOME_DO_SERVIDOR;Database=NOME_DO_BANCO;Trusted_Connection=True;TrustServerCertificate=True;"
  },
```
### PASSO 02

 No Chatling.ai, depois de criado o seu chatbot, entre no Dashboard do projeto > Website widget. Selecione a opção Inline (Width: 100%; Height: 500px) e copie o código gerado. Após isso, vá na pasta Views > Chat > Index.cshtml e cole o código no arquivo.
