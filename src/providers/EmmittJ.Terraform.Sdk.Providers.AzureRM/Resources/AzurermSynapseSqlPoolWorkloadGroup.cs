using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_synapse_sql_pool_workload_group resource.
/// </summary>
public class AzurermSynapseSqlPoolWorkloadGroup : TerraformResource
{
    public AzurermSynapseSqlPoolWorkloadGroup(string name) : base("azurerm_synapse_sql_pool_workload_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The importance attribute.
    /// </summary>
    [TerraformPropertyName("importance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Importance { get; set; }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxResourcePercent is required")]
    [TerraformPropertyName("max_resource_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxResourcePercent { get; set; }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    [TerraformPropertyName("max_resource_percent_per_request")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxResourcePercentPerRequest { get; set; }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinResourcePercent is required")]
    [TerraformPropertyName("min_resource_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinResourcePercent { get; set; }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    [TerraformPropertyName("min_resource_percent_per_request")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinResourcePercentPerRequest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("query_execution_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? QueryExecutionTimeoutInSeconds { get; set; }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    [TerraformPropertyName("sql_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlPoolId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock>? Timeouts { get; set; } = new();

}
