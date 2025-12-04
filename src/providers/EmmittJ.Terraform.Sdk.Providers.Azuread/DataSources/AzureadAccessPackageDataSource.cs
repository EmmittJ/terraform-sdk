using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAccessPackageDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_access_package Terraform data source.
/// Retrieves information about a azuread_access_package.
/// </summary>
public partial class AzureadAccessPackageDataSource(string name) : TerraformDataSource("azuread_access_package", name)
{
    /// <summary>
    /// The ID of the Catalog this access package is in
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The display name of the access package
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
    /// The ID of this access package
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id") ?? AsReference("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The description of the access package
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    public TerraformValue<bool> Hidden
        => AsReference("hidden");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAccessPackageDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAccessPackageDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
