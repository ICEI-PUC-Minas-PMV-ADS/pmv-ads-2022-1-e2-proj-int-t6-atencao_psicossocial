# Plano de Testes de Software

|Caso de Teste |CT-01 – Login do usuário |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir que usuários e profissionais façam login.|
|**Entrada** | Na página inicial, digitar CPF e senha nos respectivos campos e clicar em Login. |
|**Objetivo do Teste** | Validar acesso do usuário à plataforma através do login. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>3) Preencher os campos CPF e senha.<br>4) Clicar no botão Login. |
|**Critérios de Êxito** | "O usuário será direcionado à homepage e terá acesso ao Menu pessoal." |

|Caso de Teste |CT-02 – Cadastro de usuário |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-006 - O sistema deve permitir cadastrar um usuário. |
|**Entrada** | Na página inicial, o usuário deverá clicar em "Cadastre aqui".  |
|**Objetivo do Teste** | Validar usabilidade do cadastro de usuário. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>3) Clicar em Cadastre aqui.<br>4) Inserir os dados pessoais nos quadrantes em branco.<br>5) No quadrante do departamento, selecionar a opção Secretária.<br>6) Clicar em Cadastrar. |
|**Critérios de Êxito** | "O usuário será direcionado à homepage. |

|Caso de Teste |CT-03 – Gerenciar cadastro |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - O sistema deve permitir o gerenciamento dos dados de cadastro dos usuários.|
|**Entrada** | a página inicial, digitar CPF e senha nos respectivos campos. |
|**Objetivo do Teste** | Validar usabilidade da edição de dados de cadastro do usuário no sistema. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>4)Clicar no botão login.<br>5) Na tela seguinte, clicar no botão "Meus dados", localizado no menu lateral esquerdo.<br>6) Clicar no quadrante de dados que deseja alterar e inserir o novo valor.<br>7) Após inserção de dados, clicar no botão "Save".<br> |
|**Critérios de Êxito** | "Usuário será direcionado para a página Meus dados." |

|Caso de Teste |CT-04 – Registro de atendimentos |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - O sistema deve permitir registrar os atendimentos, para cada atendimento o profissional de saúde deverá vincular o paciente que foi atendido ao dia, a hora e a descrição do atendimento. |
|**Entrada** | Ao realizar login na aplicação, o profissional deverá acessar o botão Relatório, localizado no menu lateral esquerdo.
|**Objetivo do Teste** | Validar usabilidade do profissional, no cadastro de atendimento nas consultas. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Clicar em login.<br>5) Na Homepage, clique em  "Atendimentos".<br>6) Na página seguinte, clique no botão Novo Atendimento.<br>7) Preencha todos os dados da consulta nos respectivos quadrantes e clique em "Criar".
|**Critérios de Êxito** | "O atendimento será registrado e o profissional será direcionado ao menu inicial." |

|Caso de Teste |CT-05 – Emissão de relatório |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-004 - O sistema deve permitir a geração de relatórios para cada atendimento realizado. |
|**Entrada** | Na homepage selecione "Relatório" e insira dados do paciente para realizar busca. |
|**Objetivo do Teste** | Validar acesso do profissional aos relatórios de atendimento. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Acessar o menu relatório.<br>5) No campo Nome Paciente pesquise por nome.<br>6) Clicar no botão pesquisar.<br>7) Escolher se deseja imprimir ou salvar relatório. |
|**Critérios de Êxito** | "O usuário visualizará campo para impressão ou download do relatório." |

|Caso de Teste |CT-06 – Recuperação de senha |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-005 - O sistema deve permitir a que a senha seja recuperada. |
|**Entrada** | Na homepage clicar em "Esqueci minha Senha". |
|**Objetivo do Teste** | Validar acesso à recuperação de senha esquecida. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Clicar em "Esqueci minha senha".<br>5) Na tela seguinte, preencher os quadrantes, CPF, Nova Senha e Confirmar Senha.<br>6) Clicar no botão Confirmar. |
|**Critérios de Êxito** | "O usuário será redirecionado para a página de Login." |

|Caso de Teste |CT-07 – Cadastramento de profissionais |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-006 - O sistema deve permitir o cadastramento de profissionais de saúde. |
|**Entrada** | Na página inicial, o usuário deverá clicar em "Cadastre aqui".  |
|**Objetivo do Teste** | Validar usabilidade do cadastrado de perfil para profissional de saúde. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>3) Clicar em Cadastre aqui.<br>4) Inserir os dados solicitados nos quadrantes em branco.<br>5) No quadrante do departamento, selecionar a opção Profissional de saúde.<br>6) Clicar em Cadastrar. |
|**Critérios de Êxito** | "O usuário será direcionado à homepage e **terá mensagem de confirmação***." |

## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
