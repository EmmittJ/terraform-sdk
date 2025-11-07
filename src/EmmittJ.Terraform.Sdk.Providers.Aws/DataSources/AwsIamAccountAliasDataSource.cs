using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_account_alias.
/// </summary>
public class AwsIamAccountAliasDataSource : TerraformDataSource
{
    public AwsIamAccountAliasDataSource(string name) : base("aws_iam_account_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_alias");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    public TerraformExpression AccountAlias => this["account_alias"];

}
