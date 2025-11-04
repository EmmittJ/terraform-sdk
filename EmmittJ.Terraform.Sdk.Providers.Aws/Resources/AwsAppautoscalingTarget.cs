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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public double? MaxCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_capacity")?.Value;
        set => this.WithProperty("max_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public double? MinCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_capacity")?.Value;
        set => this.WithProperty("min_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
