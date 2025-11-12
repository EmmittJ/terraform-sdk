using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadUserTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_user resource.
/// </summary>
public partial class AzureadUser : TerraformResource
{
    public AzureadUser(string name) : base("azuread_user", name)
    {
    }

    /// <summary>
    /// Whether or not the account should be enabled
    /// </summary>
    [TerraformProperty("account_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AccountEnabled { get; set; }

    /// <summary>
    /// The age group of the user
    /// </summary>
    [TerraformProperty("age_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgeGroup { get; set; }

    /// <summary>
    /// The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect
    /// </summary>
    [TerraformProperty("business_phones")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> BusinessPhones { get; set; }

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    [TerraformProperty("city")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? City { get; set; }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    [TerraformProperty("company_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompanyName { get; set; }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    [TerraformProperty("consent_provided_for_minor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConsentProvidedForMinor { get; set; }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    [TerraformProperty("cost_center")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CostCenter { get; set; }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    [TerraformProperty("country")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Country { get; set; }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    [TerraformProperty("department")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Department { get; set; }

    /// <summary>
    /// Whether the users password is exempt from expiring
    /// </summary>
    [TerraformProperty("disable_password_expiration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisablePasswordExpiration { get; set; }

    /// <summary>
    /// Whether the user is allowed weaker passwords than the default policy to be specified.
    /// </summary>
    [TerraformProperty("disable_strong_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableStrongPassword { get; set; }

    /// <summary>
    /// The name to display in the address book for the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    [TerraformProperty("division")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Division { get; set; }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    [TerraformProperty("employee_hire_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmployeeHireDate { get; set; }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    [TerraformProperty("employee_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmployeeId { get; set; }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    [TerraformProperty("employee_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EmployeeType { get; set; }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    [TerraformProperty("fax_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FaxNumber { get; set; }

    /// <summary>
    /// Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password
    /// </summary>
    [TerraformProperty("force_password_change")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForcePasswordChange { get; set; }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    [TerraformProperty("given_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GivenName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The user’s job title
    /// </summary>
    [TerraformProperty("job_title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JobTitle { get; set; }

    /// <summary>
    /// The SMTP address for the user. Cannot be unset.
    /// </summary>
    [TerraformProperty("mail")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mail { get; set; }

    /// <summary>
    /// The mail alias for the user. Defaults to the user name part of the user principal name (UPN)
    /// </summary>
    [TerraformProperty("mail_nickname")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MailNickname { get; set; }

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    [TerraformProperty("manager_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagerId { get; set; }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    [TerraformProperty("mobile_phone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MobilePhone { get; set; }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    [TerraformProperty("office_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OfficeLocation { get; set; }

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user&#39;s `user_principal_name` property when creating a new user account
    /// </summary>
    [TerraformProperty("onpremises_immutable_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OnpremisesImmutableId { get; set; }

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    [TerraformProperty("other_mails")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? OtherMails { get; set; }

    /// <summary>
    /// The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
    /// </summary>
    [TerraformProperty("password")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    [TerraformProperty("postal_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostalCode { get; set; }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    [TerraformProperty("preferred_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreferredLanguage { get; set; }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    [TerraformProperty("show_in_address_list")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ShowInAddressList { get; set; }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    [TerraformProperty("street_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StreetAddress { get; set; }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    [TerraformProperty("surname")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Surname { get; set; }

    /// <summary>
    /// The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set
    /// </summary>
    [TerraformProperty("usage_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UsageLocation { get; set; }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPrincipalName is required")]
    [TerraformProperty("user_principal_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPrincipalName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadUserTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// A freeform field for the user to describe themselves
    /// </summary>
    [TerraformProperty("about_me")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AboutMe { get; }

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    [TerraformProperty("creation_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationType { get; }

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    [TerraformProperty("external_user_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalUserState { get; }

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    [TerraformProperty("im_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ImAddresses { get; }

    /// <summary>
    /// The object ID of the user
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    [TerraformProperty("onpremises_distinguished_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesDistinguishedName { get; }

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    [TerraformProperty("onpremises_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesDomainName { get; }

    /// <summary>
    /// The on-premise SAM account name of the user
    /// </summary>
    [TerraformProperty("onpremises_sam_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesSamAccountName { get; }

    /// <summary>
    /// The on-premise security identifier (SID) of the user
    /// </summary>
    [TerraformProperty("onpremises_security_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesSecurityIdentifier { get; }

    /// <summary>
    /// Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformProperty("onpremises_sync_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> OnpremisesSyncEnabled { get; }

    /// <summary>
    /// The on-premise user principal name of the user
    /// </summary>
    [TerraformProperty("onpremises_user_principal_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesUserPrincipalName { get; }

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    [TerraformProperty("proxy_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ProxyAddresses { get; }

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    [TerraformProperty("user_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserType { get; }

}
