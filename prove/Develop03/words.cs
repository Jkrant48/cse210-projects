// this is the words class responsible for displaying and hiding text


public class Words{

    private string _text;

    private string _reference;

    private bool _isHidden;

    private Random _random;

    public Words(){

        this._text = "";

        this._reference = "";

        this._isHidden = false;

        this._random = new Random();
    }

    public void displayscripture(List<Tuple<string, string>> separatedScriptures){
        
        

        foreach (var verse in separatedScriptures){

            _reference = verse.Item1;
            _text = verse.Item2;
            
            Console.WriteLine($"{_reference} - {_text}");         
        }
               

    }

    public void memorizeScripture(List<Tuple<string, string>> separatedScriptures){
        
        int Index = 0;

        while (Index < separatedScriptures.Count)
        {
            Console.Clear();
            var verse = separatedScriptures[Index];
           _reference = verse.Item1;

            if (_isHidden)
            {
                _text = new string('_', verse.Item2.Length);
            }
            else
            {
                _text = verse.Item2;
            }
            
            Console.WriteLine($"{_reference} - {_text}");


            var userEntry = Console.ReadLine();
            var key = Console.ReadKey(intercept: true).Key;
            

            if (key == ConsoleKey.Enter)
            {
                _isHidden = !_isHidden;
            }
                        
            else if (key == ConsoleKey.DownArrow)
            {
                Index = Math.Min(Index + 1, separatedScriptures.Count - 1);
            }
            else if (key == ConsoleKey.UpArrow)
            {
                Index = Math.Max(Index - 1, 0);
            }
            else if (userEntry == "quit")
            {
                break;
            }
        }
    }


}