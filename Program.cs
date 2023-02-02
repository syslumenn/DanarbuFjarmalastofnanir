using Syslumenn;
using System.Net.Http.Headers;
using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://api.syslumenn.is/dev/");
httpClient.DefaultRequestHeaders.Accept.Clear();
httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

(string audkenni, string token) Innskraning()
{
    var response = httpClient.PostAsJsonAsync("v1/Innskraning",
                                              new Innskraning() { notandi = "notandi", lykilord = "pwd" }
                                              ).Result;
    if (response.IsSuccessStatusCode)
    {
        var result = response.Content.ReadFromJsonAsync<InnskraningSvarSkeyti>().Result;
        return (result.audkenni, result.accessToken);
    }
    else
    {
        Console.WriteLine("Villa í auðkenningu!");
        throw new Exception(response.ReasonPhrase);
    }
}

string SendaSyslumanniGognDanarbus()
{
    (string audkenni, string token) = Innskraning();

    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    var response = httpClient.PostAsJsonAsync("v1/Danarbu/BankaupplysingarDanarbus", MockupData.Get(audkenni)).Result;
    if (response.IsSuccessStatusCode)
    {
        var result = response.Content.ReadFromJsonAsync<dynamic>().Result;
        return result.ToString();
    }
    else
    {
        throw new Exception(response.ReasonPhrase);
    }
}
try
{
    var svar = SendaSyslumanniGognDanarbus();
    Console.WriteLine(svar);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
