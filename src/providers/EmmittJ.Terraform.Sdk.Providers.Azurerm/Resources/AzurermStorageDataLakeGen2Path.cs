using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ace in AzurermStorageDataLakeGen2Path.
/// Nesting mode: set
/// </summary>
public class AzurermStorageDataLakeGen2PathAceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ace";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformValue<string> Permissions
    {
        get => new TerraformReference<string>(this, "permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageDataLakeGen2Path.
/// Nesting mode: single
/// </summary>
public class AzurermStorageDataLakeGen2PathTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_data_lake_gen2_path Terraform resource.
/// Manages a azurerm_storage_data_lake_gen2_path resource.
/// </summary>
public partial class AzurermStorageDataLakeGen2Path(string name) : TerraformResource("azurerm_storage_data_lake_gen2_path", name)
{
    /// <summary>
    /// The filesystem_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemName is required")]
    public required TerraformValue<string> FilesystemName
    {
        get => new TerraformReference<string>(this, "filesystem_name");
        set => SetArgument("filesystem_name", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformValue<string> Group
    {
        get => new TerraformReference<string>(this, "group");
        set => SetArgument("group", value);
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
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => new TerraformReference<string>(this, "resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Ace block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermStorageDataLakeGen2PathAceBlock>? Ace
    {
        get => GetArgument<TerraformSet<AzurermStorageDataLakeGen2PathAceBlock>>("ace");
        set => SetArgument("ace", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageDataLakeGen2PathTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageDataLakeGen2PathTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
