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
        get => new TerraformReference<bool>(this, "latest");
        set => SetArgument("latest", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The deprecation_date attribute.
    /// </summary>
    public TerraformValue<string> DeprecationDate
    {
        get => new TerraformReference<string>(this, "deprecation_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The release_date attribute.
    /// </summary>
    public TerraformValue<string> ReleaseDate
    {
        get => new TerraformReference<string>(this, "release_date");
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformValue<string> VersionName
    {
        get => new TerraformReference<string>(this, "version_name");
    }

}
