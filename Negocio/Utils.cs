using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Utils
    {
        public static void parse<T>(object sourceObject, ref T destObject)
        {
            //Si el source o la destination son nulas return
            if(sourceObject == null || destObject == null)
            {
                return;
            }
            //Conseguimos el tipo de los dos objetos
            Type sourceType = sourceObject.GetType();
            Type targetType= destObject.GetType();

            //Loop en las propiedades de source

            foreach( PropertyInfo p in sourceType.GetProperties())
            {
                //Coge las propiedades comunes.
                PropertyInfo targetOjb = targetType.GetProperty(p.Name);
                //Si no hay ninguna skip
                if(targetOjb == null)
                {
                    continue;
                }

                //Setea el valor en el destinatario
                targetOjb.SetValue(destObject, p.GetValue(sourceObject, null), null);
            }
        }

    }
}
