using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermArcKubernetesClusterExtensionIdentityBlock() : TerraformBlock("identity")
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermArcKubernetesClusterExtensionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_arc_kubernetes_cluster_extension resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermArcKubernetesClusterExtension : TerraformResource
{
    public AzurermArcKubernetesClusterExtension(string name) : base("azurerm_arc_kubernetes_cluster_extension", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    [TerraformProperty("configuration_protected_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ConfigurationProtectedSettings { get; set; }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    [TerraformProperty("configuration_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ConfigurationSettings { get; set; }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionType is required")]
    [TerraformProperty("extension_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExtensionType { get; set; }

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
    /// The release_namespace attribute.
    /// </summary>
    [TerraformProperty("release_namespace")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReleaseNamespace { get; set; }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    [TerraformProperty("release_train")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReleaseTrain { get; set; }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    [TerraformProperty("target_namespace")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TargetNamespace { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public required TerraformList<AzurermArcKubernetesClusterExtensionIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermArcKubernetesClusterExtensionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformProperty("current_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CurrentVersion { get; }

}
