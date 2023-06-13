using System.Text.Json.Serialization;

public class Project
{
    public string Name { get; set; }
    public string[] DescriptionParagraphs { get; set; }
    public string ImagePath { get; set; }
    public string GithubLink { get; set; }
    
    [JsonConstructor]
    public Project(string name, string imagePath, string githubLink, string[] descriptionParagraphs)
    {
        Name = name;
        ImagePath = imagePath;
        GithubLink = githubLink;
        DescriptionParagraphs = descriptionParagraphs;
    }
    public Project()
    {
        Name = "";
        ImagePath = "";
        GithubLink = "";
        DescriptionParagraphs = new string[] { };
    }
}