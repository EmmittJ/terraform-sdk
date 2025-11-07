using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_database_extended_auditing_policy resource.
/// </summary>
public class AzurermMssqlDatabaseExtendedAuditingPolicy : TerraformResource
{
    public AzurermMssqlDatabaseExtendedAuditingPolicy(string name) : base("azurerm_mssql_database_extended_auditing_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_id");
        set => this.WithProperty("database_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_monitoring_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LogMonitoringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_monitoring_enabled");
        set => this.WithProperty("log_monitoring_enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days");
        set => this.WithProperty("retention_in_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StorageAccountAccessKeyIsSecondary
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_account_access_key_is_secondary");
        set => this.WithProperty("storage_account_access_key_is_secondary", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_endpoint");
        set => this.WithProperty("storage_endpoint", value);
    }

}
