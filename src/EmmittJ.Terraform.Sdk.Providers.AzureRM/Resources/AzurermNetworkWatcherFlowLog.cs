using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_watcher_flow_log resource.
/// </summary>
public class AzurermNetworkWatcherFlowLog : TerraformResource
{
    public AzurermNetworkWatcherFlowLog(string name) : base("azurerm_network_watcher_flow_log", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The network_security_group_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? NetworkSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_security_group_id")?.Value;
        set => this.WithProperty("network_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_watcher_name attribute.
    /// </summary>
    public string? NetworkWatcherName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_watcher_name")?.Value;
        set => this.WithProperty("network_watcher_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public double? Version
    {
        get => GetProperty<TerraformLiteralProperty<double>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
