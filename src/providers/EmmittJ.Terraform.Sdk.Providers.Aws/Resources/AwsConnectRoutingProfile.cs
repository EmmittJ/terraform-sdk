using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_concurrencies in .
/// Nesting mode: set
/// </summary>
public class AwsConnectRoutingProfileMediaConcurrenciesBlock : ITerraformBlock
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformPropertyName("channel")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Channel { get; set; }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Concurrency is required")]
    [TerraformPropertyName("concurrency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Concurrency { get; set; }

}

/// <summary>
/// Block type for queue_configs in .
/// Nesting mode: set
/// </summary>
public class AwsConnectRoutingProfileQueueConfigsBlock : ITerraformBlock
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    [TerraformPropertyName("channel")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Channel { get; set; }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delay is required")]
    [TerraformPropertyName("delay")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Delay { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    [TerraformPropertyName("queue_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QueueArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "queue_arn");

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    [TerraformPropertyName("queue_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueueId { get; set; }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [TerraformPropertyName("queue_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QueueName => new TerraformReferenceProperty<TerraformProperty<string>>("", "queue_name");

}

/// <summary>
/// Manages a aws_connect_routing_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectRoutingProfile : TerraformResource
{
    public AwsConnectRoutingProfile(string name) : base("aws_connect_routing_profile", name)
    {
    }

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultOutboundQueueId is required")]
    [TerraformPropertyName("default_outbound_queue_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DefaultOutboundQueueId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

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
    /// Block for media_concurrencies.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaConcurrencies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MediaConcurrencies block(s) required")]
    [TerraformPropertyName("media_concurrencies")]
    public TerraformSet<TerraformBlock<AwsConnectRoutingProfileMediaConcurrenciesBlock>>? MediaConcurrencies { get; set; } = new();

    /// <summary>
    /// Block for queue_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("queue_configs")]
    public TerraformSet<TerraformBlock<AwsConnectRoutingProfileQueueConfigsBlock>>? QueueConfigs { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("routing_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoutingProfileId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "routing_profile_id");

}
