using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_mssql_server_security_alert_policy resource.
/// </summary>
public partial class AzurermMssqlServerSecurityAlertPolicy : TerraformResource
{
    public AzurermMssqlServerSecurityAlertPolicy(string name) : base("azurerm_mssql_server_security_alert_policy", name)
    {
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformProperty("disabled_alerts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DisabledAlerts { get; set; }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    [TerraformProperty("email_account_admins")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EmailAccountAdmins { get; set; }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformProperty("email_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EmailAddresses { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformProperty("retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionDays { get; set; }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformProperty("server_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerName { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> State { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformProperty("storage_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageEndpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
