using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_synapse_sql_pool_workload_classifier resource.
/// </summary>
public partial class AzurermSynapseSqlPoolWorkloadClassifier : TerraformResource
{
    public AzurermSynapseSqlPoolWorkloadClassifier(string name) : base("azurerm_synapse_sql_pool_workload_classifier", name)
    {
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformProperty("context")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Context { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    [TerraformProperty("importance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Importance { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberName is required")]
    [TerraformProperty("member_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MemberName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// The workload_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkloadGroupId is required")]
    [TerraformProperty("workload_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkloadGroupId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSynapseSqlPoolWorkloadClassifierTimeoutsBlock>? Timeouts { get; set; }

}
