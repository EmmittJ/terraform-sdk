using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_users.
/// </summary>
public class AwsIdentitystoreUsersDataSource : TerraformDataSource
{
    public AwsIdentitystoreUsersDataSource(string name) : base("aws_identitystore_users", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("users");
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    public string? IdentityStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_store_id")?.Value;
        set => this.WithProperty("identity_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformExpression Users => this["users"];

}
