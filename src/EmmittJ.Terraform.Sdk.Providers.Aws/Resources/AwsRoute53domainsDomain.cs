using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainAdminContactBlock : TerraformBlock
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
/// Block type for registrant_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainRegistrantContactBlock : TerraformBlock
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
public class AwsRoute53domainsDomainTechContactBlock : TerraformBlock
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
public class AwsRoute53domainsDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_route53domains_domain resource.
/// </summary>
public class AwsRoute53domainsDomain : TerraformResource
{
    public AwsRoute53domainsDomain(string name) : base("aws_route53domains_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("abuse_contact_email");
        this.DeclareOutput("abuse_contact_phone");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("registrar_name");
        this.DeclareOutput("registrar_url");
        this.DeclareOutput("status_list");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("updated_date");
        this.DeclareOutput("whois_server");
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
    /// The billing_contact attribute.
    /// </summary>
    public List<TerraformProperty<object>>? BillingContact
    {
        get => GetProperty<List<TerraformProperty<object>>>("billing_contact");
        set => this.WithProperty("billing_contact", value);
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
    /// The duration_in_years attribute.
    /// </summary>
    public TerraformProperty<double>? DurationInYears
    {
        get => GetProperty<TerraformProperty<double>>("duration_in_years");
        set => this.WithProperty("duration_in_years", value);
    }

    /// <summary>
    /// The name_server attribute.
    /// </summary>
    public List<TerraformProperty<object>>? NameServer
    {
        get => GetProperty<List<TerraformProperty<object>>>("name_server");
        set => this.WithProperty("name_server", value);
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
    public List<AwsRoute53domainsDomainAdminContactBlock>? AdminContact
    {
        get => GetProperty<List<AwsRoute53domainsDomainAdminContactBlock>>("admin_contact");
        set => this.WithProperty("admin_contact", value);
    }

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRoute53domainsDomainRegistrantContactBlock>? RegistrantContact
    {
        get => GetProperty<List<AwsRoute53domainsDomainRegistrantContactBlock>>("registrant_contact");
        set => this.WithProperty("registrant_contact", value);
    }

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRoute53domainsDomainTechContactBlock>? TechContact
    {
        get => GetProperty<List<AwsRoute53domainsDomainTechContactBlock>>("tech_contact");
        set => this.WithProperty("tech_contact", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53domainsDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53domainsDomainTimeoutsBlock>("timeouts");
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
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    public TerraformExpression RegistrarName => this["registrar_name"];

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    public TerraformExpression RegistrarUrl => this["registrar_url"];

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    public TerraformExpression StatusList => this["status_list"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    public TerraformExpression UpdatedDate => this["updated_date"];

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    public TerraformExpression WhoisServer => this["whois_server"];

}
