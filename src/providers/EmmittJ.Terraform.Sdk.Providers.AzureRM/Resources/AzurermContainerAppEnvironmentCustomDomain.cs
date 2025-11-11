using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppEnvironmentCustomDomainTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_app_environment_custom_domain resource.
/// </summary>
public partial class AzurermContainerAppEnvironmentCustomDomain : TerraformResource
{
    public AzurermContainerAppEnvironmentCustomDomain(string name) : base("azurerm_container_app_environment_custom_domain", name)
    {
    }

    /// <summary>
    /// The Custom Domain Certificate Private Key as a base64 encoded PFX or PEM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBlobBase64 is required")]
    [TerraformProperty("certificate_blob_base64")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateBlobBase64 { get; set; }

    /// <summary>
    /// The Custom Domain Certificate password.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificatePassword is required")]
    [TerraformProperty("certificate_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificatePassword { get; set; }

    /// <summary>
    /// The Container App Managed Environment ID to configure this Custom Domain on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    [TerraformProperty("container_app_environment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerAppEnvironmentId { get; set; }

    /// <summary>
    /// The Custom Domain DNS suffix for this Container App Environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsSuffix is required")]
    [TerraformProperty("dns_suffix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DnsSuffix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermContainerAppEnvironmentCustomDomainTimeoutsBlock>? Timeouts { get; set; }

}
