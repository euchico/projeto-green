using Newtonsoft.Json;

namespace LotteryData.Model;

internal class LotteryResultAwardLocation
{
    [JsonProperty("ganhadores")]
    public int Ganhadores { get; set; }

    [JsonProperty("municipio")]
    public string Municipio { get; set; }

    [JsonProperty("nomeFatansiaUL")]
    public string NomeFatansiaUL { get; set; }

    [JsonProperty("serie")]
    public string Serie { get; set; }

    [JsonProperty("posicao")]
    public int Posicao { get; set; }

    [JsonProperty("uf")]
    public string Uf { get; set; }
}
