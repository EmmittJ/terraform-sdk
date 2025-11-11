using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_user.
/// </summary>
public class AzureadUserDataSource : TerraformDataSource
{
    public AzureadUserDataSource(string name) : base("azuread_user", name)
    {
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    [TerraformPropertyName("employee_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmployeeId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The SMTP address for the user
    /// </summary>
    [TerraformPropertyName("mail")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mail { get; set; } = default!;

    /// <summary>
    /// The email alias of the user
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MailNickname { get; set; } = default!;

    /// <summary>
    /// The object ID of the user
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [TerraformPropertyName("user_principal_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserPrincipalName { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadUserDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Whether or not the account is enabled
    /// </summary>
    [TerraformPropertyName("account_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AccountEnabled => new TerraformReference(this, "account_enabled");

    /// <summary>
    /// The age group of the user
    /// </summary>
    [TerraformPropertyName("age_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgeGroup => new TerraformReference(this, "age_group");

    /// <summary>
    /// The telephone numbers for the user
    /// </summary>
    [TerraformPropertyName("business_phones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> BusinessPhones => new TerraformReference(this, "business_phones");

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    [TerraformPropertyName("city")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> City => new TerraformReference(this, "city");

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CompanyName => new TerraformReference(this, "company_name");

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    [TerraformPropertyName("consent_provided_for_minor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConsentProvidedForMinor => new TerraformReference(this, "consent_provided_for_minor");

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    [TerraformPropertyName("cost_center")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CostCenter => new TerraformReference(this, "cost_center");

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    [TerraformPropertyName("country")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Country => new TerraformReference(this, "country");

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    [TerraformPropertyName("creation_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationType => new TerraformReference(this, "creation_type");

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    [TerraformPropertyName("department")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Department => new TerraformReference(this, "department");

    /// <summary>
    /// The display name of the user
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    [TerraformPropertyName("division")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Division => new TerraformReference(this, "division");

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    [TerraformPropertyName("employee_hire_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EmployeeHireDate => new TerraformReference(this, "employee_hire_date");

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    [TerraformPropertyName("employee_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EmployeeType => new TerraformReference(this, "employee_type");

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    [TerraformPropertyName("external_user_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExternalUserState => new TerraformReference(this, "external_user_state");

    /// <summary>
    /// The fax number of the user
    /// </summary>
    [TerraformPropertyName("fax_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FaxNumber => new TerraformReference(this, "fax_number");

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    [TerraformPropertyName("given_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GivenName => new TerraformReference(this, "given_name");

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    [TerraformPropertyName("im_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ImAddresses => new TerraformReference(this, "im_addresses");

    /// <summary>
    /// The user’s job title
    /// </summary>
    [TerraformPropertyName("job_title")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobTitle => new TerraformReference(this, "job_title");

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    [TerraformPropertyName("manager_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagerId => new TerraformReference(this, "manager_id");

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    [TerraformPropertyName("mobile_phone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MobilePhone => new TerraformReference(this, "mobile_phone");

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    [TerraformPropertyName("office_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OfficeLocation => new TerraformReference(this, "office_location");

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    [TerraformPropertyName("onpremises_distinguished_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesDistinguishedName => new TerraformReference(this, "onpremises_distinguished_name");

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    [TerraformPropertyName("onpremises_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesDomainName => new TerraformReference(this, "onpremises_domain_name");

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object
    /// </summary>
    [TerraformPropertyName("onpremises_immutable_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesImmutableId => new TerraformReference(this, "onpremises_immutable_id");

    /// <summary>
    /// The on-premise SAM account name of the user
    /// </summary>
    [TerraformPropertyName("onpremises_sam_account_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesSamAccountName => new TerraformReference(this, "onpremises_sam_account_name");

    /// <summary>
    /// The on-premise security identifier (SID) of the user
    /// </summary>
    [TerraformPropertyName("onpremises_security_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesSecurityIdentifier => new TerraformReference(this, "onpremises_security_identifier");

    /// <summary>
    /// Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformPropertyName("onpremises_sync_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OnpremisesSyncEnabled => new TerraformReference(this, "onpremises_sync_enabled");

    /// <summary>
    /// The on-premise user principal name of the user
    /// </summary>
    [TerraformPropertyName("onpremises_user_principal_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesUserPrincipalName => new TerraformReference(this, "onpremises_user_principal_name");

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    [TerraformPropertyName("other_mails")]
    // Output-only attribute - read-only reference
    public TerraformList<string> OtherMails => new TerraformReference(this, "other_mails");

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PostalCode => new TerraformReference(this, "postal_code");

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredLanguage => new TerraformReference(this, "preferred_language");

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ProxyAddresses => new TerraformReference(this, "proxy_addresses");

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    [TerraformPropertyName("show_in_address_list")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ShowInAddressList => new TerraformReference(this, "show_in_address_list");

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    [TerraformPropertyName("street_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreetAddress => new TerraformReference(this, "street_address");

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    [TerraformPropertyName("surname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Surname => new TerraformReference(this, "surname");

    /// <summary>
    /// The usage location of the user
    /// </summary>
    [TerraformPropertyName("usage_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UsageLocation => new TerraformReference(this, "usage_location");

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserType => new TerraformReference(this, "user_type");

}
