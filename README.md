


# Address Book

#### The user can create, store, reference, and delete contact information. Date of current version: 5/26/2017

#### By Jordan Loop

## Description

User is given the option to create a contact to their address book. A list of created contact's name is displayed on  home page. Each name is a link that sends user to a page that displays more information about the selected contact. From the home page the user is able to remove every contact in their address book.

## Setup/Installation Requirements

* Download repository
* Using Windows PowerShell, Navigate to top level directory.
* In power shell type "dnx kestrel" (without the quotation marks).
* Open preferred web browser and type in the following URL: http://localhost:5004/

## Known Bugs

No know bugs.

## Questions/Concerns or advice?

Contact me at jordanloop@gmail.com

## Technologies Used

* ASP.NET 5
* C#
* HTML

### License

None.

## Specs

| Behavior handled<br>By this program:         | Input example<br>When it receives: | Output example<br>It should return:                                     |
|------------------------------------------------|------------------------------------|-------------------------------------------------------------------------|
| User clicks "Home" link from anywhere.         | Clicks "Home" link.                | Routs user to root.                                                     |
| User clicks "Add Contact" button from root.    | Clicks "Add Contact" button.       | Routs user to contact/create.                                           |
| User submits form from contact/create.         | Clicks "Create Contact" button.    | Routs user to contact/new.                                              |
| User clears all contacts from address book.    | Clicks "Clear All Contacts".       | Routs user to contact/clear.                                            |
| User clicks a specific contact name from root. | Clicks "Jordan Loop".              | Routs user to Jordan's contact information is displayed. |
