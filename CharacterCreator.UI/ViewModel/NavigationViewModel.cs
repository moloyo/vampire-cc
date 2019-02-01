using CharacterCreator.Model;
using CharacterCreator.UI.Data;
using CharacterCreator.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CharacterCreator.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private IPersonajeLookupDataService personajeLookupDataService;

        public ObservableCollection<LookupItem> Personajes { get; }

        private IEventAggregator eventAggregator;

        public NavigationViewModel(IPersonajeLookupDataService personajeLookupDataService, IEventAggregator eventAggregator)
        {
            this.personajeLookupDataService = personajeLookupDataService;
            this.Personajes = new ObservableCollection<LookupItem>();
            this.eventAggregator = eventAggregator;
        }

        private LookupItem personajeSeleccionado;

        public LookupItem PersonajeSeleccionado
        {
            get { return personajeSeleccionado; }
            set
            {
                personajeSeleccionado = value;
                OnPropertyChanged();
                if(value != null)
                {
                    this.eventAggregator.GetEvent<OpenPersonajeDetailViewEvent>().Publish(value.ID);
                }
            }
        }


        public async Task LoadAsync()
        {
            var lookup = await this.personajeLookupDataService.GetPersonajesLookupAsync();
            Personajes.Clear();
            foreach (var item in lookup)
            {
                Personajes.Add(item);
            }
        }
    }
}
