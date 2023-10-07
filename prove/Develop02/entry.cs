//this class accepts the user input and generates it in the needed format

public class UserEntry{
    //attributes

    public string _datetime { get;}

    public string _prompt { get; } 

    public string _userResponse {get; set;}

    public UserEntry() {
        this._datetime = DateTime.Now.ToShortDateString();

        PromptGenerator promptGen = new PromptGenerator();
        this._prompt = promptGen.displayPrompt();

    }
    
    public void displayEntry(){

        Console.WriteLine($"Date: {_datetime} - Prompt: {_prompt} \n{_userResponse}");
        Console.WriteLine();
    }

}