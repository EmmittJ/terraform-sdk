using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_endpoint_id");
        set => this.WithProperty("private_endpoint_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public TerraformExpression Connections => this["connections"];

}
