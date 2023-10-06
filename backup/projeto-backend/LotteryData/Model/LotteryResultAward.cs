using Newtonsoft.Json;

namespace LotteryData.Model;

internal class LotteryResultAward
{
    [JsonProperty("descricao")]
    public string Descricao { get; set; }

    [JsonProperty("faixa")]
    public int Faixa { get; set; }

    [JsonProperty("ganhadores")]
    public int Ganhadores { get; set; }

    [JsonProperty("valorPremio")]
    public decimal ValorPremio { get; set; }
}
