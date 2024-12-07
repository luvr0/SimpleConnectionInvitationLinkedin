# Simple Connection Invitation LinkedIn

Recentemente, decidi "resetar" minhas conexões no LinkedIn para criar uma rede mais filtrada e relevante. Porém, surgiu uma dúvida: preciso pesquisar grupos de usuários e enviar convites manualmente, um por um? Claro que não!

Foi aí que resolvi criar uma automação para fazer isso de forma mais eficiente, escolhi C# apenas pelo desafio.

## Descrição

Este projeto automatiza o envio de convites de conexão no LinkedIn, com base em filtros personalizados. Ele foi desenvolvido em C# usando o Selenium para interagir com a interface web do LinkedIn. A automação foi pensada inicialmente para atender a uma necessidade pessoal de enviar convites de maneira mais prática e rápida, sem a necessidade de fazer isso manualmente e, não pensada para um usuario final.

## Tecnologias e Ferramentas Utilizadas

- **C#**: Linguagem de programação principal.
- **Programação Orientada a Objetos (POO)**: Estruturação do código para tornar o projeto mais modular e reutilizável.
- **Selenium WebDriver**: Usado para automatizar a navegação na web, interagindo com o LinkedIn como um usuário real.

## Requisitos

- Microsoft Edge (Sim, eu prefiro esse navegador do que o Google Chrome, mas é facilmente alterado na classe Driver)

## Instalação

Para rodar este projeto, siga os passos abaixo:

1. **Clone o repositório**:
   ```bash
   git clone git@github.com:luvr0/SimpleConnectionInvitationLinkedin.git
   cd SimpleConnectionInvitationLinkedin
2. **Instale as dependências. Você precisará do Selenium:**
   ```bash
   dotnet add package Selenium.WebDriver
3. **Abra o projeto no seu editor preferido** (como Visual Studio ou VS Code) e **execute**.

   Caso esteja utilizando o **Visual Studio**, basta seguir os passos abaixo:

   - Abra o Visual Studio.
   - Selecione **Abrir o Projeto** ou **Open Project**.
   - Navegue até o diretório onde você clonou o repositório e abra o arquivo `.csproj`.
   - Clique em **Iniciar** ou pressione `Ctrl + F5` para executar o projeto.

   Caso esteja utilizando o **VS Code**, siga os seguintes passos:

   - Abra o VS Code.
   - No menu, clique em **File** > **Open Folder...** e selecione a pasta do projeto clonado.
   - No terminal integrado do VS Code (Ctrl + `), execute o comando:
     
     ```bash
     dotnet run

   O projeto deve iniciar e abrir a interface do LinkedIn no seu navegador padrão. A automação aguardará que você faça login manualmente.

4. **Login no LinkedIn**

   - O programa aguarda que você faça login manualmente no LinkedIn. Após o login, o programa começará a buscar as pessoas de acordo com o filtro especificado (por exemplo, "Back-end").

5. **Execução e envio de convites**

   - O programa percorrerá automaticamente as páginas de resultados de pesquisa, filtrando as pessoas conforme o termo de pesquisa e enviando convites de conexão.
   - Quando o programa atingir o final das páginas de resultados ou o limite de convites, ele encerrará automaticamente.

6. **Encerramento**

   - Após concluir o processo de envio de convites, o programa finalizará e o driver será fechado.

## Problemas Comuns

- **Limite de convites no LinkedIn**: O LinkedIn impõe um limite semanal de convites de conexão. Certifique-se de não exceder esse limite, caso contrário, seu perfil pode ser temporariamente bloqueado de enviar convites.
- **Falhas no login**: Se o programa não conseguir detectar que você está logado, tente realizar o login novamente e reinicie o programa.
- **Erros do Selenium**: Se ocorrerem erros relacionados ao Selenium (como falhas ao carregar a página), verifique se o navegador e o WebDriver estão configurados corretamente.


