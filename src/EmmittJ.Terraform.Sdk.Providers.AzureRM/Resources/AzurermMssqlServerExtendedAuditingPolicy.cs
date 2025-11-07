using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The audit_actions_and_groups attribute.
    /// </summary>
    public TerraformProperty<List<string>>? AuditActionsAndGroups
    {
        get => GetProperty<TerraformProperty<List<string>>>("audit_actions_and_groups");
        set => this.WithProperty("audit_actions_and_groups", value);
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
    /// The predicate_expression attribute.
    /// </summary>
    public TerraformProperty<string>? PredicateExpression
    {
        get => GetProperty<TerraformProperty<string>>("predicate_expression");
        set => this.WithProperty("predicate_expression", value);
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
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageAccountAccessKeyIsSecondary
    {
        get => GetProperty<TerraformProperty<bool>>("storage_account_access_key_is_secondary");
        set => this.WithProperty("storage_account_access_key_is_secondary", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountSubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_subscription_id");
        set => this.WithProperty("storage_account_subscription_id", value);
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
