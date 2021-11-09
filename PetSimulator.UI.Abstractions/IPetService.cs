namespace PetSimulator.UI.Abstractions
{
    public interface IPetService
    {
        IEnumerable<IUiDisplayItem> GetPets();
        IEnumerable<IUiDisplayItem> GetActions(IUiDisplayItem pet);

        IUiDisplayItem MakePet(PetType type, string name);

        IUiDisplayItem GetPet();
    }

}