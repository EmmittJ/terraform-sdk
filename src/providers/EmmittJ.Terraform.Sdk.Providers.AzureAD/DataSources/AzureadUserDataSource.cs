using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EmployeeId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "employee_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The SMTP address for the user
    /// </summary>
    [TerraformPropertyName("mail")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mail { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail");

    /// <summary>
    /// The email alias of the user
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MailNickname { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail_nickname");

    /// <summary>
    /// The object ID of the user
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [TerraformPropertyName("user_principal_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserPrincipalName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_principal_name");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadUserDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Whether or not the account is enabled
    /// </summary>
    [TerraformPropertyName("account_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AccountEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "account_enabled");

    /// <summary>
    /// The age group of the user
    /// </summary>
    [TerraformPropertyName("age_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgeGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "age_group");

    /// <summary>
    /// The telephone numbers for the user
    /// </summary>
    [TerraformPropertyName("business_phones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> BusinessPhones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "business_phones");

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    [TerraformPropertyName("city")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> City => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "city");

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompanyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "company_name");

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    [TerraformPropertyName("consent_provided_for_minor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConsentProvidedForMinor => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "consent_provided_for_minor");

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    [TerraformPropertyName("cost_center")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CostCenter => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cost_center");

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    [TerraformPropertyName("country")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Country => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "country");

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    [TerraformPropertyName("creation_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_type");

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    [TerraformPropertyName("department")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Department => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "department");

    /// <summary>
    /// The display name of the user
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    [TerraformPropertyName("division")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Division => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "division");

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    [TerraformPropertyName("employee_hire_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EmployeeHireDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "employee_hire_date");

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    [TerraformPropertyName("employee_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EmployeeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "employee_type");

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    [TerraformPropertyName("external_user_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalUserState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_user_state");

    /// <summary>
    /// The fax number of the user
    /// </summary>
    [TerraformPropertyName("fax_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FaxNumber => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fax_number");

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    [TerraformPropertyName("given_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GivenName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "given_name");

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    [TerraformPropertyName("im_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ImAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "im_addresses");

    /// <summary>
    /// The user’s job title
    /// </summary>
    [TerraformPropertyName("job_title")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobTitle => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_title");

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    [TerraformPropertyName("manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ManagerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "manager_id");

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    [TerraformPropertyName("mobile_phone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MobilePhone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mobile_phone");

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    [TerraformPropertyName("office_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OfficeLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "office_location");

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    [TerraformPropertyName("onpremises_distinguished_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesDistinguishedName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_distinguished_name");

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    [TerraformPropertyName("onpremises_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_domain_name");

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object
    /// </summary>
    [TerraformPropertyName("onpremises_immutable_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesImmutableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_immutable_id");

    /// <summary>
    /// The on-premise SAM account name of the user
    /// </summary>
    [TerraformPropertyName("onpremises_sam_account_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesSamAccountName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_sam_account_name");

    /// <summary>
    /// The on-premise security identifier (SID) of the user
    /// </summary>
    [TerraformPropertyName("onpremises_security_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesSecurityIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_security_identifier");

    /// <summary>
    /// Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformPropertyName("onpremises_sync_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OnpremisesSyncEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "onpremises_sync_enabled");

    /// <summary>
    /// The on-premise user principal name of the user
    /// </summary>
    [TerraformPropertyName("onpremises_user_principal_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesUserPrincipalName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_user_principal_name");

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    [TerraformPropertyName("other_mails")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OtherMails => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "other_mails");

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PostalCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "postal_code");

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredLanguage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_language");

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProxyAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "proxy_addresses");

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    [TerraformPropertyName("show_in_address_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ShowInAddressList => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "show_in_address_list");

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    [TerraformPropertyName("street_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreetAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "street_address");

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    [TerraformPropertyName("surname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Surname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "surname");

    /// <summary>
    /// The usage location of the user
    /// </summary>
    [TerraformPropertyName("usage_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UsageLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "usage_location");

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_type");

}
