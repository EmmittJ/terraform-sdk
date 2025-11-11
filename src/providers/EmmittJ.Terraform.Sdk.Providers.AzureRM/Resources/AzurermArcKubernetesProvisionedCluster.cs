using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock
{
    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    [TerraformPropertyName("admin_group_object_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_rbac_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AzureRbacEnabled { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesProvisionedClusterIdentityBlock
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcKubernetesProvisionedClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_arc_kubernetes_provisioned_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermArcKubernetesProvisionedCluster : TerraformResource
{
    public AzurermArcKubernetesProvisionedCluster(string name) : base("azurerm_arc_kubernetes_provisioned_cluster", name)
    {
    }

    /// <summary>
    /// The arc_agent_auto_upgrade_enabled attribute.
    /// </summary>
    [TerraformPropertyName("arc_agent_auto_upgrade_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ArcAgentAutoUpgradeEnabled { get; set; }

    /// <summary>
    /// The arc_agent_desired_version attribute.
    /// </summary>
    [TerraformPropertyName("arc_agent_desired_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ArcAgentDesiredVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for azure_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    [TerraformPropertyName("azure_active_directory")]
    public TerraformList<TerraformBlock<AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock>>? AzureActiveDirectory { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermArcKubernetesProvisionedClusterIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermArcKubernetesProvisionedClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentVersion => new TerraformReference(this, "agent_version");

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    [TerraformPropertyName("distribution")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Distribution => new TerraformReference(this, "distribution");

    /// <summary>
    /// The infrastructure attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Infrastructure => new TerraformReference(this, "infrastructure");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KubernetesVersion => new TerraformReference(this, "kubernetes_version");

    /// <summary>
    /// The offering attribute.
    /// </summary>
    [TerraformPropertyName("offering")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Offering => new TerraformReference(this, "offering");

    /// <summary>
    /// The total_core_count attribute.
    /// </summary>
    [TerraformPropertyName("total_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalCoreCount => new TerraformReference(this, "total_core_count");

    /// <summary>
    /// The total_node_count attribute.
    /// </summary>
    [TerraformPropertyName("total_node_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalNodeCount => new TerraformReference(this, "total_node_count");

}
