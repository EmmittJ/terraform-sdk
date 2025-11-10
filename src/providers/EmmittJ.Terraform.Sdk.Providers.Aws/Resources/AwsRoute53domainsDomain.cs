using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainAdminContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Email { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ZipCode { get; set; }

}

/// <summary>
/// Block type for registrant_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainRegistrantContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Email { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ZipCode { get; set; }

}

/// <summary>
/// Block type for tech_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainTechContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Email { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ZipCode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsDomainTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53domains_domain resource.
/// </summary>
public class AwsRoute53domainsDomain : TerraformResource
{
    public AwsRoute53domainsDomain(string name) : base("aws_route53domains_domain", name)
    {
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    [TerraformPropertyName("admin_privacy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AdminPrivacy { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "admin_privacy");

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformPropertyName("auto_renew")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutoRenew { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_renew");

    /// <summary>
    /// The billing_contact attribute.
    /// </summary>
    [TerraformPropertyName("billing_contact")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> BillingContact { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "billing_contact");

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    [TerraformPropertyName("billing_privacy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> BillingPrivacy { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "billing_privacy");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The duration_in_years attribute.
    /// </summary>
    [TerraformPropertyName("duration_in_years")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DurationInYears { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "duration_in_years");

    /// <summary>
    /// The name_server attribute.
    /// </summary>
    [TerraformPropertyName("name_server")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> NameServer { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "name_server");

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    [TerraformPropertyName("registrant_privacy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RegistrantPrivacy { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "registrant_privacy");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    [TerraformPropertyName("tech_privacy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TechPrivacy { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "tech_privacy");

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    [TerraformPropertyName("transfer_lock")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TransferLock { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "transfer_lock");

    /// <summary>
    /// Block for admin_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("admin_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsDomainAdminContactBlock>>? AdminContact { get; set; } = new();

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("registrant_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsDomainRegistrantContactBlock>>? RegistrantContact { get; set; } = new();

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("tech_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsDomainTechContactBlock>>? TechContact { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRoute53domainsDomainTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The abuse_contact_email attribute.
    /// </summary>
    [TerraformPropertyName("abuse_contact_email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AbuseContactEmail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "abuse_contact_email");

    /// <summary>
    /// The abuse_contact_phone attribute.
    /// </summary>
    [TerraformPropertyName("abuse_contact_phone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AbuseContactPhone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "abuse_contact_phone");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    [TerraformPropertyName("registrar_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistrarName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registrar_name");

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    [TerraformPropertyName("registrar_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistrarUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registrar_url");

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    [TerraformPropertyName("status_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> StatusList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "status_list");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    [TerraformPropertyName("updated_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_date");

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    [TerraformPropertyName("whois_server")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WhoisServer => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "whois_server");

}
