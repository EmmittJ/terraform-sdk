using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_user resource.
/// </summary>
public class AzureadUser : TerraformResource
{
    public AzureadUser(string name) : base("azuread_user", name)
    {
    }

    /// <summary>
    /// Whether or not the account should be enabled
    /// </summary>
    [TerraformPropertyName("account_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AccountEnabled { get; set; }

    /// <summary>
    /// The age group of the user
    /// </summary>
    [TerraformPropertyName("age_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AgeGroup { get; set; }

    /// <summary>
    /// The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect
    /// </summary>
    [TerraformPropertyName("business_phones")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> BusinessPhones { get; set; } = default!;

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? City { get; set; }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompanyName { get; set; }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    [TerraformPropertyName("consent_provided_for_minor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConsentProvidedForMinor { get; set; }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    [TerraformPropertyName("cost_center")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CostCenter { get; set; }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Country { get; set; }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    [TerraformPropertyName("department")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Department { get; set; }

    /// <summary>
    /// Whether the users password is exempt from expiring
    /// </summary>
    [TerraformPropertyName("disable_password_expiration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisablePasswordExpiration { get; set; }

    /// <summary>
    /// Whether the user is allowed weaker passwords than the default policy to be specified.
    /// </summary>
    [TerraformPropertyName("disable_strong_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableStrongPassword { get; set; }

    /// <summary>
    /// The name to display in the address book for the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    [TerraformPropertyName("division")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Division { get; set; }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    [TerraformPropertyName("employee_hire_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmployeeHireDate { get; set; }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    [TerraformPropertyName("employee_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmployeeId { get; set; }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    [TerraformPropertyName("employee_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmployeeType { get; set; }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    [TerraformPropertyName("fax_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FaxNumber { get; set; }

    /// <summary>
    /// Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password
    /// </summary>
    [TerraformPropertyName("force_password_change")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForcePasswordChange { get; set; }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    [TerraformPropertyName("given_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GivenName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The user’s job title
    /// </summary>
    [TerraformPropertyName("job_title")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JobTitle { get; set; }

    /// <summary>
    /// The SMTP address for the user. Cannot be unset.
    /// </summary>
    [TerraformPropertyName("mail")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mail { get; set; } = default!;

    /// <summary>
    /// The mail alias for the user. Defaults to the user name part of the user principal name (UPN)
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MailNickname { get; set; } = default!;

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    [TerraformPropertyName("manager_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagerId { get; set; }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    [TerraformPropertyName("mobile_phone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MobilePhone { get; set; }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    [TerraformPropertyName("office_location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OfficeLocation { get; set; }

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user&#39;s `user_principal_name` property when creating a new user account
    /// </summary>
    [TerraformPropertyName("onpremises_immutable_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OnpremisesImmutableId { get; set; } = default!;

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    [TerraformPropertyName("other_mails")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? OtherMails { get; set; }

    /// <summary>
    /// The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Password { get; set; } = default!;

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PostalCode { get; set; }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreferredLanguage { get; set; }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    [TerraformPropertyName("show_in_address_list")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ShowInAddressList { get; set; }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    [TerraformPropertyName("street_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StreetAddress { get; set; }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    [TerraformPropertyName("surname")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Surname { get; set; }

    /// <summary>
    /// The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set
    /// </summary>
    [TerraformPropertyName("usage_location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UsageLocation { get; set; }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPrincipalName is required")]
    [TerraformPropertyName("user_principal_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPrincipalName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadUserTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A freeform field for the user to describe themselves
    /// </summary>
    [TerraformPropertyName("about_me")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AboutMe => new TerraformReference(this, "about_me");

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    [TerraformPropertyName("creation_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationType => new TerraformReference(this, "creation_type");

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    [TerraformPropertyName("external_user_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExternalUserState => new TerraformReference(this, "external_user_state");

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    [TerraformPropertyName("im_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ImAddresses => new TerraformReference(this, "im_addresses");

    /// <summary>
    /// The object ID of the user
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectId => new TerraformReference(this, "object_id");

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
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ProxyAddresses => new TerraformReference(this, "proxy_addresses");

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserType => new TerraformReference(this, "user_type");

}
