using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateBindingTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_app_service_certificate_binding resource.
/// </summary>
public class AzurermAppServiceCertificateBinding : TerraformResource
{
    public AzurermAppServiceCertificateBinding(string name) : base("azurerm_app_service_certificate_binding", name)
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    [TerraformPropertyName("certificate_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CertificateId { get; set; }

    /// <summary>
    /// The hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnameBindingId is required")]
    [TerraformPropertyName("hostname_binding_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostnameBindingId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslState is required")]
    [TerraformPropertyName("ssl_state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SslState { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceCertificateBindingTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [TerraformPropertyName("app_service_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppServiceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_service_name");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

}
