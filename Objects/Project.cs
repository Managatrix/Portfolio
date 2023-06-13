using System.Text.Json.Serialization;

public class Project
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public string GithubLink { get; set; }

    [JsonConstructor]
    public Project(string name, string imagePath, string githubLink, string description)
    {
        Name = name;
        ImagePath = imagePath;
        GithubLink = githubLink;
        Description = description;
    }
    public Project()
    {
        Name = "";
        ImagePath = "";
        GithubLink = "";
        Description = "";
    }
}