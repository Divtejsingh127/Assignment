namespace VirtualPet
{
    internal class Pet
    {
        private string? petType;
        private string? petName;

        public Pet(string? petType, string? petName)
        {
            this.petType = petType;
            this.petName = petName;
        }

        public object PetType { get; internal set; }
        public object PetName { get; internal set; }
    }
}