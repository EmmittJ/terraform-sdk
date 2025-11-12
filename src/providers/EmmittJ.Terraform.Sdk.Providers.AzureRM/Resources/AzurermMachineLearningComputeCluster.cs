using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningComputeClusterIdentityBlock() : TerraformBlock("identity")
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
/// Block type for scale_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningComputeClusterScaleSettingsBlock() : TerraformBlock("scale_settings")
{
    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformProperty("max_node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxNodeCount { get; set; }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformProperty("min_node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinNodeCount { get; set; }

    /// <summary>
    /// The scale_down_nodes_after_idle_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleDownNodesAfterIdleDuration is required")]
    [TerraformProperty("scale_down_nodes_after_idle_duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScaleDownNodesAfterIdleDuration { get; set; }

}

/// <summary>
/// Block type for ssh in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningComputeClusterSshBlock() : TerraformBlock("ssh")
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformProperty("admin_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The key_value attribute.
    /// </summary>
    [TerraformProperty("key_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyValue { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMachineLearningComputeClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_machine_learning_compute_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMachineLearningComputeCluster : TerraformResource
{
    public AzurermMachineLearningComputeCluster(string name) : base("azurerm_machine_learning_compute_cluster", name)
    {
    }

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
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthEnabled { get; set; }

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
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NodePublicIpEnabled { get; set; }

    /// <summary>
    /// The ssh_public_access_enabled attribute.
    /// </summary>
    [TerraformProperty("ssh_public_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SshPublicAccessEnabled { get; set; }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    [TerraformProperty("subnet_resource_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetResourceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The vm_priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmPriority is required")]
    [TerraformProperty("vm_priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmPriority { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformProperty("vm_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmSize { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermMachineLearningComputeClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for scale_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleSettings block(s) allowed")]
    [TerraformProperty("scale_settings")]
    public required TerraformList<AzurermMachineLearningComputeClusterScaleSettingsBlock> ScaleSettings { get; set; } = new();

    /// <summary>
    /// Block for ssh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssh block(s) allowed")]
    [TerraformProperty("ssh")]
    public TerraformList<AzurermMachineLearningComputeClusterSshBlock> Ssh { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMachineLearningComputeClusterTimeoutsBlock Timeouts { get; set; } = new();

}
