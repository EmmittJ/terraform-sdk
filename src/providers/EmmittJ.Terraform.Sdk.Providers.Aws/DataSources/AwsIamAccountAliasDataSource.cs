using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_account_alias.
/// </summary>
public class AwsIamAccountAliasDataSource : TerraformDataSource
{
    public AwsIamAccountAliasDataSource(string name) : base("aws_iam_account_alias", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [TerraformPropertyName("account_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccountAlias => new TerraformReference(this, "account_alias");

}
