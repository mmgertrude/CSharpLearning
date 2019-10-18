namespace Treehouse.MediaLibrary{
  class Album
  {
  public readonly string Title;
  public readonly string Artist;
  //added for challenge 2
     public string Loanee;
     public bool OnLoan;
    //The constructor:
  public Album(string title, string artist){
     Title = title;
     Artist = artist;
     
   }

 //The methods:
 //GetDisplayText() was edited for challenge 2
  public string GetDisplayText(){
       string text =  "Album: " + Title + " by " + Artist;
       if (OnLoan == true){
         //we could have used the if condition below 
        // if(Loanee !=null && Loanee!= "")

        //This if version works just like the one above:
        if (!string.IsNullOrEmpty(Loanee))
        {text += " (Currently on loan to " + Loanee +")";}
        else
        {
          text += " (Currently on loan)";
        }
         } 
      return text; 
       }
//added for challenge 2 then commented out for challenge 3
// public void Loan(string loanee){
//   Loanee = loanee;
//   //to indicate that the item is currently on loan
//   OnLoan = true;}
public void Return (){
  Loanee = null;
  OnLoan = false;}
  
//challenge 3
  public void Loan(){
  OnLoan = true;}

  public void Loan(string loanee){
  Loanee = loanee;
  Loan();}
}

}