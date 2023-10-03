using Newtonsoft.Json;

namespace LotteryData.Model;

internal class LotteryResult
{
    [JsonProperty("loteria")]
    public string Loteria { get; set; }

    [JsonProperty("concurso")]
    public int Concurso { get; set; }

    [JsonProperty("data")]
    public string Data { get; set; }

    [JsonProperty("local")]
    public string Local { get; set; }

    [JsonProperty("dezenasOrdemSorteio")]
    public List<string> DezenasOrdemSorteio { get; set; }

    [JsonProperty("dezenas")]
    public List<string> Dezenas { get; set; }

    [JsonProperty("trevos")]
    public List<object> Trevos { get; set; }

    [JsonProperty("timeCoracao")]
    public string TimeCoracao { get; set; }

    [JsonProperty("mesSorte")]
    public string MesSorte { get; set; }

    [JsonProperty("premiacoes")]
    public List<LotteryResultAward> Premiacoes { get; set; }

    [JsonProperty("estadosPremiados")]
    public List<object> EstadosPremiados { get; set; }

    [JsonProperty("observacao")]
    public string Observacao { get; set; }

    [JsonProperty("acumulou")]
    public bool Acumulou { get; set; }

    [JsonProperty("proximoConcurso")]
    public int ProximoConcurso { get; set; }

    [JsonProperty("dataProximoConcurso")]
    public string DataProximoConcurso { get; set; }

    [JsonProperty("localGanhadores")]
    public List<LotteryResultAwardLocation> LocalGanhadores { get; set; }

    [JsonProperty("valorArrecadado")]
    public decimal ValorArrecadado { get; set; }

    [JsonProperty("valorAcumuladoConcurso_0_5")]
    public decimal ValorAcumuladoConcurso05 { get; set; }

    [JsonProperty("valorAcumuladoConcursoEspecial")]
    public decimal ValorAcumuladoConcursoEspecial { get; set; }

    [JsonProperty("valorAcumuladoProximoConcurso")]
    public decimal ValorAcumuladoProximoConcurso { get; set; }

    [JsonProperty("valorEstimadoProximoConcurso")]
    public decimal ValorEstimadoProximoConcurso { get; set; }
}
