using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for outbound_caller_config in .
/// Nesting mode: list
/// </summary>
public class AwsConnectQueueOutboundCallerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The outbound_caller_id_name attribute.
    /// </summary>
    [TerraformPropertyName("outbound_caller_id_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutboundCallerIdName { get; set; }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    [TerraformPropertyName("outbound_caller_id_number_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutboundCallerIdNumberId { get; set; }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    [TerraformPropertyName("outbound_flow_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutboundFlowId { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    [TerraformPropertyName("hours_of_operation_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HoursOfOperationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    [TerraformPropertyName("max_contacts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxContacts { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The quick_connect_ids attribute.
    /// </summary>
    [TerraformPropertyName("quick_connect_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? QuickConnectIds { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for outbound_caller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutboundCallerConfig block(s) allowed")]
    [TerraformPropertyName("outbound_caller_config")]
    public TerraformList<TerraformBlock<AwsConnectQueueOutboundCallerConfigBlock>>? OutboundCallerConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [TerraformPropertyName("queue_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QueueId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "queue_id");

}
