using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainAdminContactBlock : TerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine1
    {
        set => SetProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        set => SetProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        set => SetProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        set => SetProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        set => SetProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        set => SetProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        set => SetProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        set => SetProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        set => SetProperty("zip_code", value);
    }

}

/// <summary>
/// Block type for billing_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainBillingContactBlock : TerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine1
    {
        set => SetProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        set => SetProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        set => SetProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        set => SetProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        set => SetProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        set => SetProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        set => SetProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        set => SetProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        set => SetProperty("zip_code", value);
    }

}

/// <summary>
/// Block type for name_server in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainNameServerBlock : TerraformBlock
{
    /// <summary>
    /// The glue_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? GlueIps
    {
        set => SetProperty("glue_ips", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for registrant_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainRegistrantContactBlock : TerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine1
    {
        set => SetProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        set => SetProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        set => SetProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        set => SetProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        set => SetProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        set => SetProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        set => SetProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        set => SetProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        set => SetProperty("zip_code", value);
    }

}

/// <summary>
/// Block type for tech_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainTechContactBlock : TerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine1
    {
        set => SetProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        set => SetProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        set => SetProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        set => SetProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        set => SetProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        set => SetProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        set => SetProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        set => SetProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        set => SetProperty("zip_code", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsRegisteredDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
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
/// Manages a aws_route53domains_registered_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53domainsRegisteredDomain : TerraformResource
{
    public AwsRoute53domainsRegisteredDomain(string name) : base("aws_route53domains_registered_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("abuse_contact_email");
        SetOutput("abuse_contact_phone");
        SetOutput("creation_date");
        SetOutput("expiration_date");
        SetOutput("registrar_name");
        SetOutput("registrar_url");
        SetOutput("reseller");
        SetOutput("status_list");
        SetOutput("updated_date");
        SetOutput("whois_server");
        SetOutput("admin_privacy");
        SetOutput("auto_renew");
        SetOutput("billing_privacy");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("registrant_privacy");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tech_privacy");
        SetOutput("transfer_lock");
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    public TerraformProperty<bool> AdminPrivacy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("admin_privacy");
        set => SetProperty("admin_privacy", value);
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformProperty<bool> AutoRenew
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_renew");
        set => SetProperty("auto_renew", value);
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public TerraformProperty<bool> BillingPrivacy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("billing_privacy");
        set => SetProperty("billing_privacy", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
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
    /// The registrant_privacy attribute.
    /// </summary>
    public TerraformProperty<bool> RegistrantPrivacy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("registrant_privacy");
        set => SetProperty("registrant_privacy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public TerraformProperty<bool> TechPrivacy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tech_privacy");
        set => SetProperty("tech_privacy", value);
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public TerraformProperty<bool> TransferLock
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transfer_lock");
        set => SetProperty("transfer_lock", value);
    }

    /// <summary>
    /// Block for admin_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainAdminContactBlock>? AdminContact
    {
        set => SetProperty("admin_contact", value);
    }

    /// <summary>
    /// Block for billing_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainBillingContactBlock>? BillingContact
    {
        set => SetProperty("billing_contact", value);
    }

    /// <summary>
    /// Block for name_server.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 NameServer block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainNameServerBlock>? NameServer
    {
        set => SetProperty("name_server", value);
    }

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrantContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainRegistrantContactBlock>? RegistrantContact
    {
        set => SetProperty("registrant_contact", value);
    }

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TechContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainTechContactBlock>? TechContact
    {
        set => SetProperty("tech_contact", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53domainsRegisteredDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The abuse_contact_email attribute.
    /// </summary>
    public TerraformExpression AbuseContactEmail => this["abuse_contact_email"];

    /// <summary>
    /// The abuse_contact_phone attribute.
    /// </summary>
    public TerraformExpression AbuseContactPhone => this["abuse_contact_phone"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    public TerraformExpression RegistrarName => this["registrar_name"];

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    public TerraformExpression RegistrarUrl => this["registrar_url"];

    /// <summary>
    /// The reseller attribute.
    /// </summary>
    public TerraformExpression Reseller => this["reseller"];

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    public TerraformExpression StatusList => this["status_list"];

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    public TerraformExpression UpdatedDate => this["updated_date"];

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    public TerraformExpression WhoisServer => this["whois_server"];

}
