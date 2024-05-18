namespace HW4_4.ViewModels;
using System.Collections.Generic;

public class BlogsEntity
{
    public string Article {get; set; }
    public string Text  {get; set; }
    public string ImagePath {get; set; }
    public List<string> Tags {get; set; }
}