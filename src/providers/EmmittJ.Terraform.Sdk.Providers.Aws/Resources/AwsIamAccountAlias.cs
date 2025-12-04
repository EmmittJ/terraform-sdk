using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_account_alias Terraform resource.
/// Manages a aws_iam_account_alias resource.
/// </summary>
public partial class AwsIamAccountAlias(string name) : TerraformResource("aws_iam_account_alias", name)
{
    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAlias is required")]
    public required TerraformValue<string> AccountAlias
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_alias");
        set => SetArgument("account_alias", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

}
