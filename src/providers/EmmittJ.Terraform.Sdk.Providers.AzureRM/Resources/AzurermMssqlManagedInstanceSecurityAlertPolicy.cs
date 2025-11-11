using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlManagedInstanceSecurityAlertPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_mssql_managed_instance_security_alert_policy resource.
/// </summary>
public partial class AzurermMssqlManagedInstanceSecurityAlertPolicy : TerraformResource
{
    public AzurermMssqlManagedInstanceSecurityAlertPolicy(string name) : base("azurerm_mssql_managed_instance_security_alert_policy", name)
    {
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformProperty("disabled_alerts")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins_enabled attribute.
    /// </summary>
    [TerraformProperty("email_account_admins_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EmailAccountAdminsEnabled { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformProperty("email_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EmailAddresses { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceName is required")]
    [TerraformProperty("managed_instance_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagedInstanceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformProperty("retention_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionDays { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformProperty("storage_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageEndpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceSecurityAlertPolicyTimeoutsBlock>? Timeouts { get; set; }

}
