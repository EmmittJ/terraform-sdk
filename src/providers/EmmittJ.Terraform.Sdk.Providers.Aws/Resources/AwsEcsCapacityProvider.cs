using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_group_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderAutoScalingGroupProviderBlock : TerraformBlock
{
    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingGroupArn is required")]
    public required TerraformProperty<string> AutoScalingGroupArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("auto_scaling_group_arn");
        set => WithProperty("auto_scaling_group_arn", value);
    }

    /// <summary>
    /// The managed_draining attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDraining
    {
        get => GetProperty<TerraformProperty<string>>("managed_draining");
        set => WithProperty("managed_draining", value);
    }

    /// <summary>
    /// The managed_termination_protection attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedTerminationProtection
    {
        get => GetProperty<TerraformProperty<string>>("managed_termination_protection");
        set => WithProperty("managed_termination_protection", value);
    }

}

/// <summary>
/// Block type for managed_instances_provider in .
/// Nesting mode: list
/// </summary>
public class AwsEcsCapacityProviderManagedInstancesProviderBlock : TerraformBlock
{
    /// <summary>
    /// The infrastructure_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureRoleArn is required")]
    public required TerraformProperty<string> InfrastructureRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("infrastructure_role_arn");
        set => WithProperty("infrastructure_role_arn", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformProperty<string>>("propagate_tags");
        set => WithProperty("propagate_tags", value);
    }

}

/// <summary>
/// Manages a aws_ecs_capacity_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsCapacityProvider : TerraformResource
{
    public AwsEcsCapacityProvider(string name) : base("aws_ecs_capacity_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// Block for auto_scaling_group_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingGroupProvider block(s) allowed")]
    public List<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>? AutoScalingGroupProvider
    {
        get => GetProperty<List<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>>("auto_scaling_group_provider");
        set => this.WithProperty("auto_scaling_group_provider", value);
    }

    /// <summary>
    /// Block for managed_instances_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstancesProvider block(s) allowed")]
    public List<AwsEcsCapacityProviderManagedInstancesProviderBlock>? ManagedInstancesProvider
    {
        get => GetProperty<List<AwsEcsCapacityProviderManagedInstancesProviderBlock>>("managed_instances_provider");
        set => this.WithProperty("managed_instances_provider", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
