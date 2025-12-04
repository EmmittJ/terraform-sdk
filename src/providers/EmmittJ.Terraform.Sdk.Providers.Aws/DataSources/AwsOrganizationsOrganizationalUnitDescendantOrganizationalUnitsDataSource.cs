using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_organizational_unit_descendant_organizational_units Terraform data source.
/// Retrieves information about a aws_organizations_organizational_unit_descendant_organizational_units.
/// </summary>
public partial class AwsOrganizationsOrganizationalUnitDescendantOrganizationalUnitsDataSource(string name) : TerraformDataSource("aws_organizations_organizational_unit_descendant_organizational_units", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformValue<string> ParentId
    {
        get => GetArgument<TerraformValue<string>>("parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The children attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Children
        => AsReference("children");

}
