using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for container in .
/// Nesting mode: set
/// </summary>
public partial class AwsLightsailContainerServiceDeploymentVersionContainerBlock : TerraformBlockBase
{
    /// <summary>
    /// The command attribute.
    /// </summary>
    [TerraformProperty("command")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Command { get; set; }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [TerraformProperty("environment")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Environment { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The ports attribute.
    /// </summary>
    [TerraformProperty("ports")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Ports { get; set; }

}

/// <summary>
/// Block type for public_endpoint in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The container_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerPort is required")]
    [TerraformProperty("container_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ContainerPort { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_lightsail_container_service_deployment_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLightsailContainerServiceDeploymentVersion : TerraformResource
{
    public AwsLightsailContainerServiceDeploymentVersion(string name) : base("aws_lightsail_container_service_deployment_version", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// Block for container.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(53, ErrorMessage = "Maximum 53 Container block(s) allowed")]
    [TerraformProperty("container")]
    public TerraformSet<TerraformBlock<AwsLightsailContainerServiceDeploymentVersionContainerBlock>>? Container { get; set; }

    /// <summary>
    /// Block for public_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicEndpoint block(s) allowed")]
    [TerraformProperty("public_endpoint")]
    public TerraformList<TerraformBlock<AwsLightsailContainerServiceDeploymentVersionPublicEndpointBlock>>? PublicEndpoint { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsLightsailContainerServiceDeploymentVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Version { get; }

}
