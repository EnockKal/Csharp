namespace Exercise1_StackOverflow_Post;

internal class Program
{
    static void Main(string[] args)
    {
        var post = new Post();

        post.UpVote();
        post.UpVote();
        post.UpVote();
        post.UpVote();

        post.DownVote();
        post.DownVote();
        post.DownVote();

        Console.WriteLine($"total vote is: {post.Vote}");
    }
}
