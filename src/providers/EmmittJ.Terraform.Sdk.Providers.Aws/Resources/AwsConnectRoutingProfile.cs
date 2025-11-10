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
        set => SetProperty("channel", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Concurrency is required")]
    public required TerraformProperty<double> Concurrency
    {
        set => SetProperty("concurrency", value);
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
        set => SetProperty("channel", value);
    }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delay is required")]
    public required TerraformProperty<double> Delay
    {
        set => SetProperty("delay", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? QueueArn
    {
        set => SetProperty("queue_arn", value);
    }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    public required TerraformProperty<string> QueueId
    {
        set => SetProperty("queue_id", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformProperty<string>? QueueName
    {
        set => SetProperty("queue_name", value);
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
        SetOutput("arn");
        SetOutput("routing_profile_id");
        SetOutput("default_outbound_queue_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultOutboundQueueId is required")]
    public required TerraformProperty<string> DefaultOutboundQueueId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_outbound_queue_id");
        set => SetProperty("default_outbound_queue_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for media_concurrencies.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaConcurrencies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MediaConcurrencies block(s) required")]
    public HashSet<AwsConnectRoutingProfileMediaConcurrenciesBlock>? MediaConcurrencies
    {
        set => SetProperty("media_concurrencies", value);
    }

    /// <summary>
    /// Block for queue_configs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsConnectRoutingProfileQueueConfigsBlock>? QueueConfigs
    {
        set => SetProperty("queue_configs", value);
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
