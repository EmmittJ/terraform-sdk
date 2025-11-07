using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_managed_private_endpoint resource.
/// </summary>
public class AzurermSynapseManagedPrivateEndpoint : TerraformResource
{
    public AzurermSynapseManagedPrivateEndpoint(string name) : base("azurerm_synapse_managed_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubresourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subresource_name");
        set => this.WithProperty("subresource_name", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

}
