# Espespecificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

| Marcela            |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial/blob/main/docs/img/Marcela.png)|**Idade:** 27  anos - **Ocupação:** Ocupação: Psicóloga e pós-graduanda. |Aplicativos: Instagram e whatsApp.|
|**Motivações:** Marcela tem a ideia de melhorar a qualidade dos atendimentos a partir da criação de perfis de pacientes.  |**Frustrações:** Baseiam se na falta de organização das informações coletadas, agenda confusa, uso de formulários em papel e arquivos arcaicos, além da perda de documentos por funcionários e ausência de confidencialidade.|**Hobbies:** Ler, praticar esportes e aprender coisas novas.|

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.




Problema<br>
Com base no que foi mencionado, busca-se uma solução que auxilie os profissionais ligados à área de atenção psicossocial no gerenciamento de informações, de maneira que estas estejam organizadas e padronizadas, além de facilitar o acesso dessas informações.

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

#### A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que os usuários façam login e alterem sua senha. | ALTA | 
|RF-002| O sistema deve permitir gerenciar o paciente e o profissional.   | ALTA |
|RF-003| O sistema deve permitir gerenciar os atendimentos, para cada atendimento o profissional de saúde deverá vincular o paciente que foi atendido ao dia, a hora e a escrição do atendimento.   | ALTA |
|RF-004| O sistema deve emitir os seguintes relatórios: Relatório profissional, relatório por atendimento ao paciente, relatório por data.  | ALTA |
|RF-005| O sistema deve permitir ao profissional registrar o atendimento.   | ALTA |
|RF-006| O site deve permitir a visualização dos agendamentos na plataforma e do histórico de consultas por mês e status: Concluído, reagendado ou cancelado   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O App ou site será publicado em um ambiente na Internet. cap(GitHub, Firebase) | ALTA | 
|RNF-002| O website poderá ser acessado por um telefone celular Android ou IOS com uma visualização adequada. |  ALTA | 
|RNF-003| O website será compatível com os principais navegadores do mercado. |  ALTA | 
|RNF-004| O website deve ser confiável, deve atender às suas especificações. |  MÉDIA | 
|RNF-005| O website deve tratar acessos não autorizados, garantindo um alto grau de segurança. |  MÉDIA | 
|RNF-006| A interface do website deve ser amigável, ou seja deve se sentir confortável ao utilizar o site, de forma que sua experiência torna-se fácil. |  BAIXA | 
Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

| Ator | Descrição |
|------|------|
| Usuário | Funcionários e pacientes do centro de atendimento interessados em utilizar a aplicação |
|-----|-----|
| Banco de Dados | Banco de Dados responsável por armazenar, buscar e gerenciar as solicitações da plataforma |
|----|-----|
| CAPS | Centro de Atenção Psicossocial |



| Caso de Uso | Descrição | RF |
|Realizar o Cadastro de usuário na Home Page | O cadastro deve ser feito a partir de uma ficha de dados com informações do usuário | RF-02 |
| Alterar a senha | O usuário deve conseguir alterar sua senha de acesso | RF-01 |
| Fazer o login na aplicação | O usuário deve conseguir realizar o login na aplicação através de um nome de uma senha | RF-01 |
| Modificar prontuário | O site deve permitir o acesso e edição da documentação relativa ao paciente antes, durante e depois do atendimento | RF-05 |
| Alterar agendamentos | O site deve permitir aos usuários a marcação, remarcação e cancelamento de atendimentos | RF-03 |
| Gerar relatórios | O site deve permitir a visualização do  histórico de consultas por mês e gerar relatórios com base nestas informações | RF-04 |

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
