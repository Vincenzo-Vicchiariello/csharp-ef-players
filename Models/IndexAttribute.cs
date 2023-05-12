namespace csharp_ef_players.Models
{
    internal class IndexAttribute : Attribute
    {
        public IndexAttribute(string v)
        {
            V = v;
        }

        public IndexAttribute(string v, bool IsUnique)
        {
            V = v;
            this.IsUnique = IsUnique;
        }

        public string V { get; }
        public bool IsUnique { get; }
    }
}