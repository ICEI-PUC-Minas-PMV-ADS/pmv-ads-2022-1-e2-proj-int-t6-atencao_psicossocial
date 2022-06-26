# Plano de Testes de Usabilidade

O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação interativa. O Plano de Testes da usabilidade é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.

# Metodo: 
O método utilizado é de medição e avaliação. O teste visa a avaliar: 
  - O total de erros cometidos;
  - Quantidade de erros (discriminadamente);
  - Tempo gasto para conclusão da tarefa;
  - Concretização da tarefa;
  - Grau de satisfação com a tarefa com uso da escala de Likert.
  - Grau de dificuldade para executar a tarefa do passo a passo;

# Objetivos
  - Percorrer a aplicação visando identificar eventuais falhas de execução de software e avaliar a facilidade de execução dos objetivos pelos usuários;
  - Identificar os erros e corrigir de forma a melhorar aspectos de interação com usuário, responsividade e funcionamento.

# Análise dos testes
Realizados os testes, será feita análise quantitativa dos aspectos negativos observados, bem como poderá incluir comentários sobre a qualidade da aplicação. 


| `Caso de teste ` | ` CTU-001 Login do usuário ` | ` Dificuldade  ` | `  Grau Satisfação geral  ` |` Análise `|
|:---:|:---:|:---:|:---:|:---:|
| Objetivo do teste | Realizar login no sistema      |   Não há   |         Total           |        Fácil usabilidade, sem erros, compreensão geral.      |
| Critérios de Êxito | O usuário será direcionado à homepage e terá acesso ao Menu pessoal|

| `Caso de teste ` | ` CTU-002 Cadastrar novo usuário `         | ` Dificuldade  ` | `  Grau Satisfação geral  ` |` Análise `|
|:---:|:---:|:---:|:---:|:---:|
| Objetivo do teste | Identificar opção de cadastro e criar usuário  |  Não apareceu máscara no CPF | Total |  Mediante observação do usuário corrigido a máscara do CPF |
| Critérios de Êxito | O usuário será direcionado à página de login|


| `Caso de teste ` | ` CTU-003 Editar Cadastro `               | ` Dificuldade  ` | `  Grau Satisfação geral  ` |` Análise `|
|:---:|:---:|:---:|:---:|:---:|
| Objetivo do teste            | Verificar se é claro as informações de preenchimento  | Não há confirmação de alteração  |  Parcial | Apesar retornar ao menu inicial, em uma nova versão poderá ser implementada a validação da alteração |
| Critérios de Êxito           | Usuário será direcionado para a página Meus dados|


| `Caso de teste ` | ` CTU-004 Registro de atendimento  `        | ` Dificuldade  ` | `  Grau Satisfação geral  ` |` Análise `|
|:---:|:---:|:---:|:---:|:---:|
| Objetivo do teste            | Usuário identifica símbolo e legenda  |  Não há |  Total |  Fácil usabilidade, sem erros, compreensão geral.  |
| Critérios de Êxito           | O atendimento será registrado e o profissional será direcionado ao menu inicial|


| `Caso de teste ` | ` CTU-005 Emissão de relatório `            | ` Dificuldade  ` | `  Grau Satisfação geral  ` |` Análise `|
|:---:|:---:|:---:|:---:|:---:|
| Objetivo do teste            | Verificar se o sistema emite relatório|  Não há |  Total |  Fácil usabilidade, sem erros, compreensão geral.  |
| Critérios de Êxito           | O usuário visualizará campo para impressão ou download do relatório|

| `Caso de teste ` | ` CTU-006 Recuperação de senha `            | ` Dificuldade  ` | `  Grau Satisfação geral  ` |` Análise `|
|:---:|:---:|:---:|:---:|:---:|
| Objetivo do teste            | Verificar se o usuário consegue recuperar a senha  |  Poderia aparecer a mensagem de alteração da senha | Parcial  |  Apesar retornar ao menu inicial, em uma nova versão poderá ser implementada a validação da alteração |
| Critérios de Êxito           | O usuário será redirecionado para a página de Login|



