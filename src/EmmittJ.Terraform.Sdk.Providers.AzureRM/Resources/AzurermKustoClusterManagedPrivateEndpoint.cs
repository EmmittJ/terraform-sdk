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
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkResourceId
    {
        get => GetProperty<TerraformProperty<string>>("private_link_resource_id");
        set => this.WithProperty("private_link_resource_id", value);
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkResourceRegion
    {
        get => GetProperty<TerraformProperty<string>>("private_link_resource_region");
        set => this.WithProperty("private_link_resource_region", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
