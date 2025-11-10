using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ace in .
/// Nesting mode: set
/// </summary>
public class AzurermStorageDataLakeGen2PathAceBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformProperty<string> Permissions
    {
        get => GetProperty<TerraformProperty<string>>("permissions");
        set => WithProperty("permissions", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageDataLakeGen2PathTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_data_lake_gen2_path resource.
/// </summary>
public class AzurermStorageDataLakeGen2Path : TerraformResource
{
    public AzurermStorageDataLakeGen2Path(string name) : base("azurerm_storage_data_lake_gen2_path", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The filesystem_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemName is required")]
    public required TerraformProperty<string> FilesystemName
    {
        get => GetProperty<TerraformProperty<string>>("filesystem_name");
        set => this.WithProperty("filesystem_name", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string>? Owner
    {
        get => GetProperty<TerraformProperty<string>>("owner");
        set => this.WithProperty("owner", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformProperty<string> Resource
    {
        get => GetProperty<TerraformProperty<string>>("resource");
        set => this.WithProperty("resource", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for ace.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermStorageDataLakeGen2PathAceBlock>? Ace
    {
        get => GetProperty<HashSet<AzurermStorageDataLakeGen2PathAceBlock>>("ace");
        set => this.WithProperty("ace", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageDataLakeGen2PathTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageDataLakeGen2PathTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
