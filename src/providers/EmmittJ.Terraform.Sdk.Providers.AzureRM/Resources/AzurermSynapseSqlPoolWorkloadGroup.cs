using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_synapse_sql_pool_workload_group resource.
/// </summary>
public partial class AzurermSynapseSqlPoolWorkloadGroup : TerraformResource
{
    public AzurermSynapseSqlPoolWorkloadGroup(string name) : base("azurerm_synapse_sql_pool_workload_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    [TerraformProperty("importance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Importance { get; set; }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxResourcePercent is required")]
    [TerraformProperty("max_resource_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxResourcePercent { get; set; }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    [TerraformProperty("max_resource_percent_per_request")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxResourcePercentPerRequest { get; set; }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinResourcePercent is required")]
    [TerraformProperty("min_resource_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinResourcePercent { get; set; }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    [TerraformProperty("min_resource_percent_per_request")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinResourcePercentPerRequest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("query_execution_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? QueryExecutionTimeoutInSeconds { get; set; }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    [TerraformProperty("sql_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlPoolId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock Timeouts { get; set; } = new();

}
