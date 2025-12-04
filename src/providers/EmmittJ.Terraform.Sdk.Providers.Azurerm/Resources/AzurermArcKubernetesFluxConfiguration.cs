using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for blob_storage in AzurermArcKubernetesFluxConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesFluxConfigurationBlobStorageBlock : TerraformBlock
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
    /// ServicePrincipal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipal block(s) allowed")]
    public TerraformList<AzurermArcKubernetesFluxConfigurationBlobStorageBlockServicePrincipalBlock>? ServicePrincipal
    {
        get => GetArgument<TerraformList<AzurermArcKubernetesFluxConfigurationBlobStorageBlockServicePrincipalBlock>>("service_principal");
        set => SetArgument("service_principal", value);
    }

}

/// <summary>
/// Block type for service_principal in AzurermArcKubernetesFluxConfigurationBlobStorageBlock.
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesFluxConfigurationBlobStorageBlockServicePrincipalBlock : TerraformBlock
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
/// Block type for bucket in AzurermArcKubernetesFluxConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesFluxConfigurationBucketBlock : TerraformBlock
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
/// Block type for git_repository in AzurermArcKubernetesFluxConfiguration.
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesFluxConfigurationGitRepositoryBlock : TerraformBlock
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
/// Block type for kustomizations in AzurermArcKubernetesFluxConfiguration.
/// Nesting mode: set
/// </summary>
public class AzurermArcKubernetesFluxConfigurationKustomizationsBlock : TerraformBlock
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

}


/// <summary>
/// Block type for timeouts in AzurermArcKubernetesFluxConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermArcKubernetesFluxConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_arc_kubernetes_flux_configuration Terraform resource.
/// Manages a azurerm_arc_kubernetes_flux_configuration resource.
/// </summary>
public partial class AzurermArcKubernetesFluxConfiguration(string name) : TerraformResource("azurerm_arc_kubernetes_flux_configuration", name)
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
    public TerraformList<AzurermArcKubernetesFluxConfigurationBlobStorageBlock>? BlobStorage
    {
        get => GetArgument<TerraformList<AzurermArcKubernetesFluxConfigurationBlobStorageBlock>>("blob_storage");
        set => SetArgument("blob_storage", value);
    }

    /// <summary>
    /// Bucket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    public TerraformList<AzurermArcKubernetesFluxConfigurationBucketBlock>? Bucket
    {
        get => GetArgument<TerraformList<AzurermArcKubernetesFluxConfigurationBucketBlock>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// GitRepository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public TerraformList<AzurermArcKubernetesFluxConfigurationGitRepositoryBlock>? GitRepository
    {
        get => GetArgument<TerraformList<AzurermArcKubernetesFluxConfigurationGitRepositoryBlock>>("git_repository");
        set => SetArgument("git_repository", value);
    }

    /// <summary>
    /// Kustomizations block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kustomizations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    public required TerraformSet<AzurermArcKubernetesFluxConfigurationKustomizationsBlock> Kustomizations
    {
        get => GetRequiredArgument<TerraformSet<AzurermArcKubernetesFluxConfigurationKustomizationsBlock>>("kustomizations");
        set => SetArgument("kustomizations", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcKubernetesFluxConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcKubernetesFluxConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
