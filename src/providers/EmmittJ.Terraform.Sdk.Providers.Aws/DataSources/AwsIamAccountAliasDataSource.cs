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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [TerraformPropertyName("account_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccountAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_alias");

}
