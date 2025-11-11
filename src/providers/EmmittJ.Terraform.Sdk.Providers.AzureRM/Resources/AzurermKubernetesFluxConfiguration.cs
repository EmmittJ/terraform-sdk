using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for blob_storage in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesFluxConfigurationBlobStorageBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [TerraformProperty("account_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountKey { get; set; }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformProperty("container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerId { get; set; }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformProperty("local_auth_reference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalAuthReference { get; set; }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [TerraformProperty("sas_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SasToken { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("sync_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInSeconds { get; set; }

}

/// <summary>
/// Block type for bucket in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesFluxConfigurationBucketBlock : TerraformBlockBase
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformProperty("access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformProperty("local_auth_reference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalAuthReference { get; set; }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    [TerraformProperty("secret_key_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretKeyBase64 { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("sync_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TlsEnabled { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for git_repository in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKubernetesFluxConfigurationGitRepositoryBlock : TerraformBlockBase
{
    /// <summary>
    /// The https_ca_cert_base64 attribute.
    /// </summary>
    [TerraformProperty("https_ca_cert_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpsCaCertBase64 { get; set; }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    [TerraformProperty("https_key_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpsKeyBase64 { get; set; }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    [TerraformProperty("https_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpsUser { get; set; }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformProperty("local_auth_reference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalAuthReference { get; set; }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [TerraformProperty("provider")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Provider { get; set; }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    [TerraformProperty("reference_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReferenceType { get; set; }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    [TerraformProperty("reference_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReferenceValue { get; set; }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    [TerraformProperty("ssh_known_hosts_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SshKnownHostsBase64 { get; set; }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    [TerraformProperty("ssh_private_key_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SshPrivateKeyBase64 { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("sync_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for kustomizations in .
/// Nesting mode: set
/// </summary>
public partial class AzurermKubernetesFluxConfigurationKustomizationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The depends_on attribute.
    /// </summary>
    [TerraformProperty("depends_on")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DependsOn { get; set; }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    [TerraformProperty("garbage_collection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GarbageCollectionEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    [TerraformProperty("recreating_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RecreatingEnabled { get; set; }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("retry_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryIntervalInSeconds { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("sync_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The wait attribute.
    /// </summary>
    [TerraformProperty("wait")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Wait { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesFluxConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kubernetes_flux_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKubernetesFluxConfiguration : TerraformResource
{
    public AzurermKubernetesFluxConfiguration(string name) : base("azurerm_kubernetes_flux_configuration", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    [TerraformProperty("continuous_reconciliation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContinuousReconciliationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// Block for blob_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobStorage block(s) allowed")]
    [TerraformProperty("blob_storage")]
    public partial TerraformList<TerraformBlock<AzurermKubernetesFluxConfigurationBlobStorageBlock>>? BlobStorage { get; set; }

    /// <summary>
    /// Block for bucket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    [TerraformProperty("bucket")]
    public partial TerraformList<TerraformBlock<AzurermKubernetesFluxConfigurationBucketBlock>>? Bucket { get; set; }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    [TerraformProperty("git_repository")]
    public partial TerraformList<TerraformBlock<AzurermKubernetesFluxConfigurationGitRepositoryBlock>>? GitRepository { get; set; }

    /// <summary>
    /// Block for kustomizations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kustomizations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    [TerraformProperty("kustomizations")]
    public partial TerraformSet<TerraformBlock<AzurermKubernetesFluxConfigurationKustomizationsBlock>>? Kustomizations { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKubernetesFluxConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
