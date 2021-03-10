using MC = Model.Client.Models;
using MG = Model.Global.Models;

namespace Model.Client.Mapper
{
    public static class Mapper
    {
        public static MC.Person ToClient(this MG.Person entity)
        {
            if (entity == null) return null;
            return new MC.Person(
                entity.Id,
                entity.Nom,
                entity.Prenom
                );
        }
        public static MG.Person ToGlobal(this MG.Person entity)
        {
            if (entity == null) return null;
            return new MG.Person()
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Prenom = entity.Prenom
            };
        }
    }
}
