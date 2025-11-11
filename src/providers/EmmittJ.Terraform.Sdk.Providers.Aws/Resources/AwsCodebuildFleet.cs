using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetComputeConfigurationBlock
{
    /// <summary>
    /// The disk attribute.
    /// </summary>
    [TerraformPropertyName("disk")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Disk { get; set; } = default!;

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceType { get; set; } = default!;

    /// <summary>
    /// The machine_type attribute.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MachineType { get; set; } = default!;

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Memory { get; set; } = default!;

    /// <summary>
    /// The vcpu attribute.
    /// </summary>
    [TerraformPropertyName("vcpu")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Vcpu { get; set; } = default!;

}

/// <summary>
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetScalingConfigurationBlock
{

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The scaling_type attribute.
    /// </summary>
    [TerraformPropertyName("scaling_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScalingType { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetVpcConfigBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_codebuild_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodebuildFleet : TerraformResource
{
    public AwsCodebuildFleet(string name) : base("aws_codebuild_fleet", name)
    {
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseCapacity is required")]
    [TerraformPropertyName("base_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> BaseCapacity { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    [TerraformPropertyName("compute_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ComputeType { get; set; }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentType is required")]
    [TerraformPropertyName("environment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EnvironmentType { get; set; }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    [TerraformPropertyName("fleet_service_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FleetServiceRole { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    [TerraformPropertyName("overflow_behavior")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OverflowBehavior { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for compute_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfiguration block(s) allowed")]
    [TerraformPropertyName("compute_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetComputeConfigurationBlock>>? ComputeConfiguration { get; set; }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("scaling_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetScalingConfigurationBlock>>? ScalingConfiguration { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Created => new TerraformReference(this, "created");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Status => new TerraformReference(this, "status");

}
