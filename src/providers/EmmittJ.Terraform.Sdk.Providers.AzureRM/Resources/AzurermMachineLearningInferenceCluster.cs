using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningInferenceClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

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
/// Block type for ssl in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningInferenceClusterSslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl";

    /// <summary>
    /// The cert attribute.
    /// </summary>
    public TerraformValue<string>? Cert
    {
        get => new TerraformReference<string>(this, "cert");
        set => SetArgument("cert", value);
    }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformValue<string>? Cname
    {
        get => new TerraformReference<string>(this, "cname");
        set => SetArgument("cname", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The leaf_domain_label attribute.
    /// </summary>
    public TerraformValue<string>? LeafDomainLabel
    {
        get => new TerraformReference<string>(this, "leaf_domain_label");
        set => SetArgument("leaf_domain_label", value);
    }

    /// <summary>
    /// The overwrite_existing_domain attribute.
    /// </summary>
    public TerraformValue<bool>? OverwriteExistingDomain
    {
        get => new TerraformReference<bool>(this, "overwrite_existing_domain");
        set => SetArgument("overwrite_existing_domain", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningInferenceClusterTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Represents a azurerm_machine_learning_inference_cluster Terraform resource.
/// Manages a azurerm_machine_learning_inference_cluster resource.
/// </summary>
public partial class AzurermMachineLearningInferenceCluster(string name) : TerraformResource("azurerm_machine_learning_inference_cluster", name)
{
    /// <summary>
    /// The cluster_purpose attribute.
    /// </summary>
    public TerraformValue<string>? ClusterPurpose
    {
        get => new TerraformReference<string>(this, "cluster_purpose");
        set => SetArgument("cluster_purpose", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformValue<string> KubernetesClusterId
    {
        get => new TerraformReference<string>(this, "kubernetes_cluster_id");
        set => SetArgument("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    public required TerraformValue<string> MachineLearningWorkspaceId
    {
        get => new TerraformReference<string>(this, "machine_learning_workspace_id");
        set => SetArgument("machine_learning_workspace_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermMachineLearningInferenceClusterIdentityBlock? Identity
    {
        get => GetArgument<AzurermMachineLearningInferenceClusterIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Ssl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public AzurermMachineLearningInferenceClusterSslBlock? Ssl
    {
        get => GetArgument<AzurermMachineLearningInferenceClusterSslBlock>("ssl");
        set => SetArgument("ssl", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMachineLearningInferenceClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMachineLearningInferenceClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
