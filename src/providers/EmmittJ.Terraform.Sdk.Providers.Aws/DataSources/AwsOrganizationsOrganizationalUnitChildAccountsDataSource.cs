using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_organizational_unit_child_accounts Terraform data source.
/// Retrieves information about a aws_organizations_organizational_unit_child_accounts.
/// </summary>
public partial class AwsOrganizationsOrganizationalUnitChildAccountsDataSource(string name) : TerraformDataSource("aws_organizations_organizational_unit_child_accounts", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformValue<string> ParentId
    {
        get => new TerraformReference<string>(this, "parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Accounts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "accounts").ResolveNodes(ctx));
    }

}
