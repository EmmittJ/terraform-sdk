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
    public TerraformProperty<string>? AccountAlias
    {
        get => GetProperty<TerraformProperty<string>>("account_alias");
        set => this.WithProperty("account_alias", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
