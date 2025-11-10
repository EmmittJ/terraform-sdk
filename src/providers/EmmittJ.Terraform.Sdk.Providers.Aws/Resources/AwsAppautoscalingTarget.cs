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
        set => SetProperty("dynamic_scaling_in_suspended", value);
    }

    /// <summary>
    /// The dynamic_scaling_out_suspended attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicScalingOutSuspended
    {
        set => SetProperty("dynamic_scaling_out_suspended", value);
    }

    /// <summary>
    /// The scheduled_scaling_suspended attribute.
    /// </summary>
    public TerraformProperty<bool>? ScheduledScalingSuspended
    {
        set => SetProperty("scheduled_scaling_suspended", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("max_capacity");
        SetOutput("min_capacity");
        SetOutput("region");
        SetOutput("resource_id");
        SetOutput("role_arn");
        SetOutput("scalable_dimension");
        SetOutput("service_namespace");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_capacity");
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_capacity");
        set => SetProperty("min_capacity", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalableDimension is required")]
    public required TerraformProperty<string> ScalableDimension
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scalable_dimension");
        set => SetProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_namespace");
        set => SetProperty("service_namespace", value);
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
    /// Block for suspended_state.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuspendedState block(s) allowed")]
    public List<AwsAppautoscalingTargetSuspendedStateBlock>? SuspendedState
    {
        set => SetProperty("suspended_state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
