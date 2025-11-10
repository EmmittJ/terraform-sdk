using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ace in .
/// Nesting mode: set
/// </summary>
public class AzurermStorageDataLakeGen2FilesystemAceBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformPropertyName("permissions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Permissions { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Scope { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageDataLakeGen2FilesystemTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_data_lake_gen2_filesystem resource.
/// </summary>
public class AzurermStorageDataLakeGen2Filesystem : TerraformResource
{
    public AzurermStorageDataLakeGen2Filesystem(string name) : base("azurerm_storage_data_lake_gen2_filesystem", name)
    {
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformPropertyName("default_encryption_scope")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultEncryptionScope { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_encryption_scope");

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Group { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "group");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Owner { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// Block for ace.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ace")]
    public TerraformSet<TerraformBlock<AzurermStorageDataLakeGen2FilesystemAceBlock>>? Ace { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageDataLakeGen2FilesystemTimeoutsBlock>? Timeouts { get; set; } = new();

}
