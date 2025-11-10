using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningInferenceClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for ssl in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningInferenceClusterSslBlock : TerraformBlock
{
    /// <summary>
    /// The cert attribute.
    /// </summary>
    public TerraformProperty<string>? Cert
    {
        get => GetProperty<TerraformProperty<string>>("cert");
        set => WithProperty("cert", value);
    }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformProperty<string>? Cname
    {
        get => GetProperty<TerraformProperty<string>>("cname");
        set => WithProperty("cname", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The leaf_domain_label attribute.
    /// </summary>
    public TerraformProperty<string>? LeafDomainLabel
    {
        get => GetProperty<TerraformProperty<string>>("leaf_domain_label");
        set => WithProperty("leaf_domain_label", value);
    }

    /// <summary>
    /// The overwrite_existing_domain attribute.
    /// </summary>
    public TerraformProperty<bool>? OverwriteExistingDomain
    {
        get => GetProperty<TerraformProperty<bool>>("overwrite_existing_domain");
        set => WithProperty("overwrite_existing_domain", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningInferenceClusterTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_machine_learning_inference_cluster resource.
/// </summary>
public class AzurermMachineLearningInferenceCluster : TerraformResource
{
    public AzurermMachineLearningInferenceCluster(string name) : base("azurerm_machine_learning_inference_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_purpose attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterPurpose
    {
        get => GetProperty<TerraformProperty<string>>("cluster_purpose");
        set => this.WithProperty("cluster_purpose", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformProperty<string> KubernetesClusterId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    public required TerraformProperty<string> MachineLearningWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("machine_learning_workspace_id");
        set => this.WithProperty("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMachineLearningInferenceClusterIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMachineLearningInferenceClusterIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for ssl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public List<AzurermMachineLearningInferenceClusterSslBlock>? Ssl
    {
        get => GetProperty<List<AzurermMachineLearningInferenceClusterSslBlock>>("ssl");
        set => this.WithProperty("ssl", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningInferenceClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMachineLearningInferenceClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
