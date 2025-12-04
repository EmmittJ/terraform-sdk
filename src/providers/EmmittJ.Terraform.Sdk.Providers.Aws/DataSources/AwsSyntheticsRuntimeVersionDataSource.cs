using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_synthetics_runtime_version Terraform data source.
/// Retrieves information about a aws_synthetics_runtime_version.
/// </summary>
public partial class AwsSyntheticsRuntimeVersionDataSource(string name) : TerraformDataSource("aws_synthetics_runtime_version", name)
{
    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool>? Latest
    {
        get => GetArgument<TerraformValue<bool>>("latest");
        set => SetArgument("latest", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The deprecation_date attribute.
    /// </summary>
    public TerraformValue<string> DeprecationDate
        => AsReference("deprecation_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The release_date attribute.
    /// </summary>
    public TerraformValue<string> ReleaseDate
        => AsReference("release_date");

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformValue<string> VersionName
        => AsReference("version_name");

}
