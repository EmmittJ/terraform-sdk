using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for plan in AzurermKubernetesClusterExtension.
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The promotion_code attribute.
    /// </summary>
    public TerraformValue<string>? PromotionCode
    {
        get => new TerraformReference<string>(this, "promotion_code");
        set => SetArgument("promotion_code", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesClusterExtension.
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
/// Represents a azurerm_kubernetes_cluster_extension Terraform resource.
/// Manages a azurerm_kubernetes_cluster_extension resource.
/// </summary>
public partial class AzurermKubernetesClusterExtension(string name) : TerraformResource("azurerm_kubernetes_cluster_extension", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public TerraformMap<string>? ConfigurationProtectedSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration_protected_settings").ResolveNodes(ctx));
        set => SetArgument("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public TerraformMap<string>? ConfigurationSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "configuration_settings").ResolveNodes(ctx));
        set => SetArgument("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionType is required")]
    public required TerraformValue<string> ExtensionType
    {
        get => new TerraformReference<string>(this, "extension_type");
        set => SetArgument("extension_type", value);
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
    /// The release_namespace attribute.
    /// </summary>
    public TerraformValue<string> ReleaseNamespace
    {
        get => new TerraformReference<string>(this, "release_namespace");
        set => SetArgument("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public TerraformValue<string> ReleaseTrain
    {
        get => new TerraformReference<string>(this, "release_train");
        set => SetArgument("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public TerraformValue<string> TargetNamespace
    {
        get => new TerraformReference<string>(this, "target_namespace");
        set => SetArgument("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The aks_assigned_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AksAssignedIdentity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "aks_assigned_identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersion
    {
        get => new TerraformReference<string>(this, "current_version");
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermKubernetesClusterExtensionPlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermKubernetesClusterExtensionPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesClusterExtensionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesClusterExtensionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
