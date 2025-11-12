using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsRegisteredDomainAdminContactBlock() : TerraformBlock("admin_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformProperty("extra_params")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ExtraParams { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ZipCode { get; set; }

}

/// <summary>
/// Block type for billing_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsRegisteredDomainBillingContactBlock() : TerraformBlock("billing_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformProperty("extra_params")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ExtraParams { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ZipCode { get; set; }

}

/// <summary>
/// Block type for name_server in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsRegisteredDomainNameServerBlock() : TerraformBlock("name_server")
{
    /// <summary>
    /// The glue_ips attribute.
    /// </summary>
    [TerraformProperty("glue_ips")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? GlueIps { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for registrant_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsRegisteredDomainRegistrantContactBlock() : TerraformBlock("registrant_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformProperty("extra_params")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ExtraParams { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ZipCode { get; set; }

}

/// <summary>
/// Block type for tech_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53domainsRegisteredDomainTechContactBlock() : TerraformBlock("tech_contact")
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AddressLine2 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> City { get; set; }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformProperty("contact_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContactType { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformProperty("extra_params")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ExtraParams { get; set; }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformProperty("fax")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Fax { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LastName { get; set; }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformProperty("organization_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PhoneNumber { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformProperty("zip_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ZipCode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53domainsRegisteredDomainTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53domains_registered_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRoute53domainsRegisteredDomain : TerraformResource
{
    public AwsRoute53domainsRegisteredDomain(string name) : base("aws_route53domains_registered_domain", name)
    {
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    [TerraformProperty("admin_privacy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdminPrivacy { get; set; }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoRenew { get; set; }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    [TerraformProperty("billing_privacy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BillingPrivacy { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    [TerraformProperty("registrant_privacy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RegistrantPrivacy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    [TerraformProperty("tech_privacy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TechPrivacy { get; set; }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    [TerraformProperty("transfer_lock")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TransferLock { get; set; }

    /// <summary>
    /// Block for admin_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminContact block(s) allowed")]
    [TerraformProperty("admin_contact")]
    public TerraformList<AwsRoute53domainsRegisteredDomainAdminContactBlock> AdminContact { get; set; } = new();

    /// <summary>
    /// Block for billing_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingContact block(s) allowed")]
    [TerraformProperty("billing_contact")]
    public TerraformList<AwsRoute53domainsRegisteredDomainBillingContactBlock> BillingContact { get; set; } = new();

    /// <summary>
    /// Block for name_server.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 NameServer block(s) allowed")]
    [TerraformProperty("name_server")]
    public TerraformList<AwsRoute53domainsRegisteredDomainNameServerBlock> NameServer { get; set; } = new();

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrantContact block(s) allowed")]
    [TerraformProperty("registrant_contact")]
    public TerraformList<AwsRoute53domainsRegisteredDomainRegistrantContactBlock> RegistrantContact { get; set; } = new();

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TechContact block(s) allowed")]
    [TerraformProperty("tech_contact")]
    public TerraformList<AwsRoute53domainsRegisteredDomainTechContactBlock> TechContact { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRoute53domainsRegisteredDomainTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The reseller attribute.
    /// </summary>
    [TerraformProperty("reseller")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Reseller { get; }

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    [TerraformProperty("status_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> StatusList { get; }

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
