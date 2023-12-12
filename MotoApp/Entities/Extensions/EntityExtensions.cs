using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MotoApp.Entities.Extensions
{
    public static class EntityExtensions
    {
        public static T? Copy<T>(this T? itemTOCopy) where T : IEntity
        {
            var json=JsonSerializer.Serialize<T>(itemTOCopy);
            return JsonSerializer.Deserialize<T>(json);

        }




    }
}
