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
        get => new TerraformReference<string>(this, "account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformValue<string> ContainerId
    {
        get => new TerraformReference<string>(this, "container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformValue<string>? LocalAuthReference
    {
        get => new TerraformReference<string>(this, "local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    public TerraformValue<string>? SasToken
    {
        get => new TerraformReference<string>(this, "sas_token");
        set => SetArgument("sas_token", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
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
        get => new TerraformReference<string>(this, "client_id");
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
        get => new TerraformReference<string>(this, "client_certificate_base64");
        set => SetArgument("client_certificate_base64", value);
    }

    /// <summary>
    /// The client_certificate_password attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificatePassword
    {
        get => new TerraformReference<string>(this, "client_certificate_password");
        set => SetArgument("client_certificate_password", value);
    }

    /// <summary>
    /// The client_certificate_send_chain attribute.
    /// </summary>
    public TerraformValue<bool>? ClientCertificateSendChain
    {
        get => new TerraformReference<bool>(this, "client_certificate_send_chain");
        set => SetArgument("client_certificate_send_chain", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
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
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformValue<string>? LocalAuthReference
    {
        get => new TerraformReference<string>(this, "local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SecretKeyBase64
    {
        get => new TerraformReference<string>(this, "secret_key_base64");
        set => SetArgument("secret_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEnabled
    {
        get => new TerraformReference<bool>(this, "tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
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
        get => new TerraformReference<string>(this, "https_ca_cert_base64");
        set => SetArgument("https_ca_cert_base64", value);
    }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    public TerraformValue<string>? HttpsKeyBase64
    {
        get => new TerraformReference<string>(this, "https_key_base64");
        set => SetArgument("https_key_base64", value);
    }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    public TerraformValue<string>? HttpsUser
    {
        get => new TerraformReference<string>(this, "https_user");
        set => SetArgument("https_user", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    public TerraformValue<string>? LocalAuthReference
    {
        get => new TerraformReference<string>(this, "local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformValue<string>? ProviderAttribute
    {
        get => new TerraformReference<string>(this, "provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    public required TerraformValue<string> ReferenceType
    {
        get => new TerraformReference<string>(this, "reference_type");
        set => SetArgument("reference_type", value);
    }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    public required TerraformValue<string> ReferenceValue
    {
        get => new TerraformReference<string>(this, "reference_value");
        set => SetArgument("reference_value", value);
    }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SshKnownHostsBase64
    {
        get => new TerraformReference<string>(this, "ssh_known_hosts_base64");
        set => SetArgument("ssh_known_hosts_base64", value);
    }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    public TerraformValue<string>? SshPrivateKeyBase64
    {
        get => new TerraformReference<string>(this, "ssh_private_key_base64");
        set => SetArgument("ssh_private_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "depends_on").ResolveNodes(ctx));
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GarbageCollectionEnabled
    {
        get => new TerraformReference<bool>(this, "garbage_collection_enabled");
        set => SetArgument("garbage_collection_enabled", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RecreatingEnabled
    {
        get => new TerraformReference<bool>(this, "recreating_enabled");
        set => SetArgument("recreating_enabled", value);
    }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? RetryIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "retry_interval_in_seconds");
        set => SetArgument("retry_interval_in_seconds", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The wait attribute.
    /// </summary>
    public TerraformValue<bool>? Wait
    {
        get => new TerraformReference<bool>(this, "wait");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "substitute").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
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
    /// The optional attribute.
    /// </summary>
    public TerraformValue<bool>? Optional
    {
        get => new TerraformReference<bool>(this, "optional");
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
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ContinuousReconciliationEnabled
    {
        get => new TerraformReference<bool>(this, "continuous_reconciliation_enabled");
        set => SetArgument("continuous_reconciliation_enabled", value);
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
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
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
