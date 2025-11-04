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
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public string? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id")?.Value;
        set => this.WithProperty("group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_resource_id attribute.
    /// </summary>
    public string? PrivateLinkResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_id")?.Value;
        set => this.WithProperty("private_link_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_resource_region attribute.
    /// </summary>
    public string? PrivateLinkResourceRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_link_resource_region")?.Value;
        set => this.WithProperty("private_link_resource_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public string? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message")?.Value;
        set => this.WithProperty("request_message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
