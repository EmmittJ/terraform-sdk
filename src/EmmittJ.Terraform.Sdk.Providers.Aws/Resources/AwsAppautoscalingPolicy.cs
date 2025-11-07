using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appautoscaling_policy resource.
/// </summary>
public class AwsAppautoscalingPolicy : TerraformResource
{
    public AwsAppautoscalingPolicy(string name) : base("aws_appautoscaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alarm_arns");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        get => GetProperty<TerraformProperty<string>>("policy_type");
        set => this.WithProperty("policy_type", value);
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
    /// The alarm_arns attribute.
    /// </summary>
    public TerraformExpression AlarmArns => this["alarm_arns"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
