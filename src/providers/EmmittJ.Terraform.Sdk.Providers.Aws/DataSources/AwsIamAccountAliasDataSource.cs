using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_account_alias.
/// </summary>
public partial class AwsIamAccountAliasDataSource : TerraformDataSource
{
    public AwsIamAccountAliasDataSource(string name) : base("aws_iam_account_alias", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [TerraformProperty("account_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccountAlias { get; }

}
