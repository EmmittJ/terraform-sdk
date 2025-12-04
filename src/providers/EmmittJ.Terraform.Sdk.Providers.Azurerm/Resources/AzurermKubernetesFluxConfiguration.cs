using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for blob_storage in AzurermKubernetesFluxConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBlobStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blob_storage";

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformValue<string>? AccountKey
    {
        get => GetArgument<TerraformValue<string>>("account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformValue<string> ContainerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformValue<string>? LocalAuthReference
    {
        get => GetArgument<TerraformValue<string>>("local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    public TerraformValue<string>? SasToken
    {
        get => GetArgument<TerraformValue<string>>("sas_token");
        set => SetArgument("sas_token", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// ManagedIdentity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedIdentity block(s) allowed")]
    public TerraformList<AzurermKubernetesFluxConfigurationBlobStorageBlockManagedIdentityBlock>? ManagedIdentity
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationBlobStorageBlockManagedIdentityBlock>>("managed_identity");
        set => SetArgument("managed_identity", value);
    }

    /// <summary>
    /// ServicePrincipal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public TerraformList<AzurermKubernetesFluxConfigurationBlobStorageBlockServicePrincipalBlock>? ServicePrincipal
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationBlobStorageBlockServicePrincipalBlock>>("service_principal");
        set => SetArgument("service_principal", value);
    }

}

/// <summary>
/// Block type for managed_identity in AzurermKubernetesFluxConfigurationBlobStorageBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBlobStorageBlockManagedIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_identity";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

}

/// <summary>
/// Block type for service_principal in AzurermKubernetesFluxConfigurationBlobStorageBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBlobStorageBlockServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_principal";

    /// <summary>
    /// The client_certificate_base64 attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateBase64
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_base64");
        set => SetArgument("client_certificate_base64", value);
    }

    /// <summary>
    /// The client_certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_password");
        set => SetArgument("client_certificate_password", value);
    }

    /// <summary>
    /// The client_certificate_send_chain attribute.
    /// </summary>
    public TerraformValue<bool>? ClientCertificateSendChain
    {
        get => GetArgument<TerraformValue<bool>>("client_certificate_send_chain");
        set => SetArgument("client_certificate_send_chain", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for bucket in AzurermKubernetesFluxConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationBucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket";

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformValue<string>? AccessKey
    {
        get => GetArgument<TerraformValue<string>>("access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformValue<string>? LocalAuthReference
    {
        get => GetArgument<TerraformValue<string>>("local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SecretKeyBase64
    {
        get => GetArgument<TerraformValue<string>>("secret_key_base64");
        set => SetArgument("secret_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for git_repository in AzurermKubernetesFluxConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationGitRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "git_repository";

    /// <summary>
    /// The https_ca_cert_base64 attribute.
    /// </summary>
    public TerraformValue<string>? HttpsCaCertBase64
    {
        get => GetArgument<TerraformValue<string>>("https_ca_cert_base64");
        set => SetArgument("https_ca_cert_base64", value);
    }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    public TerraformValue<string>? HttpsKeyBase64
    {
        get => GetArgument<TerraformValue<string>>("https_key_base64");
        set => SetArgument("https_key_base64", value);
    }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    public TerraformValue<string>? HttpsUser
    {
        get => GetArgument<TerraformValue<string>>("https_user");
        set => SetArgument("https_user", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformValue<string>? LocalAuthReference
    {
        get => GetArgument<TerraformValue<string>>("local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformValue<string>? ProviderAttribute
    {
        get => GetArgument<TerraformValue<string>>("provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    public required TerraformValue<string> ReferenceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("reference_type");
        set => SetArgument("reference_type", value);
    }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    public required TerraformValue<string> ReferenceValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("reference_value");
        set => SetArgument("reference_value", value);
    }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SshKnownHostsBase64
    {
        get => GetArgument<TerraformValue<string>>("ssh_known_hosts_base64");
        set => SetArgument("ssh_known_hosts_base64", value);
    }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SshPrivateKeyBase64
    {
        get => GetArgument<TerraformValue<string>>("ssh_private_key_base64");
        set => SetArgument("ssh_private_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for kustomizations in AzurermKubernetesFluxConfiguration.
/// Nesting mode: set
/// </summary>
public class AzurermKubernetesFluxConfigurationKustomizationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kustomizations";

    /// <summary>
    /// The depends_on attribute.
    /// </summary>
    public TerraformList<string>? DependsOnAttribute
    {
        get => GetArgument<TerraformList<string>>("depends_on");
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GarbageCollectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("garbage_collection_enabled");
        set => SetArgument("garbage_collection_enabled", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RecreatingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("recreating_enabled");
        set => SetArgument("recreating_enabled", value);
    }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? RetryIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("retry_interval_in_seconds");
        set => SetArgument("retry_interval_in_seconds", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The wait attribute.
    /// </summary>
    public TerraformValue<bool>? Wait
    {
        get => GetArgument<TerraformValue<bool>>("wait");
        set => SetArgument("wait", value);
    }

    /// <summary>
    /// PostBuild block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostBuild block(s) allowed")]
    public TerraformList<AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlock>? PostBuild
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlock>>("post_build");
        set => SetArgument("post_build", value);
    }

}

/// <summary>
/// Block type for post_build in AzurermKubernetesFluxConfigurationKustomizationsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_build";

    /// <summary>
    /// The substitute attribute.
    /// </summary>
    public TerraformMap<string>? Substitute
    {
        get => GetArgument<TerraformMap<string>>("substitute");
        set => SetArgument("substitute", value);
    }

    /// <summary>
    /// SubstituteFrom block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlockSubstituteFromBlock>? SubstituteFrom
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlockSubstituteFromBlock>>("substitute_from");
        set => SetArgument("substitute_from", value);
    }

}

/// <summary>
/// Block type for substitute_from in AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFluxConfigurationKustomizationsBlockPostBuildBlockSubstituteFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "substitute_from";

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => GetRequiredArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
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
    /// The optional attribute.
    /// </summary>
    public TerraformValue<bool>? Optional
    {
        get => GetArgument<TerraformValue<bool>>("optional");
        set => SetArgument("optional", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesFluxConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFluxConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_kubernetes_flux_configuration Terraform resource.
/// Manages a azurerm_kubernetes_flux_configuration resource.
/// </summary>
public partial class AzurermKubernetesFluxConfiguration(string name) : TerraformResource("azurerm_kubernetes_flux_configuration", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ContinuousReconciliationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("continuous_reconciliation_enabled");
        set => SetArgument("continuous_reconciliation_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// BlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobStorage block(s) allowed")]
    public TerraformList<AzurermKubernetesFluxConfigurationBlobStorageBlock>? BlobStorage
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationBlobStorageBlock>>("blob_storage");
        set => SetArgument("blob_storage", value);
    }

    /// <summary>
    /// Bucket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    public TerraformList<AzurermKubernetesFluxConfigurationBucketBlock>? Bucket
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationBucketBlock>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// GitRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public TerraformList<AzurermKubernetesFluxConfigurationGitRepositoryBlock>? GitRepository
    {
        get => GetArgument<TerraformList<AzurermKubernetesFluxConfigurationGitRepositoryBlock>>("git_repository");
        set => SetArgument("git_repository", value);
    }

    /// <summary>
    /// Kustomizations block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kustomizations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    public required TerraformSet<AzurermKubernetesFluxConfigurationKustomizationsBlock> Kustomizations
    {
        get => GetRequiredArgument<TerraformSet<AzurermKubernetesFluxConfigurationKustomizationsBlock>>("kustomizations");
        set => SetArgument("kustomizations", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesFluxConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesFluxConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
