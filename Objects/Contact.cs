using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _address;
    private string _phone;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string firstName, string lastName, string address, string phone)
    {
      _firstName = contactFirstName;
      _lastName = contactLastName;
      _address = contactAddress;
      _phone = contactPhone;
      _id = _instances.Count; //  ASSIGNS UNIQUE ID TO EACH INSTANCE OF CONTACT WHEN INSTANTIATED
      _instances.Add(this); //  ADDS TO LIST OF ALL CONTACTS WHEN INSTANTIATED
    }

    public string GetFirstName()
    {
      return _firstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public string GetAddress()
    {
      return _address;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public int GetId()
    {
      return _id;
    }
//  ^ OBJECT METHODS ^ -- v STATIC METHODS v
    public static List<Contact> GetAllContacts()
    {
      return _instances;
    }
    public static void ClearAllContacts()
    {
      instances.Clear();
    }
    public static Contact FindContact(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
