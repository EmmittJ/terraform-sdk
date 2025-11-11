using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseRoleAssignmentTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_synapse_role_assignment resource.
/// </summary>
public partial class AzurermSynapseRoleAssignment : TerraformResource
{
    public AzurermSynapseRoleAssignment(string name) : base("azurerm_synapse_role_assignment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [TerraformProperty("principal_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrincipalType { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformProperty("role_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleName { get; set; }

    /// <summary>
    /// The synapse_spark_pool_id attribute.
    /// </summary>
    [TerraformProperty("synapse_spark_pool_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SynapseSparkPoolId { get; set; }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [TerraformProperty("synapse_workspace_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SynapseWorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSynapseRoleAssignmentTimeoutsBlock>? Timeouts { get; set; }

}
