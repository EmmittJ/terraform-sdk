using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_queue.
/// </summary>
public partial class AwsConnectQueueDataSource : TerraformDataSource
{
    public AwsConnectQueueDataSource(string name) : base("aws_connect_queue", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [TerraformProperty("queue_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> QueueId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [TerraformProperty("hours_of_operation_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HoursOfOperationId { get; }

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    [TerraformProperty("max_contacts")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxContacts { get; }

    /// <summary>
    /// The outbound_caller_config attribute.
    /// </summary>
    [TerraformProperty("outbound_caller_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> OutboundCallerConfig { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
