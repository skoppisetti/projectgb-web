using System;

namespace projectgb_web.Models
{
    public class GbVisual
    {
        public GbVisualType VisualType {get; set;}
        public string Uri {get; set;}
    }

    public enum GbVisualType
    {
        video,
        image
    }
}