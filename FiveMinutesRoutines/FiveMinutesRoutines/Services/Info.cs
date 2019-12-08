using System;
using FiveMinutesRoutines.Business;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
namespace FiveMinutesRoutines.Services
{
    public class Info : IInfo
    {
        public async Task<IList<Info>> GetInfoGroups()
        {
            // Read RecipeData.json from this PCL's DataModel folder
            var name = typeof(Info).AssemblyQualifiedName.Split(',')[1].Trim();
            var assembly = Assembly.Load(new AssemblyName(name));
            var stream = assembly.GetManifestResourceStream(name + ".Data.RecipeData.json");

            // Parse the JSON and generate a collection of RecipeGroup objects
            using (var reader = new StreamReader(stream))
            {
                string json = await reader.ReadToEndAsync();
                var obj = new { Groups = new List<Info>() };
                var result = JsonConvert.DeserializeAnonymousType(json, obj);
                return result.Groups;
            }
        }
    }
}
