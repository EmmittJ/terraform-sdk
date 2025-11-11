using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for blob_storage in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBlobStorageBlock
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [TerraformPropertyName("account_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountKey { get; set; }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformPropertyName("container_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerId { get; set; }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_reference")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalAuthReference { get; set; }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [TerraformPropertyName("sas_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SasToken { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("sync_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

}

/// <summary>
/// Block type for bucket in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBucketBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformPropertyName("access_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_reference")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalAuthReference { get; set; }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    [TerraformPropertyName("secret_key_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretKeyBase64 { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("sync_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tls_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TlsEnabled { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for git_repository in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationGitRepositoryBlock
{
    /// <summary>
    /// The https_ca_cert_base64 attribute.
    /// </summary>
    [TerraformPropertyName("https_ca_cert_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpsCaCertBase64 { get; set; }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    [TerraformPropertyName("https_key_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpsKeyBase64 { get; set; }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    [TerraformPropertyName("https_user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpsUser { get; set; }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformPropertyName("local_auth_reference")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalAuthReference { get; set; }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    [TerraformPropertyName("provider")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Provider { get; set; }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    [TerraformPropertyName("reference_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReferenceType { get; set; }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    [TerraformPropertyName("reference_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReferenceValue { get; set; }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    [TerraformPropertyName("ssh_known_hosts_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SshKnownHostsBase64 { get; set; }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    [TerraformPropertyName("ssh_private_key_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SshPrivateKeyBase64 { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("sync_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for kustomizations in .
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesFluxConfigurationKustomizationsBlock
{
    /// <summary>
    /// The depends_on attribute.
    /// </summary>
    [TerraformPropertyName("depends_on")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DependsOn { get; set; }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("garbage_collection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GarbageCollectionEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    [TerraformPropertyName("recreating_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RecreatingEnabled { get; set; }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("retry_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryIntervalInSeconds { get; set; }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("sync_interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SyncIntervalInSeconds { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The wait attribute.
    /// </summary>
    [TerraformPropertyName("wait")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Wait { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFluxConfigurationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kubernetes_flux_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesFluxConfiguration : TerraformResource
{
    public AzurermKubernetesFluxConfiguration(string name) : base("azurerm_kubernetes_flux_configuration", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("continuous_reconciliation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ContinuousReconciliationEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformPropertyName("namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// Block for blob_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobStorage block(s) allowed")]
    [TerraformPropertyName("blob_storage")]
    public TerraformList<TerraformBlock<AzurermKubernetesFluxConfigurationBlobStorageBlock>>? BlobStorage { get; set; }

    /// <summary>
    /// Block for bucket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    [TerraformPropertyName("bucket")]
    public TerraformList<TerraformBlock<AzurermKubernetesFluxConfigurationBucketBlock>>? Bucket { get; set; }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    [TerraformPropertyName("git_repository")]
    public TerraformList<TerraformBlock<AzurermKubernetesFluxConfigurationGitRepositoryBlock>>? GitRepository { get; set; }

    /// <summary>
    /// Block for kustomizations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kustomizations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    [TerraformPropertyName("kustomizations")]
    public TerraformSet<TerraformBlock<AzurermKubernetesFluxConfigurationKustomizationsBlock>>? Kustomizations { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesFluxConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
