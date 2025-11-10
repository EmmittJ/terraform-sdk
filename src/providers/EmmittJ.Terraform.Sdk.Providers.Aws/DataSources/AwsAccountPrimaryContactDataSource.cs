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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_1")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressLine1 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_line_1");

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressLine2 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_line_2");

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_3")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressLine3 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_line_3");

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> City => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "city");

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompanyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "company_name");

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CountryCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "country_code");

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    [TerraformPropertyName("district_or_county")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DistrictOrCounty => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "district_or_county");

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [TerraformPropertyName("full_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FullName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "full_name");

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PhoneNumber => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "phone_number");

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PostalCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "postal_code");

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    [TerraformPropertyName("state_or_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateOrRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_or_region");

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    [TerraformPropertyName("website_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebsiteUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_url");

}
