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
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterExtensionPlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plan";

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
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformArgument("product")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The promotion_code attribute.
    /// </summary>
    [TerraformArgument("promotion_code")]
    public TerraformValue<string>? PromotionCode
    {
        get => new TerraformReference<string>(this, "promotion_code");
        set => SetArgument("promotion_code", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterExtensionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_kubernetes_cluster_extension resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesClusterExtension : TerraformResource
{
    public AzurermKubernetesClusterExtension(string name) : base("azurerm_kubernetes_cluster_extension", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformArgument("cluster_id")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    [TerraformArgument("configuration_protected_settings")]
    public TerraformMap<string>? ConfigurationProtectedSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration_protected_settings").ResolveNodes(ctx));
        set => SetArgument("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    [TerraformArgument("configuration_settings")]
    public TerraformMap<string>? ConfigurationSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration_settings").ResolveNodes(ctx));
        set => SetArgument("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionType is required")]
    [TerraformArgument("extension_type")]
    public required TerraformValue<string> ExtensionType
    {
        get => new TerraformReference<string>(this, "extension_type");
        set => SetArgument("extension_type", value);
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
    /// The release_namespace attribute.
    /// </summary>
    [TerraformArgument("release_namespace")]
    public TerraformValue<string> ReleaseNamespace
    {
        get => new TerraformReference<string>(this, "release_namespace");
        set => SetArgument("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    [TerraformArgument("release_train")]
    public TerraformValue<string> ReleaseTrain
    {
        get => new TerraformReference<string>(this, "release_train");
        set => SetArgument("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    [TerraformArgument("target_namespace")]
    public TerraformValue<string> TargetNamespace
    {
        get => new TerraformReference<string>(this, "target_namespace");
        set => SetArgument("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformArgument("plan")]
    public TerraformList<AzurermKubernetesClusterExtensionPlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesClusterExtensionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The aks_assigned_identity attribute.
    /// </summary>
    [TerraformArgument("aks_assigned_identity")]
    public TerraformList<object> AksAssignedIdentity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "aks_assigned_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformArgument("current_version")]
    public TerraformValue<string> CurrentVersion
    {
        get => new TerraformReference<string>(this, "current_version");
    }

}
