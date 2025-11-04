using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_server_security_alert_policy resource.
/// </summary>
public class AzurermMssqlServerSecurityAlertPolicy : TerraformResource
{
    public AzurermMssqlServerSecurityAlertPolicy(string name) : base("azurerm_mssql_server_security_alert_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public HashSet<string>? DisabledAlerts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disabled_alerts")?.Value;
        set => this.WithProperty("disabled_alerts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public bool? EmailAccountAdmins
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("email_account_admins")?.Value;
        set => this.WithProperty("email_account_admins", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public HashSet<string>? EmailAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("email_addresses")?.Value;
        set => this.WithProperty("email_addresses", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public double? RetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_days")?.Value;
        set => this.WithProperty("retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public string? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name")?.Value;
        set => this.WithProperty("server_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public string? StorageAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_access_key")?.Value;
        set => this.WithProperty("storage_account_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public string? StorageEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_endpoint")?.Value;
        set => this.WithProperty("storage_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
