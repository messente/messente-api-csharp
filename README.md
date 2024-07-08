# Messente API Library

- Messente API version: 2.0.0
- C# package version: 3.0.0

[Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you&#39;re not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.

## Installation

Install Messente API library via NuGet Package Manager or .NET CLI.

### Package Manager

`Install-Package com.Messente.Api -Version 3.0.0`

### .NET CLI

`dotnet add package com.Messente.Api --version 3.0.0`

## Features

Messente API has the following features:

- Omnichannel ([external docs](https://messente.com/documentation/omnichannel-api)),
- Phonebook ([external docs](https://messente.com/documentation/phonebook-api)).

Messente API Library provides the operations described below to access the features.

### BlacklistApi

1. Adds a phone number to the blacklist [`AddToBlacklist`](docs/BlacklistApi.md#addtoblacklist)
1. Deletes a phone number from the blacklist [`DeleteFromBlacklist`](docs/BlacklistApi.md#deletefromblacklist)
1. Returns all blacklisted phone numbers [`FetchBlacklist`](docs/BlacklistApi.md#fetchblacklist)
1. Checks if a phone number is blacklisted [`IsBlacklisted`](docs/BlacklistApi.md#isblacklisted)

### BulkMessagingApi

1. Sends a bulk Omnimessage [`SendBulkOmnimessage`](docs/BulkMessagingApi.md#sendbulkomnimessage)

### ContactsApi

1. Adds a contact to a group [`AddContactToGroup`](docs/ContactsApi.md#addcontacttogroup)
1. Creates a new contact [`CreateContact`](docs/ContactsApi.md#createcontact)
1. Deletes a contact [`DeleteContact`](docs/ContactsApi.md#deletecontact)
1. Lists a contact [`FetchContact`](docs/ContactsApi.md#fetchcontact)
1. Lists groups of a contact [`FetchContactGroups`](docs/ContactsApi.md#fetchcontactgroups)
1. Returns all contacts [`FetchContacts`](docs/ContactsApi.md#fetchcontacts)
1. Removes a contact from a group [`RemoveContactFromGroup`](docs/ContactsApi.md#removecontactfromgroup)
1. Updates a contact [`UpdateContact`](docs/ContactsApi.md#updatecontact)

### DeliveryReportApi

1. Retrieves the delivery report for the Omnimessage [`RetrieveDeliveryReport`](docs/DeliveryReportApi.md#retrievedeliveryreport)

### GroupsApi

1. Creates a new group with the provided name [`CreateGroup`](docs/GroupsApi.md#creategroup)
1. Deletes a group [`DeleteGroup`](docs/GroupsApi.md#deletegroup)
1. Lists a group [`FetchGroup`](docs/GroupsApi.md#fetchgroup)
1. Returns all groups [`FetchGroups`](docs/GroupsApi.md#fetchgroups)
1. Updates a group with the provided name [`UpdateGroup`](docs/GroupsApi.md#updategroup)

### NumberLookupApi

1. Requests info about phone numbers [`FetchInfo`](docs/NumberLookupApi.md#fetchinfo)

### OmnimessageApi

1. Cancels a scheduled Omnimessage [`CancelScheduledMessage`](docs/OmnimessageApi.md#cancelscheduledmessage)
1. Sends an Omnimessage [`SendOmnimessage`](docs/OmnimessageApi.md#sendomnimessage)

### StatisticsApi

1. Requests statistics reports for each country [`CreateStatisticsReport`](docs/StatisticsApi.md#createstatisticsreport)

## Auth

**Type**: HTTP basic authentication

Read the [external getting-started article](https://messente.com/documentation/getting-started) which explains API keys and Sender ID logic.

## Getting started: sending an omnimessage

```cs
// PM > Install-Package com.Messente.Api

using System;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class SendOmniMessageExample
    {
        public static void Main()
        {
            Configuration conf = new Configuration
            {
                Username = "YOUR_MESSENTE_API_USERNAME",
                Password = "YOUR_MESSENTE_API_PASSWORD"
            };

            var apiInstance = new OmnimessageApi(conf);

            var sms = new SMS(sender: "<sender name (optional)>", text: "Hello SMS!");
            OmnimessageMessagesInner smsOmnimessageInner = new OmnimessageMessagesInner(sms)
            {
                ActualInstance = sms
            };

            var viber = new Viber(sender: "<sender name (optional)>", text: "Hello viber!");
            OmnimessageMessagesInner viberOmnimessageInner = new OmnimessageMessagesInner(viber)
            {
                ActualInstance = viber
            };

            WhatsAppParameter whatsAppParameter = new WhatsAppParameter(
                type: "text",
                text: "hello whatsapp"
            );

            WhatsAppComponent whatsAppComponent = new WhatsAppComponent(
                type: "body",
                parameters: new List<WhatsAppParameter> { whatsAppParameter }
            );

            WhatsAppTemplate whatsAppTemplate = new WhatsAppTemplate(
                name: "<template_name>",
                language: new WhatsAppLanguage(code: "<language_code>"),
                components: new List<WhatsAppComponent> { whatsAppComponent }
            );

            var whatsapp = new WhatsApp(
                sender: "<sender name (optional)>",
                template: whatsAppTemplate
            );

            OmnimessageMessagesInner whatsAppOmnimessageInner = new OmnimessageMessagesInner(whatsapp)
            {
                ActualInstance = whatsapp
            };

            var omnimessage = new Omnimessage(
                to: "<recipient_phone_number>",
                messages: new List<OmnimessageMessagesInner> {
                    smsOmnimessageInner,
                    viberOmnimessageInner,
                    whatsAppOmnimessageInner
                }
            );

            try
            {
                var result = apiInstance.SendOmnimessage(omnimessage);
                Console.WriteLine(result.ToJson());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling SendOmnimessage: " + e.Message);
            }
        }
    }
}

```

## License

[Apache-2.0](http://www.apache.org/licenses/LICENSE-2.0.html)

## Terms

[https://messente.com/terms-and-conditions](https://messente.com/terms-and-conditions)
