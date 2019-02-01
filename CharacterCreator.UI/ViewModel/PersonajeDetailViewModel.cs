using CharacterCreator.Model;
using CharacterCreator.UI.Data;
using CharacterCreator.UI.Event;
using Prism.Events;
using System.Threading.Tasks;

namespace CharacterCreator.UI.ViewModel
{
    public class PersonajeDetailViewModel : ViewModelBase, IPersonajeDetailViewModel
    {
        private IPersonajeDataService personajeDataService;
        private IEventAggregator eventAggregator;
        private Personaje personaje;

        public Personaje Personaje
        {
            get { return personaje; }
            private set
            {
                personaje = value;
                OnPropertyChanged();
            }
        }

        public PersonajeDetailViewModel(IPersonajeDataService personajeDataService, IEventAggregator eventAggregator)
        {
            this.personajeDataService = personajeDataService;
            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<OpenPersonajeDetailViewEvent>().Subscribe(OnOpenPersonajeDetailView);
        }

        private async void OnOpenPersonajeDetailView(int idPersonaje)
        {
            await this.LoadAsync(idPersonaje);
        }

        public async Task LoadAsync(int idPersonaje)
        {
            Personaje = await this.personajeDataService.GetByIdAsync(idPersonaje);
        }
    }
}
