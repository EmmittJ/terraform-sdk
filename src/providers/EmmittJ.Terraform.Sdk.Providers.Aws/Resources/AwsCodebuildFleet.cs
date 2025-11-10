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
        get => GetProperty<TerraformProperty<double>>("disk");
        set => WithProperty("disk", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The machine_type attribute.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => WithProperty("machine_type", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<double>? Memory
    {
        get => GetProperty<TerraformProperty<double>>("memory");
        set => WithProperty("memory", value);
    }

    /// <summary>
    /// The vcpu attribute.
    /// </summary>
    public TerraformProperty<double>? Vcpu
    {
        get => GetProperty<TerraformProperty<double>>("vcpu");
        set => WithProperty("vcpu", value);
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
        get => GetProperty<TerraformProperty<double>>("desired_capacity");
        set => WithProperty("desired_capacity", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The scaling_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScalingType
    {
        get => GetProperty<TerraformProperty<string>>("scaling_type");
        set => WithProperty("scaling_type", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
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
        this.WithOutput("arn");
        this.WithOutput("created");
        this.WithOutput("id");
        this.WithOutput("last_modified");
        this.WithOutput("status");
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseCapacity is required")]
    public required TerraformProperty<double> BaseCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("base_capacity");
        set => this.WithProperty("base_capacity", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeType is required")]
    public required TerraformProperty<string> ComputeType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("compute_type");
        set => this.WithProperty("compute_type", value);
    }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentType is required")]
    public required TerraformProperty<string> EnvironmentType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("environment_type");
        set => this.WithProperty("environment_type", value);
    }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformProperty<string>? FleetServiceRole
    {
        get => GetProperty<TerraformProperty<string>>("fleet_service_role");
        set => this.WithProperty("fleet_service_role", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageId
    {
        get => GetProperty<TerraformProperty<string>>("image_id");
        set => this.WithProperty("image_id", value);
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
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? OverflowBehavior
    {
        get => GetProperty<TerraformProperty<string>>("overflow_behavior");
        set => this.WithProperty("overflow_behavior", value);
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
    /// Block for compute_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfiguration block(s) allowed")]
    public List<AwsCodebuildFleetComputeConfigurationBlock>? ComputeConfiguration
    {
        get => GetProperty<List<AwsCodebuildFleetComputeConfigurationBlock>>("compute_configuration");
        set => this.WithProperty("compute_configuration", value);
    }

    /// <summary>
    /// Block for scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfiguration block(s) allowed")]
    public List<AwsCodebuildFleetScalingConfigurationBlock>? ScalingConfiguration
    {
        get => GetProperty<List<AwsCodebuildFleetScalingConfigurationBlock>>("scaling_configuration");
        set => this.WithProperty("scaling_configuration", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodebuildFleetVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsCodebuildFleetVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
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
