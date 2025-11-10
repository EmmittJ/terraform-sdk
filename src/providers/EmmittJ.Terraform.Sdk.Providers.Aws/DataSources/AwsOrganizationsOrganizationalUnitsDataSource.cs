using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organizational_units.
/// </summary>
public class AwsOrganizationsOrganizationalUnitsDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationalUnitsDataSource(string name) : base("aws_organizations_organizational_units", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("children");
        SetOutput("id");
        SetOutput("parent_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_id");
        set => SetProperty("parent_id", value);
    }

    /// <summary>
    /// The children attribute.
    /// </summary>
    public TerraformExpression Children => this["children"];

}
