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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => GetArgument<TerraformValue<string>>("product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The promotion_code attribute.
    /// </summary>
    public TerraformValue<string>? PromotionCode
    {
        get => GetArgument<TerraformValue<string>>("promotion_code");
        set => SetArgument("promotion_code", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public TerraformMap<string>? ConfigurationProtectedSettings
    {
        get => GetArgument<TerraformMap<string>>("configuration_protected_settings");
        set => SetArgument("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public TerraformMap<string>? ConfigurationSettings
    {
        get => GetArgument<TerraformMap<string>>("configuration_settings");
        set => SetArgument("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionType is required")]
    public required TerraformValue<string> ExtensionType
    {
        get => GetArgument<TerraformValue<string>>("extension_type");
        set => SetArgument("extension_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The release_namespace attribute.
    /// </summary>
    public TerraformValue<string>? ReleaseNamespace
    {
        get => GetArgument<TerraformValue<string>>("release_namespace");
        set => SetArgument("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public TerraformValue<string>? ReleaseTrain
    {
        get => GetArgument<TerraformValue<string>>("release_train");
        set => SetArgument("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public TerraformValue<string>? TargetNamespace
    {
        get => GetArgument<TerraformValue<string>>("target_namespace");
        set => SetArgument("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The aks_assigned_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AksAssignedIdentity
        => AsReference("aks_assigned_identity");

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersion
        => AsReference("current_version");

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
