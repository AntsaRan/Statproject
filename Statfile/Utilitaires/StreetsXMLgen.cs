using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Controller
{
    class StreetsXMLgen
    {
        public StreetsXMLgen()
        {

        }
        public PropertyInfo[] getProperties()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(Street);
                propertyInfos = typeof(Street).GetProperties();
                return propertyInfos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
