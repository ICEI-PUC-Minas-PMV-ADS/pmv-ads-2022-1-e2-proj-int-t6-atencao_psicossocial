# Plano de Testes de Software

|Caso de Teste |CT-01 – Login do usuário |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir que os profissionais façam login.|
|**Entrada** | Na página inicial, digitar CPF e senha nos respectivos campos. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>3) Preencher os campos CPF e senha.<br>4) Clicar no botão Login. |
|**Critérios de Êxito** | "O usuário sera direcionado a homepage e terá acesso ao seu menu.". |

|Caso de Teste |CT-02 – Cadastro de Profissionais |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir cadastrar o profissional. |
|**Entrada** | Na página inicial, o usuário deverá clicar em "Cadastre aqui".  |
|**Objetivo do Teste** | Permitir que o usuário se cadastre no sistema, conforme sua área de atuação. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>3) Clicar em Cadastre aqui.<br>4) Inserir os dados pessoais nos quadrantes em branco.<br>5) Selecionar o tipo de profissional no quadrante do departamento.<br>6) Clicar em Cadastrar. |
|**Critérios de Êxito** | O usuário será direcionado à homepage e **terá mensagem de confirmação***. |

|Caso de Teste |CT-03 – Gerenciar profissional |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - O sistema deve permitir o gerenciamento dos dados de usuário.|
|**Entrada** | a página inicial, digitar CPF e senha nos respectivos campos. |
|**Objetivo do Teste** | Permitir que o usuário edite dados de cadastro no sistema. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>4)Clicar no botão login.<br>5) Na tela seguinte, clicar no botão "Meus dados", localizado no menu lateral esquerdo.<br>6) Clicar no quadrante de dados que deseja alterar e inserir o novo valor.<br>7) Após inserção de dados, clicar no botão "Save".<br> |
|**Critérios de Êxito** | Usuário será direcionado para a página Meus dados, **com os dados já salvos**. |

|Caso de Teste |CT-04 – Registro de atendimentos |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - O sistema deve permitir registrar os atendimentos, para cada atendimento o profissional de saúde deverá vincular o paciente que foi atendido ao dia, a hora e a descrição do atendimento. |
|**Entrada** | Ao realizar login na aplicação, o usuário deverá acessar o botão Relatório, localizado no menu lateral esquerdo.
|**Objetivo do Teste** | Permitir que o usuário cadastre informações de consultas vinculadas entre paciente e profissional, com  caracteristicas e observações para consultas e controles posteriores. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Clicar em login.<br>5) Na Homepage, clique em  "Atendimentos".<br>6) Na página aberta clique no botão Azul (Novo Atendimento).<br>7) Preencha todos os dados nos quadrantes vazios e clique em "Criar".
|**Critérios de Êxito** | O usuário será direcionado a homepage. |

|Caso de Teste |CT-06 – Emissão de Relatório |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-004 - O sistema deve permitir a geração de relatórios para cada atendimento realizado. |
|**Entrada** | Na homepage selecione "Relatório" e insira dados do paciente para realizar busca. |
|**Objetivo do Teste** | Permitir que o profissional tenha acesso aos relatórios de atendimento. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço: https://psiconnect20220609203034.azurewebsites.net/.<br>4) Acessar o menu relatório.<br>5) No campo Nome Paciente pesquise por nome.<br>6) Clicar no botão pesquisar.<br>7) Escolher se deseja imprimir ou salvar relatório. |
|**Critérios de Êxito** | O usuário visualizará campo para impressão ou download do relatório. |

## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
