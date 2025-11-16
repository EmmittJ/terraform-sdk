using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for access_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermHpcCacheAccessPolicyAccessRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_rule";

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformValue<string> Access
    {
        get => new TerraformReference<string>(this, "access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    public TerraformValue<double>? AnonymousGid
    {
        get => new TerraformReference<double>(this, "anonymous_gid");
        set => SetArgument("anonymous_gid", value);
    }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    public TerraformValue<double>? AnonymousUid
    {
        get => new TerraformReference<double>(this, "anonymous_uid");
        set => SetArgument("anonymous_uid", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RootSquashEnabled
    {
        get => new TerraformReference<bool>(this, "root_squash_enabled");
        set => SetArgument("root_squash_enabled", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SubmountAccessEnabled
    {
        get => new TerraformReference<bool>(this, "submount_access_enabled");
        set => SetArgument("submount_access_enabled", value);
    }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SuidEnabled
    {
        get => new TerraformReference<bool>(this, "suid_enabled");
        set => SetArgument("suid_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_hpc_cache_access_policy Terraform resource.
/// Manages a azurerm_hpc_cache_access_policy resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermHpcCacheAccessPolicy(string name) : TerraformResource("azurerm_hpc_cache_access_policy", name)
{
    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpcCacheId is required")]
    public required TerraformValue<string> HpcCacheId
    {
        get => new TerraformReference<string>(this, "hpc_cache_id");
        set => SetArgument("hpc_cache_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// AccessRule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    public required AzurermHpcCacheAccessPolicyAccessRuleBlock AccessRule
    {
        get => GetRequiredArgument<AzurermHpcCacheAccessPolicyAccessRuleBlock>("access_rule");
        set => SetArgument("access_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHpcCacheAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHpcCacheAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
