# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

| Marcela            |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial/blob/main/docs/img/Marcela.png)|**Idade:** 27  anos - **Ocupação:** Psicóloga e pós-graduanda. |Aplicativos: Instagram e whatsApp.|
|**Motivações:** Marcela tem a ideia de melhorar a qualidade dos atendimentos a partir da criação de perfis de pacientes.  |**Frustrações:** Baseiam se na falta de organização das informações coletadas, agenda confusa, uso de formulários em papel e arquivos arcaicos, além da perda de documentos por funcionários e ausência de confidencialidade.|**Hobbies:** Ler, praticar esportes e aprender coisas novas.|
| Isaque            |                                    |                |
|![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial/blob/main/docs/img/Isaque.png)|**Idade:** 38  anos - **Ocupação:** Assistente Social e Gestor de Unidade de Saúde Pública. |**Aplicativos:** WhatsApp, Telegram, Teams e Facebook.|
|**Motivações:** Melhorar a qualidade dos serviços prestados e abranger um número maior de atendidos nas áreas de cobertura da unidade.  |**Frustrações:** Desorganização dos dados coletados, problemas relacionados à perda e mistura de documentos/ registros de pacientes, falta de meios para planejamento de programas específicos.|**Hobbies:** Ler, acompanhar notícias online, conversar com amigos por meio de videochamadas.|
| Cristiane            |                                    |                |
|![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial/blob/main/docs/img/Cristiane.png)|**Idade:** 34  anos - **Ocupação:** Secretária no Centro de Atendimento Psicossocial. |**Aplicativos:** Whatsapp, Telegram.|
|**Motivações:** Otimizar a parte de agendamentos, check in e sequência nos tratamentos oferecidos pelo centro.  |**Frustrações:** Dificuldade de agendar e confirmar consultas na clínica; dificuldade de conciliar a disponibilidade dos profissionais com a  dos pacientes.|**Hobbies:** Assistir séries e cozinhar.|





## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`                     |PARA ... `MOTIVO/VALOR`                                                |
|--------------------|--------------------------------------------------------|-----------------------------------------------------|
|Marcela             | Receber notificação dos agendamentos                   | Obter controle total da agenda de consultas         |
|Marcela             | Receber notificação dos cancelamentos                  | Realizar possíveis encaixes                                                   |
|Marcela             | Cadastrar pacientes através de Prontuário Eletrônico   | Facilitar a busca de pacientes, registro de atendimentos |
|Marcela             | Registrar/editar atendimentos/informações de pacientes | Facilitar o processo de trabalho sem meios físicos e evitar perda/ extravio de documentos |
|Marcela             | Registrar informações de forma restrita/especial e bloquear o acesso de terceiros não autorizados | Garantir a confidencialidade das informações dos pacientes |
|Isaque              | Cadastrar pacientes através de prontuário eletrônico   | Economizar papel e espaço na clínica |
|Isaque              | Gerar relatórios eletrônicos                           | Evitar a perda de documentos |
|Isaque              | Guardar as informações em um banco de dados            | Facilitar a relação de dados e possibilitar a criação de perfis de usuários |
|Cristiane           | Cadastrar os pacientes na plataforma e editar ou excluir os perfis quando necessário | Organizar o banco de dados e facilitar o acesso/controle das sessões |
 



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

#### A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que os profissionais façam login. | ALTA | 
|RF-002| O sistema deve permitir gerenciar o profissional.   | ALTA |
|RF-003| O sistema deve permitir registrar os atendimentos, para cada atendimento o profissional de saúde deverá vincular o paciente que foi atendido ao dia, a hora e a descrição do atendimento.   | ALTA |
|RF-004| O sistema deve emitir os seguintes relatórios: Relatório por profissional, relatório por atendimento ao paciente, relatório por data, histórico de consultas .  | ALTA |
|RF-005| O sistema deve permitir que os profissionais alterem a senha. | ALTA | 
|RF-006| O sistema deve permitir que os profissionais se cadastrem. | ALTA | 

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O App ou site será publicado em um ambiente na Internet. (Azure) | ALTA | 
|RNF-002| A aplicação web poderá ser acessado por um telefone celular Android ou IOS com uma visualização adequada. |  ALTA | 
|RNF-003| A aplicação web será compatível com os principais navegadores do mercado. |  ALTA | 
|RNF-004| A aplicação web deve ser confiável, deve atender às suas especificações. |  MÉDIA | 
|RNF-005| A aplicação web deve tratar acessos não autorizados, garantindo um alto grau de segurança. |  MÉDIA | 
|RNF-006| A interface da aplicação deve ser amigável, ou seja deve se sentir confortável ao utilizar o site, de forma que sua experiência torna-se fácil. |  BAIXA | 


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo. |
|02| O aplicativo deve se restringir às tecnologias básicas da Web de FrontEnd e Backend        |
|03| A equipe não pode subcontratar terceiros para o desenvolvimento do trabalho        |
|04| O projeto não pode ser feito por um único integrante do grupo        |
|05| As decisões pertinentes ao projeto devem ser tomadas por meio democrático de votação        |
|06| O projeto deve estar em conformidade com as leis e normas vigentes        |



## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

| Ator | Descrição |
|------|------|
| Usuário | Funcionários e pacientes do centro de atendimento interessados em utilizar a aplicação |
| Banco de Dados | Banco de Dados responsável por armazenar, buscar e gerenciar as solicitações da plataforma |
| CAPS | Centro de Atenção Psicossocial |



| Caso de Uso | Descrição | RF |
|------|------|------|
|Realizar o Cadastro de usuário na Home Page | O cadastro deve ser feito a partir de uma ficha de dados com informações do usuário | RF-02 |
| Alterar a senha | O usuário deve conseguir alterar sua senha de acesso | RF-01 |
| Fazer o login na aplicação | O usuário deve conseguir realizar o login na aplicação através de um nome e uma senha | RF-01 |
| Modificar prontuário | O site deve permitir o acesso e edição da documentação relativa ao paciente antes, durante e depois do atendimento | RF-05 |
| Alterar agendamentos | O site deve permitir aos usuários a marcação, remarcação e cancelamento de atendimentos | RF-03 |
| Gerar relatórios | O site deve permitir a visualização do  histórico de consultas por mês e gerar relatórios com base nestas informações | RF-04 |

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

| RELACIONAMETO | DESCRIÇÃO |
|------|------|
| INCLUSÃO | É necessário fazer o login na aplicação antes de realizar os casos de uso: “Solicitar ficha do paciente”, “Solicitar relatório de agendamento”, “Solicitar prontuário de atendimento” |
| | Para solicitar a ficha do paciente é  necessário que o banco de dados busque informações por palavra “chave”.|
|  | Para solicitar relatório de agendamento é necessário que o banco de dados busque informações por palavra “chave”. |
|EXTENSÃO|Caso o usuário ainda não tenha cadastro, será necessário fazê-lo antes de fazer login na aplicação.|
| |Caso o usuário tenha esquecido sua senha, será necessário alterá-la antes de fazer login na aplicação.|
||Caso o usuário deseje requisitar prontuário poderá fazer pesquisa em banco de dados.|

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e3-proj-mov-t4-voga-app/blob/main/docs/img/imagem%20cronograma%20de%20caso%20de%20uso.png)



> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
