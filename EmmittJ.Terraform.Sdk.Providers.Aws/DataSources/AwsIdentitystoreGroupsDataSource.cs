using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_identitystore_groups.
/// </summary>
public class AwsIdentitystoreGroupsDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupsDataSource(string name) : base("aws_identitystore_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("groups");
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
    /// The groups attribute.
    /// </summary>
    public TerraformExpression Groups => this["groups"];

}
