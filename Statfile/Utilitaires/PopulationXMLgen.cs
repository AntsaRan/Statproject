using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Controller
{
    class PopulationXMLgen
    {
        public PopulationXMLgen()
        {

        }
        public PropertyInfo[] getProperties()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(PopulationBracket);
                propertyInfos = typeof(PopulationBracket).GetProperties();
                return propertyInfos;
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
