using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadUserDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadUserDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_user Terraform data source.
/// Retrieves information about a azuread_user.
/// </summary>
public partial class AzureadUserDataSource(string name) : TerraformDataSource("azuread_user", name)
{
    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public TerraformValue<string> EmployeeId
    {
        get => GetArgument<TerraformValue<string>>("employee_id") ?? AsReference("employee_id");
        set => SetArgument("employee_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The SMTP address for the user
    /// </summary>
    public TerraformValue<string> Mail
    {
        get => GetArgument<TerraformValue<string>>("mail") ?? AsReference("mail");
        set => SetArgument("mail", value);
    }

    /// <summary>
    /// The email alias of the user
    /// </summary>
    public TerraformValue<string> MailNickname
    {
        get => GetArgument<TerraformValue<string>>("mail_nickname") ?? AsReference("mail_nickname");
        set => SetArgument("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the user
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id") ?? AsReference("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    public TerraformValue<string> UserPrincipalName
    {
        get => GetArgument<TerraformValue<string>>("user_principal_name") ?? AsReference("user_principal_name");
        set => SetArgument("user_principal_name", value);
    }

    /// <summary>
    /// Whether or not the account is enabled
    /// </summary>
    public TerraformValue<bool> AccountEnabled
        => AsReference("account_enabled");

    /// <summary>
    /// The age group of the user
    /// </summary>
    public TerraformValue<string> AgeGroup
        => AsReference("age_group");

    /// <summary>
    /// The telephone numbers for the user
    /// </summary>
    public TerraformList<string> BusinessPhones
        => AsReference("business_phones");

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    public TerraformValue<string> City
        => AsReference("city");

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    public TerraformValue<string> CompanyName
        => AsReference("company_name");

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    public TerraformValue<string> ConsentProvidedForMinor
        => AsReference("consent_provided_for_minor");

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    public TerraformValue<string> CostCenter
        => AsReference("cost_center");

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    public TerraformValue<string> Country
        => AsReference("country");

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    public TerraformValue<string> CreationType
        => AsReference("creation_type");

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    public TerraformValue<string> Department
        => AsReference("department");

    /// <summary>
    /// The display name of the user
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    public TerraformValue<string> Division
        => AsReference("division");

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformValue<string> EmployeeHireDate
        => AsReference("employee_hire_date");

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    public TerraformValue<string> EmployeeType
        => AsReference("employee_type");

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    public TerraformValue<string> ExternalUserState
        => AsReference("external_user_state");

    /// <summary>
    /// The fax number of the user
    /// </summary>
    public TerraformValue<string> FaxNumber
        => AsReference("fax_number");

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    public TerraformValue<string> GivenName
        => AsReference("given_name");

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    public TerraformList<string> ImAddresses
        => AsReference("im_addresses");

    /// <summary>
    /// The user’s job title
    /// </summary>
    public TerraformValue<string> JobTitle
        => AsReference("job_title");

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    public TerraformValue<string> ManagerId
        => AsReference("manager_id");

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    public TerraformValue<string> MobilePhone
        => AsReference("mobile_phone");

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    public TerraformValue<string> OfficeLocation
        => AsReference("office_location");

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    public TerraformValue<string> OnpremisesDistinguishedName
        => AsReference("onpremises_distinguished_name");

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    public TerraformValue<string> OnpremisesDomainName
        => AsReference("onpremises_domain_name");

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object
    /// </summary>
    public TerraformValue<string> OnpremisesImmutableId
        => AsReference("onpremises_immutable_id");

    /// <summary>
    /// The on-premise SAM account name of the user
    /// </summary>
    public TerraformValue<string> OnpremisesSamAccountName
        => AsReference("onpremises_sam_account_name");

    /// <summary>
    /// The on-premise security identifier (SID) of the user
    /// </summary>
    public TerraformValue<string> OnpremisesSecurityIdentifier
        => AsReference("onpremises_security_identifier");

    /// <summary>
    /// Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    public TerraformValue<bool> OnpremisesSyncEnabled
        => AsReference("onpremises_sync_enabled");

    /// <summary>
    /// The on-premise user principal name of the user
    /// </summary>
    public TerraformValue<string> OnpremisesUserPrincipalName
        => AsReference("onpremises_user_principal_name");

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    public TerraformList<string> OtherMails
        => AsReference("other_mails");

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    public TerraformValue<string> PostalCode
        => AsReference("postal_code");

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    public TerraformValue<string> PreferredLanguage
        => AsReference("preferred_language");

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    public TerraformList<string> ProxyAddresses
        => AsReference("proxy_addresses");

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    public TerraformValue<bool> ShowInAddressList
        => AsReference("show_in_address_list");

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    public TerraformValue<string> StreetAddress
        => AsReference("street_address");

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    public TerraformValue<string> Surname
        => AsReference("surname");

    /// <summary>
    /// The usage location of the user
    /// </summary>
    public TerraformValue<string> UsageLocation
        => AsReference("usage_location");

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    public TerraformValue<string> UserType
        => AsReference("user_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadUserDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadUserDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
