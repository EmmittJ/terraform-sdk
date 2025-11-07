using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_server_microsoft_support_auditing_policy resource.
/// </summary>
public class AzurermMssqlServerMicrosoftSupportAuditingPolicy : TerraformResource
{
    public AzurermMssqlServerMicrosoftSupportAuditingPolicy(string name) : base("azurerm_mssql_server_microsoft_support_auditing_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The blob_storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? BlobStorageEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("blob_storage_endpoint");
        set => this.WithProperty("blob_storage_endpoint", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The log_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_monitoring_enabled");
        set => this.WithProperty("log_monitoring_enabled", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerId
    {
        get => GetProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
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
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountSubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_subscription_id");
        set => this.WithProperty("storage_account_subscription_id", value);
    }

}
