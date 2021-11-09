using PetSimulator.UI.Abstractions;

namespace PetSimulator.ProcCode
{
    class ProcedureCodeSample
    {
        public bool IsCreated { get; private set; }
        public string PetName { get; private set; } = "";
        public PetType PetType { get; private set; }


        public void MakePet(PetType type, string name)
        {
            IsCreated = true;
            PetType = type;
            PetName = name;
        }




    }
}