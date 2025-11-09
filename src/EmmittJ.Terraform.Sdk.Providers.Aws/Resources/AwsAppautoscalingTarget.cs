using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appautoscaling_target resource.
/// </summary>
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
    public TerraformProperty<double>? MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => this.WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity");
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
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
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
    public TerraformProperty<string>? ScalableDimension
    {
        get => GetProperty<TerraformProperty<string>>("scalable_dimension");
        set => this.WithProperty("scalable_dimension", value);
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceNamespace
    {
        get => GetProperty<TerraformProperty<string>>("service_namespace");
        set => this.WithProperty("service_namespace", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
