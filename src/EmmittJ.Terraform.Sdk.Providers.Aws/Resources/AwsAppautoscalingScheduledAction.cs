using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appautoscaling_scheduled_action resource.
/// </summary>
public class AwsAppautoscalingScheduledAction : TerraformResource
{
    public AwsAppautoscalingScheduledAction(string name) : base("aws_appautoscaling_scheduled_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public string? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time")?.Value;
        set => this.WithProperty("end_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The schedule attribute.
    /// </summary>
    public string? Schedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule")?.Value;
        set => this.WithProperty("schedule", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The start_time attribute.
    /// </summary>
    public string? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time")?.Value;
        set => this.WithProperty("start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public string? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone")?.Value;
        set => this.WithProperty("timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
