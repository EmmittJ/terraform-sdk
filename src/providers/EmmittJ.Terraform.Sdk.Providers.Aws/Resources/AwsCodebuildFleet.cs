using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildFleetComputeConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The disk attribute.
    /// </summary>
    [TerraformProperty("disk")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Disk { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The machine_type attribute.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Memory { get; set; }

    /// <summary>
    /// The vcpu attribute.
    /// </summary>
    [TerraformProperty("vcpu")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Vcpu { get; set; }

}

/// <summary>
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildFleetScalingConfigurationBlock : TerraformBlockBase
{

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformProperty("max_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The scaling_type attribute.
    /// </summary>
    [TerraformProperty("scaling_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScalingType { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodebuildFleetVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_codebuild_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodebuildFleet : TerraformResource
{
    public AwsCodebuildFleet(string name) : base("aws_codebuild_fleet", name)
    {
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseCapacity is required")]
    [TerraformProperty("base_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BaseCapacity { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    [TerraformProperty("compute_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComputeType { get; set; }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentType is required")]
    [TerraformProperty("environment_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EnvironmentType { get; set; }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    [TerraformProperty("fleet_service_role")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FleetServiceRole { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    [TerraformProperty("overflow_behavior")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OverflowBehavior { get; set; }

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
    /// Block for compute_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfiguration block(s) allowed")]
    [TerraformProperty("compute_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetComputeConfigurationBlock>>? ComputeConfiguration { get; set; }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    [TerraformProperty("scaling_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetScalingConfigurationBlock>>? ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("vpc_config")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformProperty("created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Created { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Status { get; }

}
