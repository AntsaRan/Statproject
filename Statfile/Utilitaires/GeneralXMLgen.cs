using Statfile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Statfile.Controller
{
    class GeneralXMLgen
    {
       
        public GeneralXMLgen()
        {
               
        }

 
        public PropertyInfo[] getProperties()
        {
            try
            {
                PropertyInfo[] propertyInfos;
                Type objType = typeof(General);
                propertyInfos = typeof(General).GetProperties();
                return propertyInfos;
            }catch ( Exception e)
            {
                throw e;
            }
     


        }
    }
}
