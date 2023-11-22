﻿using EasyMicroservices.ContentsMicroservice.Clients.Attributes;

namespace EasyMicroservices.CustomerMicroservice.Contracts.Common
{
    public class PersonCategoryContract : PersonCategoryBaseContract
    {

        public long Id { get; set; }

        [ContentLanguage]
        public string Name { get; set; }
    }
}
