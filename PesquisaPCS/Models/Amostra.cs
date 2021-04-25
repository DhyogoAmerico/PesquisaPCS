using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Amostra
    {
        [Key]
        public int IdAmostra { get; set; }
        public int Idpaciente { get; set; }
        public string Idade_discretizado { get; set; }
        public char Sexo { get; set; }
        public string Gestante { get; set; }
        public string Tabagismo { get; set; }
        public string Tabagismo_atual { get; set; }
        public string Tabagismo_anterior { get; set; }
        public string Etilismo { get; set; }
        public string Etilismo_atual { get; set; }
        public string Etilismo_anterior { get; set; }
        public string Ingestao_cafe { get; set; }
        public string Cafe_mldia_discretizado { get; set; }
        public string Relacao_trabalho { get; set; }
        public string Funcao_trabalho { get; set; }
        public string Contato_praguicida { get; set; }
        public string Tempo_contato_discretizado { get; set; }
        public string Ultimo_contato_discretizado { get; set; }
        public string Classe_produto1 { get; set; }
        public string Classe_produto2 { get; set; }
        public string Classe_produto3 { get; set; }
        public string Forma_aplicacao { get; set; }
        public string Via_exposicao { get; set; }
        public string Adoeceu { get; set; }
        public string Nvezes_adoeceu { get; set; }
        public string Internado { get; set; }
        public string Nvezes_internado { get; set; }
        public string Quando_internado { get; set; }
        public string Tipo_contato { get; set; }
        public string Equipamento_protecao { get; set; }
        public string Roupa_protecao { get; set; }
        public string Bota_protecao { get; set; }
        public string Luvas_protecao { get; set; }
        public string Mascara_protecao { get; set; }
        public string Oculos_protecao { get; set; }
        public string Protetor_auricular { get; set; }
        public string Doenca_cardiovascular { get; set; }
        public string Hipertensao_arterial { get; set; }
        public string Hipotensao_arterial { get; set; }
        public string Arritmia { get; set; }
        public string Alteracao_snervoso { get; set; }
        public string Dor_cabeca { get; set; }
        public string Fraqueza_muscular { get; set; }
        public string Tremedeira { get; set; }
        public string Tremor_muscular { get; set; }
        public string Visãoturva_embacada { get; set; }
        public string Agitacao_irritabilidade { get; set; }
        public string Vertigens_tonturas { get; set; }
        public string Formigamento { get; set; }
        public string Incoordenacao_motora { get; set; }
        public string Aparelho_digestorio { get; set; }
        public string Colicas_dorbarriga { get; set; }
        public string Dor_estomago { get; set; }
        public string Azia_queimacao { get; set; }
        public string Nauseas_enjoo { get; set; }
        public string Vomito { get; set; }
        public string Diarreia { get; set; }
        public string Aparelho_respiratorio { get; set; }
        public string Falta_dear { get; set; }
        public string Irritaçao_nasal { get; set; }
        public string Catarro_escarro { get; set; }
        public string Tosse { get; set; }
        public string Aparelho_auditivo { get; set; }
        public string Diminuicao_audicao { get; set; }
        public string Zumbido { get; set; }
        public string Pele_mucosa { get; set; }
        public string Dc_sensibilizante { get; set; }
        public string Dc_irritativa { get; set; }
        public string Irritacao_ocular { get; set; }
        public string Aparelho_urinario { get; set; }
        public string Diminuicao_urina { get; set; }
        public string Urinaescura_sangue { get; set; }
        public string Outro { get; set; }
        public string Exposicao_raiox { get; set; }
        public string Quandodias_exposicao_discretizado { get; set; }
        public string Teve_cancerv { get; set; }
        public string Snc_cancer { get; set; }
        public string Digestorio_cancer { get; set; }
        public string Respiratorio_cancer { get; set; }
        public string Reprodutor_cancer { get; set; }
        public string Glandular_cancer { get; set; }
        public string Pele_osso_sangue_cancer { get; set; }
        public string Familia_cancer { get; set; }
        public string Snc_cancerfamilia { get; set; }
        public string Digestorio_cancerfamilia { get; set; }
        public string Respiratorio_cancerfamilia { get; set; }
        public string Reprodutor_cancerfamilia { get; set; }
        public string Glandular_cancerfamilia { get; set; }
        public string Pele_osso_sangue_cancerfamilia { get; set; }
        public string Eda_regiao { get; set; }
        public string Ch_t_discretizado { get; set; }
        public string Ch_e_discretizado { get; set; }
        public string Ch_p_discretizado { get; set; }
        public string Ast_discretizado { get; set; }
        public string Alt_discretizado { get; set; }
        public string Y_gt_discretizado { get; set; }
        public string Creatinina_discretizado { get; set; }
        public string Ambulatorio { get; set; }
        public string Habito_alimentar_discretizado { get; set; }
        public string Imc_discretizado { get; set; }
        public string Circunferencia_abdominal_discretizado { get; set; }
        public string Dificuldade_engravidar { get; set; }
        public string Aborto_espontaneo { get; set; }
        public string Tem_filhos { get; set; }
        public string Filho_maformacao { get; set; }
        public string Medicamento_continuo { get; set; }
        public string Remedio_micose { get; set; }
        public string Sigla_diagnostico { get; set; }
    }
}
