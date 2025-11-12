using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsDomainAdminContactBlock() : TerraformBlock("admin_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ZipCode { get; set; }

}

/// <summary>
/// Block type for registrant_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsDomainRegistrantContactBlock() : TerraformBlock("registrant_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ZipCode { get; set; }

}

/// <summary>
/// Block type for tech_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsDomainTechContactBlock() : TerraformBlock("tech_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ZipCode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53domainsDomainTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53domains_domain resource.
/// </summary>
public partial class AwsRoute53domainsDomain : TerraformResource
{
    public AwsRoute53domainsDomain(string name) : base("aws_route53domains_domain", name)
    {
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    [TerraformProperty("admin_privacy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AdminPrivacy { get; set; }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AutoRenew { get; set; }

    /// <summary>
    /// The billing_contact attribute.
    /// </summary>
    [TerraformProperty("billing_contact")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> BillingContact { get; set; }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    [TerraformProperty("billing_privacy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> BillingPrivacy { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The duration_in_years attribute.
    /// </summary>
    [TerraformProperty("duration_in_years")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DurationInYears { get; set; }

    /// <summary>
    /// The name_server attribute.
    /// </summary>
    [TerraformProperty("name_server")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> NameServer { get; set; }

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    [TerraformProperty("registrant_privacy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> RegistrantPrivacy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    [TerraformProperty("tech_privacy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TechPrivacy { get; set; }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    [TerraformProperty("transfer_lock")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TransferLock { get; set; }

    /// <summary>
    /// Block for admin_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("admin_contact")]
    public TerraformList<AwsRoute53domainsDomainAdminContactBlock> AdminContact { get; set; } = new();

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("registrant_contact")]
    public TerraformList<AwsRoute53domainsDomainRegistrantContactBlock> RegistrantContact { get; set; } = new();

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tech_contact")]
    public TerraformList<AwsRoute53domainsDomainTechContactBlock> TechContact { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRoute53domainsDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The abuse_contact_email attribute.
    /// </summary>
    [TerraformProperty("abuse_contact_email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AbuseContactEmail { get; }

    /// <summary>
    /// The abuse_contact_phone attribute.
    /// </summary>
    [TerraformProperty("abuse_contact_phone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AbuseContactPhone { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    [TerraformProperty("registrar_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistrarName { get; }

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    [TerraformProperty("registrar_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistrarUrl { get; }

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    [TerraformProperty("status_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> StatusList { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    [TerraformProperty("updated_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedDate { get; }

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    [TerraformProperty("whois_server")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WhoisServer { get; }

}
