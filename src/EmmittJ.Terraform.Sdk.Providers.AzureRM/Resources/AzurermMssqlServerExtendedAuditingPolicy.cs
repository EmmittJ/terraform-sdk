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
    public List<string>? AuditActionsAndGroups
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("audit_actions_and_groups")?.Value;
        set => this.WithProperty("audit_actions_and_groups", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The predicate_expression attribute.
    /// </summary>
    public string? PredicateExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("predicate_expression")?.Value;
        set => this.WithProperty("predicate_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    public bool? StorageAccountAccessKeyIsSecondary
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_account_access_key_is_secondary")?.Value;
        set => this.WithProperty("storage_account_access_key_is_secondary", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public string? StorageAccountSubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_subscription_id")?.Value;
        set => this.WithProperty("storage_account_subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
