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
    public TerraformLiteralProperty<HashSet<string>>? CompatibleArchitectures
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("compatible_architectures");
        set => this.WithProperty("compatible_architectures", value);
    }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CompatibleRuntimes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("compatible_runtimes");
        set => this.WithProperty("compatible_runtimes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Filename
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filename");
        set => this.WithProperty("filename", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LayerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("layer_name");
        set => this.WithProperty("layer_name", value);
    }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseInfo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_info");
        set => this.WithProperty("license_info", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket");
        set => this.WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key");
        set => this.WithProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3ObjectVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_object_version");
        set => this.WithProperty("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceCodeHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_code_hash");
        set => this.WithProperty("source_code_hash", value);
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
