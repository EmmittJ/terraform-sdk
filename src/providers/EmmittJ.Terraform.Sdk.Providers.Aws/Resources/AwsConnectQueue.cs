using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for outbound_caller_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsConnectQueueOutboundCallerConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The outbound_caller_id_name attribute.
    /// </summary>
    [TerraformProperty("outbound_caller_id_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutboundCallerIdName { get; set; }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    [TerraformProperty("outbound_caller_id_number_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutboundCallerIdNumberId { get; set; }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    [TerraformProperty("outbound_flow_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutboundFlowId { get; set; }

}

/// <summary>
/// Manages a aws_connect_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConnectQueue : TerraformResource
{
    public AwsConnectQueue(string name) : base("aws_connect_queue", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    [TerraformProperty("hours_of_operation_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HoursOfOperationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    [TerraformProperty("max_contacts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxContacts { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The quick_connect_ids attribute.
    /// </summary>
    [TerraformProperty("quick_connect_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? QuickConnectIds { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for outbound_caller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutboundCallerConfig block(s) allowed")]
    [TerraformProperty("outbound_caller_config")]
    public TerraformList<TerraformBlock<AwsConnectQueueOutboundCallerConfigBlock>>? OutboundCallerConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [TerraformProperty("queue_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QueueId { get; }

}
