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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    public string? PrivateEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_endpoint_id")?.Value;
        set => this.WithProperty("private_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connections attribute.
    /// </summary>
    public TerraformExpression Connections => this["connections"];

}
