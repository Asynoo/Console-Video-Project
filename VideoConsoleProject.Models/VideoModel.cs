using System;

namespace VideoConsoleProject.Models
{
    public class VideoModel
    {
             public int? Id { get; set; }
             public string Title { get; set; }
             public DateTime ReleaseDate { get; set; }
             public string StoryLine { get; set; }   
    }
}