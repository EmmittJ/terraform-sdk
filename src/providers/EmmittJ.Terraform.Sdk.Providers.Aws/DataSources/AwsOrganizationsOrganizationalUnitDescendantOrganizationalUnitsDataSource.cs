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
        this.WithOutput("children");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The children attribute.
    /// </summary>
    public TerraformExpression Children => this["children"];

}
