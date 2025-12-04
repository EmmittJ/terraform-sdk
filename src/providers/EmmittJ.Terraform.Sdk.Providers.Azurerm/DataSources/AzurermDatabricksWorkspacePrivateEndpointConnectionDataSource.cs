using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_databricks_workspace_private_endpoint_connection Terraform data source.
/// Retrieves information about a azurerm_databricks_workspace_private_endpoint_connection.
/// </summary>
public partial class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource(string name) : TerraformDataSource("azurerm_databricks_workspace_private_endpoint_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateEndpointId is required")]
    public required TerraformValue<string> PrivateEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_endpoint_id");
        set => SetArgument("private_endpoint_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Connections
        => AsReference("connections");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
