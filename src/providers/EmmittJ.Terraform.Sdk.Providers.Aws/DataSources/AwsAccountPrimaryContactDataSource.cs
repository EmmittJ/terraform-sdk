using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_account_primary_contact.
/// </summary>
public partial class AwsAccountPrimaryContactDataSource : TerraformDataSource
{
    public AwsAccountPrimaryContactDataSource(string name) : base("aws_account_primary_contact", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformProperty("address_line_1")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AddressLine1 { get; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AddressLine2 { get; }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    [TerraformProperty("address_line_3")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AddressLine3 { get; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformProperty("city")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> City { get; }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    [TerraformProperty("company_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CompanyName { get; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformProperty("country_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CountryCode { get; }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    [TerraformProperty("district_or_county")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DistrictOrCounty { get; }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [TerraformProperty("full_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FullName { get; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PhoneNumber { get; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformProperty("postal_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PostalCode { get; }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    [TerraformProperty("state_or_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StateOrRegion { get; }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    [TerraformProperty("website_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebsiteUrl { get; }

}
