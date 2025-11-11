using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public partial class AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock : TerraformBlockBase
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    [TerraformProperty("admin_group_object_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    [TerraformProperty("azure_rbac_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzureRbacEnabled { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermArcKubernetesProvisionedClusterIdentityBlock : TerraformBlockBase
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
public partial class AzurermArcKubernetesProvisionedClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_arc_kubernetes_provisioned_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermArcKubernetesProvisionedCluster : TerraformResource
{
    public AzurermArcKubernetesProvisionedCluster(string name) : base("azurerm_arc_kubernetes_provisioned_cluster", name)
    {
    }

    /// <summary>
    /// The arc_agent_auto_upgrade_enabled attribute.
    /// </summary>
    [TerraformProperty("arc_agent_auto_upgrade_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ArcAgentAutoUpgradeEnabled { get; set; }

    /// <summary>
    /// The arc_agent_desired_version attribute.
    /// </summary>
    [TerraformProperty("arc_agent_desired_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ArcAgentDesiredVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    [TerraformProperty("azure_active_directory")]
    public partial TerraformList<TerraformBlock<AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock>>? AzureActiveDirectory { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermArcKubernetesProvisionedClusterIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermArcKubernetesProvisionedClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformProperty("agent_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentVersion { get; }

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    [TerraformProperty("distribution")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Distribution { get; }

    /// <summary>
    /// The infrastructure attribute.
    /// </summary>
    [TerraformProperty("infrastructure")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Infrastructure { get; }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformProperty("kubernetes_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KubernetesVersion { get; }

    /// <summary>
    /// The offering attribute.
    /// </summary>
    [TerraformProperty("offering")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Offering { get; }

    /// <summary>
    /// The total_core_count attribute.
    /// </summary>
    [TerraformProperty("total_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalCoreCount { get; }

    /// <summary>
    /// The total_node_count attribute.
    /// </summary>
    [TerraformProperty("total_node_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalNodeCount { get; }

}
