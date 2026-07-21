// La versión NO está en el .csproj sino centralizada en Directory.Packages.props:
// el lector tiene que resolverla de ahí o no encuentra nada.
using Newtonsoft.Json;

Console.WriteLine(JsonConvert.SerializeObject(new { ok = true }));
