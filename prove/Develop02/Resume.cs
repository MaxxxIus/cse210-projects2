public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public List<Education> _experience = new List<Education>();

    public void DisplayFullResume()
{
    foreach(Job job in _jobs)
    {
        string desc = job.GetDescription();
        Console.WriteLine($" {desc}");
    }
}
}