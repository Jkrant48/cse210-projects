//This class reads the scriptures from a list and separates the reference from the text

public class ScriptureReader{

    private List<string> _scriptures;

    private string _fileName;


    public ScriptureReader(){

        this._fileName = "Scriptures.txt";

        this._scriptures = new List<string>();
    }

    public void LoadFromFile() {      

        String[] readscripture = File.ReadAllLines(_fileName);
        
        // add scripture to list
        _scriptures.AddRange(readscripture);


    }

    public List<Tuple<string, string>> separatedScripture(){
        
        List<Tuple<string, string>> separatedScripture = new List<Tuple<string, string>>();
        
        foreach (string script in _scriptures)
        {
            string[] refernceAndText = script.Split('-');
            if (refernceAndText.Length == 2)
            {
                string reference = refernceAndText[0].Trim();
                string text = refernceAndText[1].Trim();
                separatedScripture.Add(Tuple.Create(reference, text));
            }
            else
            {
                Console.WriteLine("Invalid format in scripture: " + script);
            }
        }

        return separatedScripture;
    }
    
}