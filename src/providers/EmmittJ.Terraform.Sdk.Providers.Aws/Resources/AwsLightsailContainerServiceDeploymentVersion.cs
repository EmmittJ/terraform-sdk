using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in AwsLightsailContainerServiceDeploymentVersion.
/// Nesting mode: set
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "command").ResolveNodes(ctx));
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformMap<string>? Environment
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment").ResolveNodes(ctx));
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The ports attribute.
    /// </summary>
    public TerraformMap<string>? Ports
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "ports").ResolveNodes(ctx));
        set => SetArgument("ports", value);
    }

}


/// <summary>
/// Block type for public_endpoint in AwsLightsailContainerServiceDeploymentVersion.
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_endpoint";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    public required TerraformValue<double> ContainerPort
    {
        get => new TerraformReference<double>(this, "container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// HealthCheck block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HealthCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public required TerraformList<AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlockHealthCheckBlock> HealthCheck
    {
        get => GetRequiredArgument<TerraformList<AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlockHealthCheckBlock>>("health_check");
        set => SetArgument("health_check", value);
    }

}

/// <summary>
/// Block type for health_check in AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock.
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlockHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check";

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    public TerraformValue<double>? HealthyThreshold
    {
        get => new TerraformReference<double>(this, "healthy_threshold");
        set => SetArgument("healthy_threshold", value);
    }

    /// <summary>
    /// The interval_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalSeconds
    {
        get => new TerraformReference<double>(this, "interval_seconds");
        set => SetArgument("interval_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The success_codes attribute.
    /// </summary>
    public TerraformValue<string>? SuccessCodes
    {
        get => new TerraformReference<string>(this, "success_codes");
        set => SetArgument("success_codes", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => new TerraformReference<double>(this, "timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformValue<double>? UnhealthyThreshold
    {
        get => new TerraformReference<double>(this, "unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLightsailContainerServiceDeploymentVersion.
/// Nesting mode: single
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_lightsail_container_service_deployment_version Terraform resource.
/// Manages a aws_lightsail_container_service_deployment_version resource.
/// </summary>
public partial class AwsLightsailContainerServiceDeploymentVersion(string name) : TerraformResource("aws_lightsail_container_service_deployment_version", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

    /// <summary>
    /// Container block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(53, ErrorMessage = "Maximum 53 Container block(s) allowed")]
    public required TerraformSet<AwsLightsailContainerServiceDeploymentVersionContainerBlock> Container
    {
        get => GetRequiredArgument<TerraformSet<AwsLightsailContainerServiceDeploymentVersionContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// PublicEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicEndpoint block(s) allowed")]
    public TerraformList<AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock>? PublicEndpoint
    {
        get => GetArgument<TerraformList<AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock>>("public_endpoint");
        set => SetArgument("public_endpoint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
