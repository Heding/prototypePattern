using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PrototypeInfrastructure
{
    public static class Utils
    {
        public static T getPrototype<T>(this T self) {

            if (!typeof(T).IsSerializable)
                throw new ArgumentException("Type T must be serializable");

            if (ReferenceEquals(self, null))
                return default(T);

            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream()) {

                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);

            }
        }
    }
}
