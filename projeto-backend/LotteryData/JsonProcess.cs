using System.Collections.Generic;
using System.Text.Json;

namespace LotteryData;

internal class JsonProcess
{
    internal List<string> GetLotteryList(string json)
    {
        try
        {
            using (JsonDocument response = JsonDocument.Parse(json))
            {
                List<string> lotteryList = new List<string>();

                foreach(JsonElement element in response.RootElement.EnumerateArray())
                {
                    if (element.ValueKind == JsonValueKind.String)
                    {
                        lotteryList.Add(element.GetString());
                    }
                }
                
                return lotteryList;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
