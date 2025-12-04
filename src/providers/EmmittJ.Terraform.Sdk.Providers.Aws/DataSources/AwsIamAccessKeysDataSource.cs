using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_access_keys Terraform data source.
/// Retrieves information about a aws_iam_access_keys.
/// </summary>
public partial class AwsIamAccessKeysDataSource(string name) : TerraformDataSource("aws_iam_access_keys", name)
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
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => GetArgument<TerraformValue<string>>("user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The access_keys attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> AccessKeys
        => AsReference("access_keys");

}
