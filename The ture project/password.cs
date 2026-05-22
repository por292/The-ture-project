using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
namespace The_ture_project
{
    internal class password
    {

    }
}
public class Account
{
    public int id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
}
class Program
{
    static void Main()
    {
        string json = @"[
          { ""id"": 1, ""username"": ""alex_starling99"", ""password"": ""Tr!$7#qP29"" },
          { ""id"": 2, ""username"": ""bruce_lee_88"", ""password"": ""P@ssw0rd!_88"" },
          { ""id"": 3, ""username"": ""morgan_dev_2026"", ""password"": ""C0d!ng$tr0ng!&"" }
        ]";

        var accounts = JsonSerializer.Deserialize<List<Account>>(json);

        foreach (var acc in accounts)
        {
            Console.WriteLine($"ID: {acc.id}, Username: {acc.username}, Password: {acc.password}");
        }
    }
}
