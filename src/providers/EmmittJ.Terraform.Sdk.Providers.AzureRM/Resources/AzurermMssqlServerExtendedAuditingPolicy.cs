using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerExtendedAuditingPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_server_extended_auditing_policy resource.
/// </summary>
public class AzurermMssqlServerExtendedAuditingPolicy : TerraformResource
{
    public AzurermMssqlServerExtendedAuditingPolicy(string name) : base("azurerm_mssql_server_extended_auditing_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("audit_actions_and_groups");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("log_monitoring_enabled");
        SetOutput("predicate_expression");
        SetOutput("retention_in_days");
        SetOutput("server_id");
        SetOutput("storage_account_access_key");
        SetOutput("storage_account_access_key_is_secondary");
        SetOutput("storage_account_subscription_id");
        SetOutput("storage_endpoint");
    }

    /// <summary>
    /// The audit_actions_and_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>> AuditActionsAndGroups
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("audit_actions_and_groups");
        set => SetProperty("audit_actions_and_groups", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The predicate_expression attribute.
    /// </summary>
    public TerraformProperty<string> PredicateExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("predicate_expression");
        set => SetProperty("predicate_expression", value);
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
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
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountSubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_subscription_id");
        set => SetProperty("storage_account_subscription_id", value);
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
    public AzurermMssqlServerExtendedAuditingPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
