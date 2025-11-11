using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBatchJobTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_batch_job resource.
/// </summary>
public partial class AzurermBatchJob : TerraformResource
{
    public AzurermBatchJob(string name) : base("azurerm_batch_job", name)
    {
    }

    /// <summary>
    /// The batch_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchPoolId is required")]
    [TerraformProperty("batch_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BatchPoolId { get; set; }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    [TerraformProperty("common_environment_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? CommonEnvironmentProperties { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    [TerraformProperty("task_retry_maximum")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TaskRetryMaximum { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBatchJobTimeoutsBlock>? Timeouts { get; set; }

}
