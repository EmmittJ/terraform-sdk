using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_instance_profiles Terraform data source.
/// Retrieves information about a aws_iam_instance_profiles.
/// </summary>
public partial class AwsIamInstanceProfilesDataSource(string name) : TerraformDataSource("aws_iam_instance_profiles", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformSet<string> Arns
        => AsReference("arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformSet<string> Names
        => AsReference("names");

    /// <summary>
    /// The paths attribute.
    /// </summary>
    public TerraformSet<string> Paths
        => AsReference("paths");

}
