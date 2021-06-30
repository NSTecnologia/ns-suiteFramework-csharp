using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSSuiteClientCSharp.Projetos._Genéricos
{
    public abstract class JSON
    {
        public virtual string ToJSONString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings 
            { 
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
