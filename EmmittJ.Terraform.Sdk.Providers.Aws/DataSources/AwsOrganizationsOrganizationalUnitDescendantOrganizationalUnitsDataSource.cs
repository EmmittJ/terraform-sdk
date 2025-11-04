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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public string? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id")?.Value;
        set => this.WithProperty("parent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The children attribute.
    /// </summary>
    public TerraformExpression Children => this["children"];

}
