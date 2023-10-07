using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
// this class will have a list of all entries and 
// store them in a file
// loads from the file 

public class Journal{

    public List<UserEntry> _entries = new List<UserEntry>();

    public string _fileName {get; set;} //get the file name

    

    public void displaySavedEntries()
    {
        foreach (UserEntry entry in _entries)
        {
            entry.displayEntry();
        }
    }

    public void saveJournal(){


        using (var outputFile = new StreamWriter(_fileName))
        {
            foreach (UserEntry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._datetime} - Prompt: {entry._prompt} \nYour entry: {entry._userResponse}");
                outputFile.WriteLine();
            }
        }
    }

    public void loadJournal(){

        string[] lines = File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
           Console.WriteLine(line); 
        }
    }
    

}