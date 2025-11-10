using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolExtendedAuditingPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("id");
        SetOutput("log_monitoring_enabled");
        SetOutput("retention_in_days");
        SetOutput("sql_pool_id");
        SetOutput("storage_account_access_key");
        SetOutput("storage_account_access_key_is_secondary");
        SetOutput("storage_endpoint");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LogMonitoringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_monitoring_enabled");
        set => SetProperty("log_monitoring_enabled", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_in_days");
        set => SetProperty("retention_in_days", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    public required TerraformProperty<string> SqlPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_pool_id");
        set => SetProperty("sql_pool_id", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_access_key");
        set => SetProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    public TerraformProperty<bool> StorageAccountAccessKeyIsSecondary
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_account_access_key_is_secondary");
        set => SetProperty("storage_account_access_key_is_secondary", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> StorageEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_endpoint");
        set => SetProperty("storage_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolExtendedAuditingPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
