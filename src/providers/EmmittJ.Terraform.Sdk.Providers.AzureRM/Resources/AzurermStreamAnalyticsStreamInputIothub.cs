using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for serialization in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStreamAnalyticsStreamInputIothubSerializationBlock : TerraformBlockBase
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [TerraformProperty("encoding")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    [TerraformProperty("field_delimiter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FieldDelimiter { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsStreamInputIothubTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_stream_analytics_stream_input_iothub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStreamAnalyticsStreamInputIothub : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputIothub(string name) : base("azurerm_stream_analytics_stream_input_iothub", name)
    {
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    [TerraformProperty("eventhub_consumer_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventhubConsumerGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iothub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubNamespace is required")]
    [TerraformProperty("iothub_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IothubNamespace { get; set; }

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
    /// The shared_access_policy_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyKey is required")]
    [TerraformProperty("shared_access_policy_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SharedAccessPolicyKey { get; set; }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyName is required")]
    [TerraformProperty("shared_access_policy_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SharedAccessPolicyName { get; set; }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    [TerraformProperty("stream_analytics_job_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StreamAnalyticsJobName { get; set; }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    [TerraformProperty("serialization")]
    public TerraformList<TerraformBlock<AzurermStreamAnalyticsStreamInputIothubSerializationBlock>>? Serialization { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsStreamInputIothubTimeoutsBlock>? Timeouts { get; set; }

}
