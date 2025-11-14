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
public class AzurermKeyVaultKeyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_key.
/// </summary>
public class AzurermKeyVaultKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultKeyDataSource(string name) : base("azurerm_key_vault_key", name)
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformArgument("key_vault_id")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultKeyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformArgument("curve")]
    public TerraformValue<string> Curve
    {
        get => new TerraformReference<string>(this, "curve");
    }

    /// <summary>
    /// The e attribute.
    /// </summary>
    [TerraformArgument("e")]
    public TerraformValue<string> E
    {
        get => new TerraformReference<string>(this, "e");
    }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformArgument("key_opts")]
    public TerraformList<string> KeyOpts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "key_opts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformArgument("key_size")]
    public TerraformValue<double> KeySize
    {
        get => new TerraformReference<double>(this, "key_size");
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformArgument("key_type")]
    public TerraformValue<string> KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
    }

    /// <summary>
    /// The n attribute.
    /// </summary>
    [TerraformArgument("n")]
    public TerraformValue<string> N
    {
        get => new TerraformReference<string>(this, "n");
    }

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    [TerraformArgument("public_key_openssh")]
    public TerraformValue<string> PublicKeyOpenssh
    {
        get => new TerraformReference<string>(this, "public_key_openssh");
    }

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformArgument("public_key_pem")]
    public TerraformValue<string> PublicKeyPem
    {
        get => new TerraformReference<string>(this, "public_key_pem");
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformArgument("resource_id")]
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    [TerraformArgument("resource_versionless_id")]
    public TerraformValue<string> ResourceVersionlessId
    {
        get => new TerraformReference<string>(this, "resource_versionless_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformArgument("versionless_id")]
    public TerraformValue<string> VersionlessId
    {
        get => new TerraformReference<string>(this, "versionless_id");
    }

    /// <summary>
    /// The x attribute.
    /// </summary>
    [TerraformArgument("x")]
    public TerraformValue<string> X
    {
        get => new TerraformReference<string>(this, "x");
    }

    /// <summary>
    /// The y attribute.
    /// </summary>
    [TerraformArgument("y")]
    public TerraformValue<string> Y
    {
        get => new TerraformReference<string>(this, "y");
    }

}
