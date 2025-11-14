using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for blob_storage in .
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
    [TerraformArgument("account_key")]
    public TerraformValue<string>? AccountKey
    {
        get => new TerraformReference<string>(this, "account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformArgument("container_id")]
    public required TerraformValue<string> ContainerId
    {
        get => new TerraformReference<string>(this, "container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformArgument("local_auth_reference")]
    public TerraformValue<string>? LocalAuthReference
    {
        get => new TerraformReference<string>(this, "local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [TerraformArgument("sas_token")]
    public TerraformValue<string>? SasToken
    {
        get => new TerraformReference<string>(this, "sas_token");
        set => SetArgument("sas_token", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("sync_interval_in_seconds")]
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_in_seconds")]
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

}

/// <summary>
/// Block type for bucket in .
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
    [TerraformArgument("access_key")]
    public TerraformValue<string>? AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformArgument("bucket_name")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformArgument("local_auth_reference")]
    public TerraformValue<string>? LocalAuthReference
    {
        get => new TerraformReference<string>(this, "local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The secret_key_base64 attribute.
    /// </summary>
    [TerraformArgument("secret_key_base64")]
    public TerraformValue<string>? SecretKeyBase64
    {
        get => new TerraformReference<string>(this, "secret_key_base64");
        set => SetArgument("secret_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("sync_interval_in_seconds")]
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_in_seconds")]
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformArgument("tls_enabled")]
    public TerraformValue<bool>? TlsEnabled
    {
        get => new TerraformReference<bool>(this, "tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for git_repository in .
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
    [TerraformArgument("https_ca_cert_base64")]
    public TerraformValue<string>? HttpsCaCertBase64
    {
        get => new TerraformReference<string>(this, "https_ca_cert_base64");
        set => SetArgument("https_ca_cert_base64", value);
    }

    /// <summary>
    /// The https_key_base64 attribute.
    /// </summary>
    [TerraformArgument("https_key_base64")]
    public TerraformValue<string>? HttpsKeyBase64
    {
        get => new TerraformReference<string>(this, "https_key_base64");
        set => SetArgument("https_key_base64", value);
    }

    /// <summary>
    /// The https_user attribute.
    /// </summary>
    [TerraformArgument("https_user")]
    public TerraformValue<string>? HttpsUser
    {
        get => new TerraformReference<string>(this, "https_user");
        set => SetArgument("https_user", value);
    }

    /// <summary>
    /// The local_auth_reference attribute.
    /// </summary>
    [TerraformArgument("local_auth_reference")]
    public TerraformValue<string>? LocalAuthReference
    {
        get => new TerraformReference<string>(this, "local_auth_reference");
        set => SetArgument("local_auth_reference", value);
    }

    /// <summary>
    /// The reference_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceType is required")]
    [TerraformArgument("reference_type")]
    public required TerraformValue<string> ReferenceType
    {
        get => new TerraformReference<string>(this, "reference_type");
        set => SetArgument("reference_type", value);
    }

    /// <summary>
    /// The reference_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceValue is required")]
    [TerraformArgument("reference_value")]
    public required TerraformValue<string> ReferenceValue
    {
        get => new TerraformReference<string>(this, "reference_value");
        set => SetArgument("reference_value", value);
    }

    /// <summary>
    /// The ssh_known_hosts_base64 attribute.
    /// </summary>
    [TerraformArgument("ssh_known_hosts_base64")]
    public TerraformValue<string>? SshKnownHostsBase64
    {
        get => new TerraformReference<string>(this, "ssh_known_hosts_base64");
        set => SetArgument("ssh_known_hosts_base64", value);
    }

    /// <summary>
    /// The ssh_private_key_base64 attribute.
    /// </summary>
    [TerraformArgument("ssh_private_key_base64")]
    public TerraformValue<string>? SshPrivateKeyBase64
    {
        get => new TerraformReference<string>(this, "ssh_private_key_base64");
        set => SetArgument("ssh_private_key_base64", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("sync_interval_in_seconds")]
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_in_seconds")]
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for kustomizations in .
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
    [TerraformArgument("depends_on")]
    public TerraformList<string>? DependsOn
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "depends_on").ResolveNodes(ctx));
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// The garbage_collection_enabled attribute.
    /// </summary>
    [TerraformArgument("garbage_collection_enabled")]
    public TerraformValue<bool>? GarbageCollectionEnabled
    {
        get => new TerraformReference<bool>(this, "garbage_collection_enabled");
        set => SetArgument("garbage_collection_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The recreating_enabled attribute.
    /// </summary>
    [TerraformArgument("recreating_enabled")]
    public TerraformValue<bool>? RecreatingEnabled
    {
        get => new TerraformReference<bool>(this, "recreating_enabled");
        set => SetArgument("recreating_enabled", value);
    }

    /// <summary>
    /// The retry_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("retry_interval_in_seconds")]
    public TerraformValue<double>? RetryIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "retry_interval_in_seconds");
        set => SetArgument("retry_interval_in_seconds", value);
    }

    /// <summary>
    /// The sync_interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("sync_interval_in_seconds")]
    public TerraformValue<double>? SyncIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "sync_interval_in_seconds");
        set => SetArgument("sync_interval_in_seconds", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_in_seconds")]
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_arc_kubernetes_flux_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermArcKubernetesFluxConfiguration : TerraformResource
{
    public AzurermArcKubernetesFluxConfiguration(string name) : base("azurerm_arc_kubernetes_flux_configuration", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformArgument("cluster_id")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The continuous_reconciliation_enabled attribute.
    /// </summary>
    [TerraformArgument("continuous_reconciliation_enabled")]
    public TerraformValue<bool>? ContinuousReconciliationEnabled
    {
        get => new TerraformReference<bool>(this, "continuous_reconciliation_enabled");
        set => SetArgument("continuous_reconciliation_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformArgument("namespace")]
    public required TerraformValue<string> Namespace
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformArgument("scope")]
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Block for blob_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlobStorage block(s) allowed")]
    [TerraformArgument("blob_storage")]
    public TerraformList<AzurermArcKubernetesFluxConfigurationBlobStorageBlock> BlobStorage { get; set; } = new();

    /// <summary>
    /// Block for bucket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    [TerraformArgument("bucket")]
    public TerraformList<AzurermArcKubernetesFluxConfigurationBucketBlock> Bucket { get; set; } = new();

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    [TerraformArgument("git_repository")]
    public TerraformList<AzurermArcKubernetesFluxConfigurationGitRepositoryBlock> GitRepository { get; set; } = new();

    /// <summary>
    /// Block for kustomizations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kustomizations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Kustomizations block(s) required")]
    [TerraformArgument("kustomizations")]
    public required TerraformSet<AzurermArcKubernetesFluxConfigurationKustomizationsBlock> Kustomizations { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermArcKubernetesFluxConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
