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
    public TerraformLiteralProperty<HashSet<string>>? DisabledDataSources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disabled_data_sources");
        set => this.WithProperty("disabled_data_sources", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The events_to_export attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EventsToExport
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("events_to_export");
        set => this.WithProperty("events_to_export", value);
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
    /// The iothub_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IothubIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iothub_ids");
        set => this.WithProperty("iothub_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LogUnmaskedIpsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_unmasked_ips_enabled");
        set => this.WithProperty("log_unmasked_ips_enabled", value);
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
    /// The query_for_resources attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueryForResources
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_for_resources");
        set => this.WithProperty("query_for_resources", value);
    }

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? QuerySubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("query_subscription_ids");
        set => this.WithProperty("query_subscription_ids", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
