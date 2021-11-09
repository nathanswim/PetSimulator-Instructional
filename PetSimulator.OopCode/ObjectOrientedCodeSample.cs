using PetSimulator.UI.Abstractions;

namespace PetSimulator.OopCode
{
    class ObjectOrientedCodeSample
    {
        public bool IsCreated { get; private set; }

        public string MakePet(PetType type, string name)
        {
            return "";
        }

        internal string Act(PetActionType act) => throw new NotImplementedException();
    }
}