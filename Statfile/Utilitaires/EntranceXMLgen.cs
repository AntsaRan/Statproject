using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Controller
{
    class EntranceXMLgen
    {

        public EntranceXMLgen()
        {

        }

        public PropertyInfo[] getProperties()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(Entrance);
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
