using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesClusterExtensionIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcKubernetesClusterExtensionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_arc_kubernetes_cluster_extension Terraform resource.
/// Manages a azurerm_arc_kubernetes_cluster_extension resource.
/// </summary>
public partial class AzurermArcKubernetesClusterExtension(string name) : TerraformResource("azurerm_arc_kubernetes_cluster_extension", name)
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
    /// The current_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersion
    {
        get => new TerraformReference<string>(this, "current_version");
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermArcKubernetesClusterExtensionIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermArcKubernetesClusterExtensionIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcKubernetesClusterExtensionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcKubernetesClusterExtensionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
