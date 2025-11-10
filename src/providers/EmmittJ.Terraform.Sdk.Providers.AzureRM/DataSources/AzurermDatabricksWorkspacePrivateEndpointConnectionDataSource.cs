using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_databricks_workspace_private_endpoint_connection.
/// </summary>
public class AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource : TerraformDataSource
{
    public AzurermDatabricksWorkspacePrivateEndpointConnectionDataSource(string name) : base("azurerm_databricks_workspace_private_endpoint_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connections");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateEndpointId is required")]
    public required TerraformProperty<string> PrivateEndpointId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_endpoint_id");
        set => this.WithProperty("private_endpoint_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDatabricksWorkspacePrivateEndpointConnectionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public TerraformExpression Connections => this["connections"];

}
