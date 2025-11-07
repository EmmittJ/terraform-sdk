using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_sql_pool_extended_auditing_policy resource.
/// </summary>
public class AzurermSynapseSqlPoolExtendedAuditingPolicy : TerraformResource
{
    public AzurermSynapseSqlPoolExtendedAuditingPolicy(string name) : base("azurerm_synapse_sql_pool_extended_auditing_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The sql_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_pool_id");
        set => this.WithProperty("sql_pool_id", value);
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
