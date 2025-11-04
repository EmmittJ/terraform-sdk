using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_layer_version resource.
/// </summary>
public class AwsLambdaLayerVersion : TerraformResource
{
    public AwsLambdaLayerVersion(string name) : base("aws_lambda_layer_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("code_sha256");
        this.DeclareOutput("created_date");
        this.DeclareOutput("layer_arn");
        this.DeclareOutput("signing_job_arn");
        this.DeclareOutput("signing_profile_version_arn");
        this.DeclareOutput("source_code_size");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    public HashSet<string>? CompatibleArchitectures
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("compatible_architectures")?.Value;
        set => this.WithProperty("compatible_architectures", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public HashSet<string>? CompatibleRuntimes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("compatible_runtimes")?.Value;
        set => this.WithProperty("compatible_runtimes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The filename attribute.
    /// </summary>
    public string? Filename
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filename")?.Value;
        set => this.WithProperty("filename", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The layer_name attribute.
    /// </summary>
    public string? LayerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("layer_name")?.Value;
        set => this.WithProperty("layer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public string? LicenseInfo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_info")?.Value;
        set => this.WithProperty("license_info", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The s3_object_version attribute.
    /// </summary>
    public string? S3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_object_version")?.Value;
        set => this.WithProperty("s3_object_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public string? SourceCodeHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_code_hash")?.Value;
        set => this.WithProperty("source_code_hash", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformExpression CodeSha256 => this["code_sha256"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    public TerraformExpression LayerArn => this["layer_arn"];

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformExpression SigningJobArn => this["signing_job_arn"];

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformExpression SigningProfileVersionArn => this["signing_profile_version_arn"];

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformExpression SourceCodeSize => this["source_code_size"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
