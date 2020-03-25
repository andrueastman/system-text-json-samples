namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type User.
    /// </summary>
    public partial class User : DirectoryObject
    {

        ///<summary>
        /// The User constructor
        ///</summary>
        public User()
        {
            this.ODataType = "microsoft.graph.user";
        }

        /// <summary>
        /// Gets or sets account enabled.
        /// true if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter.
        /// </summary>
        [JsonPropertyName("accountEnabled")]
        public bool? AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets age group.
        /// Sets the age group of the user. Allowed values: null, minor, notAdult and adult. Refer to the legal age group property definitions for further information.
        /// </summary>
        [JsonPropertyName("ageGroup")]
        public string AgeGroup { get; set; }

        /// <summary>
        /// Gets or sets business phones.
        /// The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [JsonPropertyName("businessPhones")]
        public IEnumerable<string> BusinessPhones { get; set; }

        /// <summary>
        /// Gets or sets city.
        /// The city in which the user is located. Supports $filter.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets company name.
        /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from.
        /// </summary>
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets consent provided for minor.
        /// Sets whether consent has been obtained for minors. Allowed values: null, granted, denied and notRequired. Refer to the legal age group property definitions for further information.
        /// </summary>
        [JsonPropertyName("consentProvidedForMinor")]
        public string ConsentProvidedForMinor { get; set; }

        /// <summary>
        /// Gets or sets country.
        /// The country/region in which the user is located; for example, 'US' or 'UK'. Supports $filter.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets creation type.
        /// Indicates whether the user account was created as a regular school or work account (null), an external account (Invitation), a local account for an Azure Active Directory B2C tenant (LocalAccount) or self-service sign-up using email verification (EmailVerified). Read-only.
        /// </summary>
        [JsonPropertyName("creationType")]
        public string CreationType { get; set; }

        /// <summary>
        /// Gets or sets department.
        /// The name for the department in which the user works. Supports $filter.
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets display name.
        /// The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets employee id.
        /// The employee identifier assigned to the user by the organization. Supports $filter.
        /// </summary>
        [JsonPropertyName("employeeId")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets fax number.
        /// The fax number of the user.
        /// </summary>
        [JsonPropertyName("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets given name.
        /// The given name (first name) of the user. Supports $filter.
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets im addresses.
        /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only.
        /// </summary>
        [JsonPropertyName("imAddresses")]
        public IEnumerable<string> ImAddresses { get; set; }

        /// <summary>
        /// Gets or sets is resource account.
        /// true if the user is a resource account; otherwise, false. Null value should be considered false.
        /// </summary>
        [JsonPropertyName("isResourceAccount")]
        public bool? IsResourceAccount { get; set; }

        /// <summary>
        /// Gets or sets job title.
        /// The user’s job title. Supports $filter.
        /// </summary>
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets last password change date time.
        /// The time when this Azure AD user last changed their password. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("lastPasswordChangeDateTime")]
        public DateTimeOffset? LastPasswordChangeDateTime { get; set; }

        /// <summary>
        /// Gets or sets legal age group classification.
        /// Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, minorWithOutParentalConsent, minorWithParentalConsent, minorNoParentalConsentRequired, notAdult and adult. Refer to the legal age group property definitions for further information.)
        /// </summary>
        [JsonPropertyName("legalAgeGroupClassification")]
        public string LegalAgeGroupClassification { get; set; }
        
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the user, for example, 'jeff@contoso.onmicrosoft.com'. Read-Only. Supports $filter.
        /// </summary>
        [JsonPropertyName("mail")]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the user. This property must be specified when a user is created. Supports $filter.
        /// </summary>
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Gets or sets mobile phone.
        /// The primary cellular telephone number for the user.
        /// </summary>
        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or sets on premises distinguished name.
        /// Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesDistinguishedName")]
        public string OnPremisesDistinguishedName { get; set; }

        /// <summary>
        /// Gets or sets on premises immutable id.
        /// This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user’s userPrincipalName (UPN) property. Important: The $ and _ characters cannot be used when specifying this property. Supports $filter.
        /// </summary>
        [JsonPropertyName("onPremisesImmutableId")]
        public string OnPremisesImmutableId { get; set; }

        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Indicates the last time at which the object was synced with the on-premises directory; for example: '2013-02-16T03:04:54Z'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesLastSyncDateTime")]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }

        /// <summary>
        /// Gets or sets on premises security identifier.
        /// Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only
        /// </summary>
        [JsonPropertyName("onPremisesSyncEnabled")]
        public bool? OnPremisesSyncEnabled { get; set; }

        /// <summary>
        /// Gets or sets on premises domain name.
        /// Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesDomainName")]
        public string OnPremisesDomainName { get; set; }

        /// <summary>
        /// Gets or sets on premises sam account name.
        /// Contains the on-premises samAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesSamAccountName")]
        public string OnPremisesSamAccountName { get; set; }

        /// <summary>
        /// Gets or sets on premises user principal name.
        /// Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesUserPrincipalName")]
        public string OnPremisesUserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets other mails.
        /// A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com']. Supports $filter.
        /// </summary>
        [JsonPropertyName("otherMails")]
        public IEnumerable<string> OtherMails { get; set; }

        /// <summary>
        /// Gets or sets password policies.
        /// Specifies password policies for the user. This value is an enumeration with one possible value being 'DisableStrongPassword', which allows weaker passwords than the default policy to be specified. 'DisablePasswordExpiration' can also be specified. The two may be specified together; for example: 'DisablePasswordExpiration, DisableStrongPassword'.
        /// </summary>
        [JsonPropertyName("passwordPolicies")]
        public string PasswordPolicies { get; set; }

        /// <summary>
        /// Gets or sets password profile.
        /// Specifies the password profile for the user. The profile contains the user’s password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required.
        /// </summary>
        [JsonPropertyName("passwordProfile")]
        public PasswordProfile PasswordProfile { get; set; }

        /// <summary>
        /// Gets or sets office location.
        /// The office location in the user's place of business.
        /// </summary>
        [JsonPropertyName("officeLocation")]
        public string OfficeLocation { get; set; }

        /// <summary>
        /// Gets or sets postal code.
        /// The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code.
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for the user. Should follow ISO 639-1 Code; for example 'en-US'.
        /// </summary>
        [JsonPropertyName("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Gets or sets proxy addresses.
        /// For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'] The any operator is required for filter expressions on multi-valued properties. Read-only, Not nullable. Supports $filter.
        /// </summary>
        [JsonPropertyName("proxyAddresses")]
        public IEnumerable<string> ProxyAddresses { get; set; }

        /// <summary>
        /// Gets or sets show in address list.
        /// true if the Outlook global address list should contain this user, otherwise false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false.
        /// </summary>
        [JsonPropertyName("showInAddressList")]
        public bool? ShowInAddressList { get; set; }

        /// <summary>
        /// Gets or sets sign in sessions valid from date time.
        /// Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset.
        /// </summary>
        [JsonPropertyName("signInSessionsValidFromDateTime")]
        public DateTimeOffset? SignInSessionsValidFromDateTime { get; set; }

        /// <summary>
        /// Gets or sets state.
        /// The state or province in the user's address. Supports $filter.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets street address.
        /// The street address of the user's place of business.
        /// </summary>
        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets surname.
        /// The user's surname (family name or last name). Supports $filter.
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets usage location.
        /// A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: 'US', 'JP', and 'GB'. Not nullable. Supports $filter.
        /// </summary>
        [JsonPropertyName("usageLocation")]
        public string UsageLocation { get; set; }

        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant’s collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets user type.
        /// A string value that can be used to classify user types in your directory, such as 'Member' and 'Guest'. Supports $filter.
        /// </summary>
        [JsonPropertyName("userType")]
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets device enrollment limit.
        /// The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
        /// </summary>
        [JsonPropertyName("deviceEnrollmentLimit")]
        public Int32? DeviceEnrollmentLimit { get; set; }

        /// <summary>
        /// Gets or sets about me.
        /// A freeform text entry field for the user to describe themselves.
        /// </summary>
        [JsonPropertyName("aboutMe")]
        public string AboutMe { get; set; }

        /// <summary>
        /// Gets or sets birthday.
        /// The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("birthday")]
        public DateTimeOffset? Birthday { get; set; }

        /// <summary>
        /// Gets or sets hire date.
        /// The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("hireDate")]
        public DateTimeOffset? HireDate { get; set; }

        /// <summary>
        /// Gets or sets interests.
        /// A list for the user to describe their interests.
        /// </summary>
        [JsonPropertyName("interests")]
        public IEnumerable<string> Interests { get; set; }

        /// <summary>
        /// Gets or sets my site.
        /// The URL for the user's personal site.
        /// </summary>
        [JsonPropertyName("mySite")]
        public string MySite { get; set; }

        /// <summary>
        /// Gets or sets past projects.
        /// A list for the user to enumerate their past projects.
        /// </summary>
        [JsonPropertyName("pastProjects")]
        public IEnumerable<string> PastProjects { get; set; }

        /// <summary>
        /// Gets or sets preferred name.
        /// The preferred name for the user.
        /// </summary>
        [JsonPropertyName("preferredName")]
        public string PreferredName { get; set; }

        /// <summary>
        /// Gets or sets responsibilities.
        /// A list for the user to enumerate their responsibilities.
        /// </summary>
        [JsonPropertyName("responsibilities")]
        public IEnumerable<string> Responsibilities { get; set; }

        /// <summary>
        /// Gets or sets schools.
        /// A list for the user to enumerate the schools they have attended.
        /// </summary>
        [JsonPropertyName("schools")]
        public IEnumerable<string> Schools { get; set; }

        /// <summary>
        /// Gets or sets skills.
        /// A list for the user to enumerate their skills.
        /// </summary>
        [JsonPropertyName("skills")]
        public IEnumerable<string> Skills { get; set; }

        /// <summary>
        /// Gets or sets manager.
        /// The user or contact that is this user’s manager. Read-only. (HTTP Methods: GET, PUT, DELETE.)
        /// </summary>
        [JsonPropertyName("manager")]
        public DirectoryObject Manager { get; set; }

        // /// <summary>
        // /// Gets or sets calendar.
        // /// The user's primary calendar. Read-only.
        // /// </summary>
        // [JsonPropertyName("calendar")]
        // public Calendar Calendar { get; set; }
        //
        // /// <summary>
        // /// Gets or sets calendars.
        // /// The user's calendars. Read-only. Nullable.
        // /// </summary>
        // [JsonPropertyName("calendars")]
        // public IUserCalendarsCollectionPage Calendars { get; set; }
        //
        // /// <summary>
        // /// Gets or sets calendar view.
        // /// The calendar view for the calendar. Read-only. Nullable.
        // /// </summary>
        // [JsonPropertyName("calendarView")]
        // public IUserCalendarViewCollectionPage CalendarView { get; set; }
        //
        /// <summary>
        /// Gets or sets events.
        /// The user's events. Default is to show Events under the Default Calendar. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("events")]
        public IUserEventsCollectionPage Events { get; set; }
        //
        // /// <summary>
        // /// Gets or sets contacts.
        // /// The user's contacts. Read-only. Nullable.
        // /// </summary>
        // [JsonPropertyName("contacts")]
        // public IUserContactsCollectionPage Contacts { get; set; }
        //
        // /// <summary>
        // /// Gets or sets photo.
        // /// The user's profile photo. Read-only.
        // /// </summary>
        // [JsonPropertyName("photo")]
        // public ProfilePhoto Photo { get; set; }
        //
        // /// <summary>
        // /// Gets or sets drive.
        // /// The user's OneDrive. Read-only.
        // /// </summary>
        // [JsonPropertyName("drive")]
        // public Drive Drive { get; set; }
        //
        // /// <summary>
        // /// Gets or sets drives.
        // /// A collection of drives available for this user. Read-only.
        // /// </summary>
        // [JsonPropertyName("drives")]
        // public IUserDrivesCollectionPage Drives { get; set; }
        
    }
}