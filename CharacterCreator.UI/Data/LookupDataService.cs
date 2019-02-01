using CharacterCreator.DataAccess;
using CharacterCreator.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.UI.Data
{
    public class LookupDataService : IPersonajeLookupDataService
    {
        private Func<CharacterCreatorDbContext> contextCreator;

        public LookupDataService(Func<CharacterCreatorDbContext> contextCreator)
        {
            this.contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetPersonajesLookupAsync()
        {
            using (var context = this.contextCreator())
            {
                return await context.Personajes.AsNoTracking().Select(p => new LookupItem
                {
                    ID = p.ID,
                    DisplayMember = p.Nombre
                }).ToListAsync();
            }
        }
    }
}
