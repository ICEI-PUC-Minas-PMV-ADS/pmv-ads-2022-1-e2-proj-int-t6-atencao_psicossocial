A
<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.


## CT-01 - Login do usuário
https://user-images.githubusercontent.com/61605610/175189496-e3b58fe8-bc4a-44e1-a2d4-2d8bb1fb37f0.mp4

## CT-02 - Cadastro de usuário  
https://user-images.githubusercontent.com/61605610/175189672-4a24100a-a4d7-4e4d-9e3a-fce25c170cda.mp4

## CT-03 - Editar Cadastro
https://user-images.githubusercontent.com/61605610/175189681-b3953c27-e8b1-484c-94c0-33c819225b8a.mp4

## CT-04 - Registro de atendimentos
https://user-images.githubusercontent.com/61605610/175189686-ffb1133f-8ff0-4c96-af22-fe2d1acd6401.mp4

## CT-05 - Emissão de relatório
https://user-images.githubusercontent.com/61605610/175189698-6bd7fa9e-df87-4730-be8b-c848c1f97098.mp4

## CT-06 - Recuperação de senha
https://user-images.githubusercontent.com/61605610/175189709-54ada8b7-d51d-4611-87a4-1a9754145c81.mp4

## Avaliação

Como demonstra o resultado do teste acima, o usuário inseriu os seus dados nos formulários e o sistema não retornou nenhum alerta de erro, o que demonstra o sucesso nas aplicações. Esta aplicação visa possibilitar ao usuário do projeto o controle de atendimento de pacientes, bem como oferecer ao profissional uma base com uma construção de um software possibilitando o usuário ter acesso ao registro dos pacientes. Para fins de avaliação, elaboramos a seguinte tabela que relaciona os casos de teste de software  propostos e os respectivos comentários a respeito das funcionalidades da aplicação:

| Requisitos          |              Descrição             |Comentarios/Consideraçãoes|Status                                  |
|---------------------|------------------------------------|--------------------------|----------------------------------------|
|CT-01 - Login do usuário|Login de usuario/profissional.  |Usuario/profissional consegue acessar a plataforma com sucesso ao realisar o login.|Implementado com sucesso.               |
|CT-02 - Cadastro de usuário | Permite que o usuario se cadastre na plataforma, com sua respectiva atuação no sistema.|Usuario consegue acessar a pagina de cadastro de usuario e se cadastrar com sucesso.| Implementado parcialmente.|
|CT-03 - Editar Cadastro| Permite ao usuario alterar entre atuações no sistema, como Profissional da Saude e Secretario(a).|Usuario consegue acessar a pagina de Meus dados e alterar entre permissoes com sucesso.| Implementado com sucesso.|
|CT-04 - Registro de atendimentos | Permite que o profissional da saude registre atendimento com as seguintes informações: prescrição medica, caracteristicas do tratamento do paciente.| Profissional da saude consegue acessar a pagina de Atendimentos e cadastrar adentimento realizado com sucesso. | Implementado com sucesso.|
|CT-05 - Emissão de relatório| Permite que o usuario crie um relatorio para cada paciente atendido.| Profissional/Usuario tem acesso ao historico de atendimentos de cada paciente com sucesso.| Implementado com sucesso.|
|CT-06 - Recuperação de senha| Permite que o usuario recupe e ou redefina sua senha, atraves de seu CPF.| Usuario consegue acessar a pagina de de recuperação de senha, mas foi encontrado falta de segurança e/ou vulnerabilidade dos dados, futuramente , em momento oportuno podemos melhorar com uma autenticação de dois fatores. | Implementado parcialmente.|

