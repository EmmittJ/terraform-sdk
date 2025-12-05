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
        get => GetArgument<TerraformValue<string>>("compatible_architecture");
        set => SetArgument("compatible_architecture", value);
    }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    public TerraformValue<string>? CompatibleRuntime
    {
        get => GetArgument<TerraformValue<string>>("compatible_runtime");
        set => SetArgument("compatible_runtime", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformValue<string> LayerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("layer_name");
        set => SetArgument("layer_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => GetArgument<TerraformValue<double>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformValue<string> CodeSha256
        => CreateReference("code_sha256");

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    public TerraformSet<string> CompatibleArchitectures
        => CreateReference("compatible_architectures");

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public TerraformSet<string> CompatibleRuntimes
        => CreateReference("compatible_runtimes");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => CreateReference("created_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    public TerraformValue<string> LayerArn
        => CreateReference("layer_arn");

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformValue<string> LicenseInfo
        => CreateReference("license_info");

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningJobArn
        => CreateReference("signing_job_arn");

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformValue<string> SigningProfileVersionArn
        => CreateReference("signing_profile_version_arn");

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> SourceCodeHash
        => CreateReference("source_code_hash");

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformValue<double> SourceCodeSize
        => CreateReference("source_code_size");

}
