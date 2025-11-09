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
    public TerraformProperty<string>? ArtifactS3Location
    {
        get => GetProperty<TerraformProperty<string>>("artifact_s3_location");
        set => this.WithProperty("artifact_s3_location", value);
    }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteLambda
    {
        get => GetProperty<TerraformProperty<bool>>("delete_lambda");
        set => this.WithProperty("delete_lambda", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? FailureRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("failure_retention_period");
        set => this.WithProperty("failure_retention_period", value);
    }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    public TerraformProperty<string>? Handler
    {
        get => GetProperty<TerraformProperty<string>>("handler");
        set => this.WithProperty("handler", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => this.WithProperty("runtime_version", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformProperty<string>? S3Key
    {
        get => GetProperty<TerraformProperty<string>>("s3_key");
        set => this.WithProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    public TerraformProperty<string>? S3Version
    {
        get => GetProperty<TerraformProperty<string>>("s3_version");
        set => this.WithProperty("s3_version", value);
    }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    public TerraformProperty<bool>? StartCanary
    {
        get => GetProperty<TerraformProperty<bool>>("start_canary");
        set => this.WithProperty("start_canary", value);
    }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? SuccessRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("success_retention_period");
        set => this.WithProperty("success_retention_period", value);
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
    /// The zip_file attribute.
    /// </summary>
    public TerraformProperty<string>? ZipFile
    {
        get => GetProperty<TerraformProperty<string>>("zip_file");
        set => this.WithProperty("zip_file", value);
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
