using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultKeyDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_key Terraform data source.
/// Retrieves information about a azurerm_key_vault_key.
/// </summary>
public partial class AzurermKeyVaultKeyDataSource(string name) : TerraformDataSource("azurerm_key_vault_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformValue<string> Curve
        => CreateReference("curve");

    /// <summary>
    /// The e attribute.
    /// </summary>
    public TerraformValue<string> E
        => CreateReference("e");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    public TerraformList<string> KeyOpts
        => CreateReference("key_opts");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double> KeySize
        => CreateReference("key_size");

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformValue<string> KeyType
        => CreateReference("key_type");

    /// <summary>
    /// The n attribute.
    /// </summary>
    public TerraformValue<string> N
        => CreateReference("n");

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyOpenssh
        => CreateReference("public_key_openssh");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyPem
        => CreateReference("public_key_pem");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => CreateReference("resource_id");

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceVersionlessId
        => CreateReference("resource_versionless_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessId
        => CreateReference("versionless_id");

    /// <summary>
    /// The x attribute.
    /// </summary>
    public TerraformValue<string> X
        => CreateReference("x");

    /// <summary>
    /// The y attribute.
    /// </summary>
    public TerraformValue<string> Y
        => CreateReference("y");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultKeyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultKeyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
