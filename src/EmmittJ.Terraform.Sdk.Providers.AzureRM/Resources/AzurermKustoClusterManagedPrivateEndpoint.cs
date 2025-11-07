using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_cluster_managed_private_endpoint resource.
/// </summary>
public class AzurermKustoClusterManagedPrivateEndpoint : TerraformResource
{
    public AzurermKustoClusterManagedPrivateEndpoint(string name) : base("azurerm_kusto_cluster_managed_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
    /// The private_link_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateLinkResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_id");
        set => this.WithProperty("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateLinkResourceRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_region");
        set => this.WithProperty("private_link_resource_region", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
