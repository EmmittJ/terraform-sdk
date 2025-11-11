using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_account_primary_contact.
/// </summary>
public class AwsAccountPrimaryContactDataSource : TerraformDataSource
{
    public AwsAccountPrimaryContactDataSource(string name) : base("aws_account_primary_contact", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AddressLine1 => new TerraformReference(this, "address_line_1");

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AddressLine2 => new TerraformReference(this, "address_line_2");

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_3")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AddressLine3 => new TerraformReference(this, "address_line_3");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> City => new TerraformReference(this, "city");

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CompanyName => new TerraformReference(this, "company_name");

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CountryCode => new TerraformReference(this, "country_code");

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    [TerraformPropertyName("district_or_county")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DistrictOrCounty => new TerraformReference(this, "district_or_county");

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [TerraformPropertyName("full_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FullName => new TerraformReference(this, "full_name");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PhoneNumber => new TerraformReference(this, "phone_number");

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PostalCode => new TerraformReference(this, "postal_code");

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    [TerraformPropertyName("state_or_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateOrRegion => new TerraformReference(this, "state_or_region");

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    [TerraformPropertyName("website_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebsiteUrl => new TerraformReference(this, "website_url");

}
