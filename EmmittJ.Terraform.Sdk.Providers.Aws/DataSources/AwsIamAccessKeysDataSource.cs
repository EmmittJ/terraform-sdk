using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_access_keys.
/// </summary>
public class AwsIamAccessKeysDataSource : TerraformDataSource
{
    public AwsIamAccessKeysDataSource(string name) : base("aws_iam_access_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_keys");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public string? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user")?.Value;
        set => this.WithProperty("user", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access_keys attribute.
    /// </summary>
    public TerraformExpression AccessKeys => this["access_keys"];

}
