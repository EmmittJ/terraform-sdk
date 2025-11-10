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
        get => GetProperty<TerraformProperty<string>>("account_key");
        set => WithProperty("account_key", value);
    }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformProperty<string> ContainerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container_id");
        set => WithProperty("container_id", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformProperty<string>? LocalAuthReference
    {
        get => GetProperty<TerraformProperty<string>>("local_auth_reference");
        set => WithProperty("local_auth_reference", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    public TerraformProperty<string>? SasToken
    {
        get => GetProperty<TerraformProperty<string>>("sas_token");
        set => WithProperty("sas_token", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("sync_interval_in_seconds");
        set => WithProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
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
        get => GetProperty<TerraformProperty<string>>("access_key");
        set => WithProperty("access_key", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket_name");
        set => WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformProperty<string>? LocalAuthReference
    {
        get => GetProperty<TerraformProperty<string>>("local_auth_reference");
        set => WithProperty("local_auth_reference", value);
    }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SecretKeyBase64
    {
        get => GetProperty<TerraformProperty<string>>("secret_key_base64");
        set => WithProperty("secret_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("sync_interval_in_seconds");
        set => WithProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_enabled");
        set => WithProperty("tls_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
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
        get => GetProperty<TerraformProperty<string>>("https_ca_cert_base64");
        set => WithProperty("https_ca_cert_base64", value);
    }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsKeyBase64
    {
        get => GetProperty<TerraformProperty<string>>("https_key_base64");
        set => WithProperty("https_key_base64", value);
    }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsUser
    {
        get => GetProperty<TerraformProperty<string>>("https_user");
        set => WithProperty("https_user", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformProperty<string>? LocalAuthReference
    {
        get => GetProperty<TerraformProperty<string>>("local_auth_reference");
        set => WithProperty("local_auth_reference", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformProperty<string>? Provider
    {
        get => GetProperty<TerraformProperty<string>>("provider");
        set => WithProperty("provider", value);
    }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    public required TerraformProperty<string> ReferenceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("reference_type");
        set => WithProperty("reference_type", value);
    }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    public required TerraformProperty<string> ReferenceValue
    {
        get => GetRequiredProperty<TerraformProperty<string>>("reference_value");
        set => WithProperty("reference_value", value);
    }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SshKnownHostsBase64
    {
        get => GetProperty<TerraformProperty<string>>("ssh_known_hosts_base64");
        set => WithProperty("ssh_known_hosts_base64", value);
    }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? SshPrivateKeyBase64
    {
        get => GetProperty<TerraformProperty<string>>("ssh_private_key_base64");
        set => WithProperty("ssh_private_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("sync_interval_in_seconds");
        set => WithProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("depends_on");
        set => WithProperty("depends_on", value);
    }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GarbageCollectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("garbage_collection_enabled");
        set => WithProperty("garbage_collection_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RecreatingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("recreating_enabled");
        set => WithProperty("recreating_enabled", value);
    }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RetryIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("retry_interval_in_seconds");
        set => WithProperty("retry_interval_in_seconds", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SyncIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("sync_interval_in_seconds");
        set => WithProperty("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The wait attribute.
    /// </summary>
    public TerraformProperty<bool>? Wait
    {
        get => GetProperty<TerraformProperty<bool>>("wait");
        set => WithProperty("wait", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ContinuousReconciliationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("continuous_reconciliation_enabled");
        set => this.WithProperty("continuous_reconciliation_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for blob_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobStorage block(s) allowed")]
    public List<AzurermKubernetesFluxConfigurationBlobStorageBlock>? BlobStorage
    {
        get => GetProperty<List<AzurermKubernetesFluxConfigurationBlobStorageBlock>>("blob_storage");
        set => this.WithProperty("blob_storage", value);
    }

    /// <summary>
    /// Block for bucket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    public List<AzurermKubernetesFluxConfigurationBucketBlock>? Bucket
    {
        get => GetProperty<List<AzurermKubernetesFluxConfigurationBucketBlock>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public List<AzurermKubernetesFluxConfigurationGitRepositoryBlock>? GitRepository
    {
        get => GetProperty<List<AzurermKubernetesFluxConfigurationGitRepositoryBlock>>("git_repository");
        set => this.WithProperty("git_repository", value);
    }

    /// <summary>
    /// Block for kustomizations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    public HashSet<AzurermKubernetesFluxConfigurationKustomizationsBlock>? Kustomizations
    {
        get => GetProperty<HashSet<AzurermKubernetesFluxConfigurationKustomizationsBlock>>("kustomizations");
        set => this.WithProperty("kustomizations", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesFluxConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKubernetesFluxConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
