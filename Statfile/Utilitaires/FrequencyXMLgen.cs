using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Utilitaires
{
    class FrequencyXMLgen
    {
        public FrequencyXMLgen()
        {

        }
        public PropertyInfo[] getProperties()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(Frequency);
                propertyInfos = objType.GetProperties();
                return propertyInfos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
