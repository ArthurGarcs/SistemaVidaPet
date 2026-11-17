# Justificativa de Escopo — Sistema VidaPet
**Projeto:** TP1 — Projeto de Bloco: Desenvolvimento Back-End 
**Domínio:** Clínica Veterinária VidaPet  

---

## 1. Delimitação do Escopo (O que entra no TP1)
Nesta primeira fase (TP1), o projeto tem um foco essencialmente analítico, de modelagem e de validação do ambiente. O escopo contempla:
* **Modelagem Documental:** O levantamento detalhado de requisitos funcionais e não funcionais, definindo as regras de negócio e restrições do sistema.
* **Modelagem de Casos de Uso (UML):** A especificação formal dos atores (Recepcionista e Veterinário) e dos fluxos principais e alternativos das operações centrais da clínica.
* **Protótipo Standalone Inicial (`src/`):** Um programa em consola desenvolvido em C# (.NET 10) para testar o ambiente de desenvolvimento, tipos primitivos, operadores e controlo de fluxo, sem a complexidade de classes ou bases de dados nesta etapa preliminar.

---

## 2. Delimitação Futura 
Para simular a evolução real de um projeto de software em equipas de engenharia, foram deliberadamente diferidos para as próximas entregas:
* **Programação Orientada a Objetos (POO):** A criação de classes estruturadas, atributos, encapsulamento e métodos para as entidades (Animal, Veterinário e Consulta) será introduzida nos blocos seguintes.
* **Persistência de Dados:** O armazenamento definitivo dos registos em base de dados relacional ou em memória via ORM, ocorrerá em fases posteriores.
* **Arquitetura Web e API REST:** A transição do programa em consola para uma aplicação web completa com controladores e endpoints HTTP em ASP.NET Core será realizada nas etapas finais.
* **Segurança e Autenticação:** Mecanismos de controlo de acessos por papéis (perfis de utilizador para recepcionistas e veterinários) serão aplicados na camada de serviço web.

---

## 3. Suposições e Decisões de Projeto
* **Duração Padrão:** Assume-se que todas as consultas ocupam estritamente blocos de 30 minutos, simplificando o cálculo de sobreposição de horários na agenda dos profissionais.
* **Janela Operacional:** O sistema restringe o agendamento exclusivamente a dias úteis (segunda a sexta-feira) e ao horário comercial padrão (8h00 às 18h00).
* **Espécies Permitidas:** Conforme a especificação inicial fornecida, o registo de animais restringe-se unicamente a cães e gatos, delimitando o domínio veterinário desta fase.