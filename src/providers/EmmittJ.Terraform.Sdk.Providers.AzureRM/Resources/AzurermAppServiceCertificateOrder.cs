using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceCertificateOrderTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_app_service_certificate_order resource.
/// </summary>
public partial class AzurermAppServiceCertificateOrder : TerraformResource
{
    public AzurermAppServiceCertificateOrder(string name) : base("azurerm_app_service_certificate_order", name)
    {
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoRenew { get; set; }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformProperty("csr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Csr { get; set; }

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    [TerraformProperty("distinguished_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DistinguishedName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformProperty("key_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? KeySize { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    [TerraformProperty("product_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProductType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    [TerraformProperty("validity_in_years")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ValidityInYears { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppServiceCertificateOrderTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    [TerraformProperty("app_service_certificate_not_renewable_reasons")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AppServiceCertificateNotRenewableReasons { get; }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformProperty("certificates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Certificates { get; }

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

}
