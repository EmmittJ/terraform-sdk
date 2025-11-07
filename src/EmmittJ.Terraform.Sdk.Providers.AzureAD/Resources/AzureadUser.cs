using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public TerraformLiteralProperty<bool>? AccountEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("account_enabled");
        set => this.WithProperty("account_enabled", value);
    }

    /// <summary>
    /// The age group of the user
    /// </summary>
    public TerraformLiteralProperty<string>? AgeGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("age_group");
        set => this.WithProperty("age_group", value);
    }

    /// <summary>
    /// The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect
    /// </summary>
    public TerraformLiteralProperty<List<string>>? BusinessPhones
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("business_phones");
        set => this.WithProperty("business_phones", value);
    }

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    public TerraformLiteralProperty<string>? City
    {
        get => GetProperty<TerraformLiteralProperty<string>>("city");
        set => this.WithProperty("city", value);
    }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    public TerraformLiteralProperty<string>? CompanyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("company_name");
        set => this.WithProperty("company_name", value);
    }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    public TerraformLiteralProperty<string>? ConsentProvidedForMinor
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consent_provided_for_minor");
        set => this.WithProperty("consent_provided_for_minor", value);
    }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    public TerraformLiteralProperty<string>? CostCenter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cost_center");
        set => this.WithProperty("cost_center", value);
    }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    public TerraformLiteralProperty<string>? Country
    {
        get => GetProperty<TerraformLiteralProperty<string>>("country");
        set => this.WithProperty("country", value);
    }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    public TerraformLiteralProperty<string>? Department
    {
        get => GetProperty<TerraformLiteralProperty<string>>("department");
        set => this.WithProperty("department", value);
    }

    /// <summary>
    /// Whether the users password is exempt from expiring
    /// </summary>
    public TerraformLiteralProperty<bool>? DisablePasswordExpiration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_password_expiration");
        set => this.WithProperty("disable_password_expiration", value);
    }

    /// <summary>
    /// Whether the user is allowed weaker passwords than the default policy to be specified.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableStrongPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_strong_password");
        set => this.WithProperty("disable_strong_password", value);
    }

    /// <summary>
    /// The name to display in the address book for the user
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    public TerraformLiteralProperty<string>? Division
    {
        get => GetProperty<TerraformLiteralProperty<string>>("division");
        set => this.WithProperty("division", value);
    }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformLiteralProperty<string>? EmployeeHireDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("employee_hire_date");
        set => this.WithProperty("employee_hire_date", value);
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public TerraformLiteralProperty<string>? EmployeeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("employee_id");
        set => this.WithProperty("employee_id", value);
    }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    public TerraformLiteralProperty<string>? EmployeeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("employee_type");
        set => this.WithProperty("employee_type", value);
    }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    public TerraformLiteralProperty<string>? FaxNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fax_number");
        set => this.WithProperty("fax_number", value);
    }

    /// <summary>
    /// Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password
    /// </summary>
    public TerraformLiteralProperty<bool>? ForcePasswordChange
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_password_change");
        set => this.WithProperty("force_password_change", value);
    }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    public TerraformLiteralProperty<string>? GivenName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("given_name");
        set => this.WithProperty("given_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The user’s job title
    /// </summary>
    public TerraformLiteralProperty<string>? JobTitle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_title");
        set => this.WithProperty("job_title", value);
    }

    /// <summary>
    /// The SMTP address for the user. Cannot be unset.
    /// </summary>
    public TerraformLiteralProperty<string>? Mail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mail");
        set => this.WithProperty("mail", value);
    }

    /// <summary>
    /// The mail alias for the user. Defaults to the user name part of the user principal name (UPN)
    /// </summary>
    public TerraformLiteralProperty<string>? MailNickname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mail_nickname");
        set => this.WithProperty("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    public TerraformLiteralProperty<string>? ManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("manager_id");
        set => this.WithProperty("manager_id", value);
    }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    public TerraformLiteralProperty<string>? MobilePhone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_phone");
        set => this.WithProperty("mobile_phone", value);
    }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    public TerraformLiteralProperty<string>? OfficeLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("office_location");
        set => this.WithProperty("office_location", value);
    }

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user&#39;s `user_principal_name` property when creating a new user account
    /// </summary>
    public TerraformLiteralProperty<string>? OnpremisesImmutableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("onpremises_immutable_id");
        set => this.WithProperty("onpremises_immutable_id", value);
    }

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? OtherMails
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("other_mails");
        set => this.WithProperty("other_mails", value);
    }

    /// <summary>
    /// The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    public TerraformLiteralProperty<string>? PostalCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("postal_code");
        set => this.WithProperty("postal_code", value);
    }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    public TerraformLiteralProperty<string>? PreferredLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_language");
        set => this.WithProperty("preferred_language", value);
    }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    public TerraformLiteralProperty<bool>? ShowInAddressList
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("show_in_address_list");
        set => this.WithProperty("show_in_address_list", value);
    }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    public TerraformLiteralProperty<string>? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    public TerraformLiteralProperty<string>? StreetAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("street_address");
        set => this.WithProperty("street_address", value);
    }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    public TerraformLiteralProperty<string>? Surname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("surname");
        set => this.WithProperty("surname", value);
    }

    /// <summary>
    /// The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set
    /// </summary>
    public TerraformLiteralProperty<string>? UsageLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_location");
        set => this.WithProperty("usage_location", value);
    }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    public TerraformLiteralProperty<string>? UserPrincipalName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_principal_name");
        set => this.WithProperty("user_principal_name", value);
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
