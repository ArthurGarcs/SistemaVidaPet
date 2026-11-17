# Documento de Requisitos — Sistema VidaPet
**Projeto:** TP1 — Projeto de Bloco: Desenvolvimento Back-End 
**Domínio:** Clínica Veterinária VidaPet  

---

## 1. Introdução e Escopo
O Sistema VidaPet tem como objetivo principal substituir o controlo manual em papel realizado na receção por um sistema digital estruturado, eliminando problemas como horários marcados em duplicidade e consultas esquecidas. Nesta primeira etapa (TP1), o escopo foca-se no levantamento e especificação dos requisitos funcionais e não funcionais que norteiam todo o desenvolvimento do sistema.

---

## 2. Requisitos Funcionais (RF)

| ID | Requisito | Descrição |
| :--- | :--- | :--- |
| **RF01** | Cadastro de Animais | O sistema deve permitir o registo de animais informando nome, espécie (exclusivo para cão ou gato), idade, nome do tutor e telefone de contacto do tutor. |
| **RF02** | Cadastro de Veterinários | O sistema deve permitir o registo de veterinários informando o nome e o respetivo CRMV. |
| **RF03** | Agendamento de Consultas | O recepcionista deve poder agendar uma consulta associando um animal, um veterinário, data, horário, situação inicial e observações. |
| **RF04** | Validação de Horário Comercial | As consultas devem ter uma duração fixa de 30 minutos e só podem ser agendadas de segunda a sexta-feira, no horário compreendido entre as 8h00 e as 18h00. |
| **RF05** | Restrição de Conflito de Agenda | O sistema deve impedir que um veterinário possua duas consultas agendadas num mesmo dia e horário coincidente. |
| **RF06** | Validação de Data Futura | O sistema deve rejeitar o agendamento de consultas em datas que já passaram (data anterior à data atual do sistema). |
| **RF07** | Cancelamento de Consulta | O recepcionista ou o sistema deve permitir o cancelamento de uma consulta **apenas** se a sua situação atual estiver registada como "agendada". |
| **RF08** | Consulta de Agenda Diária | O veterinário deve conseguir consultar a sua agenda de atendimentos filtrada para o dia corrente. |
| **RF09** | Registo de Atendimento Realizado | O veterinário responsável pela consulta deve poder alterar a situação da consulta de "agendada" para "realizada", registando as observações do atendimento. |

---

## 3. Requisitos Não Funcionais (RNF)

| ID | Requisito | Descrição |
| :--- | :--- | :--- |
| **RNF01** | Linguagem e Plataforma | O sistema deve ser desenvolvido em **C#** utilizando o **.NET 10 SDK (LTS)**, garantindo portabilidade e execução via CLR. |
| **RNF02** | Organização do Repositório | O repositório no GitHub deve seguir rigidamente a separação estrutural exigida, contendo a pasta `docs/` (com a documentação) e a pasta `src/` (com o código-fonte). |
| **RNF03** | Interface de Linha de Comandos (CLI) | O protótipo standalone inicial deve interagir com o utilizador através de um menu em consola estruturado, limpo e intuitivo. |
| **RNF04** | Qualidade e Manutenibilidade | O código-fonte deve adotar padrões claros de nomenclatura de variáveis, tipagem estrita e tratamento defensivo de entradas do utilizador. |