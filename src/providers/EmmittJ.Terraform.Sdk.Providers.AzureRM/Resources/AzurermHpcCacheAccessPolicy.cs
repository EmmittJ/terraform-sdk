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
        set => SetProperty("access", value);
    }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    public TerraformProperty<double>? AnonymousGid
    {
        set => SetProperty("anonymous_gid", value);
    }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    public TerraformProperty<double>? AnonymousUid
    {
        set => SetProperty("anonymous_uid", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RootSquashEnabled
    {
        set => SetProperty("root_squash_enabled", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SubmountAccessEnabled
    {
        set => SetProperty("submount_access_enabled", value);
    }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SuidEnabled
    {
        set => SetProperty("suid_enabled", value);
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
        SetOutput("hpc_cache_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HpcCacheId is required")]
    public required TerraformProperty<string> HpcCacheId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hpc_cache_id");
        set => SetProperty("hpc_cache_id", value);
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
    /// Block for access_rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    public HashSet<AzurermHpcCacheAccessPolicyAccessRuleBlock>? AccessRule
    {
        set => SetProperty("access_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHpcCacheAccessPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
