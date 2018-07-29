using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Serialization.Model
{
    class TypeSimple : BaseSimpleElement
    {
        TypeSimple(string name)
        {
            FullName = name;
        }

        public static implicit operator TypeSimple(Type type)
        {
            TypeSimple result = new TypeSimple(type.FullName);
            return result;
        }
    }
}
