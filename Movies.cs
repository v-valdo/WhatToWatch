namespace WhatToWatch;
public class Movies
{
    public List<string> Genre = new(); 
public Movies()
    {
        Genre = Enum.GetNames(typeof(Genre)).ToList();
    }
}
