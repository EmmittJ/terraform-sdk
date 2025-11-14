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
    [TerraformArgument("access")]
    public required TerraformValue<string> Access
    {
        get => new TerraformReference<string>(this, "access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    [TerraformArgument("anonymous_gid")]
    public TerraformValue<double>? AnonymousGid
    {
        get => new TerraformReference<double>(this, "anonymous_gid");
        set => SetArgument("anonymous_gid", value);
    }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    [TerraformArgument("anonymous_uid")]
    public TerraformValue<double>? AnonymousUid
    {
        get => new TerraformReference<double>(this, "anonymous_uid");
        set => SetArgument("anonymous_uid", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformArgument("filter")]
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    [TerraformArgument("root_squash_enabled")]
    public TerraformValue<bool>? RootSquashEnabled
    {
        get => new TerraformReference<bool>(this, "root_squash_enabled");
        set => SetArgument("root_squash_enabled", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    [TerraformArgument("submount_access_enabled")]
    public TerraformValue<bool>? SubmountAccessEnabled
    {
        get => new TerraformReference<bool>(this, "submount_access_enabled");
        set => SetArgument("submount_access_enabled", value);
    }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    [TerraformArgument("suid_enabled")]
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
/// Manages a azurerm_hpc_cache_access_policy resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHpcCacheAccessPolicy : TerraformResource
{
    public AzurermHpcCacheAccessPolicy(string name) : base("azurerm_hpc_cache_access_policy", name)
    {
    }

    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpcCacheId is required")]
    [TerraformArgument("hpc_cache_id")]
    public required TerraformValue<string> HpcCacheId
    {
        get => new TerraformReference<string>(this, "hpc_cache_id");
        set => SetArgument("hpc_cache_id", value);
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
    /// Block for access_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    [TerraformArgument("access_rule")]
    public required TerraformSet<AzurermHpcCacheAccessPolicyAccessRuleBlock> AccessRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHpcCacheAccessPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
