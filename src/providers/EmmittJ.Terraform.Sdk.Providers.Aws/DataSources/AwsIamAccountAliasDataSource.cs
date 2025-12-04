using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_account_alias Terraform data source.
/// Retrieves information about a aws_iam_account_alias.
/// </summary>
public partial class AwsIamAccountAliasDataSource(string name) : TerraformDataSource("aws_iam_account_alias", name)
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
    /// The account_alias attribute.
    /// </summary>
    public TerraformValue<string> AccountAlias
        => AsReference("account_alias");

}
