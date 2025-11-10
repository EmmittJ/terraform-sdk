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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("about_me");
        this.DeclareOutput("creation_type");
        this.DeclareOutput("external_user_state");
        this.DeclareOutput("im_addresses");
        this.DeclareOutput("object_id");
        this.DeclareOutput("onpremises_distinguished_name");
        this.DeclareOutput("onpremises_domain_name");
        this.DeclareOutput("onpremises_sam_account_name");
        this.DeclareOutput("onpremises_security_identifier");
        this.DeclareOutput("onpremises_sync_enabled");
        this.DeclareOutput("onpremises_user_principal_name");
        this.DeclareOutput("proxy_addresses");
        this.DeclareOutput("user_type");
    }

    /// <summary>
    /// Whether or not the account should be enabled
    /// </summary>
    public TerraformProperty<bool>? AccountEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("account_enabled");
        set => this.WithProperty("account_enabled", value);
    }

    /// <summary>
    /// The age group of the user
    /// </summary>
    public TerraformProperty<string>? AgeGroup
    {
        get => GetProperty<TerraformProperty<string>>("age_group");
        set => this.WithProperty("age_group", value);
    }

    /// <summary>
    /// The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect
    /// </summary>
    public List<TerraformProperty<string>>? BusinessPhones
    {
        get => GetProperty<List<TerraformProperty<string>>>("business_phones");
        set => this.WithProperty("business_phones", value);
    }

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    public TerraformProperty<string>? City
    {
        get => GetProperty<TerraformProperty<string>>("city");
        set => this.WithProperty("city", value);
    }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    public TerraformProperty<string>? CompanyName
    {
        get => GetProperty<TerraformProperty<string>>("company_name");
        set => this.WithProperty("company_name", value);
    }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    public TerraformProperty<string>? ConsentProvidedForMinor
    {
        get => GetProperty<TerraformProperty<string>>("consent_provided_for_minor");
        set => this.WithProperty("consent_provided_for_minor", value);
    }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    public TerraformProperty<string>? CostCenter
    {
        get => GetProperty<TerraformProperty<string>>("cost_center");
        set => this.WithProperty("cost_center", value);
    }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    public TerraformProperty<string>? Country
    {
        get => GetProperty<TerraformProperty<string>>("country");
        set => this.WithProperty("country", value);
    }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    public TerraformProperty<string>? Department
    {
        get => GetProperty<TerraformProperty<string>>("department");
        set => this.WithProperty("department", value);
    }

    /// <summary>
    /// Whether the users password is exempt from expiring
    /// </summary>
    public TerraformProperty<bool>? DisablePasswordExpiration
    {
        get => GetProperty<TerraformProperty<bool>>("disable_password_expiration");
        set => this.WithProperty("disable_password_expiration", value);
    }

    /// <summary>
    /// Whether the user is allowed weaker passwords than the default policy to be specified.
    /// </summary>
    public TerraformProperty<bool>? DisableStrongPassword
    {
        get => GetProperty<TerraformProperty<bool>>("disable_strong_password");
        set => this.WithProperty("disable_strong_password", value);
    }

    /// <summary>
    /// The name to display in the address book for the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    public TerraformProperty<string>? Division
    {
        get => GetProperty<TerraformProperty<string>>("division");
        set => this.WithProperty("division", value);
    }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformProperty<string>? EmployeeHireDate
    {
        get => GetProperty<TerraformProperty<string>>("employee_hire_date");
        set => this.WithProperty("employee_hire_date", value);
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public TerraformProperty<string>? EmployeeId
    {
        get => GetProperty<TerraformProperty<string>>("employee_id");
        set => this.WithProperty("employee_id", value);
    }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    public TerraformProperty<string>? EmployeeType
    {
        get => GetProperty<TerraformProperty<string>>("employee_type");
        set => this.WithProperty("employee_type", value);
    }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    public TerraformProperty<string>? FaxNumber
    {
        get => GetProperty<TerraformProperty<string>>("fax_number");
        set => this.WithProperty("fax_number", value);
    }

    /// <summary>
    /// Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password
    /// </summary>
    public TerraformProperty<bool>? ForcePasswordChange
    {
        get => GetProperty<TerraformProperty<bool>>("force_password_change");
        set => this.WithProperty("force_password_change", value);
    }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    public TerraformProperty<string>? GivenName
    {
        get => GetProperty<TerraformProperty<string>>("given_name");
        set => this.WithProperty("given_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The user’s job title
    /// </summary>
    public TerraformProperty<string>? JobTitle
    {
        get => GetProperty<TerraformProperty<string>>("job_title");
        set => this.WithProperty("job_title", value);
    }

    /// <summary>
    /// The SMTP address for the user. Cannot be unset.
    /// </summary>
    public TerraformProperty<string>? Mail
    {
        get => GetProperty<TerraformProperty<string>>("mail");
        set => this.WithProperty("mail", value);
    }

    /// <summary>
    /// The mail alias for the user. Defaults to the user name part of the user principal name (UPN)
    /// </summary>
    public TerraformProperty<string>? MailNickname
    {
        get => GetProperty<TerraformProperty<string>>("mail_nickname");
        set => this.WithProperty("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    public TerraformProperty<string>? ManagerId
    {
        get => GetProperty<TerraformProperty<string>>("manager_id");
        set => this.WithProperty("manager_id", value);
    }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    public TerraformProperty<string>? MobilePhone
    {
        get => GetProperty<TerraformProperty<string>>("mobile_phone");
        set => this.WithProperty("mobile_phone", value);
    }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    public TerraformProperty<string>? OfficeLocation
    {
        get => GetProperty<TerraformProperty<string>>("office_location");
        set => this.WithProperty("office_location", value);
    }

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user&#39;s `user_principal_name` property when creating a new user account
    /// </summary>
    public TerraformProperty<string>? OnpremisesImmutableId
    {
        get => GetProperty<TerraformProperty<string>>("onpremises_immutable_id");
        set => this.WithProperty("onpremises_immutable_id", value);
    }

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    public HashSet<TerraformProperty<string>>? OtherMails
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("other_mails");
        set => this.WithProperty("other_mails", value);
    }

    /// <summary>
    /// The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    public TerraformProperty<string>? PostalCode
    {
        get => GetProperty<TerraformProperty<string>>("postal_code");
        set => this.WithProperty("postal_code", value);
    }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    public TerraformProperty<string>? PreferredLanguage
    {
        get => GetProperty<TerraformProperty<string>>("preferred_language");
        set => this.WithProperty("preferred_language", value);
    }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    public TerraformProperty<bool>? ShowInAddressList
    {
        get => GetProperty<TerraformProperty<bool>>("show_in_address_list");
        set => this.WithProperty("show_in_address_list", value);
    }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    public TerraformProperty<string>? StreetAddress
    {
        get => GetProperty<TerraformProperty<string>>("street_address");
        set => this.WithProperty("street_address", value);
    }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    public TerraformProperty<string>? Surname
    {
        get => GetProperty<TerraformProperty<string>>("surname");
        set => this.WithProperty("surname", value);
    }

    /// <summary>
    /// The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set
    /// </summary>
    public TerraformProperty<string>? UsageLocation
    {
        get => GetProperty<TerraformProperty<string>>("usage_location");
        set => this.WithProperty("usage_location", value);
    }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPrincipalName is required")]
    public required TerraformProperty<string> UserPrincipalName
    {
        get => GetProperty<TerraformProperty<string>>("user_principal_name");
        set => this.WithProperty("user_principal_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadUserTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadUserTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
