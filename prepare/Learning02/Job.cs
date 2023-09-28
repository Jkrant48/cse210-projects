// Job class
//keeps track of completed jobs

public class Job
{
    // attributes
    public string _company = "";
    public string _jobtitle = "";
    public int _startYear;
    public int _endYear;

    //behavior
    
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear}");
    }


}