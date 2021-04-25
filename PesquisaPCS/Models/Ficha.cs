using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaPCS.Models
{
    public class Ficha
    {
        [Key]
        public int Idficha { get; set; }
        public int Idpaciente { get; set; }
        public int Idade { get; set; }
        public int Idmunicipio_trabalha { get; set; }
        public string Gestante { get; set; }
        public string Tabagismo { get; set; }
        public string Tabagismo_atual { get; set; }
        public string Tabagismo_anterior { get; set; }
        public string Etilismo { get; set; }
        public string Etilismo_atual { get; set; }
        public string Etilismo_anterior { get; set; }
        public string Ingestao_cafe { get; set; }
        public double Cafe_mldia { get; set; }
        public string Relacao_trabalho { get; set; }
        public string Funcao_trabalho { get; set; }
        public string Contato_praguicida { get; set; }
        public int Tempo_contato { get; set; }
        public int Ultimo_contato { get; set; }
        public string Cultura { get; set; }
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
        public int Quandodias_exposicao { get; set; }
        public string Teve_cancer { get; set; }
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
        public double Ch_t { get; set; }
        public double Ch_e { get; set; }
        public double Ch_p { get; set; }
        public double Ast { get; set; }
        public double Alt { get; set; }
        public double Y_gt { get; set; }
        public double Creatinina { get; set; }
        public string Ambulatorio { get; set; }
        public double Habito_alimentar { get; set; }
        public double Imc { get; set; }
        public int Circunferencia_abdominal { get; set; }
        public string Dificuldade_engravidar { get; set; }
        public string Aborto_espontaneo { get; set; }
        public string Tem_filhos { get; set; }
        public string Filho_maformacao { get; set; }
        public string Medicamento_continuo { get; set; }
        public string Medicamento { get; set; }
        public string Remedio_micose { get; set; }
        public string Nome_remedio { get; set; }
        public int Iddiagnostico { get; set; }
    }
}

