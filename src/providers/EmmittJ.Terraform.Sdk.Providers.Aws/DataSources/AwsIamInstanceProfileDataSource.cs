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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => AsReference("create_date");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The role_id attribute.
    /// </summary>
    public TerraformValue<string> RoleId
        => AsReference("role_id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string> RoleName
        => AsReference("role_name");

}
