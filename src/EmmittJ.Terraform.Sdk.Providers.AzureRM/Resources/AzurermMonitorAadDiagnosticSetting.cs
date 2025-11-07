using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_aad_diagnostic_setting resource.
/// </summary>
public class AzurermMonitorAadDiagnosticSetting : TerraformResource
{
    public AzurermMonitorAadDiagnosticSetting(string name) : base("azurerm_monitor_aad_diagnostic_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubAuthorizationRuleId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_authorization_rule_id");
        set => this.WithProperty("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_name");
        set => this.WithProperty("eventhub_name", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

}
