using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlDatabaseExtendedAuditingPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformProperty<string> DatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("database_id");
        set => this.WithProperty("database_id", value);
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
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_in_days");
        set => this.WithProperty("retention_in_days", value);
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
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageAccountAccessKeyIsSecondary
    {
        get => GetProperty<TerraformProperty<bool>>("storage_account_access_key_is_secondary");
        set => this.WithProperty("storage_account_access_key_is_secondary", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? StorageEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_endpoint");
        set => this.WithProperty("storage_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlDatabaseExtendedAuditingPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlDatabaseExtendedAuditingPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
