﻿namespace ConMan.Models;

public class Location
{
    public int Id { get; set; }
    public string LocationName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    
    public ICollection<Event> Events { get; set; }
}