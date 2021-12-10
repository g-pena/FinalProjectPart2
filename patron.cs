using System;
using System.Collections.Generic;

class Patron : Person
{
  //Auto-Implemented properties
  public string LibraryId {get; set;}
  public DateTime StartDate {get; set;}
  public DateTime EndDate {get; set;}
  public bool IsAccountActive {get; set;}
  public double FineAmountDue {get; set;}
  
  private List<Rental> RentalCart = new List<Rental>(); 


  //constructor

  public Patron (string fname, string lname, string id) : base (fname, lname)
  {
    FirstName = fname;
    LastName = lname;
    LibraryId = id;
    FineAmountDue = 0;
    StartDate = DateTime.Today;
    IsAccountActive = true;
  }

  //method
  public void Display()
  {
    Console.WriteLine("Patron Id = "+LibraryId+"Name = "+FirstName+LastName);
  }

  public void AddToRentalCart(Book b, DateTime due)
  {
    EndDate = due;
    Book n = new Book(b);
    RentalCart.Add(n);
    Console.WriteLine("Book was added successfully.");
  }


}