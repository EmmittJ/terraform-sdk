using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rotation_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultKeyRotationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rotation_policy";

    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    public TerraformValue<string>? ExpireAfter
    {
        get => new TerraformReference<string>(this, "expire_after");
        set => SetArgument("expire_after", value);
    }

    /// <summary>
    /// The notify_before_expiry attribute.
    /// </summary>
    public TerraformValue<string>? NotifyBeforeExpiry
    {
        get => new TerraformReference<string>(this, "notify_before_expiry");
        set => SetArgument("notify_before_expiry", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_key Terraform resource.
/// Manages a azurerm_key_vault_key resource.
/// </summary>
public partial class AzurermKeyVaultKey(string name) : TerraformResource("azurerm_key_vault_key", name)
{
    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformValue<string> Curve
    {
        get => new TerraformReference<string>(this, "curve");
        set => SetArgument("curve", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
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
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    public TerraformList<string>? KeyOpts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "key_opts").ResolveNodes(ctx));
        set => SetArgument("key_opts", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double>? KeySize
    {
        get => new TerraformReference<double>(this, "key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformValue<string> KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
        set => SetArgument("key_type", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformValue<string>? NotBeforeDate
    {
        get => new TerraformReference<string>(this, "not_before_date");
        set => SetArgument("not_before_date", value);
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
    /// RotationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationPolicy block(s) allowed")]
    public TerraformList<AzurermKeyVaultKeyRotationPolicyBlock>? RotationPolicy
    {
        get => GetArgument<TerraformList<AzurermKeyVaultKeyRotationPolicyBlock>>("rotation_policy");
        set => SetArgument("rotation_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
