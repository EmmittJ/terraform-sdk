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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public string? PolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type")?.Value;
        set => this.WithProperty("policy_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scalable_dimension attribute.
    /// </summary>
    public string? ScalableDimension
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scalable_dimension")?.Value;
        set => this.WithProperty("scalable_dimension", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_namespace attribute.
    /// </summary>
    public string? ServiceNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_namespace")?.Value;
        set => this.WithProperty("service_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
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
