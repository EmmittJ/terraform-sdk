using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_databricks_workspace_private_endpoint_connection.
/// </summary>
public class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource : TerraformDataSource
{
    public AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource(string name) : base("azurerm_databricks_workspace_private_endpoint_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateEndpointId is required")]
    [TerraformPropertyName("private_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateEndpointId { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The connections attribute.
    /// </summary>
    [TerraformPropertyName("connections")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Connections => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connections");

}
