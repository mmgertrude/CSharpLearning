namespace Treehouse.MediaLibrary{
  class Movie{
public readonly string Title;
public readonly string Director;
//added for challenge 2
public string Loanee;
public bool OnLoan;
 public Movie(string title, string director){
     Title = title;
     Director = director;}


//GetDisplayText() was edited for challenge 2
  public string GetDisplayText(){
       string text =  "Movie: " + Title + " by " + Director;
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

