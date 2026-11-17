# Especificação de Casos de Uso (UML) — Sistema VidaPet
**Projeto:** TP1 — Projeto de Bloco: Desenvolvimento Back-End 
**Domínio:** Clínica Veterinária VidaPet  

---

## 1. Identificação de Atores
* **Recepcionista:** Ator responsável pela gestão administrativa da clínica, incluindo o cadastro de animais, o cadastro de veterinários e o agendamento ou cancelamento de consultas.
* **Veterinário:** Ator responsável pela prestação do atendimento clínico, consulta da agenda diária e encerramento de consultas com o registro de observações.

---

## 2. Diagrama de Casos de Uso (Representação Textual UML)

```text
+-------------------------------------------------------------------+
|                         SISTEMA VIDAPET                           |
|                                                                   |
|  [Recepcionista] ---> ( UC01: Cadastrar Animal )                  |
|  [Recepcionista] ---> ( UC02: Cadastrar Veterinário )             |
|  [Recepcionista] ---> ( UC03: Agendar Consulta )                  |
|  [Recepcionista] ---> ( UC04: Cancelar Consulta )                 |
|                                                                   |
|  [Veterinário]   ---> ( UC05: Consultar Agenda Diária )           |
|  [Veterinário]   ---> ( UC06: Registrar Atendimento Realizado )   |
|                                                                   |
+-------------------------------------------------------------------+
```

---

## 3. Detalhamento Completo dos Casos de Uso

### UC01: Cadastrar Animal
* **Ator Principal:** Recepcionista
* **Pré-condição:** Nenhuma.
* **Fluxo Principal:**
  1. O recepcionista solicita o cadastro de um novo animal.
  2. O sistema solicita os dados obrigatórios: nome, espécie (cão ou gato), idade, nome do tutor e telefone de contato.
  3. O recepcionista preenche as informações solicitadas.
  4. O sistema valida se a espécie informada é válida ("cão" ou "gato") e se os campos obrigatórios estão preenchidos.
  5. O sistema salva o cadastro do animal e exibe uma mensagem de confirmação.
* **Fluxos Alternativos:**
  * *A1 Espécie Inválida:* Se o recepcionista informar uma espécie diferente de cão ou gato, o sistema rejeita o cadastro e emite um alerta.

---

### UC02: Cadastrar Veterinário
* **Ator Principal:** Recepcionista
* **Pré-condição:** Nenhuma.
* **Fluxo Principal:**
  1. O recepcionista inicia o cadastro de um novo veterinário.
  2. O sistema solicita o nome completo e o número do CRMV.
  3. O recepcionista insere os dados.
  4. O sistema valida se o CRMV já se encontra cadastrado.
  5. O sistema grava o veterinário e confirma a operação.
* **Fluxos Alternativos:**
  * *A1 CRMV Duplicado:* Se o CRMV já existir no sistema, o cadastro é bloqueado e é exibido um aviso de duplicidade.

---

### UC03: Agendar Consulta
* **Ator Principal:** Recepcionista
* **Pré-condição:** O animal e o veterinário devem estar previamente cadastrados no sistema.
* **Fluxo Principal:**
  1. O recepcionista inicia a operação de agendamento de consulta.
  2. O sistema solicita os dados obrigatórios: animal, veterinário, data, horário e observações iniciais.
  3. O recepcionista insere os dados solicitados.
  4. O sistema valida se a data é futura e se respeita o horário comercial (segunda a sexta-feira, das 8h00 às 18h00, em blocos de 30 minutos).
  5. O sistema verifica se o veterinário já possui outra consulta agendada no mesmo horário.
  6. Estando todas as validações corretas, o sistema grava a consulta com a situação "agendada" e confirma o sucesso.
* **Fluxos Alternativos:**
  * *A1 Data Passada ou Fora do Horário:* Se a data for anterior à atual ou fora do período útil, o sistema rejeita o agendamento e exibe uma mensagem de erro.
  * *A2 Conflito de Horário:* Se o veterinário já estiver ocupado no horário pretendido, o sistema bloqueia o registro e notifica o usuário.

---

### UC04: Cancelar Consulta
* **Ator Principal:** Recepcionista
* **Pré-condição:** A consulta deve estar registrada com a situação atual "agendada".
* **Fluxo Principal:**
  1. O recepcionista seleciona a consulta que pretende cancelar.
  2. O sistema verifica o estado atual da consulta.
  3. O sistema altera a situação da consulta para "cancelada".
  4. O sistema emite uma mensagem de confirmação de cancelamento.
* **Fluxos Alternativos:**
  * *A1 Consulta Já Encerrada:* Se a consulta já estiver realizada ou cancelada previamente, o sitema impede a alteração e emite um alerta.

---

### UC05: Consultar Agenda Diária
* **Ator Principal:** Veterinário
* **Pré-condição:** O veterinário deve estar devidamente identificável no sistema.
* **Fluxo Principal:**
  1. O veterinário solicit a visualização da sua agenda.
  2. O sistema filtra e exibe todas as consultas associadas ao seu CRMV para o dia corrente, ordenadas por horário.
* **Fluxos Alternativos:**
  * *A1 Agenda Vazia:* Se não existirem consultas para o dia, o sistema exibe uma mensagem informativa de ausência de agendamentos

---

### UC06: Registrar Atendimento Realizado
* **Ator Principal:** Veterinário
* **Pré-condição:** A consulta deve estar com o estado "agendda".
* **Fluxo Principal:**
  1. O veterinário seleciona uma consulta pendente na sua agenda diária.
  2. O sistema solicita a inserção das observações clínicas do atendimento.
  3. O veterinário introduz as anotações e confirma o encerramento do atendimento.
  4. O sistema atualiza a situação da consulta para "realizada" e salva os dados.
* **Fluxos Alternativos:**
  * *A1 (Estado Incompatível):* Se a consulta selecionada já estiver cancelada ou realizada, o sistema bloqueia a ação e avisa o usuário.