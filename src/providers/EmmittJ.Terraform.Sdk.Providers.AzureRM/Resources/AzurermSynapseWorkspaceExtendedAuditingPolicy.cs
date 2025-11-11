using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseWorkspaceExtendedAuditingPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_synapse_workspace_extended_auditing_policy resource.
/// </summary>
public partial class AzurermSynapseWorkspaceExtendedAuditingPolicy : TerraformResource
{
    public AzurermSynapseWorkspaceExtendedAuditingPolicy(string name) : base("azurerm_synapse_workspace_extended_auditing_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("log_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LogMonitoringEnabled { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionInDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_access_key_is_secondary attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key_is_secondary")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? StorageAccountAccessKeyIsSecondary { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformProperty("storage_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageEndpoint { get; set; }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    [TerraformProperty("synapse_workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SynapseWorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSynapseWorkspaceExtendedAuditingPolicyTimeoutsBlock>? Timeouts { get; set; }

}
