using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_concurrencies in .
/// Nesting mode: set
/// </summary>
public class AwsConnectRoutingProfileMediaConcurrenciesBlock : TerraformBlock
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformProperty<string> Channel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("channel");
        set => WithProperty("channel", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Concurrency is required")]
    public required TerraformProperty<double> Concurrency
    {
        get => GetRequiredProperty<TerraformProperty<double>>("concurrency");
        set => WithProperty("concurrency", value);
    }

}

/// <summary>
/// Block type for queue_configs in .
/// Nesting mode: set
/// </summary>
public class AwsConnectRoutingProfileQueueConfigsBlock : TerraformBlock
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformProperty<string> Channel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("channel");
        set => WithProperty("channel", value);
    }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delay is required")]
    public required TerraformProperty<double> Delay
    {
        get => GetRequiredProperty<TerraformProperty<double>>("delay");
        set => WithProperty("delay", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? QueueArn
    {
        get => GetProperty<TerraformProperty<string>>("queue_arn");
        set => WithProperty("queue_arn", value);
    }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    public required TerraformProperty<string> QueueId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("queue_id");
        set => WithProperty("queue_id", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformProperty<string>? QueueName
    {
        get => GetProperty<TerraformProperty<string>>("queue_name");
        set => WithProperty("queue_name", value);
    }

}

/// <summary>
/// Manages a aws_connect_routing_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectRoutingProfile : TerraformResource
{
    public AwsConnectRoutingProfile(string name) : base("aws_connect_routing_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("routing_profile_id");
    }

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultOutboundQueueId is required")]
    public required TerraformProperty<string> DefaultOutboundQueueId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_outbound_queue_id");
        set => this.WithProperty("default_outbound_queue_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for media_concurrencies.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MediaConcurrencies block(s) required")]
    public HashSet<AwsConnectRoutingProfileMediaConcurrenciesBlock>? MediaConcurrencies
    {
        get => GetProperty<HashSet<AwsConnectRoutingProfileMediaConcurrenciesBlock>>("media_concurrencies");
        set => this.WithProperty("media_concurrencies", value);
    }

    /// <summary>
    /// Block for queue_configs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsConnectRoutingProfileQueueConfigsBlock>? QueueConfigs
    {
        get => GetProperty<HashSet<AwsConnectRoutingProfileQueueConfigsBlock>>("queue_configs");
        set => this.WithProperty("queue_configs", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformExpression RoutingProfileId => this["routing_profile_id"];

}
