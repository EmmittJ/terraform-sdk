using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_certificate_order.
/// </summary>
public class AzurermAppServiceCertificateOrderDataSource : TerraformDataSource
{
    public AzurermAppServiceCertificateOrderDataSource(string name) : base("azurerm_app_service_certificate_order", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    [TerraformPropertyName("app_service_certificate_not_renewable_reasons")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AppServiceCertificateNotRenewableReasons => new TerraformReference(this, "app_service_certificate_not_renewable_reasons");

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformPropertyName("auto_renew")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoRenew => new TerraformReference(this, "auto_renew");

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformPropertyName("certificates")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Certificates => new TerraformReference(this, "certificates");

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformPropertyName("csr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Csr => new TerraformReference(this, "csr");

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    [TerraformPropertyName("distinguished_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DistinguishedName => new TerraformReference(this, "distinguished_name");

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    [TerraformPropertyName("domain_verification_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainVerificationToken => new TerraformReference(this, "domain_verification_token");

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationTime => new TerraformReference(this, "expiration_time");

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("intermediate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IntermediateThumbprint => new TerraformReference(this, "intermediate_thumbprint");

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    [TerraformPropertyName("is_private_key_external")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsPrivateKeyExternal => new TerraformReference(this, "is_private_key_external");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> KeySize => new TerraformReference(this, "key_size");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    [TerraformPropertyName("product_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProductType => new TerraformReference(this, "product_type");

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("root_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootThumbprint => new TerraformReference(this, "root_thumbprint");

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("signed_certificate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SignedCertificateThumbprint => new TerraformReference(this, "signed_certificate_thumbprint");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    [TerraformPropertyName("validity_in_years")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ValidityInYears => new TerraformReference(this, "validity_in_years");

}
