using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_id");
        set => WithProperty("key_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for feature_store in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceFeatureStoreBlock : TerraformBlock
{
    /// <summary>
    /// The computer_spark_runtime_version attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerSparkRuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("computer_spark_runtime_version");
        set => WithProperty("computer_spark_runtime_version", value);
    }

    /// <summary>
    /// The offline_connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? OfflineConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("offline_connection_name");
        set => WithProperty("offline_connection_name", value);
    }

    /// <summary>
    /// The online_connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? OnlineConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("online_connection_name");
        set => WithProperty("online_connection_name", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceIdentityBlock : TerraformBlock
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for managed_network in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceManagedNetworkBlock : TerraformBlock
{
    /// <summary>
    /// The isolation_mode attribute.
    /// </summary>
    public TerraformProperty<string>? IsolationMode
    {
        get => GetProperty<TerraformProperty<string>>("isolation_mode");
        set => WithProperty("isolation_mode", value);
    }

    /// <summary>
    /// The provision_on_creation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionOnCreationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("provision_on_creation_enabled");
        set => WithProperty("provision_on_creation_enabled", value);
    }

}

/// <summary>
/// Block type for serverless_compute in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceServerlessComputeBlock : TerraformBlock
{
    /// <summary>
    /// The public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_ip_enabled");
        set => WithProperty("public_ip_enabled", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_machine_learning_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMachineLearningWorkspace : TerraformResource
{
    public AzurermMachineLearningWorkspace(string name) : base("azurerm_machine_learning_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("discovery_url");
        this.WithOutput("workspace_id");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
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
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
    }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    public TerraformProperty<bool>? HighBusinessImpact
    {
        get => GetProperty<TerraformProperty<bool>>("high_business_impact");
        set => this.WithProperty("high_business_impact", value);
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
    /// The image_build_compute_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageBuildComputeName
    {
        get => GetProperty<TerraformProperty<string>>("image_build_compute_name");
        set => this.WithProperty("image_build_compute_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryUserAssignedIdentity
    {
        get => GetProperty<TerraformProperty<string>>("primary_user_assigned_identity");
        set => this.WithProperty("primary_user_assigned_identity", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ServiceSideEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("service_side_encryption_enabled");
        set => this.WithProperty("service_side_encryption_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
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
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? V1LegacyModeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("v1_legacy_mode_enabled");
        set => this.WithProperty("v1_legacy_mode_enabled", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceEncryptionBlock>? Encryption
    {
        get => GetProperty<List<AzurermMachineLearningWorkspaceEncryptionBlock>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// Block for feature_store.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureStore block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceFeatureStoreBlock>? FeatureStore
    {
        get => GetProperty<List<AzurermMachineLearningWorkspaceFeatureStoreBlock>>("feature_store");
        set => this.WithProperty("feature_store", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMachineLearningWorkspaceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for managed_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedNetwork block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceManagedNetworkBlock>? ManagedNetwork
    {
        get => GetProperty<List<AzurermMachineLearningWorkspaceManagedNetworkBlock>>("managed_network");
        set => this.WithProperty("managed_network", value);
    }

    /// <summary>
    /// Block for serverless_compute.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessCompute block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceServerlessComputeBlock>? ServerlessCompute
    {
        get => GetProperty<List<AzurermMachineLearningWorkspaceServerlessComputeBlock>>("serverless_compute");
        set => this.WithProperty("serverless_compute", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMachineLearningWorkspaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    public TerraformExpression DiscoveryUrl => this["discovery_url"];

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceId => this["workspace_id"];

}
