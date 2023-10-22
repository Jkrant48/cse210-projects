//This is a scriptures class

using System.ComponentModel;

public class Scriptures{

    //attributes
    
    private string _scripture {get; set;}
    
    private string _fileName;

    public Scriptures() {

        this._fileName = "scriptures.txt";
    }


    // method
    public void SaveScriptures(string scripture) {

        this._scripture = scripture;

        /*_scriptures.Add(_scripture); */       
        using (StreamWriter writer = File.AppendText(_fileName))
        {
            writer.WriteLine(_scripture);
        }

    }

   
    // recieve scriptures to be memorized and save to a file
}