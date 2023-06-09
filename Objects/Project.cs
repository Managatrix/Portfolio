using System.Text.Json.Serialization;

public class Project
{
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public string GithubLink { get; set; }
    public bool NoSourceCodeLink { get; set; }

    [JsonConstructor]
    public Project(string name, string icon, string imagePath, string githubLink, string description)
    {
        Name = name;
        Icon = icon;
        ImagePath = imagePath;
        GithubLink = githubLink;
        Description = description;
        NoSourceCodeLink = (GithubLink == "") ? true : false;
    }
    public Project()
    {
        Name = "";
        Icon = "";
        ImagePath = "";
        GithubLink = "";
        Description = "";
        NoSourceCodeLink = true;
    }
}