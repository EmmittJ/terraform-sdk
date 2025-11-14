using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_key_vault_managed_storage_account_sas_token_definition resource.
/// </summary>
public class AzurermKeyVaultManagedStorageAccountSasTokenDefinition : TerraformResource
{
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinition(string name) : base("azurerm_key_vault_managed_storage_account_sas_token_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedStorageAccountId is required")]
    [TerraformArgument("managed_storage_account_id")]
    public required TerraformValue<string> ManagedStorageAccountId
    {
        get => new TerraformReference<string>(this, "managed_storage_account_id");
        set => SetArgument("managed_storage_account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sas_template_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasTemplateUri is required")]
    [TerraformArgument("sas_template_uri")]
    public required TerraformValue<string> SasTemplateUri
    {
        get => new TerraformReference<string>(this, "sas_template_uri");
        set => SetArgument("sas_template_uri", value);
    }

    /// <summary>
    /// The sas_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasType is required")]
    [TerraformArgument("sas_type")]
    public required TerraformValue<string> SasType
    {
        get => new TerraformReference<string>(this, "sas_type");
        set => SetArgument("sas_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The validity_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidityPeriod is required")]
    [TerraformArgument("validity_period")]
    public required TerraformValue<string> ValidityPeriod
    {
        get => new TerraformReference<string>(this, "validity_period");
        set => SetArgument("validity_period", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinitionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformArgument("secret_id")]
    public TerraformValue<string> SecretId
    {
        get => new TerraformReference<string>(this, "secret_id");
    }

}
