using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAccessPackageCatalogRoleDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_access_package_catalog_role Terraform data source.
/// Retrieves information about a azuread_access_package_catalog_role.
/// </summary>
public partial class AzureadAccessPackageCatalogRoleDataSource(string name) : TerraformDataSource("azuread_access_package_catalog_role", name)
{
    /// <summary>
    /// The display name of the catalog role
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object ID of the catalog role
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The description of the catalog role
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The object ID of the template associated with the catalog role
    /// </summary>
    public TerraformValue<string> TemplateId
    {
        get => new TerraformReference<string>(this, "template_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAccessPackageCatalogRoleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
