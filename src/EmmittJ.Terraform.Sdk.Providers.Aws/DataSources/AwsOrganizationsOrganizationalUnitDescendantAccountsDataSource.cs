using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organizational_unit_descendant_accounts.
/// </summary>
public class AwsOrganizationsOrganizationalUnitDescendantAccountsDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationalUnitDescendantAccountsDataSource(string name) : base("aws_organizations_organizational_unit_descendant_accounts", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accounts");
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
    /// The parent_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformExpression Accounts => this["accounts"];

}
