using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainAdminContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine1 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_1");

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine2 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_2");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> City { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "city");

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContactType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "contact_type");

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CountryCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "country_code");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Email { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "email");

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformPropertyName("extra_params")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ExtraParams { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "extra_params");

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Fax { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "fax");

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FirstName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "first_name");

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LastName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "last_name");

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "organization_name");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PhoneNumber { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "phone_number");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZipCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "zip_code");

}

/// <summary>
/// Block type for billing_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainBillingContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine1 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_1");

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine2 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_2");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> City { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "city");

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContactType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "contact_type");

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CountryCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "country_code");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Email { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "email");

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformPropertyName("extra_params")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ExtraParams { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "extra_params");

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Fax { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "fax");

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FirstName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "first_name");

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LastName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "last_name");

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "organization_name");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PhoneNumber { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "phone_number");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZipCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "zip_code");

}

/// <summary>
/// Block type for name_server in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainNameServerBlock : ITerraformBlock
{
    /// <summary>
    /// The glue_ips attribute.
    /// </summary>
    [TerraformPropertyName("glue_ips")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? GlueIps { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for registrant_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainRegistrantContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine1 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_1");

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine2 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_2");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> City { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "city");

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContactType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "contact_type");

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CountryCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "country_code");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Email { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "email");

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformPropertyName("extra_params")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ExtraParams { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "extra_params");

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Fax { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "fax");

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FirstName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "first_name");

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LastName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "last_name");

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "organization_name");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PhoneNumber { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "phone_number");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZipCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "zip_code");

}

/// <summary>
/// Block type for tech_contact in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainTechContactBlock : ITerraformBlock
{
    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine1 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_1");

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddressLine2 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "address_line_2");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> City { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "city");

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    [TerraformPropertyName("contact_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContactType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "contact_type");

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CountryCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "country_code");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Email { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "email");

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    [TerraformPropertyName("extra_params")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ExtraParams { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "extra_params");

    /// <summary>
    /// The fax attribute.
    /// </summary>
    [TerraformPropertyName("fax")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Fax { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "fax");

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FirstName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "first_name");

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LastName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "last_name");

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    [TerraformPropertyName("organization_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "organization_name");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PhoneNumber { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "phone_number");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    [TerraformPropertyName("zip_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZipCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "zip_code");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsRegisteredDomainTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53domains_registered_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53domainsRegisteredDomain : TerraformResource
{
    public AwsRoute53domainsRegisteredDomain(string name) : base("aws_route53domains_registered_domain", name)
    {
    }

    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    [TerraformPropertyName("admin_privacy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdminPrivacy { get; set; }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformPropertyName("auto_renew")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoRenew { get; set; }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    [TerraformPropertyName("billing_privacy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BillingPrivacy { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    [TerraformPropertyName("registrant_privacy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RegistrantPrivacy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    [TerraformPropertyName("tech_privacy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TechPrivacy { get; set; }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    [TerraformPropertyName("transfer_lock")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TransferLock { get; set; }

    /// <summary>
    /// Block for admin_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminContact block(s) allowed")]
    [TerraformPropertyName("admin_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsRegisteredDomainAdminContactBlock>>? AdminContact { get; set; } = new();

    /// <summary>
    /// Block for billing_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingContact block(s) allowed")]
    [TerraformPropertyName("billing_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsRegisteredDomainBillingContactBlock>>? BillingContact { get; set; } = new();

    /// <summary>
    /// Block for name_server.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 NameServer block(s) allowed")]
    [TerraformPropertyName("name_server")]
    public TerraformList<TerraformBlock<AwsRoute53domainsRegisteredDomainNameServerBlock>>? NameServer { get; set; } = new();

    /// <summary>
    /// Block for registrant_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrantContact block(s) allowed")]
    [TerraformPropertyName("registrant_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsRegisteredDomainRegistrantContactBlock>>? RegistrantContact { get; set; } = new();

    /// <summary>
    /// Block for tech_contact.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TechContact block(s) allowed")]
    [TerraformPropertyName("tech_contact")]
    public TerraformList<TerraformBlock<AwsRoute53domainsRegisteredDomainTechContactBlock>>? TechContact { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRoute53domainsRegisteredDomainTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The reseller attribute.
    /// </summary>
    [TerraformPropertyName("reseller")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Reseller => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reseller");

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    [TerraformPropertyName("status_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> StatusList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "status_list");

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
