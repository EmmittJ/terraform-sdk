using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_bus in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointEventBusBlock : TerraformBlock
{
    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    public required TerraformProperty<string> EventBusArn
    {
        set => SetProperty("event_bus_arn", value);
    }

}

/// <summary>
/// Block type for replication_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointReplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for routing_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointRoutingConfigBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_cloudwatch_event_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchEventEndpoint : TerraformResource
{
    public AwsCloudwatchEventEndpoint(string name) : base("aws_cloudwatch_event_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint_url");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// Block for event_bus.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 EventBus block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 EventBus block(s) allowed")]
    public List<AwsCloudwatchEventEndpointEventBusBlock>? EventBus
    {
        set => SetProperty("event_bus", value);
    }

    /// <summary>
    /// Block for replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfig block(s) allowed")]
    public List<AwsCloudwatchEventEndpointReplicationConfigBlock>? ReplicationConfig
    {
        set => SetProperty("replication_config", value);
    }

    /// <summary>
    /// Block for routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    public List<AwsCloudwatchEventEndpointRoutingConfigBlock>? RoutingConfig
    {
        set => SetProperty("routing_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    public TerraformExpression EndpointUrl => this["endpoint_url"];

}
