using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_caller_identity Terraform data source.
/// Retrieves information about a aws_caller_identity.
/// </summary>
public partial class AwsCallerIdentityDataSource(string name) : TerraformDataSource("aws_caller_identity", name)
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
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
        => AsReference("account_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
        => AsReference("user_id");

}
