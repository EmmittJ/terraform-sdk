using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_layer_version Terraform resource.
/// Manages a aws_lambda_layer_version resource.
/// </summary>
public partial class AwsLambdaLayerVersion(string name) : TerraformResource("aws_lambda_layer_version", name)
{
    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    public TerraformSet<string>? CompatibleArchitectures
    {
        get => GetArgument<TerraformSet<string>>("compatible_architectures");
        set => SetArgument("compatible_architectures", value);
    }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public TerraformSet<string>? CompatibleRuntimes
    {
        get => GetArgument<TerraformSet<string>>("compatible_runtimes");
        set => SetArgument("compatible_runtimes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => GetArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformValue<string> LayerName
    {
        get => GetArgument<TerraformValue<string>>("layer_name");
        set => SetArgument("layer_name", value);
    }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformValue<string>? LicenseInfo
    {
        get => GetArgument<TerraformValue<string>>("license_info");
        set => SetArgument("license_info", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? S3Bucket
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformValue<string>? S3Key
    {
        get => GetArgument<TerraformValue<string>>("s3_key");
        set => SetArgument("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("s3_object_version");
        set => SetArgument("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => GetArgument<TerraformValue<bool>>("skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformValue<string>? SourceCodeHash
    {
        get => GetArgument<TerraformValue<string>>("source_code_hash");
        set => SetArgument("source_code_hash", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformValue<string> CodeSha256
        => AsReference("code_sha256");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    public TerraformValue<string> LayerArn
        => AsReference("layer_arn");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningJobArn
        => AsReference("signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningProfileVersionArn
        => AsReference("signing_profile_version_arn");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
        => AsReference("source_code_size");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}
