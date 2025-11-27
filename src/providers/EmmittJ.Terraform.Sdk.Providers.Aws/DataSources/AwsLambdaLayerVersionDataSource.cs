using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_layer_version Terraform data source.
/// Retrieves information about a aws_lambda_layer_version.
/// </summary>
public partial class AwsLambdaLayerVersionDataSource(string name) : TerraformDataSource("aws_lambda_layer_version", name)
{
    /// <summary>
    /// The compatible_architecture attribute.
    /// </summary>
    public TerraformValue<string>? CompatibleArchitecture
    {
        get => new TerraformReference<string>(this, "compatible_architecture");
        set => SetArgument("compatible_architecture", value);
    }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    public TerraformValue<string>? CompatibleRuntime
    {
        get => new TerraformReference<string>(this, "compatible_runtime");
        set => SetArgument("compatible_runtime", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
        set => SetArgument("version", value);
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
    /// The compatible_architectures attribute.
    /// </summary>
    public TerraformSet<string> CompatibleArchitectures
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "compatible_architectures").ResolveNodes(ctx));
    }

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public TerraformSet<string> CompatibleRuntimes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "compatible_runtimes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    public TerraformValue<string> LayerArn
    {
        get => new TerraformReference<string>(this, "layer_arn");
    }

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformValue<string> LicenseInfo
    {
        get => new TerraformReference<string>(this, "license_info");
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
    /// The source_code_hash attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> SourceCodeHash
    {
        get => new TerraformReference<string>(this, "source_code_hash");
    }

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
    {
        get => new TerraformReference<double>(this, "source_code_size");
    }

}
