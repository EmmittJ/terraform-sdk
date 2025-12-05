using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAccessPackageResourceCatalogAssociation.
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azuread_access_package_resource_catalog_association Terraform resource.
/// Manages a azuread_access_package_resource_catalog_association resource.
/// </summary>
public partial class AzureadAccessPackageResourceCatalogAssociation(string name) : TerraformResource("azuread_access_package_resource_catalog_association", name)
{
    /// <summary>
    /// The unique ID of the access package catalog
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformValue<string> CatalogId
    {
        get => GetRequiredArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginId is required")]
    public required TerraformValue<string> ResourceOriginId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_origin_id");
        set => SetArgument("resource_origin_id", value);
    }

    /// <summary>
    /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOriginSystem is required")]
    public required TerraformValue<string> ResourceOriginSystem
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_origin_system");
        set => SetArgument("resource_origin_system", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAccessPackageResourceCatalogAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
