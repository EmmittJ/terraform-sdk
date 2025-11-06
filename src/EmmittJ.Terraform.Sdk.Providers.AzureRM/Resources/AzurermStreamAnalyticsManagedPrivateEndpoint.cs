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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_cluster_name attribute.
    /// </summary>
    public string? StreamAnalyticsClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_cluster_name")?.Value;
        set => this.WithProperty("stream_analytics_cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public string? SubresourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subresource_name")?.Value;
        set => this.WithProperty("subresource_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
