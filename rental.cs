using System;


class Rental
{
  //Properties
  public DateTime DateRented {get; set;}
  public DateTime DateDue {get; set;}

  public Book BookObject {get; set;}

  public Rental ()
  {
    BookObject = new Book ();
  }

  //Constructor

  public Rental (DateTime rented, DateTime due, Book b)
  {
    DateRented = rented;
    DateDue = due;
  }


}