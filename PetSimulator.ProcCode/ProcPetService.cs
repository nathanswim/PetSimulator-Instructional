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

        public string MakePet(IUiDisplayItem petType, string petName)
        {
            if (petType.Value == null)
                throw new ArgumentException($"{nameof(petType)} must have a valid {typeof(PetType).FullName} value and cannot have a value of null.");
            var t = (PetType)petType.Value;
            return _sample.MakePet(t, petName);
        }

        public IUiDisplayItem GetPet()
        {
            if (!_sample.IsCreated)
                return UiDisplayItem.Empty;
            else
                return new UiDisplayItem(_sample.PetName, _sample.PetType);
        }

        public string PerformAction(IUiDisplayItem action)
        {
            if (!_sample.IsCreated)
                throw new InvalidOperationException($"A pet must be created in order to perform an action.");
            if (action.Value == null)
                throw new ArgumentException($"{nameof(action)} must have a valid {typeof(PetActionType).FullName} value and cannot have a value of null.", nameof(action));
            var act = (PetActionType)action.Value;

            return _sample.Act(act);
        }

        private IEnumerable<IUiDisplayItem> GetNameValues<TEnum>() where TEnum : struct, Enum
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