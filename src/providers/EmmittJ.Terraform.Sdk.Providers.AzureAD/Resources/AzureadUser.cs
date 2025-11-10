using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_user resource.
/// </summary>
public class AzureadUser : TerraformResource
{
    public AzureadUser(string name) : base("azuread_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("about_me");
        SetOutput("creation_type");
        SetOutput("external_user_state");
        SetOutput("im_addresses");
        SetOutput("object_id");
        SetOutput("onpremises_distinguished_name");
        SetOutput("onpremises_domain_name");
        SetOutput("onpremises_sam_account_name");
        SetOutput("onpremises_security_identifier");
        SetOutput("onpremises_sync_enabled");
        SetOutput("onpremises_user_principal_name");
        SetOutput("proxy_addresses");
        SetOutput("user_type");
        SetOutput("account_enabled");
        SetOutput("age_group");
        SetOutput("business_phones");
        SetOutput("city");
        SetOutput("company_name");
        SetOutput("consent_provided_for_minor");
        SetOutput("cost_center");
        SetOutput("country");
        SetOutput("department");
        SetOutput("disable_password_expiration");
        SetOutput("disable_strong_password");
        SetOutput("display_name");
        SetOutput("division");
        SetOutput("employee_hire_date");
        SetOutput("employee_id");
        SetOutput("employee_type");
        SetOutput("fax_number");
        SetOutput("force_password_change");
        SetOutput("given_name");
        SetOutput("id");
        SetOutput("job_title");
        SetOutput("mail");
        SetOutput("mail_nickname");
        SetOutput("manager_id");
        SetOutput("mobile_phone");
        SetOutput("office_location");
        SetOutput("onpremises_immutable_id");
        SetOutput("other_mails");
        SetOutput("password");
        SetOutput("postal_code");
        SetOutput("preferred_language");
        SetOutput("show_in_address_list");
        SetOutput("state");
        SetOutput("street_address");
        SetOutput("surname");
        SetOutput("usage_location");
        SetOutput("user_principal_name");
    }

