using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerExtendedAuditingPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_server_extended_auditing_policy resource.
/// </summary>
public class AzurermMssqlServerExtendedAuditingPolicy : TerraformResource
{
    public AzurermMssqlServerExtendedAuditingPolicy(string name) : base("azurerm_mssql_server_extended_auditing_policy", name)
    {
    }

    /// <summary>
    /// The audit_actions_and_groups attribute.
    /// </summary>
    [TerraformPropertyName("audit_actions_and_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> AuditActionsAndGroups { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "audit_actions_and_groups");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The log_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("log_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LogMonitoringEnabled { get; set; }

    /// <summary>
    /// The predicate_expression attribute.
    /// </summary>
    [TerraformPropertyName("predicate_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PredicateExpression { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionInDays { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerId { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key_is_secondary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StorageAccountAccessKeyIsSecondary { get; set; }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_subscription_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountSubscriptionId { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("storage_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageEndpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlServerExtendedAuditingPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

}
