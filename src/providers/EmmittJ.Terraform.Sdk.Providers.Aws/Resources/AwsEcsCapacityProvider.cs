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
        set => SetProperty("auto_scaling_group_arn", value);
    }

    /// <summary>
    /// The managed_draining attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedDraining
    {
        set => SetProperty("managed_draining", value);
    }

    /// <summary>
    /// The managed_termination_protection attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedTerminationProtection
    {
        set => SetProperty("managed_termination_protection", value);
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
        set => SetProperty("infrastructure_role_arn", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        set => SetProperty("propagate_tags", value);
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
        SetOutput("arn");
        SetOutput("cluster");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
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
    /// Block for auto_scaling_group_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingGroupProvider block(s) allowed")]
    public List<AwsEcsCapacityProviderAutoScalingGroupProviderBlock>? AutoScalingGroupProvider
    {
        set => SetProperty("auto_scaling_group_provider", value);
    }

    /// <summary>
    /// Block for managed_instances_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedInstancesProvider block(s) allowed")]
    public List<AwsEcsCapacityProviderManagedInstancesProviderBlock>? ManagedInstancesProvider
    {
        set => SetProperty("managed_instances_provider", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
