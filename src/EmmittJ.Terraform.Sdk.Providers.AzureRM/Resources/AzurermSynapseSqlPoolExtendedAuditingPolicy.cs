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
    /// The retention_in_days attribute.
    /// </summary>
    public double? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days")?.Value;
        set => this.WithProperty("retention_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    public string? SqlPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_pool_id")?.Value;
        set => this.WithProperty("sql_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    public bool? StorageAccountAccessKeyIsSecondary
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_account_access_key_is_secondary")?.Value;
        set => this.WithProperty("storage_account_access_key_is_secondary", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
