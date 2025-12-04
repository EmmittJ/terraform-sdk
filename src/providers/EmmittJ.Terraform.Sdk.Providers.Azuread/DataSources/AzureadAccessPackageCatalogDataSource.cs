using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAccessPackageCatalogDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageCatalogDataSourceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_access_package_catalog Terraform data source.
/// Retrieves information about a azuread_access_package_catalog.
/// </summary>
public partial class AzureadAccessPackageCatalogDataSource(string name) : TerraformDataSource("azuread_access_package_catalog", name)
{
    /// <summary>
    /// The display name of the access package catalog
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of this access package catalog
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id") ?? AsReference("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    public TerraformValue<bool> ExternallyVisible
        => AsReference("externally_visible");

    /// <summary>
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    public TerraformValue<bool> Published
        => AsReference("published");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAccessPackageCatalogDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAccessPackageCatalogDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
