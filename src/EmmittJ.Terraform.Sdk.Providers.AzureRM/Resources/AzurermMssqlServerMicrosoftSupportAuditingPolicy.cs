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
    public string? BlobStorageEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blob_storage_endpoint")?.Value;
        set => this.WithProperty("blob_storage_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The log_monitoring_enabled attribute.
    /// </summary>
    public bool? LogMonitoringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_monitoring_enabled")?.Value;
        set => this.WithProperty("log_monitoring_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public string? StorageAccountSubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_subscription_id")?.Value;
        set => this.WithProperty("storage_account_subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
