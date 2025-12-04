using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermMachineLearningInferenceCluster.
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for ssl in AzurermMachineLearningInferenceCluster.
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
        get => GetArgument<TerraformValue<string>>("cert");
        set => SetArgument("cert", value);
    }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformValue<string>? Cname
    {
        get => GetArgument<TerraformValue<string>>("cname");
        set => SetArgument("cname", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The leaf_domain_label attribute.
    /// </summary>
    public TerraformValue<string>? LeafDomainLabel
    {
        get => GetArgument<TerraformValue<string>>("leaf_domain_label");
        set => SetArgument("leaf_domain_label", value);
    }

    /// <summary>
    /// The overwrite_existing_domain attribute.
    /// </summary>
    public TerraformValue<bool>? OverwriteExistingDomain
    {
        get => GetArgument<TerraformValue<bool>>("overwrite_existing_domain");
        set => SetArgument("overwrite_existing_domain", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMachineLearningInferenceCluster.
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
        get => GetArgument<TerraformValue<string>>("cluster_purpose");
        set => SetArgument("cluster_purpose", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformValue<string> KubernetesClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("kubernetes_cluster_id");
        set => SetArgument("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    public required TerraformValue<string> MachineLearningWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("machine_learning_workspace_id");
        set => SetArgument("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMachineLearningInferenceClusterIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMachineLearningInferenceClusterIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Ssl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public TerraformList<AzurermMachineLearningInferenceClusterSslBlock>? Ssl
    {
        get => GetArgument<TerraformList<AzurermMachineLearningInferenceClusterSslBlock>>("ssl");
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
