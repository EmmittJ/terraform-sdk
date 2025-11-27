using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadUser.
/// Nesting mode: single
/// </summary>
public class AzureadUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_user Terraform resource.
/// Manages a azuread_user resource.
/// </summary>
public partial class AzureadUser(string name) : TerraformResource("azuread_user", name)
{
    /// <summary>
    /// Whether or not the account should be enabled
    /// </summary>
    public TerraformValue<bool>? AccountEnabled
    {
        get => new TerraformReference<bool>(this, "account_enabled");
        set => SetArgument("account_enabled", value);
    }

    /// <summary>
    /// The age group of the user
    /// </summary>
    public TerraformValue<string>? AgeGroup
    {
        get => new TerraformReference<string>(this, "age_group");
        set => SetArgument("age_group", value);
    }

    /// <summary>
    /// The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced with Azure AD Connect
    /// </summary>
    public TerraformList<string> BusinessPhones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "business_phones").ResolveNodes(ctx));
        set => SetArgument("business_phones", value);
    }

    /// <summary>
    /// The city in which the user is located
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The company name which the user is associated. This property can be useful for describing the company that an external user comes from
    /// </summary>
    public TerraformValue<string>? CompanyName
    {
        get => new TerraformReference<string>(this, "company_name");
        set => SetArgument("company_name", value);
    }

    /// <summary>
    /// Whether consent has been obtained for minors
    /// </summary>
    public TerraformValue<string>? ConsentProvidedForMinor
    {
        get => new TerraformReference<string>(this, "consent_provided_for_minor");
        set => SetArgument("consent_provided_for_minor", value);
    }

    /// <summary>
    /// The cost center associated with the user.
    /// </summary>
    public TerraformValue<string>? CostCenter
    {
        get => new TerraformReference<string>(this, "cost_center");
        set => SetArgument("cost_center", value);
    }

    /// <summary>
    /// The country/region in which the user is located, e.g. `US` or `UK`
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The name for the department in which the user works
    /// </summary>
    public TerraformValue<string>? Department
    {
        get => new TerraformReference<string>(this, "department");
        set => SetArgument("department", value);
    }

    /// <summary>
    /// Whether the users password is exempt from expiring
    /// </summary>
    public TerraformValue<bool>? DisablePasswordExpiration
    {
        get => new TerraformReference<bool>(this, "disable_password_expiration");
        set => SetArgument("disable_password_expiration", value);
    }

    /// <summary>
    /// Whether the user is allowed weaker passwords than the default policy to be specified.
    /// </summary>
    public TerraformValue<bool>? DisableStrongPassword
    {
        get => new TerraformReference<bool>(this, "disable_strong_password");
        set => SetArgument("disable_strong_password", value);
    }

    /// <summary>
    /// The name to display in the address book for the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The name of the division in which the user works.
    /// </summary>
    public TerraformValue<string>? Division
    {
        get => new TerraformReference<string>(this, "division");
        set => SetArgument("division", value);
    }

    /// <summary>
    /// The hire date of the user, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformValue<string>? EmployeeHireDate
    {
        get => new TerraformReference<string>(this, "employee_hire_date");
        set => SetArgument("employee_hire_date", value);
    }

    /// <summary>
    /// The employee identifier assigned to the user by the organisation
    /// </summary>
    public TerraformValue<string>? EmployeeId
    {
        get => new TerraformReference<string>(this, "employee_id");
        set => SetArgument("employee_id", value);
    }

    /// <summary>
    /// Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor.
    /// </summary>
    public TerraformValue<string>? EmployeeType
    {
        get => new TerraformReference<string>(this, "employee_type");
        set => SetArgument("employee_type", value);
    }

    /// <summary>
    /// The fax number of the user
    /// </summary>
    public TerraformValue<string>? FaxNumber
    {
        get => new TerraformReference<string>(this, "fax_number");
        set => SetArgument("fax_number", value);
    }

    /// <summary>
    /// Whether the user is forced to change the password during the next sign-in. Only takes effect when also changing the password
    /// </summary>
    public TerraformValue<bool>? ForcePasswordChange
    {
        get => new TerraformReference<bool>(this, "force_password_change");
        set => SetArgument("force_password_change", value);
    }

    /// <summary>
    /// The given name (first name) of the user
    /// </summary>
    public TerraformValue<string>? GivenName
    {
        get => new TerraformReference<string>(this, "given_name");
        set => SetArgument("given_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The user’s job title
    /// </summary>
    public TerraformValue<string>? JobTitle
    {
        get => new TerraformReference<string>(this, "job_title");
        set => SetArgument("job_title", value);
    }

    /// <summary>
    /// The SMTP address for the user. Cannot be unset.
    /// </summary>
    public TerraformValue<string> Mail
    {
        get => new TerraformReference<string>(this, "mail");
        set => SetArgument("mail", value);
    }

    /// <summary>
    /// The mail alias for the user. Defaults to the user name part of the user principal name (UPN)
    /// </summary>
    public TerraformValue<string> MailNickname
    {
        get => new TerraformReference<string>(this, "mail_nickname");
        set => SetArgument("mail_nickname", value);
    }

    /// <summary>
    /// The object ID of the user&#39;s manager
    /// </summary>
    public TerraformValue<string>? ManagerId
    {
        get => new TerraformReference<string>(this, "manager_id");
        set => SetArgument("manager_id", value);
    }

    /// <summary>
    /// The primary cellular telephone number for the user
    /// </summary>
    public TerraformValue<string>? MobilePhone
    {
        get => new TerraformReference<string>(this, "mobile_phone");
        set => SetArgument("mobile_phone", value);
    }

    /// <summary>
    /// The office location in the user&#39;s place of business
    /// </summary>
    public TerraformValue<string>? OfficeLocation
    {
        get => new TerraformReference<string>(this, "office_location");
        set => SetArgument("office_location", value);
    }

    /// <summary>
    /// The value used to associate an on-premise Active Directory user account with their Azure AD user object. This must be specified if you are using a federated domain for the user&#39;s `user_principal_name` property when creating a new user account
    /// </summary>
    public TerraformValue<string> OnpremisesImmutableId
    {
        get => new TerraformReference<string>(this, "onpremises_immutable_id");
        set => SetArgument("onpremises_immutable_id", value);
    }

    /// <summary>
    /// Additional email addresses for the user
    /// </summary>
    public TerraformSet<string>? OtherMails
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "other_mails").ResolveNodes(ctx));
        set => SetArgument("other_mails", value);
    }

    /// <summary>
    /// The password for the user. The password must satisfy minimum requirements as specified by the password policy. The maximum length is 256 characters. This property is required when creating a new user
    /// </summary>
    public TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The postal code for the user&#39;s postal address. The postal code is specific to the user&#39;s country/region. In the United States of America, this attribute contains the ZIP code
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => new TerraformReference<string>(this, "postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The user&#39;s preferred language, in ISO 639-1 notation
    /// </summary>
    public TerraformValue<string>? PreferredLanguage
    {
        get => new TerraformReference<string>(this, "preferred_language");
        set => SetArgument("preferred_language", value);
    }

    /// <summary>
    /// Whether or not the Outlook global address list should include this user
    /// </summary>
    public TerraformValue<bool>? ShowInAddressList
    {
        get => new TerraformReference<bool>(this, "show_in_address_list");
        set => SetArgument("show_in_address_list", value);
    }

    /// <summary>
    /// The state or province in the user&#39;s address
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The street address of the user&#39;s place of business
    /// </summary>
    public TerraformValue<string>? StreetAddress
    {
        get => new TerraformReference<string>(this, "street_address");
        set => SetArgument("street_address", value);
    }

    /// <summary>
    /// The user&#39;s surname (family name or last name)
    /// </summary>
    public TerraformValue<string>? Surname
    {
        get => new TerraformReference<string>(this, "surname");
        set => SetArgument("surname", value);
    }

    /// <summary>
    /// The usage location of the user. Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. The usage location is a two letter country code (ISO standard 3166). Examples include: `NO`, `JP`, and `GB`. Cannot be reset to null once set
    /// </summary>
    public TerraformValue<string>? UsageLocation
    {
        get => new TerraformReference<string>(this, "usage_location");
        set => SetArgument("usage_location", value);
    }

    /// <summary>
    /// The user principal name (UPN) of the user
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPrincipalName is required")]
    public required TerraformValue<string> UserPrincipalName
    {
        get => new TerraformReference<string>(this, "user_principal_name");
        set => SetArgument("user_principal_name", value);
    }

    /// <summary>
    /// A freeform field for the user to describe themselves
    /// </summary>
    public TerraformValue<string> AboutMe
    {
        get => new TerraformReference<string>(this, "about_me");
    }

    /// <summary>
    /// Indicates whether the user account was created as a regular school or work account (`null`), an external account (`Invitation`), a local account for an Azure Active Directory B2C tenant (`LocalAccount`) or self-service sign-up using email verification (`EmailVerified`)
    /// </summary>
    public TerraformValue<string> CreationType
    {
        get => new TerraformReference<string>(this, "creation_type");
    }

    /// <summary>
    /// For an external user invited to the tenant, this property represents the invited user&#39;s invitation status
    /// </summary>
    public TerraformValue<string> ExternalUserState
    {
        get => new TerraformReference<string>(this, "external_user_state");
    }

    /// <summary>
    /// The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user
    /// </summary>
    public TerraformList<string> ImAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "im_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The object ID of the user
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// The on-premise Active Directory distinguished name (DN) of the user
    /// </summary>
    public TerraformValue<string> OnpremisesDistinguishedName
    {
        get => new TerraformReference<string>(this, "onpremises_distinguished_name");
    }

    /// <summary>
    /// The on-premise FQDN (i.e. dnsDomainName) of the user
    /// </summary>
    public TerraformValue<string> OnpremisesDomainName
    {
        get => new TerraformReference<string>(this, "onpremises_domain_name");
    }

    /// <summary>
    /// The on-premise SAM account name of the user
    /// </summary>
    public TerraformValue<string> OnpremisesSamAccountName
    {
        get => new TerraformReference<string>(this, "onpremises_sam_account_name");
    }

    /// <summary>
    /// The on-premise security identifier (SID) of the user
    /// </summary>
    public TerraformValue<string> OnpremisesSecurityIdentifier
    {
        get => new TerraformReference<string>(this, "onpremises_security_identifier");
    }

    /// <summary>
    /// Whether this user is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    public TerraformValue<bool> OnpremisesSyncEnabled
    {
        get => new TerraformReference<bool>(this, "onpremises_sync_enabled");
    }

    /// <summary>
    /// The on-premise user principal name of the user
    /// </summary>
    public TerraformValue<string> OnpremisesUserPrincipalName
    {
        get => new TerraformReference<string>(this, "onpremises_user_principal_name");
    }

    /// <summary>
    /// Email addresses for the user that direct to the same mailbox
    /// </summary>
    public TerraformList<string> ProxyAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "proxy_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user type in the directory. Possible values are `Guest` or `Member`
    /// </summary>
    public TerraformValue<string> UserType
    {
        get => new TerraformReference<string>(this, "user_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadUserTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadUserTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
