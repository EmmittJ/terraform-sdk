using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_certificate_order.
/// </summary>
public partial class AzurermAppServiceCertificateOrderDataSource : TerraformDataSource
{
    public AzurermAppServiceCertificateOrderDataSource(string name) : base("azurerm_app_service_certificate_order", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    [TerraformProperty("app_service_certificate_not_renewable_reasons")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AppServiceCertificateNotRenewableReasons { get; }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoRenew { get; }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformProperty("certificates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Certificates { get; }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformProperty("csr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Csr { get; }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    [TerraformProperty("distinguished_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DistinguishedName { get; }

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    [TerraformProperty("domain_verification_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainVerificationToken { get; }

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationTime { get; }

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    [TerraformProperty("intermediate_thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IntermediateThumbprint { get; }

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    [TerraformProperty("is_private_key_external")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsPrivateKeyExternal { get; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformProperty("key_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> KeySize { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    [TerraformProperty("product_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProductType { get; }

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    [TerraformProperty("root_thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootThumbprint { get; }

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    [TerraformProperty("signed_certificate_thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SignedCertificateThumbprint { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    [TerraformProperty("validity_in_years")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ValidityInYears { get; }

}
