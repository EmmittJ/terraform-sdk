using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningInferenceClusterIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for ssl in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningInferenceClusterSslBlock() : TerraformBlock("ssl")
{
    /// <summary>
    /// The cert attribute.
    /// </summary>
    [TerraformProperty("cert")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cert { get; set; }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformProperty("cname")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cname { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The leaf_domain_label attribute.
    /// </summary>
    [TerraformProperty("leaf_domain_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LeafDomainLabel { get; set; }

    /// <summary>
    /// The overwrite_existing_domain attribute.
    /// </summary>
    [TerraformProperty("overwrite_existing_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OverwriteExistingDomain { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMachineLearningInferenceClusterTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_machine_learning_inference_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMachineLearningInferenceCluster : TerraformResource
{
    public AzurermMachineLearningInferenceCluster(string name) : base("azurerm_machine_learning_inference_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_purpose attribute.
    /// </summary>
    [TerraformProperty("cluster_purpose")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterPurpose { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformProperty("kubernetes_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesClusterId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    [TerraformProperty("machine_learning_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MachineLearningWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermMachineLearningInferenceClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ssl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    [TerraformProperty("ssl")]
    public TerraformList<AzurermMachineLearningInferenceClusterSslBlock> Ssl { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMachineLearningInferenceClusterTimeoutsBlock Timeouts { get; set; } = new();

}
