using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for suspended_state in .
/// Nesting mode: list
/// </summary>
public class AwsAppautoscalingTargetSuspendedStateBlock : TerraformBlock
{
    /// <summary>
    /// The dynamic_scaling_in_suspended attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicScalingInSuspended
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_scaling_in_suspended");
        set => WithProperty("dynamic_scaling_in_suspended", value);
    }

    /// <summary>
    /// The dynamic_scaling_out_suspended attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicScalingOutSuspended
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_scaling_out_suspended");
        set => WithProperty("dynamic_scaling_out_suspended", value);
    }

    /// <summary>
    /// The scheduled_scaling_suspended attribute.
    /// </summary>
    public TerraformProperty<bool>? ScheduledScalingSuspended
    {
        get => GetProperty<TerraformProperty<bool>>("scheduled_scaling_suspended");
        set => WithProperty("scheduled_scaling_suspended", value);
    }

}

/// <summary>
/// Manages a aws_appautoscaling_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppautoscalingTarget : TerraformResource
{
    public AwsAppautoscalingTarget(string name) : base("aws_appautoscaling_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_capacity");
        set => this.WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_capacity");
        set => this.WithProperty("min_capacity", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scalable_dimension");
        set => this.WithProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_namespace");
        set => this.WithProperty("service_namespace", value);
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
    /// Block for suspended_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuspendedState block(s) allowed")]
    public List<AwsAppautoscalingTargetSuspendedStateBlock>? SuspendedState
    {
        get => GetProperty<List<AwsAppautoscalingTargetSuspendedStateBlock>>("suspended_state");
        set => this.WithProperty("suspended_state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
