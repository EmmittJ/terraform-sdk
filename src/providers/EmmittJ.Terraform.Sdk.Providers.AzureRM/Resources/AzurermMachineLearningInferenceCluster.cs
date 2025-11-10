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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("cert", value);
    }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformProperty<string>? Cname
    {
        set => SetProperty("cname", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The leaf_domain_label attribute.
    /// </summary>
    public TerraformProperty<string>? LeafDomainLabel
    {
        set => SetProperty("leaf_domain_label", value);
    }

    /// <summary>
    /// The overwrite_existing_domain attribute.
    /// </summary>
    public TerraformProperty<bool>? OverwriteExistingDomain
    {
        set => SetProperty("overwrite_existing_domain", value);
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

}

/// <summary>
/// Manages a azurerm_machine_learning_inference_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMachineLearningInferenceCluster : TerraformResource
{
    public AzurermMachineLearningInferenceCluster(string name) : base("azurerm_machine_learning_inference_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_purpose");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kubernetes_cluster_id");
        SetOutput("location");
        SetOutput("machine_learning_workspace_id");
        SetOutput("name");
        SetOutput("tags");
    }

    /// <summary>
    /// The cluster_purpose attribute.
    /// </summary>
    public TerraformProperty<string> ClusterPurpose
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_purpose");
        set => SetProperty("cluster_purpose", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformProperty<string> KubernetesClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubernetes_cluster_id");
        set => SetProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    public required TerraformProperty<string> MachineLearningWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("machine_learning_workspace_id");
        set => SetProperty("machine_learning_workspace_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMachineLearningInferenceClusterIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for ssl.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssl block(s) allowed")]
    public List<AzurermMachineLearningInferenceClusterSslBlock>? Ssl
    {
        set => SetProperty("ssl", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningInferenceClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
