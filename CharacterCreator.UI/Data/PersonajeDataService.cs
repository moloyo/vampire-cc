using CharacterCreator.DataAccess;
using CharacterCreator.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace CharacterCreator.UI.Data
{
    public class PersonajeDataService : IPersonajeDataService
    {
        private Func<CharacterCreatorDbContext> contextCreator;

        public PersonajeDataService(Func<CharacterCreatorDbContext> contextCreator)
        {
            this.contextCreator = contextCreator;
        }

        public async Task<Personaje> GetByIdAsync(int idPersonaje)
        {
            using (var ctx = this.contextCreator())
            {
                return await ctx.Personajes.AsNoTracking().SingleAsync(p => p.ID == idPersonaje);
            }
        }
    }
}
