class Project
{
    public string Name { get; }
    public string[] DescriptionParagraphs { get; }
    public string ImagePath { get; }
    public string GithubLink { get; }
    public Project(string name, string imagePath, string githubLink, string paragraph1, string paragraph2 = "", string paragraph3 = "")
    {
        Name = name;
        ImagePath = "images/" + imagePath;
        GithubLink = githubLink;
        string[] rawDescriptionParagraphs = {paragraph1, paragraph2, paragraph3};
        DescriptionParagraphs = rawDescriptionParagraphs.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    }
}