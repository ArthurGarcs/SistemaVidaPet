using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;

        string animalNome = "";
        string animalEspecie = "";
        int animalIdade = 0;
        string tutorNome = "";
        string tutorTelefone = "";
        bool animalCadastrado = false;

        string vetNome = "";
        string vetCrmv = "";
        bool vetCadastrado = false;

        string consultaData = "";
        string consultaHorario = "";
        string consultaStatus = "Livre";
        string consultaObservacoes = "";
        bool consultaAtiva = false;

       
        Console.WriteLine("SISTEMA DE AGENDAMENTO — VIDAPET");
    

        do
        {
            Console.WriteLine("\n--- MENU PRINCIPAL ---");
            Console.WriteLine("1. Cadastrar Animal");
            Console.WriteLine("2. Cadastrar Veterinário");
            Console.WriteLine("3. Agendar Consulta");
            Console.WriteLine("4. Visualizar Agenda/Consultas");
            Console.WriteLine("5. Cancelar Consulta");
            Console.WriteLine("6. Registrar Atendimento Realizado");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("\n[ERRO] Por favor, digite um número válido correspondente ao menu");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\n--- CADASTRO DE ANIMAL ---");
                    Console.Write("Nome do animal: ");
                    animalNome = Console.ReadLine();

                    Console.Write("Espécie (Cão ou Gato): ");
                    animalEspecie = Console.ReadLine().Trim();

                    if (animalEspecie.Equals("Cão", StringComparison.OrdinalIgnoreCase) || 
                        animalEspecie.Equals("Gato", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Idade do animal (anos): ");
                        if (int.TryParse(Console.ReadLine(), out animalIdade))
                        {
                            Console.Write("Nome do tutor: ");
                            tutorNome = Console.ReadLine();

                            Console.Write("Telefone do tutor: ");
                            tutorTelefone = Console.ReadLine();

                            animalCadastrado = true;
                            Console.WriteLine("\n[SUCESSO] Animal cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\n[ERRO] Idade inválida. Cadastro cancelado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n[ERRO] Espécie não permitida! O sistema atende apenas Cães e Gatos");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- CADASTRO DE VETERINÁRIO ---");
                    Console.Write("Nome do veterinário: ");
                    vetNome = Console.ReadLine();

                    Console.Write("CRMV do veterinário: ");
                    vetCrmv = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(vetNome) && !string.IsNullOrWhiteSpace(vetCrmv))
                    {
                        vetCadastrado = true;
                        Console.WriteLine("\n[SUCESSO] Veterinario cadastrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("\n[ERRO] Preencha todos os campos do veterinário.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\n--- AGENDAMENTO DE CONSULTA ---");
                    if (!animalCadastrado || !vetCadastrado)
                    {
                        Console.WriteLine("\n[AVISO] E necessário ter ao menos um Animal e um Veterinário cadastrados para agendar.");
                        break;
                    }

                    Console.Write("Informe a data da consulta (DD/MM/AAAA): ");
                    consultaData = Console.ReadLine();

                    Console.Write("Informe o horário: ");
                    consultaHorario = Console.ReadLine();

                    Console.Write("Observações iniciais: ");
                    consultaObservacoes = Console.ReadLine();

                    consultaStatus = "Agendada";
                    consultaAtiva = true;
                    Console.WriteLine($"\n[SUCESSO] Consulta agendada para o animal {animalNome} com o Dr(a). {vetNome} no dia {consultaData} às {consultaHorario}!");
                    break;

                case 4:
                    Console.WriteLine("\n--- CONSULTA DE AGENDA ---");
                    if (!consultaAtiva)
                    {
                        Console.WriteLine("\nNenhuma consulta ativa no momento.");
                    }
                    else
                    {
                        Console.WriteLine($"Status: {consultaStatus}");
                        Console.WriteLine($"Data/Horário: {consultaData} às {consultaHorario}");
                        Console.WriteLine($"Animal: {animalNome} ({animalEspecie}), Tutor: {tutorNome} - Tel: {tutorTelefone}");
                        Console.WriteLine($"Veterinário: {vetNome} (CRMV: {vetCrmv})");
                        Console.WriteLine($"Observações: {consultaObservacoes}");
                    }
                    break;

                case 5:
                    Console.WriteLine("\n--- CANCELAR CONSULTA ---");
                    if (consultaAtiva && consultaStatus == "Agendada")
                    {
                        consultaStatus = "Cancelada";
                        consultaAtiva = false;
                        Console.WriteLine("\n[SUCESSO] Consulta cancelada com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("\n[ERRO] Não há consultas agendadas válidas para cancelar");
                    }
                    break;

                case 6:
                    Console.WriteLine("\n--- REGISTRAR ATENDIMENTO REALIZADO ---");
                    if (consultaAtiva && consultaStatus == "Agendada")
                    {
                        consultaStatus = "Realizada";
                        consultaAtiva = false;
                        Console.Write("Digite as observações finais/diagnóstico do atendimento: ");
                        string obsFinal = Console.ReadLine();
                        consultaObservacoes += " | Conclusão: " + obsFinal;
                        Console.WriteLine("\n[SUCESSO] Consulta marcada como realizada pelo veterinário!");
                    }
                    else
                    {
                        Console.WriteLine("\n[ERRO] Somente consultas ativas e agendadas podem ser marcadas como realizadas");
                    }
                    break;

                case 0:
                    Console.WriteLine("\nEncerrando o programa VidaPet. Até logo!");
                    break;

                default:
                    Console.WriteLine("\n[ERRO] Opção inválida. Escolha um número entre 0 e 6");
                    break;
            }

        } while (opcao != 0);
    }
}