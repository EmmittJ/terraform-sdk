using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automanage_configuration resource.
/// </summary>
public class AzurermAutomanageConfiguration : TerraformResource
{
    public AzurermAutomanageConfiguration(string name) : base("azurerm_automanage_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_enabled attribute.
    /// </summary>
    public bool? AutomationAccountEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automation_account_enabled")?.Value;
        set => this.WithProperty("automation_account_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    public bool? BootDiagnosticsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("boot_diagnostics_enabled")?.Value;
        set => this.WithProperty("boot_diagnostics_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    public bool? DefenderForCloudEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("defender_for_cloud_enabled")?.Value;
        set => this.WithProperty("defender_for_cloud_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    public bool? GuestConfigurationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("guest_configuration_enabled")?.Value;
        set => this.WithProperty("guest_configuration_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The log_analytics_enabled attribute.
    /// </summary>
    public bool? LogAnalyticsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_analytics_enabled")?.Value;
        set => this.WithProperty("log_analytics_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The status_change_alert_enabled attribute.
    /// </summary>
    public bool? StatusChangeAlertEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("status_change_alert_enabled")?.Value;
        set => this.WithProperty("status_change_alert_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
