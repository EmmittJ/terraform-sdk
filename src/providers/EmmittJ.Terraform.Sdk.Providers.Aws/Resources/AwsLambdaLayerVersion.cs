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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "compatible_architectures").ResolveNodes(ctx));
        set => SetArgument("compatible_architectures", value);
    }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public TerraformSet<string>? CompatibleRuntimes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "compatible_runtimes").ResolveNodes(ctx));
        set => SetArgument("compatible_runtimes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    public TerraformValue<string>? Filename
    {
        get => new TerraformReference<string>(this, "filename");
        set => SetArgument("filename", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformValue<string> LayerName
    {
        get => new TerraformReference<string>(this, "layer_name");
        set => SetArgument("layer_name", value);
    }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformValue<string>? LicenseInfo
    {
        get => new TerraformReference<string>(this, "license_info");
        set => SetArgument("license_info", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? S3Bucket
    {
        get => new TerraformReference<string>(this, "s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    public TerraformValue<string>? S3Key
    {
        get => new TerraformReference<string>(this, "s3_key");
        set => SetArgument("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectVersion
    {
        get => new TerraformReference<string>(this, "s3_object_version");
        set => SetArgument("s3_object_version", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformValue<string> SourceCodeHash
    {
        get => new TerraformReference<string>(this, "source_code_hash");
        set => SetArgument("source_code_hash", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformValue<string> CodeSha256
    {
        get => new TerraformReference<string>(this, "code_sha256");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    public TerraformValue<string> LayerArn
    {
        get => new TerraformReference<string>(this, "layer_arn");
    }

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningJobArn
    {
        get => new TerraformReference<string>(this, "signing_job_arn");
    }

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningProfileVersionArn
    {
        get => new TerraformReference<string>(this, "signing_profile_version_arn");
    }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
    {
        get => new TerraformReference<double>(this, "source_code_size");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
