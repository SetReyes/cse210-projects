
// Job list
public class Resume
{
    // Declare variable
    public string _personName = "";
    // Initializing list
    public List<Job> _jobs = new List<Job>();

    // A method that displays name and the job 
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Job:");
        // Takes the job in the job list and applies Job class
        foreach (Job job in _jobs)
        {
            // Displaying job information
            job.DisplayJobDetails();
        }

    }
}