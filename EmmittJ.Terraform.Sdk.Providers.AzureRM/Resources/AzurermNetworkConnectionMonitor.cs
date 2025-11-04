using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_connection_monitor resource.
/// </summary>
public class AzurermNetworkConnectionMonitor : TerraformResource
{
    public AzurermNetworkConnectionMonitor(string name) : base("azurerm_network_connection_monitor", name)
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_watcher_id attribute.
    /// </summary>
    public string? NetworkWatcherId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_watcher_id")?.Value;
        set => this.WithProperty("network_watcher_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public string? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes")?.Value;
        set => this.WithProperty("notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The output_workspace_resource_ids attribute.
    /// </summary>
    public HashSet<string>? OutputWorkspaceResourceIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("output_workspace_resource_ids")?.Value;
        set => this.WithProperty("output_workspace_resource_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
