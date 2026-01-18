namespace Exercise1_StackOverflow_Post;

public class Post
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private int _vote;

    public string Title
    {
        get { return _title; }
    }

    public string Description
    {
        get { return _description; }
    }

    public DateTime DateTime
    {
        get { return _dateTime; }
    }

    public int Vote
    {
        get { return _vote; }
    }


    public Post()
    {
        _title = "Ny title";
        _description = "Ny description";
        _dateTime = DateTime.Now;
        _vote = 5;
    }

    public void UpVote()
    {
        _vote++;
    }

    public void DownVote()
    {
        _vote--;
    }

}
