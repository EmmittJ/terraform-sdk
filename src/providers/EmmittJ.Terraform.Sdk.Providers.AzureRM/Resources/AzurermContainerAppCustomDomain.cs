using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppCustomDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_custom_domain resource.
/// </summary>
public partial class AzurermContainerAppCustomDomain : TerraformResource
{
    public AzurermContainerAppCustomDomain(string name) : base("azurerm_container_app_custom_domain", name)
    {
    }

    /// <summary>
    /// The Binding type. Possible values include `Disabled` and `SniEnabled`.
    /// </summary>
    [TerraformProperty("certificate_binding_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateBindingType { get; set; }

    /// <summary>
    /// The container_app_environment_certificate_id attribute.
    /// </summary>
    [TerraformProperty("container_app_environment_certificate_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerAppEnvironmentCertificateId { get; set; }

    /// <summary>
    /// The container_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppId is required")]
    [TerraformProperty("container_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerAppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The hostname of the Certificate. Must be the CN or a named SAN in the certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermContainerAppCustomDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The container_app_environment_managed_certificate_id attribute.
    /// </summary>
    [TerraformProperty("container_app_environment_managed_certificate_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContainerAppEnvironmentManagedCertificateId { get; }

}
