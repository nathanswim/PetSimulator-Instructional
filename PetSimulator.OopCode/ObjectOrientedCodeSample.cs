using PetSimulator.UI.Abstractions;

namespace PetSimulator.OopCode
{
    class ObjectOrientedCodeSample
    {
        private Pet pet = null!;

        public bool IsCreated => pet != null;

        public string MakePet(PetType type, string name)
        {
            pet = type switch
            {
                PetType.Cat => new Cat(name),
                PetType.Dog => new Dog(name),
                PetType.Bird => new Bird(name),
                PetType.Fish => new Fish(name),
                _ => throw new ArgumentOutOfRangeException(nameof(PetType))
            };

            return $"Hello, I am your new pet. I am a {type} and my name is {name}";
        }

        public string Act(PetActionType action)
        {
            if (!IsCreated)
                throw new ArgumentOutOfRangeException(nameof(PetType));

            return PetAction(action);
        }

        private string PetAction(PetActionType action)
        {
            return action switch
            {
                PetActionType.Eat => pet.Eat(),
                PetActionType.Sleep => pet.Sleep(),
                PetActionType.Walk => pet.Walk(),
                PetActionType.Speak => pet.Speak(),
                _ => throw new ArgumentOutOfRangeException(nameof(action))
            };
        }

    }

}