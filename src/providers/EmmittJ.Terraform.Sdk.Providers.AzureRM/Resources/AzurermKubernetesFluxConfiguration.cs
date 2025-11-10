using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for blob_storage in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBlobStorageBlock : TerraformBlock
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformProperty<string>? AccountKey
    {
        set => SetProperty("account_key", value);
    }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformProperty<string> ContainerId
    {
        set => SetProperty("container_id", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformProperty<string>? LocalAuthReference
    {
        set => SetProperty("local_auth_reference", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    public TerraformProperty<string>? SasToken
    {
        set => SetProperty("sas_token", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        set => SetProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        set => SetProperty("timeout_in_seconds", value);
    }

}

/// <summary>
/// Block type for bucket in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBucketBlock : TerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformProperty<string>? AccessKey
    {
        set => SetProperty("access_key", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformProperty<string>? LocalAuthReference
    {
        set => SetProperty("local_auth_reference", value);
    }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SecretKeyBase64
    {
        set => SetProperty("secret_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        set => SetProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        set => SetProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEnabled
    {
        set => SetProperty("tls_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for git_repository in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationGitRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// The https_ca_cert_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsCaCertBase64
    {
        set => SetProperty("https_ca_cert_base64", value);
    }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsKeyBase64
    {
        set => SetProperty("https_key_base64", value);
    }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsUser
    {
        set => SetProperty("https_user", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformProperty<string>? LocalAuthReference
    {
        set => SetProperty("local_auth_reference", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformProperty<string>? Provider
    {
        set => SetProperty("provider", value);
    }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    public required TerraformProperty<string> ReferenceType
    {
        set => SetProperty("reference_type", value);
    }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    public required TerraformProperty<string> ReferenceValue
    {
        set => SetProperty("reference_value", value);
    }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SshKnownHostsBase64
    {
        set => SetProperty("ssh_known_hosts_base64", value);
    }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SshPrivateKeyBase64
    {
        set => SetProperty("ssh_private_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        set => SetProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        set => SetProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for kustomizations in .
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesFluxConfigurationKustomizationsBlock : TerraformBlock
{
    /// <summary>
    /// The depends_on attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DependsOn
    {
        set => SetProperty("depends_on", value);
    }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GarbageCollectionEnabled
    {
        set => SetProperty("garbage_collection_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RecreatingEnabled
    {
        set => SetProperty("recreating_enabled", value);
    }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RetryIntervalInSeconds
    {
        set => SetProperty("retry_interval_in_seconds", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        set => SetProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        set => SetProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The wait attribute.
    /// </summary>
    public TerraformProperty<bool>? Wait
    {
        set => SetProperty("wait", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFluxConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_kubernetes_flux_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesFluxConfiguration : TerraformResource
{
    public AzurermKubernetesFluxConfiguration(string name) : base("azurerm_kubernetes_flux_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_id");
        SetOutput("continuous_reconciliation_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace");
        SetOutput("scope");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ContinuousReconciliationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("continuous_reconciliation_enabled");
        set => SetProperty("continuous_reconciliation_enabled", value);
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
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for blob_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobStorage block(s) allowed")]
    public List<AzurermKubernetesFluxConfigurationBlobStorageBlock>? BlobStorage
    {
        set => SetProperty("blob_storage", value);
    }

    /// <summary>
    /// Block for bucket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    public List<AzurermKubernetesFluxConfigurationBucketBlock>? Bucket
    {
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public List<AzurermKubernetesFluxConfigurationGitRepositoryBlock>? GitRepository
    {
        set => SetProperty("git_repository", value);
    }

    /// <summary>
    /// Block for kustomizations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kustomizations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    public HashSet<AzurermKubernetesFluxConfigurationKustomizationsBlock>? Kustomizations
    {
        set => SetProperty("kustomizations", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesFluxConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
