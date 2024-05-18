using System;
using System.Collections.Generic;
using HW4_4.Models;

namespace HW4_4.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        MainMenuEntity = new() 
        { 
            Home = "Home", 
            About = "About", 
            MainTopicsList = new List<string> {"Main topic 1","Main topic 2", "Main topic 3"},
            AssoshiatedBlogs = "Assoshiated blogs",
            Profile = "RSS"
        };
        
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity() 
            {
                Article = "Lorem Ipsum", 
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vestibulum cursus arcu, ac auctor mauris laoreet et. In mauris dolor, tincidunt eget fermentum non, maximus at massa.",
                ImagePath = "resm:Avalonia.Skia.Assets.NoiseAsset_256X256_PNG.png?assembly=Avalonia.Skia",
                Tags = new List<string> {"Tag1", "Tag2", "Tag3"}
            },
            new BlogsEntity() 
            {Article = "Lorem Ipsum", Text = "In eros ipsum, sagittis id quam sed, suscipit pretium mauris. Ut et scelerisque felis."},
            new BlogsEntity() 
            {Article = "Lorem Ipsum", Text = "In eros ipsum, sagittis id quam sed, suscipit pretium mauris. Ut et scelerisque felis."},
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Новость 1", PublishTime = DateTime.Now },
            new() { Text = "Новость 2", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public MainEntity MainMenuEntity {get; set;}
    public List<BlogsEntity> BlogsEntities {get; set;}
    public List<NewsEntity> NewsEntities {get; set;}

    
}