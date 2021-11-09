using PetSimulator.UI.Abstractions;

namespace PetSimulator.ProcCode
{
    class ProcedureCodeSample
    {
        public bool IsCreated { get; private set; }
        public string PetName { get; private set; } = "";
        public PetType PetType { get; private set; }


        public string MakePet(PetType type, string name)
        {
            IsCreated = true;
            PetType = type;
            PetName = name;
            return $"Hello, I am your new pet. I am a {type} and my name is {name}";
        }

        public string Act(PetActionType action)
        {
            switch (PetType)
            {
                case PetType.Cat:
                    return CatAction(action);
                case PetType.Dog:
                    return DogAction(action);
                case PetType.Bird:
                    return BirdAction(action);
                default:
                    throw new ArgumentOutOfRangeException(nameof(PetType));
            }
        }

        private string BirdAction(PetActionType action)
        {
            return action switch
            {
                PetActionType.Eat => BirdEat(),
                PetActionType.Sleep => BirdSleep(),
                PetActionType.Walk => BirdWalk(),
                PetActionType.Speak => BirdSpeak(),
                _ => throw new ArgumentOutOfRangeException(nameof(action))
            };
        }

        private string CatAction(PetActionType action)
        {
            return action switch
            {
                PetActionType.Eat => CatEat(),
                PetActionType.Sleep => CatSleep(),
                PetActionType.Walk => CatWalk(),
                PetActionType.Speak => CatSpeak(),
                _ => throw new ArgumentOutOfRangeException(nameof(action))
            };
        }

        private string DogAction(PetActionType action)
        {
            return action switch
            {
                PetActionType.Eat => DogEat(),
                PetActionType.Sleep => DogSleep(),
                PetActionType.Walk => DogWalk(),
                PetActionType.Speak => DogSpeak(),
                _ => throw new ArgumentOutOfRangeException(nameof(action))
            };
        }

        private string BirdSpeak() => $"{PetName} says, \"Tweet! tweet! tweet!\"";
        private string BirdWalk() => $"{PetName} stretches wings and Flap! flap! flap!";
        private string BirdSleep() => $"{PetName} tucks head under wing and snore";
        private string BirdEat() => $"{PetName} goes to bird seed tray and Peck peck peck";

        private string CatSpeak() => $"{PetName} says, \"Meow meow meow\"";
        private string CatWalk() => $"{PetName} swaggers along lazyily";
        private string CatSleep() => $"{PetName} finds fresh clean laundry and sleep";
        private string CatEat() => $"{PetName} thinks, \"Mmmm... canned tuna...\"";

        private string DogSpeak() => $"{PetName} all alarmed says, \"Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf!\"";
        private string DogWalk() => $"{PetName} brings leash to master and stare forlornly until master gives in... pee on everything along the way";
        private string DogSleep() => $"{PetName} jumps up on sofa, turn three times and lay down";
        private string DogEat() => $"{PetName} goes to dog bowl and munch, munch, munches the kibble... all the while dreaming of table scraps";
    }
}