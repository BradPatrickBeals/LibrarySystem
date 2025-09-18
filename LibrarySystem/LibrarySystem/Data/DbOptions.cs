namespace LibrarySystem.Data
{
    public sealed class DbOptions
    {
        public const string SectionName = "ConnectionStrings";
        public string DefaultConnection { get; set; } = string.Empty;
    }
}
