public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private static Random _random = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life",
                "John", 3, 16),

            new Scripture(
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths",
                "Proverbs", 3, new List<int> { 5, 6 }),

            new Scripture(
                "I can do all things through Christ which strengtheneth me",
                "Philippians", 4, 13),

            new Scripture(
                "And we know that all things work together for good to them that love God to them who are the called according to his purpose",
                "Romans", 8, 28),

            new Scripture(
                "Adam fell that men might be and men are that they might have joy",
                "2 Nephi", 2, 25),
        };
    }

    public Scripture GetRandomScripture()
    {
        return _scriptures[_random.Next(_scriptures.Count)];
    }
}
