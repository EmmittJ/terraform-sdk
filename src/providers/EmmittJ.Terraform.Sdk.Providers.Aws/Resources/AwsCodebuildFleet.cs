using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetComputeConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The disk attribute.
    /// </summary>
    [TerraformPropertyName("disk")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Disk { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "instance_type");

    /// <summary>
    /// The machine_type attribute.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MachineType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "machine_type");

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Memory { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "memory");

    /// <summary>
    /// The vcpu attribute.
    /// </summary>
    [TerraformPropertyName("vcpu")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Vcpu { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "vcpu");

}

/// <summary>
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetScalingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    [TerraformPropertyName("desired_capacity")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DesiredCapacity => new TerraformReferenceProperty<TerraformProperty<double>>("", "desired_capacity");

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxCapacity { get; set; }

    /// <summary>
    /// The scaling_type attribute.
    /// </summary>
    [TerraformPropertyName("scaling_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScalingType { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Subnets { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

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
    public required TerraformProperty<TerraformProperty<double>> BaseCapacity { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    [TerraformPropertyName("compute_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComputeType { get; set; }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentType is required")]
    [TerraformPropertyName("environment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnvironmentType { get; set; }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    [TerraformPropertyName("fleet_service_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FleetServiceRole { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    [TerraformPropertyName("overflow_behavior")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OverflowBehavior { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "overflow_behavior");

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
    /// Block for compute_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfiguration block(s) allowed")]
    [TerraformPropertyName("compute_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetComputeConfigurationBlock>>? ComputeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("scaling_configuration")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetScalingConfigurationBlock>>? ScalingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsCodebuildFleetVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Created => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Status => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "status");

}
