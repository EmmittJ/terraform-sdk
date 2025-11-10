using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in .
/// Nesting mode: set
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionContainerBlock : TerraformBlock
{
    /// <summary>
    /// The command attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Command
    {
        set => SetProperty("command", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Environment
    {
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The ports attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Ports
    {
        set => SetProperty("ports", value);
    }

}

/// <summary>
/// Block type for public_endpoint in .
/// Nesting mode: list
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    public required TerraformProperty<double> ContainerPort
    {
        set => SetProperty("container_port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_lightsail_container_service_deployment_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLightsailContainerServiceDeploymentVersion : TerraformResource
{
    public AwsLightsailContainerServiceDeploymentVersion(string name) : base("aws_lightsail_container_service_deployment_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("state");
        SetOutput("version");
        SetOutput("id");
        SetOutput("region");
        SetOutput("service_name");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// Block for container.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(53, ErrorMessage = "Maximum 53 Container block(s) allowed")]
    public HashSet<AwsLightsailContainerServiceDeploymentVersionContainerBlock>? Container
    {
        set => SetProperty("container", value);
    }

    /// <summary>
    /// Block for public_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicEndpoint block(s) allowed")]
    public List<AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock>? PublicEndpoint
    {
        set => SetProperty("public_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
