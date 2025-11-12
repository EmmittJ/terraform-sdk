using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlServerMicrosoftSupportAuditingPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_server_microsoft_support_auditing_policy resource.
/// </summary>
public partial class AzurermMssqlServerMicrosoftSupportAuditingPolicy : TerraformResource
{
    public AzurermMssqlServerMicrosoftSupportAuditingPolicy(string name) : base("azurerm_mssql_server_microsoft_support_auditing_policy", name)
    {
    }

    /// <summary>
    /// The blob_storage_endpoint attribute.
    /// </summary>
    [TerraformProperty("blob_storage_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BlobStorageEndpoint { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("log_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogMonitoringEnabled { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_subscription_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountSubscriptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlServerMicrosoftSupportAuditingPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
