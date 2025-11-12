using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for serialization in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock() : TerraformBlock("serialization")
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [TerraformProperty("encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    [TerraformProperty("field_delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FieldDelimiter { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_stream_analytics_stream_input_eventhub_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStreamAnalyticsStreamInputEventhubV2 : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputEventhubV2(string name) : base("azurerm_stream_analytics_stream_input_eventhub_v2", name)
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformProperty("authentication_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationMode { get; set; }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_consumer_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventhubConsumerGroupName { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    [TerraformProperty("eventhub_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventhubName { get; set; }

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
    /// The partition_key attribute.
    /// </summary>
    [TerraformProperty("partition_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PartitionKey { get; set; }

    /// <summary>
    /// The servicebus_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicebusNamespace is required")]
    [TerraformProperty("servicebus_namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServicebusNamespace { get; set; }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    [TerraformProperty("shared_access_policy_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedAccessPolicyKey { get; set; }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    [TerraformProperty("shared_access_policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedAccessPolicyName { get; set; }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    [TerraformProperty("stream_analytics_job_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamAnalyticsJobId { get; set; }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    [TerraformProperty("serialization")]
    public required TerraformList<AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock> Serialization { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock Timeouts { get; set; } = new();

}
