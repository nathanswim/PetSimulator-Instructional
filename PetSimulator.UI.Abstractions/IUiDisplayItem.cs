namespace PetSimulator.UI.Abstractions
{
    public interface IUiDisplayItem
    {
        string DisplayName { get; }
        object? Value { get; }
    }

    public class UiDisplayItem : IUiDisplayItem
    {
        public static readonly UiDisplayItem Empty = new("", null);

        public UiDisplayItem(string displayName, object? value)
        {
            DisplayName = displayName;
            Value = value;
        }

        public string DisplayName { get; } = "";
        public object? Value { get; }
    }

}