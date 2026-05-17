
class Entry
{
    //attribute 
    public string _date;
   
    public string _response;

    public string _prompt;
    
    //behavior 
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt} - {_response}");
    }
    
}