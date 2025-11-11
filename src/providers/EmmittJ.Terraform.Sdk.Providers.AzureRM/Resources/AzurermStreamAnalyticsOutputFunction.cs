using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsOutputFunctionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_stream_analytics_output_function resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputFunction : TerraformResource
{
    public AzurermStreamAnalyticsOutputFunction(string name) : base("azurerm_stream_analytics_output_function", name)
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [TerraformProperty("api_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiKey { get; set; }

    /// <summary>
    /// The batch_max_count attribute.
    /// </summary>
    [TerraformProperty("batch_max_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BatchMaxCount { get; set; }

    /// <summary>
    /// The batch_max_in_bytes attribute.
    /// </summary>
    [TerraformProperty("batch_max_in_bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BatchMaxInBytes { get; set; }

    /// <summary>
    /// The function_app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionApp is required")]
    [TerraformProperty("function_app")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionApp { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionName { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    [TerraformProperty("stream_analytics_job_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StreamAnalyticsJobName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsOutputFunctionTimeoutsBlock>? Timeouts { get; set; }

}
