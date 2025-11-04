using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_ml_transform resource.
/// </summary>
public class AwsGlueMlTransform : TerraformResource
{
    public AwsGlueMlTransform(string name) : base("aws_glue_ml_transform", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("label_count");
        this.DeclareOutput("schema");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    public string? GlueVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("glue_version")?.Value;
        set => this.WithProperty("glue_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_retries attribute.
    /// </summary>
    public double? MaxRetries
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_retries")?.Value;
        set => this.WithProperty("max_retries", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The number_of_workers attribute.
    /// </summary>
    public double? NumberOfWorkers
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_workers")?.Value;
        set => this.WithProperty("number_of_workers", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The timeout attribute.
    /// </summary>
    public double? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public string? WorkerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("worker_type")?.Value;
        set => this.WithProperty("worker_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The label_count attribute.
    /// </summary>
    public TerraformExpression LabelCount => this["label_count"];

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformExpression Schema => this["schema"];

}
