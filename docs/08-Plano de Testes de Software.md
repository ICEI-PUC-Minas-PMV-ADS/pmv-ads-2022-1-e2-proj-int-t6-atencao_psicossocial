# Plano de Testes de Software

|Caso de Teste |CT-01 – Login do usuário |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir que os profissionais façam login.|
|**Entrada** | Na página incial, digitar CPF e senha nos respectivos campos. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador. <br>2) Informar endereço: https://psiconnect20220609203034.azurewebsites.net/. <br>3) Preencher os campos CPF e senha.<br>4) Clicar no botão Login. |
|**Critérios de Êxito** | "O usuário sera direcionado a homepage e terá acesso ao seu menu.". |

|Caso de Teste |CT-02 – Alterar Senha |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O sistema deve permitir que os profissionais façam login e alterem sua senha.|
|**Entrada** | Após clicar no botão esqueci senha, o usuário deverá informar o email cadastrado. |
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
|**Entrada** | Editar Cadastro Profissional: Após preencher dados do profissional. |
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

|Caso de Teste |CT-06 – Emissão de Relatório |
|--------------------|-----------------------------------------------------------------------------------------------------------------------|
|**Requisitos Associados** | RF-004 - O sistema deve permitir a geração de relatórios para cada atendimento realizado. |
|**Entrada** | Através de um formulário contendo informações do paciente e profissional vinculado. |
|**Objetivo do Teste** | Permitir que o profissional tenha acesso ao registo do atendimento. |
|**Passos** | 1) Acessar o Navegador .<br>2) Informar o endereço do Site.<br>3) Fazer login.<br>4) Acessar o menu relatório.<br>5) Ir no campo nome do paciente.<br>6) Adicionar CPF ou nome do paciente.<br>7) Clicar no botão pesquisar.<br>8) Clicar botão imprimir. |
|**Critérios de Êxito** | O usuário será visualizará campo para impressão ou download do relatório. |

## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
