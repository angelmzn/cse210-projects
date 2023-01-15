public class job {
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJobDetails(){
        Console.WriteLine($"{_company}, {_jobTitle}, from {_startYear} to {_endYear}.");
    }



};