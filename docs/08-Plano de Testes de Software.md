# Plano de Testes de Software

|Caso de Teste |CT-001 – Fazer Login |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de login de usuário/profissional.|
|**Entrada** | Na página inicial, digitar CPF e senha nos respectivos campos e clicar em Login. |
|**Objetivo do Teste** | Validar acesso do usuário à plataforma através do login. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>3) Preencher os campos CPF e senha.<br>4) Clicar no botão Login. |
|**Critérios de Êxito** | "O usuário será direcionado à homepage e terá acesso ao Menu pessoal." |

|Caso de Teste |CT-002 – Cadastrar novo usuário |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - A aplicação deve possibilitar o cadastro tanto de usuários quanto de profissionais. |
|**Entrada** | Na página inicial, o usuário deverá clicar em "Cadastre aqui".  |
|**Objetivo do Teste** | Validar usabilidade do cadastro de usuário. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>3) Clicar em Cadastre aqui.<br>4) Inserir os dados pessoais nos quadrantes em branco.<br>5) Escolher uma senha pessoal.<br>6) No quadrante do departamento, selecionar o departamento escolher a opção de sua função.<br>7) Clicar em Cadastrar. |
|**Critérios de Êxito** | "O usuário será direcionado à página de login." |

|Caso de Teste |CT-003 – Editar cadastro |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - A aplicação deve permitir editar dados de cadastro.|
|**Entrada** | a página inicial, digitar CPF e senha nos respectivos campos. |
|**Objetivo do Teste** | Validar usabilidade da edição de dados de cadastro do usuário no sistema. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>4)Clicar no botão login.<br>5) Na tela seguinte, clicar no botão "Meus dados", localizado no menu lateral esquerdo.<br>6) Clicar no quadrante de dados que deseja alterar e inserir o novo valor.<br>7) Após inserção de dados, clicar no botão "Save".<br> |
|**Critérios de Êxito** | "Usuário será direcionado para a página Meus dados." |

|Caso de Teste |CT-004 – Registro de atendimento |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-004 - A aplicação deve registrar o atendimento do paciente. |
|**Entrada** | Ao realizar login na aplicação, o profissional deverá acessar o botão Relatório, localizado no menu lateral esquerdo.
|**Objetivo do Teste** | Validar usabilidade do profissional, no cadastro de atendimento nas consultas. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Clicar em login.<br>5) Na Homepage, clique em  "Atendimentos".<br>6) Na página seguinte, clique no botão Novo Atendimento.<br>7) Preencha todos os dados da consulta nos respectivos quadrantes e clique em "Criar".
|**Critérios de Êxito** | "O atendimento será registrado e o profissional será direcionado ao menu inicial." |

|Caso de Teste |CT-005 – Emissão de relatório |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-005 - A aplicação deve permitir a emissão de relatórios de atendimento. |
|**Entrada** | Na homepage selecione "Relatório" e insira dados do paciente para realizar busca. |
|**Objetivo do Teste** | Validar acesso do profissional aos relatórios de atendimento. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Acessar o menu relatório.<br>5) No campo Nome Paciente pesquise por nome.<br>6) Clicar no botão pesquisar.<br>7) Escolher se deseja imprimir ou salvar relatório. |
|**Critérios de Êxito** | "O usuário visualizará campo para impressão ou download do relatório." |

|Caso de Teste |CT-006 – Recuperação de senha |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-006 - A aplicação deve ter a opção de recuperação/alteração da senha. |
|**Entrada** | Na homepage clicar em "Esqueci minha Senha". |
|**Objetivo do Teste** | Validar acesso à recuperação de senha esquecida. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Clicar em "Esqueci minha senha".<br>5) Na tela seguinte, preencher os quadrantes, CPF, Nova Senha e Confirmar Senha.<br>6) Clicar no botão Confirmar. |
|**Critérios de Êxito** | "O usuário será redirecionado para a página de Login." |


## Ferramentas de Testes (Opcional)

Para registro dos testes acima utilizamos a ferramenta nativa do Windows, intitulada "Xbox Game Bar", acessada através do comando das teclas **`windows`** + **`G`**. Com esta ferramenta, otimizou o processo para registro capturando um vídeo de cada Caso de Teste, demonstrando assim o passo a passo de cada teste acima.
Este acesso foi testado através do navegador Microsoft Edge, mas também realizado em diversos navegadores, sendo satisfatório em todos.
