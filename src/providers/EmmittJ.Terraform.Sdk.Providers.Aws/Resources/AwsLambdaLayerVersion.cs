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
        SetOutput("arn");
        SetOutput("code_sha256");
        SetOutput("created_date");
        SetOutput("layer_arn");
        SetOutput("signing_job_arn");
        SetOutput("signing_profile_version_arn");
        SetOutput("source_code_size");
        SetOutput("version");
        SetOutput("compatible_architectures");
        SetOutput("compatible_runtimes");
        SetOutput("description");
        SetOutput("filename");
        SetOutput("id");
        SetOutput("layer_name");
        SetOutput("license_info");
        SetOutput("region");
        SetOutput("s3_bucket");
        SetOutput("s3_key");
        SetOutput("s3_object_version");
        SetOutput("skip_destroy");
        SetOutput("source_code_hash");
    }

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CompatibleArchitectures
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("compatible_architectures");
        set => SetProperty("compatible_architectures", value);
    }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CompatibleRuntimes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("compatible_runtimes");
        set => SetProperty("compatible_runtimes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformProperty<string> Filename
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filename");
        set => SetProperty("filename", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformProperty<string> LayerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("layer_name");
        set => SetProperty("layer_name", value);
    }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformProperty<string> LicenseInfo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_info");
        set => SetProperty("license_info", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string> S3Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket");
        set => SetProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformProperty<string> S3Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_key");
        set => SetProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string> S3ObjectVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_object_version");
        set => SetProperty("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformProperty<string> SourceCodeHash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_code_hash");
        set => SetProperty("source_code_hash", value);
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
