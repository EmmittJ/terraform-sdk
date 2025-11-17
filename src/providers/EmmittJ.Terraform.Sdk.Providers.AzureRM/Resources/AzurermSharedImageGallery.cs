using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sharing in AzurermSharedImageGallery.
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageGallerySharingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sharing";

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformValue<string> Permission
    {
        get => new TerraformReference<string>(this, "permission");
        set => SetArgument("permission", value);
    }

    /// <summary>
    /// CommunityGallery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommunityGallery block(s) allowed")]
    public TerraformList<AzurermSharedImageGallerySharingBlockCommunityGalleryBlock>? CommunityGallery
    {
        get => GetArgument<TerraformList<AzurermSharedImageGallerySharingBlockCommunityGalleryBlock>>("community_gallery");
        set => SetArgument("community_gallery", value);
    }

}

/// <summary>
/// Block type for community_gallery in AzurermSharedImageGallerySharingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSharedImageGallerySharingBlockCommunityGalleryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "community_gallery";

    /// <summary>
    /// The eula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Eula is required")]
    public required TerraformValue<string> Eula
    {
        get => new TerraformReference<string>(this, "eula");
        set => SetArgument("eula", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherEmail is required")]
    public required TerraformValue<string> PublisherEmail
    {
        get => new TerraformReference<string>(this, "publisher_email");
        set => SetArgument("publisher_email", value);
    }

    /// <summary>
    /// The publisher_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublisherUri is required")]
    public required TerraformValue<string> PublisherUri
    {
        get => new TerraformReference<string>(this, "publisher_uri");
        set => SetArgument("publisher_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSharedImageGallery.
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageGalleryTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_shared_image_gallery Terraform resource.
/// Manages a azurerm_shared_image_gallery resource.
/// </summary>
public partial class AzurermSharedImageGallery(string name) : TerraformResource("azurerm_shared_image_gallery", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The unique_name attribute.
    /// </summary>
    public TerraformValue<string> UniqueName
    {
        get => new TerraformReference<string>(this, "unique_name");
    }

    /// <summary>
    /// Sharing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sharing block(s) allowed")]
    public TerraformList<AzurermSharedImageGallerySharingBlock>? Sharing
    {
        get => GetArgument<TerraformList<AzurermSharedImageGallerySharingBlock>>("sharing");
        set => SetArgument("sharing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSharedImageGalleryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSharedImageGalleryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
