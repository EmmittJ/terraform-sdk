using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_account_primary_contact resource.
/// </summary>
public class AwsAccountPrimaryContact : TerraformResource
{
    public AwsAccountPrimaryContact(string name) : base("aws_account_primary_contact", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressLine1 is required")]
    [TerraformPropertyName("address_line_1")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_2")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AddressLine2 { get; set; }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_line_3")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AddressLine3 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "City is required")]
    [TerraformPropertyName("city")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> City { get; set; }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    [TerraformPropertyName("company_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompanyName { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    [TerraformPropertyName("country_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    [TerraformPropertyName("district_or_county")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DistrictOrCounty { get; set; }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullName is required")]
    [TerraformPropertyName("full_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FullName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformPropertyName("phone_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PhoneNumber { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalCode is required")]
    [TerraformPropertyName("postal_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PostalCode { get; set; }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    [TerraformPropertyName("state_or_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StateOrRegion { get; set; }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    [TerraformPropertyName("website_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebsiteUrl { get; set; }

}
