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
    public TerraformProperty<string>? IdentityStoreId
    {
        get => GetProperty<TerraformProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformExpression Users => this["users"];

}
