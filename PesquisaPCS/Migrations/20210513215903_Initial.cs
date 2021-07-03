using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PesquisaPCS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agrotoxicos",
                columns: table => new
                {
                    Idagrotoxico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_agrotoxico = table.Column<string>(nullable: true),
                    Tipo_agrotoxico = table.Column<string>(nullable: true),
                    Principio_ativo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agrotoxicos", x => x.Idagrotoxico);
                });

            migrationBuilder.CreateTable(
                name: "Amostras",
                columns: table => new
                {
                    IdAmostra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idpaciente = table.Column<int>(nullable: false),
                    Idade_discretizado = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    Gestante = table.Column<string>(nullable: true),
                    Tabagismo = table.Column<string>(nullable: true),
                    Tabagismo_atual = table.Column<string>(nullable: true),
                    Tabagismo_anterior = table.Column<string>(nullable: true),
                    Etilismo = table.Column<string>(nullable: true),
                    Etilismo_atual = table.Column<string>(nullable: true),
                    Etilismo_anterior = table.Column<string>(nullable: true),
                    Ingestao_cafe = table.Column<string>(nullable: true),
                    Cafe_mldia_discretizado = table.Column<string>(nullable: true),
                    Relacao_trabalho = table.Column<string>(nullable: true),
                    Funcao_trabalho = table.Column<string>(nullable: true),
                    Contato_praguicida = table.Column<string>(nullable: true),
                    Tempo_contato_discretizado = table.Column<string>(nullable: true),
                    Ultimo_contato_discretizado = table.Column<string>(nullable: true),
                    Classe_produto1 = table.Column<string>(nullable: true),
                    Classe_produto2 = table.Column<string>(nullable: true),
                    Classe_produto3 = table.Column<string>(nullable: true),
                    Forma_aplicacao = table.Column<string>(nullable: true),
                    Via_exposicao = table.Column<string>(nullable: true),
                    Adoeceu = table.Column<string>(nullable: true),
                    Nvezes_adoeceu = table.Column<string>(nullable: true),
                    Internado = table.Column<string>(nullable: true),
                    Nvezes_internado = table.Column<string>(nullable: true),
                    Quando_internado = table.Column<string>(nullable: true),
                    Tipo_contato = table.Column<string>(nullable: true),
                    Equipamento_protecao = table.Column<string>(nullable: true),
                    Roupa_protecao = table.Column<string>(nullable: true),
                    Bota_protecao = table.Column<string>(nullable: true),
                    Luvas_protecao = table.Column<string>(nullable: true),
                    Mascara_protecao = table.Column<string>(nullable: true),
                    Oculos_protecao = table.Column<string>(nullable: true),
                    Protetor_auricular = table.Column<string>(nullable: true),
                    Doenca_cardiovascular = table.Column<string>(nullable: true),
                    Hipertensao_arterial = table.Column<string>(nullable: true),
                    Hipotensao_arterial = table.Column<string>(nullable: true),
                    Arritmia = table.Column<string>(nullable: true),
                    Alteracao_snervoso = table.Column<string>(nullable: true),
                    Dor_cabeca = table.Column<string>(nullable: true),
                    Fraqueza_muscular = table.Column<string>(nullable: true),
                    Tremedeira = table.Column<string>(nullable: true),
                    Tremor_muscular = table.Column<string>(nullable: true),
                    Visãoturva_embacada = table.Column<string>(nullable: true),
                    Agitacao_irritabilidade = table.Column<string>(nullable: true),
                    Vertigens_tonturas = table.Column<string>(nullable: true),
                    Formigamento = table.Column<string>(nullable: true),
                    Incoordenacao_motora = table.Column<string>(nullable: true),
                    Aparelho_digestorio = table.Column<string>(nullable: true),
                    Colicas_dorbarriga = table.Column<string>(nullable: true),
                    Dor_estomago = table.Column<string>(nullable: true),
                    Azia_queimacao = table.Column<string>(nullable: true),
                    Nauseas_enjoo = table.Column<string>(nullable: true),
                    Vomito = table.Column<string>(nullable: true),
                    Diarreia = table.Column<string>(nullable: true),
                    Aparelho_respiratorio = table.Column<string>(nullable: true),
                    Falta_dear = table.Column<string>(nullable: true),
                    Irritaçao_nasal = table.Column<string>(nullable: true),
                    Catarro_escarro = table.Column<string>(nullable: true),
                    Tosse = table.Column<string>(nullable: true),
                    Aparelho_auditivo = table.Column<string>(nullable: true),
                    Diminuicao_audicao = table.Column<string>(nullable: true),
                    Zumbido = table.Column<string>(nullable: true),
                    Pele_mucosa = table.Column<string>(nullable: true),
                    Dc_sensibilizante = table.Column<string>(nullable: true),
                    Dc_irritativa = table.Column<string>(nullable: true),
                    Irritacao_ocular = table.Column<string>(nullable: true),
                    Aparelho_urinario = table.Column<string>(nullable: true),
                    Diminuicao_urina = table.Column<string>(nullable: true),
                    Urinaescura_sangue = table.Column<string>(nullable: true),
                    Outro = table.Column<string>(nullable: true),
                    Exposicao_raiox = table.Column<string>(nullable: true),
                    Quandodias_exposicao_discretizado = table.Column<string>(nullable: true),
                    Teve_cancerv = table.Column<string>(nullable: true),
                    Snc_cancer = table.Column<string>(nullable: true),
                    Digestorio_cancer = table.Column<string>(nullable: true),
                    Respiratorio_cancer = table.Column<string>(nullable: true),
                    Reprodutor_cancer = table.Column<string>(nullable: true),
                    Glandular_cancer = table.Column<string>(nullable: true),
                    Pele_osso_sangue_cancer = table.Column<string>(nullable: true),
                    Familia_cancer = table.Column<string>(nullable: true),
                    Snc_cancerfamilia = table.Column<string>(nullable: true),
                    Digestorio_cancerfamilia = table.Column<string>(nullable: true),
                    Respiratorio_cancerfamilia = table.Column<string>(nullable: true),
                    Reprodutor_cancerfamilia = table.Column<string>(nullable: true),
                    Glandular_cancerfamilia = table.Column<string>(nullable: true),
                    Pele_osso_sangue_cancerfamilia = table.Column<string>(nullable: true),
                    Eda_regiao = table.Column<string>(nullable: true),
                    Ch_t_discretizado = table.Column<string>(nullable: true),
                    Ch_e_discretizado = table.Column<string>(nullable: true),
                    Ch_p_discretizado = table.Column<string>(nullable: true),
                    Ast_discretizado = table.Column<string>(nullable: true),
                    Alt_discretizado = table.Column<string>(nullable: true),
                    Y_gt_discretizado = table.Column<string>(nullable: true),
                    Creatinina_discretizado = table.Column<string>(nullable: true),
                    Ambulatorio = table.Column<string>(nullable: true),
                    Habito_alimentar_discretizado = table.Column<string>(nullable: true),
                    Imc_discretizado = table.Column<string>(nullable: true),
                    Circunferencia_abdominal_discretizado = table.Column<string>(nullable: true),
                    Dificuldade_engravidar = table.Column<string>(nullable: true),
                    Aborto_espontaneo = table.Column<string>(nullable: true),
                    Tem_filhos = table.Column<string>(nullable: true),
                    Filho_maformacao = table.Column<string>(nullable: true),
                    Medicamento_continuo = table.Column<string>(nullable: true),
                    Remedio_micose = table.Column<string>(nullable: true),
                    Sigla_diagnostico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amostras", x => x.IdAmostra);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Iddiagnostico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sigla_diagnostico = table.Column<string>(nullable: true),
                    Descricao_diagnostico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Iddiagnostico);
                });

            migrationBuilder.CreateTable(
                name: "Fichas_Agro",
                columns: table => new
                {
                    Idficha_agro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idficha = table.Column<int>(nullable: false),
                    Idproduto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas_Agro", x => x.Idficha_agro);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Idpaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Idmunicipio_residencia = table.Column<int>(nullable: false),
                    Zona_residencia = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    Data_nascimento = table.Column<DateTime>(nullable: false),
                    Escolaridade = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Idpaciente);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Idmunicipio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_municipio = table.Column<string>(nullable: true),
                    PacienteIdpaciente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Idmunicipio);
                    table.ForeignKey(
                        name: "FK_Municipios_Pacientes_PacienteIdpaciente",
                        column: x => x.PacienteIdpaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Idpaciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Idficha = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idpaciente = table.Column<int>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Idmunicipio_trabalha = table.Column<int>(nullable: false),
                    Gestante = table.Column<string>(nullable: true),
                    Tabagismo = table.Column<string>(nullable: true),
                    Tabagismo_atual = table.Column<string>(nullable: true),
                    Tabagismo_anterior = table.Column<string>(nullable: true),
                    Etilismo = table.Column<string>(nullable: true),
                    Etilismo_atual = table.Column<string>(nullable: true),
                    Etilismo_anterior = table.Column<string>(nullable: true),
                    Ingestao_cafe = table.Column<string>(nullable: true),
                    Cafe_mldia = table.Column<double>(nullable: false),
                    Relacao_trabalho = table.Column<string>(nullable: true),
                    Funcao_trabalho = table.Column<string>(nullable: true),
                    Contato_praguicida = table.Column<string>(nullable: true),
                    Tempo_contato = table.Column<int>(nullable: false),
                    Ultimo_contato = table.Column<int>(nullable: false),
                    Cultura = table.Column<string>(nullable: true),
                    Forma_aplicacao = table.Column<string>(nullable: true),
                    Via_exposicao = table.Column<string>(nullable: true),
                    Adoeceu = table.Column<string>(nullable: true),
                    Nvezes_adoeceu = table.Column<string>(nullable: true),
                    Internado = table.Column<string>(nullable: true),
                    Nvezes_internado = table.Column<string>(nullable: true),
                    Quando_internado = table.Column<string>(nullable: true),
                    Tipo_contato = table.Column<string>(nullable: true),
                    Equipamento_protecao = table.Column<string>(nullable: true),
                    Roupa_protecao = table.Column<string>(nullable: true),
                    Bota_protecao = table.Column<string>(nullable: true),
                    Luvas_protecao = table.Column<string>(nullable: true),
                    Mascara_protecao = table.Column<string>(nullable: true),
                    Oculos_protecao = table.Column<string>(nullable: true),
                    Protetor_auricular = table.Column<string>(nullable: true),
                    Doenca_cardiovascular = table.Column<string>(nullable: true),
                    Hipertensao_arterial = table.Column<string>(nullable: true),
                    Hipotensao_arterial = table.Column<string>(nullable: true),
                    Arritmia = table.Column<string>(nullable: true),
                    Alteracao_snervoso = table.Column<string>(nullable: true),
                    Dor_cabeca = table.Column<string>(nullable: true),
                    Fraqueza_muscular = table.Column<string>(nullable: true),
                    Tremedeira = table.Column<string>(nullable: true),
                    Tremor_muscular = table.Column<string>(nullable: true),
                    Visãoturva_embacada = table.Column<string>(nullable: true),
                    Agitacao_irritabilidade = table.Column<string>(nullable: true),
                    Vertigens_tonturas = table.Column<string>(nullable: true),
                    Formigamento = table.Column<string>(nullable: true),
                    Incoordenacao_motora = table.Column<string>(nullable: true),
                    Aparelho_digestorio = table.Column<string>(nullable: true),
                    Colicas_dorbarriga = table.Column<string>(nullable: true),
                    Dor_estomago = table.Column<string>(nullable: true),
                    Azia_queimacao = table.Column<string>(nullable: true),
                    Nauseas_enjoo = table.Column<string>(nullable: true),
                    Vomito = table.Column<string>(nullable: true),
                    Diarreia = table.Column<string>(nullable: true),
                    Aparelho_respiratorio = table.Column<string>(nullable: true),
                    Falta_dear = table.Column<string>(nullable: true),
                    Irritaçao_nasal = table.Column<string>(nullable: true),
                    Catarro_escarro = table.Column<string>(nullable: true),
                    Tosse = table.Column<string>(nullable: true),
                    Aparelho_auditivo = table.Column<string>(nullable: true),
                    Diminuicao_audicao = table.Column<string>(nullable: true),
                    Zumbido = table.Column<string>(nullable: true),
                    Pele_mucosa = table.Column<string>(nullable: true),
                    Dc_sensibilizante = table.Column<string>(nullable: true),
                    Dc_irritativa = table.Column<string>(nullable: true),
                    Irritacao_ocular = table.Column<string>(nullable: true),
                    Aparelho_urinario = table.Column<string>(nullable: true),
                    Diminuicao_urina = table.Column<string>(nullable: true),
                    Urinaescura_sangue = table.Column<string>(nullable: true),
                    Outro = table.Column<string>(nullable: true),
                    Exposicao_raiox = table.Column<string>(nullable: true),
                    Quandodias_exposicao = table.Column<int>(nullable: false),
                    Teve_cancer = table.Column<string>(nullable: true),
                    Snc_cancer = table.Column<string>(nullable: true),
                    Digestorio_cancer = table.Column<string>(nullable: true),
                    Respiratorio_cancer = table.Column<string>(nullable: true),
                    Reprodutor_cancer = table.Column<string>(nullable: true),
                    Glandular_cancer = table.Column<string>(nullable: true),
                    Pele_osso_sangue_cancer = table.Column<string>(nullable: true),
                    Familia_cancer = table.Column<string>(nullable: true),
                    Snc_cancerfamilia = table.Column<string>(nullable: true),
                    Digestorio_cancerfamilia = table.Column<string>(nullable: true),
                    Respiratorio_cancerfamilia = table.Column<string>(nullable: true),
                    Reprodutor_cancerfamilia = table.Column<string>(nullable: true),
                    Glandular_cancerfamilia = table.Column<string>(nullable: true),
                    Pele_osso_sangue_cancerfamilia = table.Column<string>(nullable: true),
                    Eda_regiao = table.Column<string>(nullable: true),
                    Ch_t = table.Column<double>(nullable: false),
                    Ch_e = table.Column<double>(nullable: false),
                    Ch_p = table.Column<double>(nullable: false),
                    Ast = table.Column<double>(nullable: false),
                    Alt = table.Column<double>(nullable: false),
                    Y_gt = table.Column<double>(nullable: false),
                    Creatinina = table.Column<double>(nullable: false),
                    Ambulatorio = table.Column<string>(nullable: true),
                    Habito_alimentar = table.Column<double>(nullable: false),
                    Imc = table.Column<double>(nullable: false),
                    Circunferencia_abdominal = table.Column<int>(nullable: false),
                    Dificuldade_engravidar = table.Column<string>(nullable: true),
                    Aborto_espontaneo = table.Column<string>(nullable: true),
                    Tem_filhos = table.Column<string>(nullable: true),
                    Filho_maformacao = table.Column<string>(nullable: true),
                    Medicamento_continuo = table.Column<string>(nullable: true),
                    Medicamento = table.Column<string>(nullable: true),
                    Remedio_micose = table.Column<string>(nullable: true),
                    Nome_remedio = table.Column<string>(nullable: true),
                    Iddiagnostico = table.Column<int>(nullable: false),
                    MunicipioIdmunicipio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Idficha);
                    table.ForeignKey(
                        name: "FK_Fichas_Municipios_MunicipioIdmunicipio",
                        column: x => x.MunicipioIdmunicipio,
                        principalTable: "Municipios",
                        principalColumn: "Idmunicipio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_MunicipioIdmunicipio",
                table: "Fichas",
                column: "MunicipioIdmunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_PacienteIdpaciente",
                table: "Municipios",
                column: "PacienteIdpaciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agrotoxicos");

            migrationBuilder.DropTable(
                name: "Amostras");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "Fichas_Agro");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