    /// <summary>
    /// Whether or not the account should be enabled
    /// </summary>
    public TerraformProperty<bool> AccountEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("account_enabled");
        set => SetProperty("account_enabled", value);
    }

    /// <summary>
    /// The age group of the user
    /// </summary>
    public TerraformProperty<string> AgeGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("age_group");
        set => SetProperty("age_group", value);
    }

    /// <summary>
    /// The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect
    /// </summary>
    public List<TerraformProperty<string>> BusinessPhones
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("business_phones");
        set => SetProperty("business_phones", value);
    }

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    public TerraformProperty<string> City
    {
        get => GetRequiredOutput<TerraformProperty<string>>("city");
        set => SetProperty("city", value);
    }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    public TerraformProperty<string> CompanyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("company_name");
        set => SetProperty("company_name", value);
    }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    public TerraformProperty<string> ConsentProvidedForMinor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consent_provided_for_minor");
        set => SetProperty("consent_provided_for_minor", value);
    }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    public TerraformProperty<string> CostCenter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cost_center");
        set => SetProperty("cost_center", value);
    }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    public TerraformProperty<string> Country
    {
        get => GetRequiredOutput<TerraformProperty<string>>("country");
        set => SetProperty("country", value);
    }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    public TerraformProperty<string> Department
    {
        get => GetRequiredOutput<TerraformProperty<string>>("department");
        set => SetProperty("department", value);
    }

    /// <summary>
    /// Whether the users password is exempt from expiring
    /// </summary>
    public TerraformProperty<bool> DisablePasswordExpiration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_password_expiration");
        set => SetProperty("disable_password_expiration", value);
    }

    /// <summary>
    /// Whether the user is allowed weaker passwords than the default policy to be specified.
    /// </summary>
    public TerraformProperty<bool> DisableStrongPassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_strong_password");
        set => SetProperty("disable_strong_password", value);
    }

    /// <summary>
    /// The name to display in the address book for the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    public TerraformProperty<string> Division
    {
        get => GetRequiredOutput<TerraformProperty<string>>("division");
        set => SetProperty("division", value);
    }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformProperty<string> EmployeeHireDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("employee_hire_date");
        set => SetProperty("employee_hire_date", value);
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public TerraformProperty<string> EmployeeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("employee_id");
        set => SetProperty("employee_id", value);
    }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    public TerraformProperty<string> EmployeeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("employee_type");
        set => SetProperty("employee_type", value);
    }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    public TerraformProperty<string> FaxNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fax_number");
        set => SetProperty("fax_number", value);
    }

    /// <summary>
    /// Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password
    /// </summary>
    public TerraformProperty<bool> ForcePasswordChange
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_password_change");
        set => SetProperty("force_password_change", value);
    }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    public TerraformProperty<string> GivenName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("given_name");
        set => SetProperty("given_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The user’s job title
    /// </summary>
    public TerraformProperty<string> JobTitle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_title");
        set => SetProperty("job_title", value);
    }

    /// <summary>
    /// The SMTP address for the user. Cannot be unset.
    /// </summary>
    public TerraformProperty<string> Mail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mail");
        set => SetProperty("mail", value);
    }

    /// <summary>
    /// The mail alias for the user. Defaults to the user name part of the user principal name (UPN)
    /// </summary>
    public TerraformProperty<string> MailNickname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mail_nickname");
        set => SetProperty("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    public TerraformProperty<string> ManagerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("manager_id");
        set => SetProperty("manager_id", value);
    }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    public TerraformProperty<string> MobilePhone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_phone");
        set => SetProperty("mobile_phone", value);
    }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    public TerraformProperty<string> OfficeLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("office_location");
        set => SetProperty("office_location", value);
    }

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user&#39;s `user_principal_name` property when creating a new user account
    /// </summary>
    public TerraformProperty<string> OnpremisesImmutableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("onpremises_immutable_id");
        set => SetProperty("onpremises_immutable_id", value);
    }

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    public HashSet<TerraformProperty<string>> OtherMails
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("other_mails");
        set => SetProperty("other_mails", value);
    }

    /// <summary>
    /// The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    public TerraformProperty<string> PostalCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("postal_code");
        set => SetProperty("postal_code", value);
    }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    public TerraformProperty<string> PreferredLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_language");
        set => SetProperty("preferred_language", value);
    }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    public TerraformProperty<bool> ShowInAddressList
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("show_in_address_list");
        set => SetProperty("show_in_address_list", value);
    }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    public TerraformProperty<string> StreetAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("street_address");
        set => SetProperty("street_address", value);
    }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    public TerraformProperty<string> Surname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("surname");
        set => SetProperty("surname", value);
    }

    /// <summary>
    /// The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set
    /// </summary>
    public TerraformProperty<string> UsageLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage_location");
        set => SetProperty("usage_location", value);
    }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPrincipalName is required")]
    public required TerraformProperty<string> UserPrincipalName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_principal_name");
        set => SetProperty("user_principal_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadUserTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A freeform field for the user to describe themselves
    /// </summary>
    public TerraformExpression AboutMe => this["about_me"];

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    public TerraformExpression CreationType => this["creation_type"];

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    public TerraformExpression ExternalUserState => this["external_user_state"];

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    public TerraformExpression ImAddresses => this["im_addresses"];

    /// <summary>
    /// The object ID of the user
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    public TerraformExpression OnpremisesDistinguishedName => this["onpremises_distinguished_name"];

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    public TerraformExpression OnpremisesDomainName => this["onpremises_domain_name"];

    /// <summary>
    /// The on-premise SAM account name of the user
    /// </summary>
    public TerraformExpression OnpremisesSamAccountName => this["onpremises_sam_account_name"];

    /// <summary>
    /// The on-premise security identifier (SID) of the user
    /// </summary>
    public TerraformExpression OnpremisesSecurityIdentifier => this["onpremises_security_identifier"];

    /// <summary>
    /// Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    public TerraformExpression OnpremisesSyncEnabled => this["onpremises_sync_enabled"];

    /// <summary>
    /// The on-premise user principal name of the user
    /// </summary>
    public TerraformExpression OnpremisesUserPrincipalName => this["onpremises_user_principal_name"];

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    public TerraformExpression ProxyAddresses => this["proxy_addresses"];

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    public TerraformExpression UserType => this["user_type"];

}
