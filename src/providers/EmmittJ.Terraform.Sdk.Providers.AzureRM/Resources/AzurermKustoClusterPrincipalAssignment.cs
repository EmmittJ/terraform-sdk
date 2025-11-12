using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoClusterPrincipalAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_kusto_cluster_principal_assignment resource.
/// </summary>
public partial class AzurermKustoClusterPrincipalAssignment : TerraformResource
{
    public AzurermKustoClusterPrincipalAssignment(string name) : base("azurerm_kusto_cluster_principal_assignment", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

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
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformProperty("principal_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKustoClusterPrincipalAssignmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The principal_name attribute.
    /// </summary>
    [TerraformProperty("principal_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrincipalName { get; }

    /// <summary>
    /// The tenant_name attribute.
    /// </summary>
    [TerraformProperty("tenant_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantName { get; }

}
