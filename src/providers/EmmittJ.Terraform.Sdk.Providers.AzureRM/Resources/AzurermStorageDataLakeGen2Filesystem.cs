using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ace in .
/// Nesting mode: set
/// </summary>
public class AzurermStorageDataLakeGen2FilesystemAceBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformProperty<string> Permissions
    {
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageDataLakeGen2FilesystemTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_data_lake_gen2_filesystem resource.
/// </summary>
public class AzurermStorageDataLakeGen2Filesystem : TerraformResource
{
    public AzurermStorageDataLakeGen2Filesystem(string name) : base("azurerm_storage_data_lake_gen2_filesystem", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_encryption_scope");
        SetOutput("group");
        SetOutput("id");
        SetOutput("name");
        SetOutput("owner");
        SetOutput("properties");
        SetOutput("storage_account_id");
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public TerraformProperty<string> DefaultEncryptionScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_encryption_scope");
        set => SetProperty("default_encryption_scope", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string> Group
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group");
        set => SetProperty("group", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string> Owner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner");
        set => SetProperty("owner", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Properties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("properties");
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for ace.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermStorageDataLakeGen2FilesystemAceBlock>? Ace
    {
        set => SetProperty("ace", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageDataLakeGen2FilesystemTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
