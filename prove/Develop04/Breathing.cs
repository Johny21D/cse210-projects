class Breathing : Activity
{
     public Breathing():base("Breathing", @"This activity will help you relax by walking your through breathing in and out slowly. 
    Clear your mind and focus on your breathing.")
    {
        
    }
    public void Begin()
    {
    
    DisplayStartingMessage();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
        Console.WriteLine("Breathe in...");
        ShowCountDown(4);

        Console.WriteLine("Breathe out...");
        ShowCountDown(4);
    }

    DisplayEndingMessage(); 
    }
}