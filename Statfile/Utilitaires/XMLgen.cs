using Statfile.Model;
using Statfile.Utilitaires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Statfile.Controller
{
    class XMLgen
    {
        private General general;
        private Parameters parameters;
        private List<PopulationBracket> population;
        private List<Opening> openings;
        private List<Closing> closings;
        private List<Street> streets;
        private List<Entrance> entrances;
        private List<School> schools;
        private List<BusStation> busstation;
        private List<BusLine> buslines;

        internal General General { get => general; set => general = value; }
        internal Parameters Parameters { get => parameters; set => parameters = value; }
        internal List<PopulationBracket> Population { get => population; set => population = value; }
        internal List<Closing> Closings { get => closings; set => closings = value; }
        internal List<Opening> Openings { get => openings; set => openings = value; }
        internal List<Street> Streets { get => streets; set => streets = value; }
        internal List<Entrance> Entrances { get => entrances; set => entrances = value; }
        internal List<School> Schools { get => schools; set => schools = value; }
        internal List<BusStation> Busstation { get => busstation; set => busstation = value; }
        internal List<BusLine> Buslines { get => buslines; set => buslines = value; }

        public XMLgen()
        {
        }

        public void writeXML(string path)
        {
            try { 
            GeneralXMLgen genxml = new GeneralXMLgen();
            ParametersXMLgen paramxml = new ParametersXMLgen();
            PopulationXMLgen popxml = new PopulationXMLgen();
            WorkXMLgen workxml = new WorkXMLgen();
            StreetsXMLgen streetxml = new StreetsXMLgen();
            EntranceXMLgen entrancexml = new EntranceXMLgen();
            SchoolXMLgen schoolxml = new SchoolXMLgen();
            BusStationXMLgen busStationxml = new BusStationXMLgen();
            FrequencyXMLgen frequencyXML = new FrequencyXMLgen();


            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = true;
            XmlWriter writer = XmlWriter.Create(path, settings);

            PropertyInfo[] propertyInfosGen = genxml.getProperties();
            PropertyInfo[] propertyInfosParams = paramxml.getProperties();
            PropertyInfo[] propertyInfosPop = popxml.getProperties();
            PropertyInfo[] propertyInfosWorkOpening = workxml.getPropertiesOpening();
            PropertyInfo[] propertyInfosWorkClosing = workxml.getPropertiesClosing();
            PropertyInfo[] propertyInfosStreets = streetxml.getProperties();
            PropertyInfo[] propertyInfosEntrances = entrancexml.getProperties();
            PropertyInfo[] propertyInfosSchool = schoolxml.getProperties();
            PropertyInfo[] propertyInfosBusStation = busStationxml.getProperties();
            PropertyInfo[] propertyInfosFrequency = frequencyXML.getProperties();

            //START XML
             writer.WriteStartElement("city");
           // PARTIE GENERAL
            writer.WriteStartElement("general");
            foreach (PropertyInfo propertyInfo in propertyInfosGen)
            { string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
              writer.WriteAttributeString(name, general.GetType().GetProperty(propertyInfo.Name).GetValue(general, null).ToString().Replace(',', '.')); 
            }
            writer.WriteEndElement();
            //PARTIE PARAMETRES
                writer.WriteStartElement("parameters");
            foreach (PropertyInfo propertyInfo in propertyInfosParams)
            {
                string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                writer.WriteAttributeString(name, parameters.GetType().GetProperty(propertyInfo.Name).GetValue(parameters, null).ToString().Replace(',', '.'));
            }
                writer.WriteEndElement();

            //PARTIE POPULATION
            writer.WriteStartElement("population");

            for (int i = 0; i < Population.Count(); i++)
            {
                writer.WriteStartElement("bracket");
                foreach (PropertyInfo propertyInfo in propertyInfosPop)
                {
                    string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                    writer.WriteAttributeString(name, Population[i].GetType().GetProperty(propertyInfo.Name).GetValue(Population[i], null).ToString().Replace(',', '.'));
                }
   
                writer.WriteEndElement();

            }
            writer.WriteEndElement();
            //PARTIE WORKHOURS
            writer.WriteStartElement("workHours");

            for (int i = 0; i < Openings.Count(); i++)
            {
                writer.WriteStartElement("opening");
                foreach (PropertyInfo propertyInfo in propertyInfosWorkOpening)
                {
                    string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                    writer.WriteAttributeString(name, Openings[i].GetType().GetProperty(propertyInfo.Name).GetValue(Openings[i], null).ToString().Replace(',', '.'));
                }

                writer.WriteEndElement();

            }

            for (int i = 0; i < Closings.Count(); i++)
            {
                writer.WriteStartElement("closing");
                foreach (PropertyInfo propertyInfo in propertyInfosWorkClosing)
                {
                    string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                    writer.WriteAttributeString(name, Closings[i].GetType().GetProperty(propertyInfo.Name).GetValue(Closings[i], null).ToString().Replace(',', '.'));
                }

                writer.WriteEndElement();

            }
            writer.WriteEndElement();
                //PARTIE RUES
                writer.WriteStartElement("streets");

                for (int i = 0; i < streets.Count(); i++)
                {
                    writer.WriteStartElement("street");
                    foreach (PropertyInfo propertyInfo in propertyInfosStreets)
                    {
                        string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                        writer.WriteAttributeString(name, streets[i].GetType().GetProperty(propertyInfo.Name).GetValue(streets[i], null).ToString().Replace(',', '.'));
                    }

                    writer.WriteEndElement();

                }
                writer.WriteEndElement();

                //CITYGATES
                writer.WriteStartElement("cityGates");

                for (int i = 0; i < entrances.Count(); i++)
                {
                    writer.WriteStartElement("entrance");
                    foreach (PropertyInfo propertyInfo in propertyInfosEntrances)
                    {
                        string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                        writer.WriteAttributeString(name, entrances[i].GetType().GetProperty(propertyInfo.Name).GetValue(entrances[i], null).ToString().Replace(',', '.'));
                    }

                    writer.WriteEndElement();

                }
                writer.WriteEndElement();
                //SCHOOLS
                writer.WriteStartElement("schools");

                for (int i = 0; i < Schools.Count(); i++)
                {
                    writer.WriteStartElement("school");
                    foreach (PropertyInfo propertyInfo in propertyInfosSchool)
                    {
                        string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                        writer.WriteAttributeString(name, Schools[i].GetType().GetProperty(propertyInfo.Name).GetValue(Schools[i], null).ToString().Replace(',', '.'));
                    }

                    writer.WriteEndElement();

                }
                writer.WriteEndElement();
                //BUSSTATIONS
                writer.WriteStartElement("busStations");

                for (int i = 0; i < Busstation.Count(); i++)
                {
                    writer.WriteStartElement("busStation");
                    foreach (PropertyInfo propertyInfo in propertyInfosBusStation)
                    {
                        string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                        writer.WriteAttributeString(name, Busstation[i].GetType().GetProperty(propertyInfo.Name).GetValue(Busstation[i], null).ToString().Replace(',', '.'));
                    }

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                //BUSLINES
                writer.WriteStartElement("busLines");

                for (int i = 0; i < Buslines.Count(); i++)
                {
                    List<BusStation> stations = Buslines[i].Stations;
                    List<BusStation> revStations = Buslines[i].RevStations;
                    List<Frequency> frequencies = Buslines[i].Frequencies;

                    writer.WriteStartElement("busLine");
                    writer.WriteAttributeString("id", Buslines[i].Id.ToString());
                    writer.WriteAttributeString("maxTripDuration", Buslines[i].MaxTripDuration.ToString());
                    writer.WriteStartElement("stations");
                    for (int j = 0; j < stations.Count(); j++)
                    {
                        writer.WriteStartElement("station");
                        writer.WriteAttributeString("refId", stations[i].Id.ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    for (int j = 0; j < revStations.Count(); j++)
                    {
                        writer.WriteStartElement("station");
                        writer.WriteAttributeString("refId", stations[i].Id.ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteStartElement("frequencies");
                    for (int j = 0; j < frequencies.Count(); j++)
                    {
                        writer.WriteStartElement("frequency");
                        foreach (PropertyInfo propertyInfo in propertyInfosFrequency)
                        {
                            string name = char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                            writer.WriteAttributeString(name, frequencies[i].GetType().GetProperty(propertyInfo.Name).GetValue(frequencies[i], null).ToString().Replace(',', '.'));
                        }
                        writer.WriteEndElement();

                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            writer.WriteFullEndElement();
            writer.Close();
            writer.Flush();

            }catch(Exception e)
            {
                throw e;
            }

        }
    }
}
