using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Statfile.Controller
{
    class WorkXMLgen
    {
        public WorkXMLgen()
        {
        }
        public PropertyInfo[] getPropertiesOpening()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(Opening);
                propertyInfos = objType.GetProperties();
                return propertyInfos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public PropertyInfo[] getPropertiesClosing()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(Closing);
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
