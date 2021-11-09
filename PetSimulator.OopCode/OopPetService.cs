using PetSimulator.UI.Abstractions;

namespace PetSimulator.OopCode
{
    public class OopPetService : IPetService
    {
        public IEnumerable<IUiDisplayItem> GetActions(IUiDisplayItem pet) => throw new NotImplementedException();
        public IUiDisplayItem GetPet() => throw new NotImplementedException();
        public IEnumerable<IUiDisplayItem> GetPets() => throw new NotImplementedException();
        public IUiDisplayItem MakePet(PetType type, string name) => throw new NotImplementedException();
    }
}