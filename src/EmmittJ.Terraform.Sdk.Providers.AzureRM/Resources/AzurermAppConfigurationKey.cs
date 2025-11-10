using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationKeyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_configuration_key resource.
/// </summary>
public class AzurermAppConfigurationKey : TerraformResource
{
    public AzurermAppConfigurationKey(string name) : base("azurerm_app_configuration_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformProperty<string> ConfigurationStoreId
    {
        get => GetProperty<TerraformProperty<string>>("configuration_store_id");
        set => this.WithProperty("configuration_store_id", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
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
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        get => GetProperty<TerraformProperty<string>>("label");
        set => this.WithProperty("label", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformProperty<bool>? Locked
    {
        get => GetProperty<TerraformProperty<bool>>("locked");
        set => this.WithProperty("locked", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    public TerraformProperty<string>? VaultKeyReference
    {
        get => GetProperty<TerraformProperty<string>>("vault_key_reference");
        set => this.WithProperty("vault_key_reference", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppConfigurationKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
