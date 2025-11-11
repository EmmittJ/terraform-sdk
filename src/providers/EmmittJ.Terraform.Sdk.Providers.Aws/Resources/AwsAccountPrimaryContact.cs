using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_account_primary_contact resource.
/// </summary>
public partial class AwsAccountPrimaryContact : TerraformResource
{
    public AwsAccountPrimaryContact(string name) : base("aws_account_primary_contact", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressLine1 is required")]
    [TerraformProperty("address_line_1")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AddressLine1 { get; set; }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    [TerraformProperty("address_line_2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine2 { get; set; }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    [TerraformProperty("address_line_3")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressLine3 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "City is required")]
    [TerraformProperty("city")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> City { get; set; }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    [TerraformProperty("company_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CompanyName { get; set; }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    [TerraformProperty("country_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    [TerraformProperty("district_or_county")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DistrictOrCounty { get; set; }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullName is required")]
    [TerraformProperty("full_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FullName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformProperty("phone_number")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PhoneNumber { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalCode is required")]
    [TerraformProperty("postal_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PostalCode { get; set; }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    [TerraformProperty("state_or_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StateOrRegion { get; set; }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    [TerraformProperty("website_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebsiteUrl { get; set; }

}
