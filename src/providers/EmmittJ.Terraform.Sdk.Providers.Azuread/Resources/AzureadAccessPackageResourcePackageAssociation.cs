using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadAccessPackageResourcePackageAssociation.
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageResourcePackageAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_access_package_resource_package_association Terraform resource.
/// Manages a azuread_access_package_resource_package_association resource.
/// </summary>
public partial class AzureadAccessPackageResourcePackageAssociation(string name) : TerraformResource("azuread_access_package_resource_package_association", name)
{
    /// <summary>
    /// The ID of access package this resource association is configured to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPackageId is required")]
    public required TerraformValue<string> AccessPackageId
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_package_id");
        set => SetArgument("access_package_id", value);
    }

    /// <summary>
    /// The role of access type to the specified resource, valid values are `Member` and `Owner`
    /// </summary>
    public TerraformValue<string>? AccessType
    {
        get => GetArgument<TerraformValue<string>>("access_type");
        set => SetArgument("access_type", value);
    }

    /// <summary>
    /// The ID of the access package catalog association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogResourceAssociationId is required")]
    public required TerraformValue<string> CatalogResourceAssociationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("catalog_resource_association_id");
        set => SetArgument("catalog_resource_association_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadAccessPackageResourcePackageAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadAccessPackageResourcePackageAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
