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
    public TerraformProperty<HashSet<string>>? DisabledAlerts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("disabled_alerts");
        set => this.WithProperty("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformProperty<bool>? EmailAccountAdmins
    {
        get => GetProperty<TerraformProperty<bool>>("email_account_admins");
        set => this.WithProperty("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EmailAddresses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_days");
        set => this.WithProperty("retention_days", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? StorageEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_endpoint");
        set => this.WithProperty("storage_endpoint", value);
    }

}
