using PetSimulator.UI.Abstractions;

namespace PetSimulator.OopCode
{
    abstract class Pet
    {
        public Pet(PetType type, string name)
        {
            Type = type;
            Name = name;
        }
        public PetType Type { get; }

        public string Name { get; }

        public abstract string Speak();
        public abstract string Eat();
        public abstract string Walk();
        public abstract string Sleep();
    }

    class Cat : Pet
    {
        public Cat(string name)
            : base(PetType.Cat, name)
        {
        }

        public override string Eat() => $"{Name} thinks, \"Mmmm... canned tuna...\"";
        public override string Sleep() => $"{Name} finds fresh clean laundry and sleep";
        public override string Speak() => $"{Name} says, \"Meow meow meow\"";
        public override string Walk() => $"{Name} swaggers along lazyily";
    }

    class Dog : Pet
    {
        public Dog(string name)
            : base(PetType.Dog, name)
        {
        }

        public override string Speak() => $"{Name} all alarmed says, \"Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf! Arf!\"";
        public override string Walk() => $"{Name} brings leash to master and stare forlornly until master gives in... pee on everything along the way";
        public override string Sleep() => $"{Name} jumps up on sofa, turn three times and lay down";
        public override string Eat() => $"{Name} goes to dog bowl and munch, munch, munches the kibble... all the while dreaming of table scraps";
    }

    class Bird : Pet
    {
        public Bird(string name)
            : base(PetType.Bird, name)
        {
        }

        public override string Speak() => $"{Name} says, \"Tweet! tweet! tweet!\"";
        public override string Walk() => $"{Name} stretches wings and Flap! flap! flap!";
        public override string Sleep() => $"{Name} tucks head under wing and snore";
        public override string Eat() => $"{Name} goes to bird seed tray and Peck peck peck";

    }

    class Fish : Pet
    {
        public Fish(string name)
            : base(PetType.Fish, name)
        {
        }

        public override string Speak() => $"{Name} says, \"Blub! blub! blub!\"";
        public override string Walk() => $"{Name} says \"What?!?!\" swishes tail and swims away";
        public override string Sleep() => $"{Name} levitate in water and stare blankly";
        public override string Eat() => $"{Name} approach surface and gulp.";

    }

}