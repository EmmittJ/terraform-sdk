using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceCertificateOrderDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_certificate_not_renewable_reasons attribute.
    /// </summary>
    [TerraformPropertyName("app_service_certificate_not_renewable_reasons")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AppServiceCertificateNotRenewableReasons => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "app_service_certificate_not_renewable_reasons");

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    [TerraformPropertyName("auto_renew")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoRenew => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_renew");

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    [TerraformPropertyName("certificates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Certificates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificates");

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformPropertyName("csr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Csr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "csr");

    /// <summary>
    /// The distinguished_name attribute.
    /// </summary>
    [TerraformPropertyName("distinguished_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DistinguishedName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "distinguished_name");

    /// <summary>
    /// The domain_verification_token attribute.
    /// </summary>
    [TerraformPropertyName("domain_verification_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainVerificationToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_verification_token");

    /// <summary>
    /// The expiration_time attribute.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_time");

    /// <summary>
    /// The intermediate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("intermediate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IntermediateThumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "intermediate_thumbprint");

    /// <summary>
    /// The is_private_key_external attribute.
    /// </summary>
    [TerraformPropertyName("is_private_key_external")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsPrivateKeyExternal => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_private_key_external");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> KeySize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "key_size");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The product_type attribute.
    /// </summary>
    [TerraformPropertyName("product_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProductType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_type");

    /// <summary>
    /// The root_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("root_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootThumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_thumbprint");

    /// <summary>
    /// The signed_certificate_thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("signed_certificate_thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SignedCertificateThumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signed_certificate_thumbprint");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The validity_in_years attribute.
    /// </summary>
    [TerraformPropertyName("validity_in_years")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ValidityInYears => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "validity_in_years");

}
