using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlFailoverGroupDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_failover_group.
/// </summary>
public partial class AzurermMssqlFailoverGroupDataSource : TerraformDataSource
{
    public AzurermMssqlFailoverGroupDataSource(string name) : base("azurerm_mssql_failover_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlFailoverGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformProperty("databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Databases { get; }

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    [TerraformProperty("partner_server")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PartnerServer { get; }

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    [TerraformProperty("read_write_endpoint_failover_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReadWriteEndpointFailoverPolicy { get; }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("readonly_endpoint_failover_policy_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ReadonlyEndpointFailoverPolicyEnabled { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
