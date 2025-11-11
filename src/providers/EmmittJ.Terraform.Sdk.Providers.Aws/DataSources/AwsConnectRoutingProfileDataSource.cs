using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_routing_profile.
/// </summary>
public class AwsConnectRoutingProfileDataSource : TerraformDataSource
{
    public AwsConnectRoutingProfileDataSource(string name) : base("aws_connect_routing_profile", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("routing_profile_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoutingProfileId { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    [TerraformPropertyName("default_outbound_queue_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultOutboundQueueId => new TerraformReference(this, "default_outbound_queue_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The media_concurrencies attribute.
    /// </summary>
    [TerraformPropertyName("media_concurrencies")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> MediaConcurrencies => new TerraformReference(this, "media_concurrencies");

    /// <summary>
    /// The queue_configs attribute.
    /// </summary>
    [TerraformPropertyName("queue_configs")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> QueueConfigs => new TerraformReference(this, "queue_configs");

}
