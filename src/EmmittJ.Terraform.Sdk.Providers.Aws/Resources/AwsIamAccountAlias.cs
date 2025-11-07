using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_alias resource.
/// </summary>
public class AwsIamAccountAlias : TerraformResource
{
    public AwsIamAccountAlias(string name) : base("aws_iam_account_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountAlias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_alias");
        set => this.WithProperty("account_alias", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
