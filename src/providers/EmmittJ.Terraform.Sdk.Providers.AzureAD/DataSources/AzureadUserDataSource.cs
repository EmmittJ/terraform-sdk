using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azuread_user.
/// </summary>
public class AzureadUserDataSource : TerraformDataSource
{
    public AzureadUserDataSource(string name) : base("azuread_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_enabled");
        SetOutput("age_group");
        SetOutput("business_phones");
        SetOutput("city");
        SetOutput("company_name");
        SetOutput("consent_provided_for_minor");
        SetOutput("cost_center");
        SetOutput("country");
        SetOutput("creation_type");
        SetOutput("department");
        SetOutput("display_name");
        SetOutput("division");
        SetOutput("employee_hire_date");
        SetOutput("employee_type");
        SetOutput("external_user_state");
        SetOutput("fax_number");
        SetOutput("given_name");
        SetOutput("im_addresses");
        SetOutput("job_title");
        SetOutput("manager_id");
        SetOutput("mobile_phone");
        SetOutput("office_location");
        SetOutput("onpremises_distinguished_name");
        SetOutput("onpremises_domain_name");
        SetOutput("onpremises_immutable_id");
        SetOutput("onpremises_sam_account_name");
        SetOutput("onpremises_security_identifier");
        SetOutput("onpremises_sync_enabled");
        SetOutput("onpremises_user_principal_name");
        SetOutput("other_mails");
        SetOutput("postal_code");
        SetOutput("preferred_language");
        SetOutput("proxy_addresses");
        SetOutput("show_in_address_list");
        SetOutput("state");
        SetOutput("street_address");
        SetOutput("surname");
        SetOutput("usage_location");
        SetOutput("user_type");
        SetOutput("employee_id");
        SetOutput("id");
        SetOutput("mail");
        SetOutput("mail_nickname");
        SetOutput("object_id");
        SetOutput("user_principal_name");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The SMTP address for the user
    /// </summary>
    public TerraformProperty<string> Mail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mail");
        set => SetProperty("mail", value);
    }

    /// <summary>
    /// The email alias of the user
    /// </summary>
    public TerraformProperty<string> MailNickname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mail_nickname");
        set => SetProperty("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the user
    /// </summary>
    public TerraformProperty<string> ObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_id");
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    public TerraformProperty<string> UserPrincipalName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_principal_name");
        set => SetProperty("user_principal_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadUserDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Whether or not the account is enabled
    /// </summary>
    public TerraformExpression AccountEnabled => this["account_enabled"];

    /// <summary>
    /// The age group of the user
    /// </summary>
    public TerraformExpression AgeGroup => this["age_group"];

    /// <summary>
    /// The telephone numbers for the user
    /// </summary>
    public TerraformExpression BusinessPhones => this["business_phones"];

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    public TerraformExpression City => this["city"];

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    public TerraformExpression CompanyName => this["company_name"];

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    public TerraformExpression ConsentProvidedForMinor => this["consent_provided_for_minor"];

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    public TerraformExpression CostCenter => this["cost_center"];

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    public TerraformExpression Country => this["country"];

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    public TerraformExpression CreationType => this["creation_type"];

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    public TerraformExpression Department => this["department"];

    /// <summary>
    /// The display name of the user
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    public TerraformExpression Division => this["division"];

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformExpression EmployeeHireDate => this["employee_hire_date"];

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    public TerraformExpression EmployeeType => this["employee_type"];

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    public TerraformExpression ExternalUserState => this["external_user_state"];

    /// <summary>
    /// The fax number of the user
    /// </summary>
    public TerraformExpression FaxNumber => this["fax_number"];

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    public TerraformExpression GivenName => this["given_name"];

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    public TerraformExpression ImAddresses => this["im_addresses"];

    /// <summary>
    /// The user’s job title
    /// </summary>
    public TerraformExpression JobTitle => this["job_title"];

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    public TerraformExpression ManagerId => this["manager_id"];

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    public TerraformExpression MobilePhone => this["mobile_phone"];

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    public TerraformExpression OfficeLocation => this["office_location"];

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    public TerraformExpression OnpremisesDistinguishedName => this["onpremises_distinguished_name"];

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    public TerraformExpression OnpremisesDomainName => this["onpremises_domain_name"];

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object
    /// </summary>
    public TerraformExpression OnpremisesImmutableId => this["onpremises_immutable_id"];

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
    /// Additional email addresses for the user
    /// </summary>
    public TerraformExpression OtherMails => this["other_mails"];

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    public TerraformExpression PostalCode => this["postal_code"];

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    public TerraformExpression PreferredLanguage => this["preferred_language"];

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    public TerraformExpression ProxyAddresses => this["proxy_addresses"];

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    public TerraformExpression ShowInAddressList => this["show_in_address_list"];

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    public TerraformExpression StreetAddress => this["street_address"];

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    public TerraformExpression Surname => this["surname"];

    /// <summary>
    /// The usage location of the user
    /// </summary>
    public TerraformExpression UsageLocation => this["usage_location"];

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    public TerraformExpression UserType => this["user_type"];

}
