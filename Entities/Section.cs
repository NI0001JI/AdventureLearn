using Godot;
using System;
using System.Collections.Generic;

public class Section : Node
{
    public int SectionId { get; set; }
    public string SectionName { get; set; }
    public List<Level> Level { get; set; }
}
