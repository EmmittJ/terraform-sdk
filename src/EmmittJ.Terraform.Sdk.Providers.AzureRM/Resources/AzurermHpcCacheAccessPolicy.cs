using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for access_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermHpcCacheAccessPolicyAccessRuleBlock : TerraformBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformProperty<string> Access
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access");
        set => WithProperty("access", value);
    }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    public TerraformProperty<double>? AnonymousGid
    {
        get => GetProperty<TerraformProperty<double>>("anonymous_gid");
        set => WithProperty("anonymous_gid", value);
    }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    public TerraformProperty<double>? AnonymousUid
    {
        get => GetProperty<TerraformProperty<double>>("anonymous_uid");
        set => WithProperty("anonymous_uid", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RootSquashEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("root_squash_enabled");
        set => WithProperty("root_squash_enabled", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SubmountAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("submount_access_enabled");
        set => WithProperty("submount_access_enabled", value);
    }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SuidEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("suid_enabled");
        set => WithProperty("suid_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_hpc_cache_access_policy resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHpcCacheAccessPolicy : TerraformResource
{
    public AzurermHpcCacheAccessPolicy(string name) : base("azurerm_hpc_cache_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpcCacheId is required")]
    public required TerraformProperty<string> HpcCacheId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hpc_cache_id");
        set => this.WithProperty("hpc_cache_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for access_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    public HashSet<AzurermHpcCacheAccessPolicyAccessRuleBlock>? AccessRule
    {
        get => GetProperty<HashSet<AzurermHpcCacheAccessPolicyAccessRuleBlock>>("access_rule");
        set => this.WithProperty("access_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHpcCacheAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermHpcCacheAccessPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
