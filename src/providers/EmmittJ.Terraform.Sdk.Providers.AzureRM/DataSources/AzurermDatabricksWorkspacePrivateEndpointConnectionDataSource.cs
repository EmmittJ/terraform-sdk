using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_databricks_workspace_private_endpoint_connection.
/// </summary>
public partial class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource : TerraformDataSource
{
    public AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource(string name) : base("azurerm_databricks_workspace_private_endpoint_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateEndpointId is required")]
    [TerraformProperty("private_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateEndpointId { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    [TerraformProperty("connections")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Connections { get; }

}
