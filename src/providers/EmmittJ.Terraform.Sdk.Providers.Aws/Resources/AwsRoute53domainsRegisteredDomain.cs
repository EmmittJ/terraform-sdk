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
        get => GetProperty<TerraformProperty<string>>("address_line_1");
        set => WithProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        get => GetProperty<TerraformProperty<string>>("address_line_2");
        set => WithProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        get => GetProperty<TerraformProperty<string>>("city");
        set => WithProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        get => GetProperty<TerraformProperty<string>>("contact_type");
        set => WithProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("extra_params");
        set => WithProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        get => GetProperty<TerraformProperty<string>>("fax");
        set => WithProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => WithProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => WithProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        get => GetProperty<TerraformProperty<string>>("organization_name");
        set => WithProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        get => GetProperty<TerraformProperty<string>>("zip_code");
        set => WithProperty("zip_code", value);
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
        get => GetProperty<TerraformProperty<string>>("address_line_1");
        set => WithProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        get => GetProperty<TerraformProperty<string>>("address_line_2");
        set => WithProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        get => GetProperty<TerraformProperty<string>>("city");
        set => WithProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        get => GetProperty<TerraformProperty<string>>("contact_type");
        set => WithProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("extra_params");
        set => WithProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        get => GetProperty<TerraformProperty<string>>("fax");
        set => WithProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => WithProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => WithProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        get => GetProperty<TerraformProperty<string>>("organization_name");
        set => WithProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        get => GetProperty<TerraformProperty<string>>("zip_code");
        set => WithProperty("zip_code", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("glue_ips");
        set => WithProperty("glue_ips", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<string>>("address_line_1");
        set => WithProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        get => GetProperty<TerraformProperty<string>>("address_line_2");
        set => WithProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        get => GetProperty<TerraformProperty<string>>("city");
        set => WithProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        get => GetProperty<TerraformProperty<string>>("contact_type");
        set => WithProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("extra_params");
        set => WithProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        get => GetProperty<TerraformProperty<string>>("fax");
        set => WithProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => WithProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => WithProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        get => GetProperty<TerraformProperty<string>>("organization_name");
        set => WithProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        get => GetProperty<TerraformProperty<string>>("zip_code");
        set => WithProperty("zip_code", value);
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
        get => GetProperty<TerraformProperty<string>>("address_line_1");
        set => WithProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        get => GetProperty<TerraformProperty<string>>("address_line_2");
        set => WithProperty("address_line_2", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformProperty<string>? City
    {
        get => GetProperty<TerraformProperty<string>>("city");
        set => WithProperty("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContactType
    {
        get => GetProperty<TerraformProperty<string>>("contact_type");
        set => WithProperty("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ExtraParams
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("extra_params");
        set => WithProperty("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformProperty<string>? Fax
    {
        get => GetProperty<TerraformProperty<string>>("fax");
        set => WithProperty("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => WithProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => WithProperty("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationName
    {
        get => GetProperty<TerraformProperty<string>>("organization_name");
        set => WithProperty("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformProperty<string>? ZipCode
    {
        get => GetProperty<TerraformProperty<string>>("zip_code");
        set => WithProperty("zip_code", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
        this.WithOutput("abuse_contact_email");
        this.WithOutput("abuse_contact_phone");
        this.WithOutput("creation_date");
        this.WithOutput("expiration_date");
        this.WithOutput("registrar_name");
        this.WithOutput("registrar_url");
        this.WithOutput("reseller");
        this.WithOutput("status_list");
        this.WithOutput("updated_date");
        this.WithOutput("whois_server");
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? AdminPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("admin_privacy");
        set => this.WithProperty("admin_privacy", value);
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoRenew
    {
        get => GetProperty<TerraformProperty<bool>>("auto_renew");
        set => this.WithProperty("auto_renew", value);
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? BillingPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("billing_privacy");
        set => this.WithProperty("billing_privacy", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The registrant_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? RegistrantPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("registrant_privacy");
        set => this.WithProperty("registrant_privacy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public TerraformProperty<bool>? TechPrivacy
    {
        get => GetProperty<TerraformProperty<bool>>("tech_privacy");
        set => this.WithProperty("tech_privacy", value);
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public TerraformProperty<bool>? TransferLock
    {
        get => GetProperty<TerraformProperty<bool>>("transfer_lock");
        set => this.WithProperty("transfer_lock", value);
    }

    /// <summary>
    /// Block for admin_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainAdminContactBlock>? AdminContact
    {
        get => GetProperty<List<AwsRoute53domainsRegisteredDomainAdminContactBlock>>("admin_contact");
        set => this.WithProperty("admin_contact", value);
    }

    /// <summary>
    /// Block for billing_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainBillingContactBlock>? BillingContact
    {
        get => GetProperty<List<AwsRoute53domainsRegisteredDomainBillingContactBlock>>("billing_contact");
        set => this.WithProperty("billing_contact", value);
    }

    /// <summary>
    /// Block for name_server.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 NameServer block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainNameServerBlock>? NameServer
    {
        get => GetProperty<List<AwsRoute53domainsRegisteredDomainNameServerBlock>>("name_server");
        set => this.WithProperty("name_server", value);
    }

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrantContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainRegistrantContactBlock>? RegistrantContact
    {
        get => GetProperty<List<AwsRoute53domainsRegisteredDomainRegistrantContactBlock>>("registrant_contact");
        set => this.WithProperty("registrant_contact", value);
    }

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TechContact block(s) allowed")]
    public List<AwsRoute53domainsRegisteredDomainTechContactBlock>? TechContact
    {
        get => GetProperty<List<AwsRoute53domainsRegisteredDomainTechContactBlock>>("tech_contact");
        set => this.WithProperty("tech_contact", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53domainsRegisteredDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53domainsRegisteredDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
