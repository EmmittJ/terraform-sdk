using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_instance_profile Terraform data source.
/// Retrieves information about a aws_iam_instance_profile.
/// </summary>
public partial class AwsIamInstanceProfileDataSource(string name) : TerraformDataSource("aws_iam_instance_profile", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => CreateReference("create_date");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => CreateReference("path");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    public TerraformValue<string> RoleId
        => CreateReference("role_id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string> RoleName
        => CreateReference("role_name");

}
