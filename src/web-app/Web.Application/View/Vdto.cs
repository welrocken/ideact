using System;

namespace Ideact.Web.Application.View
{
    public abstract class Vdto
    {
        private string id;
        public string Id
        {
            get
            {
                if (id == null)
                    id = GetId(GetType(), FreeId());

                return id;
            }
        }

        private static string FreeId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string GetId<T>(string id)
        {
            return GetId(typeof(T), id);
        }

        public static string GetId(Type type, string id)
        {
            return type.Name + id;
        }
    }
}