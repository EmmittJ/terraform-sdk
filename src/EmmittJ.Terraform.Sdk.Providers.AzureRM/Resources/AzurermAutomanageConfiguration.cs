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
    public TerraformProperty<bool>? AutomationAccountEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automation_account_enabled");
        set => this.WithProperty("automation_account_enabled", value);
    }

    /// <summary>
    /// The boot_diagnostics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BootDiagnosticsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("boot_diagnostics_enabled");
        set => this.WithProperty("boot_diagnostics_enabled", value);
    }

    /// <summary>
    /// The defender_for_cloud_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DefenderForCloudEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("defender_for_cloud_enabled");
        set => this.WithProperty("defender_for_cloud_enabled", value);
    }

    /// <summary>
    /// The guest_configuration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GuestConfigurationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("guest_configuration_enabled");
        set => this.WithProperty("guest_configuration_enabled", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_analytics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogAnalyticsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_analytics_enabled");
        set => this.WithProperty("log_analytics_enabled", value);
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
    /// The status_change_alert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StatusChangeAlertEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("status_change_alert_enabled");
        set => this.WithProperty("status_change_alert_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
