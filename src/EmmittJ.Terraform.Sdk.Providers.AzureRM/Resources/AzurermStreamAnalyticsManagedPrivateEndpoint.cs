using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_managed_private_endpoint resource.
/// </summary>
public class AzurermStreamAnalyticsManagedPrivateEndpoint : TerraformResource
{
    public AzurermStreamAnalyticsManagedPrivateEndpoint(string name) : base("azurerm_stream_analytics_managed_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stream_analytics_cluster_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsClusterName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_cluster_name");
        set => this.WithProperty("stream_analytics_cluster_name", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubresourceName
    {
        get => GetProperty<TerraformProperty<string>>("subresource_name");
        set => this.WithProperty("subresource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

}
