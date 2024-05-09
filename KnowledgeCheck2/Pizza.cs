namespace KnowledgeCheck2
{
    internal class Pizza : Food
    {
        public string? toppings { get; set; }
        public string? style { get; set; }
        public int size { get; set; }

        public override string ToString()
        {
            return $"Pizza: ${price}, {calories} calories, {style} style, {size} inches, with {toppings}";
        }
    }
}
