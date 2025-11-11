using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadUserDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_user.
/// </summary>
public partial class AzureadUserDataSource : TerraformDataSource
{
    public AzureadUserDataSource(string name) : base("azuread_user", name)
    {
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    [TerraformProperty("employee_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EmployeeId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The SMTP address for the user
    /// </summary>
    [TerraformProperty("mail")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mail { get; set; }

    /// <summary>
    /// The email alias of the user
    /// </summary>
    [TerraformProperty("mail_nickname")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MailNickname { get; set; }

    /// <summary>
    /// The object ID of the user
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [TerraformProperty("user_principal_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserPrincipalName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadUserDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Whether or not the account is enabled
    /// </summary>
    [TerraformProperty("account_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AccountEnabled { get; }

    /// <summary>
    /// The age group of the user
    /// </summary>
    [TerraformProperty("age_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgeGroup { get; }

    /// <summary>
    /// The telephone numbers for the user
    /// </summary>
    [TerraformProperty("business_phones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> BusinessPhones { get; }

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    [TerraformProperty("city")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> City { get; }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    [TerraformProperty("company_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CompanyName { get; }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    [TerraformProperty("consent_provided_for_minor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConsentProvidedForMinor { get; }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    [TerraformProperty("cost_center")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CostCenter { get; }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    [TerraformProperty("country")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Country { get; }

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    [TerraformProperty("creation_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationType { get; }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    [TerraformProperty("department")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Department { get; }

    /// <summary>
    /// The display name of the user
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    [TerraformProperty("division")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Division { get; }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    [TerraformProperty("employee_hire_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EmployeeHireDate { get; }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    [TerraformProperty("employee_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EmployeeType { get; }

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    [TerraformProperty("external_user_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalUserState { get; }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    [TerraformProperty("fax_number")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FaxNumber { get; }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    [TerraformProperty("given_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GivenName { get; }

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    [TerraformProperty("im_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ImAddresses { get; }

    /// <summary>
    /// The user’s job title
    /// </summary>
    [TerraformProperty("job_title")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobTitle { get; }

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    [TerraformProperty("manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagerId { get; }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    [TerraformProperty("mobile_phone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MobilePhone { get; }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    [TerraformProperty("office_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OfficeLocation { get; }

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
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object
    /// </summary>
    [TerraformProperty("onpremises_immutable_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesImmutableId { get; }

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
    /// Additional email addresses for the user
    /// </summary>
    [TerraformProperty("other_mails")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OtherMails { get; }

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    [TerraformProperty("postal_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PostalCode { get; }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    [TerraformProperty("preferred_language")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredLanguage { get; }

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    [TerraformProperty("proxy_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ProxyAddresses { get; }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    [TerraformProperty("show_in_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ShowInAddressList { get; }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    [TerraformProperty("street_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreetAddress { get; }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    [TerraformProperty("surname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Surname { get; }

    /// <summary>
    /// The usage location of the user
    /// </summary>
    [TerraformProperty("usage_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UsageLocation { get; }

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    [TerraformProperty("user_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserType { get; }

}
