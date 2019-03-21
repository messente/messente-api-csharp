# Messente API Library

- Messente API version: 0.0.1
- C# package version: 0.0.1

[Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber and WhatsApp messages, blacklist phone numbers to make sure you&#39;re not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.

## Installation

Install Messente API library via NuGet Package Manager or .NET CLI.

### Package Manager

`Install-Package com.Messente.Api -Version 0.0.1`

### .NET CLI

`dotnet add package com.Messente.Api --version 0.0.1`

## Features

Messente API has the following features:

- Omnichannel ([external docs](https://messente.com/omnichannel-api)),
- Phonebook ([external docs](https://messente.com/phonebook-api)).

Messente API Library provides the operations described below to access the features.

### BlacklistApi

1. Adds a phone number to the blacklist. [`AddToBlacklist`](docs/BlacklistApi.md#addtoblacklist)
1. Deletes a phone number from the blacklist. [`DeleteFromBlacklist`](docs/BlacklistApi.md#deletefromblacklist)
1. Returns all blacklisted phone numbers. [`FetchBlacklist`](docs/BlacklistApi.md#fetchblacklist)
1. Checks if a phone number is blacklisted. [`IsBlacklisted`](docs/BlacklistApi.md#isblacklisted)

### ContactsApi

1. Adds a contact to a group. [`AddContactToGroup`](docs/ContactsApi.md#addcontacttogroup)
1. Creates a new contact. [`CreateContact`](docs/ContactsApi.md#createcontact)
1. Deletes a contact. [`DeleteContact`](docs/ContactsApi.md#deletecontact)
1. Lists a contact. [`FetchContact`](docs/ContactsApi.md#fetchcontact)
1. Lists groups of a contact. [`FetchContactGroups`](docs/ContactsApi.md#fetchcontactgroups)
1. Returns all contacts. [`FetchContacts`](docs/ContactsApi.md#fetchcontacts)
1. Removes a contact from a group. [`RemoveContactFromGroup`](docs/ContactsApi.md#removecontactfromgroup)
1. Updates a contact. [`UpdateContact`](docs/ContactsApi.md#updatecontact)

### DeliveryReportApi

1. Retrieves the delivery report for the Omnimessage. [`RetrieveDeliveryReport`](docs/DeliveryReportApi.md#retrievedeliveryreport)

### GroupsApi

1. Creates a new group with the provided name. [`CreateGroup`](docs/GroupsApi.md#creategroup)
1. Deletes a group. [`DeleteGroup`](docs/GroupsApi.md#deletegroup)
1. Lists a group. [`FetchGroup`](docs/GroupsApi.md#fetchgroup)
1. Returns all groups. [`FetchGroups`](docs/GroupsApi.md#fetchgroups)
1. Updates a group with the provided name. [`UpdateGroup`](docs/GroupsApi.md#updategroup)

### OmnimessageApi

1. Cancels a scheduled Omnimessage. [`CancelScheduledMessage`](docs/OmnimessageApi.md#cancelscheduledmessage)
1. Sends an Omnimessage. [`SendOmnimessage`](docs/OmnimessageApi.md#sendomnimessage)

## Auth

**Type**: HTTP basic authentication

Read the [external getting-started article](https://messente.com/documentation/getting-started) which explains API keys and Sender ID logic.

## Getting started: sending an omnimessage

```cs
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello!");
            Console.ReadKey();
        }
    }
}

// TODO

```

## License

[Apache 2.0](http://www.apache.org/licenses/LICENSE-2.0.html)

## Terms

[https://messente.com/terms-and-conditions](https://messente.com/terms-and-conditions)
