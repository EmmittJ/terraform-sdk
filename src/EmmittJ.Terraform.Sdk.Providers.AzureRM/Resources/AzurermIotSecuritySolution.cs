using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iot_security_solution resource.
/// </summary>
public class AzurermIotSecuritySolution : TerraformResource
{
    public AzurermIotSecuritySolution(string name) : base("azurerm_iot_security_solution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disabled_data_sources attribute.
    /// </summary>
    public HashSet<string>? DisabledDataSources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disabled_data_sources")?.Value;
        set => this.WithProperty("disabled_data_sources", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The events_to_export attribute.
    /// </summary>
    public HashSet<string>? EventsToExport
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("events_to_export")?.Value;
        set => this.WithProperty("events_to_export", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The iothub_ids attribute.
    /// </summary>
    public HashSet<string>? IothubIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iothub_ids")?.Value;
        set => this.WithProperty("iothub_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    public bool? LogUnmaskedIpsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_unmasked_ips_enabled")?.Value;
        set => this.WithProperty("log_unmasked_ips_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The query_for_resources attribute.
    /// </summary>
    public string? QueryForResources
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_for_resources")?.Value;
        set => this.WithProperty("query_for_resources", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    public HashSet<string>? QuerySubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("query_subscription_ids")?.Value;
        set => this.WithProperty("query_subscription_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
