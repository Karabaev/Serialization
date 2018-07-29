using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Serialization.Model
{
    class AssemblySimple : BaseSimpleElement
    {
        

        AssemblySimple(string fullName)
        {
            FullName = fullName;
        }

        public static implicit operator AssemblySimple(Assembly assembly)
        {
            AssemblySimple result = new AssemblySimple(assembly.FullName);
            return result;
        }
    }
}
