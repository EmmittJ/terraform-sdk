using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_concurrencies in .
/// Nesting mode: set
/// </summary>
public partial class AwsConnectRoutingProfileMediaConcurrenciesBlock : TerraformBlockBase
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformProperty("channel")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Channel { get; set; }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Concurrency is required")]
    [TerraformProperty("concurrency")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Concurrency { get; set; }

}

/// <summary>
/// Block type for queue_configs in .
/// Nesting mode: set
/// </summary>
public partial class AwsConnectRoutingProfileQueueConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformProperty("channel")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Channel { get; set; }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delay is required")]
    [TerraformProperty("delay")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Delay { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }


    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    [TerraformProperty("queue_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> QueueId { get; set; }


}

/// <summary>
/// Manages a aws_connect_routing_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConnectRoutingProfile : TerraformResource
{
    public AwsConnectRoutingProfile(string name) : base("aws_connect_routing_profile", name)
    {
    }

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultOutboundQueueId is required")]
    [TerraformProperty("default_outbound_queue_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DefaultOutboundQueueId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Description { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for media_concurrencies.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaConcurrencies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MediaConcurrencies block(s) required")]
    [TerraformProperty("media_concurrencies")]
    public TerraformSet<TerraformBlock<AwsConnectRoutingProfileMediaConcurrenciesBlock>>? MediaConcurrencies { get; set; }

    /// <summary>
    /// Block for queue_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("queue_configs")]
    public TerraformSet<TerraformBlock<AwsConnectRoutingProfileQueueConfigsBlock>>? QueueConfigs { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [TerraformProperty("routing_profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RoutingProfileId { get; }

}
