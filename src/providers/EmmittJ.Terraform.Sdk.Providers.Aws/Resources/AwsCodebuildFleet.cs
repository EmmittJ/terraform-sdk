using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetComputeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformProperty<double>? Disk
    {
        set => SetProperty("disk", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The machine_type attribute.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        set => SetProperty("machine_type", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<double>? Memory
    {
        set => SetProperty("memory", value);
    }

    /// <summary>
    /// The vcpu attribute.
    /// </summary>
    public TerraformProperty<double>? Vcpu
    {
        set => SetProperty("vcpu", value);
    }

}

/// <summary>
/// Block type for scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The desired_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCapacity
    {
        set => SetProperty("desired_capacity", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The scaling_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScalingType
    {
        set => SetProperty("scaling_type", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsCodebuildFleetVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        set => SetProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_codebuild_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodebuildFleet : TerraformResource
{
    public AwsCodebuildFleet(string name) : base("aws_codebuild_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created");
        SetOutput("id");
        SetOutput("last_modified");
        SetOutput("status");
        SetOutput("base_capacity");
        SetOutput("compute_type");
        SetOutput("environment_type");
        SetOutput("fleet_service_role");
        SetOutput("image_id");
        SetOutput("name");
        SetOutput("overflow_behavior");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseCapacity is required")]
    public required TerraformProperty<double> BaseCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("base_capacity");
        set => SetProperty("base_capacity", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformProperty<string> ComputeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_type");
        set => SetProperty("compute_type", value);
    }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentType is required")]
    public required TerraformProperty<string> EnvironmentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_type");
        set => SetProperty("environment_type", value);
    }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformProperty<string> FleetServiceRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_service_role");
        set => SetProperty("fleet_service_role", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string> ImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_id");
        set => SetProperty("image_id", value);
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
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformProperty<string> OverflowBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("overflow_behavior");
        set => SetProperty("overflow_behavior", value);
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
    /// Block for compute_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfiguration block(s) allowed")]
    public List<AwsCodebuildFleetComputeConfigurationBlock>? ComputeConfiguration
    {
        set => SetProperty("compute_configuration", value);
    }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    public List<AwsCodebuildFleetScalingConfigurationBlock>? ScalingConfiguration
    {
        set => SetProperty("scaling_configuration", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodebuildFleetVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformExpression Created => this["created"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
