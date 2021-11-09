namespace PetSimulator.UI.Abstractions
{
    public interface IPetService
    {
        IEnumerable<IUiDisplayItem> GetPets();
        IEnumerable<IUiDisplayItem> GetActions(IUiDisplayItem pet);

        IUiDisplayItem GetPet();

        string MakePet(IUiDisplayItem petType, string petName);

        string PerformAction(IUiDisplayItem action);
    }

}