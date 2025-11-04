using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_synthetics_canary resource.
/// </summary>
public class AwsSyntheticsCanary : TerraformResource
{
    public AwsSyntheticsCanary(string name) : base("aws_synthetics_canary", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("engine_arn");
        this.DeclareOutput("source_location_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("timeline");
    }

    /// <summary>
    /// The artifact_s3_location attribute.
    /// </summary>
    public string? ArtifactS3Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("artifact_s3_location")?.Value;
        set => this.WithProperty("artifact_s3_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    public bool? DeleteLambda
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_lambda")?.Value;
        set => this.WithProperty("delete_lambda", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public string? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn")?.Value;
        set => this.WithProperty("execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    public double? FailureRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("failure_retention_period")?.Value;
        set => this.WithProperty("failure_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public string? Handler
    {
        get => GetProperty<TerraformLiteralProperty<string>>("handler")?.Value;
        set => this.WithProperty("handler", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The runtime_version attribute.
    /// </summary>
    public string? RuntimeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_version")?.Value;
        set => this.WithProperty("runtime_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public string? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket")?.Value;
        set => this.WithProperty("s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public string? S3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key")?.Value;
        set => this.WithProperty("s3_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    public string? S3Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_version")?.Value;
        set => this.WithProperty("s3_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    public bool? StartCanary
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_canary")?.Value;
        set => this.WithProperty("start_canary", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    public double? SuccessRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("success_retention_period")?.Value;
        set => this.WithProperty("success_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The zip_file attribute.
    /// </summary>
    public string? ZipFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zip_file")?.Value;
        set => this.WithProperty("zip_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The engine_arn attribute.
    /// </summary>
    public TerraformExpression EngineArn => this["engine_arn"];

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    public TerraformExpression SourceLocationArn => this["source_location_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The timeline attribute.
    /// </summary>
    public TerraformExpression Timeline => this["timeline"];

}
