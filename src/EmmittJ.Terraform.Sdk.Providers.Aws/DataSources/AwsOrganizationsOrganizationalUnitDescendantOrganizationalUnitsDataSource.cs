using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organizational_unit_descendant_organizational_units.
/// </summary>
public class AwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsDataSource(string name) : base("aws_organizations_organizational_unit_descendant_organizational_units", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("children");
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
    /// The children attribute.
    /// </summary>
    public TerraformExpression Children => this["children"];

}
