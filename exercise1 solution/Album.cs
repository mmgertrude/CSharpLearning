namespace Treehouse.MediaLibrary{
  class Album{
  //public string Title;  //Before doing part 4b)
  //public string Artist; //Before doing part 4b)
  //after doing part 4b)
  public readonly string Title;
  public readonly string Artist;
    
   public Album(string title, string artist){
     Title = title;
     Artist = artist;
   }
}
}