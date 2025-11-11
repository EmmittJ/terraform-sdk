using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for outbound_caller_config in .
/// Nesting mode: list
/// </summary>
public class AwsConnectQueueOutboundCallerConfigBlock
{
    /// <summary>
    /// The outbound_caller_id_name attribute.
    /// </summary>
    [TerraformPropertyName("outbound_caller_id_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundCallerIdName { get; set; }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    [TerraformPropertyName("outbound_caller_id_number_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundCallerIdNumberId { get; set; }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    [TerraformPropertyName("outbound_flow_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundFlowId { get; set; }

}

/// <summary>
/// Manages a aws_connect_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectQueue : TerraformResource
{
    public AwsConnectQueue(string name) : base("aws_connect_queue", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    [TerraformPropertyName("hours_of_operation_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HoursOfOperationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    [TerraformPropertyName("max_contacts")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxContacts { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The quick_connect_ids attribute.
    /// </summary>
    [TerraformPropertyName("quick_connect_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? QuickConnectIds { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for outbound_caller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutboundCallerConfig block(s) allowed")]
    [TerraformPropertyName("outbound_caller_config")]
    public TerraformList<TerraformBlock<AwsConnectQueueOutboundCallerConfigBlock>>? OutboundCallerConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [TerraformPropertyName("queue_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QueueId => new TerraformReference(this, "queue_id");

}
