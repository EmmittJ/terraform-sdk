using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppCustomDomainTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_container_app_custom_domain resource.
/// </summary>
public class AzurermContainerAppCustomDomain : TerraformResource
{
    public AzurermContainerAppCustomDomain(string name) : base("azurerm_container_app_custom_domain", name)
    {
    }

    /// <summary>
    /// The Binding type. Possible values include `Disabled` and `SniEnabled`.
    /// </summary>
    [TerraformPropertyName("certificate_binding_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateBindingType { get; set; }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("container_app_environment_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerAppEnvironmentCertificateId { get; set; }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppId is required")]
    [TerraformPropertyName("container_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerAppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppCustomDomainTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("container_app_environment_managed_certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerAppEnvironmentManagedCertificateId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_app_environment_managed_certificate_id");

}
