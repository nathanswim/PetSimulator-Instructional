using PetSimulator.UI.Abstractions;

namespace PetSimulator.ProcCode
{
    public class ProcPetService : IPetService
    {
        ProcedureCodeSample _sample = new();

        public IEnumerable<IUiDisplayItem> GetPets()
            => GetNameValues<PetType>();

        public IEnumerable<IUiDisplayItem> GetActions(IUiDisplayItem pet)
            => GetNameValues<PetActionType>();

        public IUiDisplayItem MakePet(PetType type, string name)
        {
            _sample.MakePet(type, name);
            return new UiDisplayItem(_sample.PetName, _sample.PetType);
        }

        public IUiDisplayItem GetPet()
        {
            if (!_sample.IsCreated)
                return UiDisplayItem.Empty;
            else
                return new UiDisplayItem(_sample.PetName, _sample.PetType);
        }

        public IEnumerable<IUiDisplayItem> GetNameValues<TEnum>() where TEnum : struct, Enum
        {
            var result = new List<IUiDisplayItem>();
            var values = Enum.GetValues<TEnum>();
            foreach (var value in values)
            {
                var name = Enum.GetName(value) ?? "";
                result.Add(new UiDisplayItem(name, value));
            }
            return result;
        }

    }
}