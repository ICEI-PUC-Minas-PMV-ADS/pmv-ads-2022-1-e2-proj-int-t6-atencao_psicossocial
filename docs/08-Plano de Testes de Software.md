# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Login do usuário |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir que os profissionais façam login e alterem sua senha.|
|**Entrada** | Login: Após preencher o CPF e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar o endereço do Site.   <br>3) Preencher os campos com informações válidas.<br>4) Clicar no botão Logar. |
|**Critérios de Êxito** | "O usuário sera direcionado a homepage e terá acesso ao seu menu.". |

|Caso de Teste |CT-02 – Alterar Senha |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir que os profissionais façam login e alterem sua senha.|
|**Entrada** | Após clicar no botão esqueci senha, o usuário deverá informar o email cadastrado.. |
|**Objetivo do Teste** | Verificar se os campos do formulário estão sendo exibidos corretamente. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar o endereço do Site.  <br>3) Clicar no botão de login. <br>4)Selecionar esqueci a senha.<br>5) Preencher os campo com dados validos.<br>6) Clicar Salvar. |
|**Critérios de Êxito** | Senha alterada com sucesso. |

|Caso de Teste |CT-03 – Cadasto de Profissionais |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - O sistema deve permitir gerenciar o profissional. |
|**Entrada** | Cadastrar Profissional: Após preencher dados silicitados do proficional. |
|**Objetivo do Teste** | Permitir que o usuário se cadatre como profissional no sistema. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço do Site.<br>3) Fazer login<br>4) Clicar em Profissionais.<br>5) Selecionar novo.<br>6) Preencher os campos com informações validas.<br>7) Clicar no botão Cadastrar. |
|**Critérios de Êxito** | O usuário sera direcionado a homepage e terá mensagem de confirmação. |
 
|Caso de Teste |CT-04 – Edição de Profissionais |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - O sistema deve permitir gerenciar o profissional. |
|**Entrada** | Editar Cadastro Proficional: Após preencher dados do proficional. |
|**Objetivo do Teste** | Permitir que o usuário edite cadatro de proficionais no sistema. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço do Site.<br>3) Fazer login.<br>4) Clicar em Profissionais.<br>5) Selecionar existente.<br>6) Selecionar editar.<br>7) Preencher os campos com informações válidas.<br>8) Clicar no botão Salvar. |
|**Critérios de Êxito** | O usuário será direcionado a homepage e terá a mensagem de confirmação. |

|Caso de Teste |CT-05 – Registro de atendimentos |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - O sistema deve permitir registrar os atendimentos, para cada atendimento o profissional de saúde deverá vincular o paciente que foi atendido ao dia, a hora e a descrição do atendimento. |
|**Entrada** | Através de um formulário contendo informações do paciente e profissional vinculado. |
|**Objetivo do Teste** | Permitir que o usuário cadastre informações de consultatas vinculadas entre paciente e proficional, com  caracteristicas e observações para consultas e controles posteriores. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço do Site.<br>3) Fazer login.<br>4) Clicar em Registro de atendimento.<br>5) Selecionar existente.<br>6) Selecionar editar.<br>7) Preencher os campos com informações válidas.<br>8) Clicar no botão Salvar. |
|**Critérios de Êxito** | O usuário será direcionado a homepage e terá mensagem de confirmação. |

## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:

> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
