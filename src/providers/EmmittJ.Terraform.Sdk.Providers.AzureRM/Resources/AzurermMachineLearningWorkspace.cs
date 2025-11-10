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
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
        set => SetProperty("computer_spark_runtime_version", value);
    }

    /// <summary>
    /// The offline_connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? OfflineConnectionName
    {
        set => SetProperty("offline_connection_name", value);
    }

    /// <summary>
    /// The online_connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? OnlineConnectionName
    {
        set => SetProperty("online_connection_name", value);
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
        set => SetProperty("isolation_mode", value);
    }

    /// <summary>
    /// The provision_on_creation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionOnCreationEnabled
    {
        set => SetProperty("provision_on_creation_enabled", value);
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
        set => SetProperty("public_ip_enabled", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
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
        SetOutput("discovery_url");
        SetOutput("workspace_id");
        SetOutput("application_insights_id");
        SetOutput("container_registry_id");
        SetOutput("description");
        SetOutput("friendly_name");
        SetOutput("high_business_impact");
        SetOutput("id");
        SetOutput("image_build_compute_name");
        SetOutput("key_vault_id");
        SetOutput("kind");
        SetOutput("location");
        SetOutput("name");
        SetOutput("primary_user_assigned_identity");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("service_side_encryption_enabled");
        SetOutput("sku_name");
        SetOutput("storage_account_id");
        SetOutput("tags");
        SetOutput("v1_legacy_mode_enabled");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_insights_id");
        set => SetProperty("application_insights_id", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformProperty<string> ContainerRegistryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_registry_id");
        set => SetProperty("container_registry_id", value);
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
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
    }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    public TerraformProperty<bool> HighBusinessImpact
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("high_business_impact");
        set => SetProperty("high_business_impact", value);
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
    /// The image_build_compute_name attribute.
    /// </summary>
    public TerraformProperty<string> ImageBuildComputeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_build_compute_name");
        set => SetProperty("image_build_compute_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryUserAssignedIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_user_assigned_identity");
        set => SetProperty("primary_user_assigned_identity", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ServiceSideEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("service_side_encryption_enabled");
        set => SetProperty("service_side_encryption_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
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
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> V1LegacyModeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("v1_legacy_mode_enabled");
        set => SetProperty("v1_legacy_mode_enabled", value);
    }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceEncryptionBlock>? Encryption
    {
        set => SetProperty("encryption", value);
    }

    /// <summary>
    /// Block for feature_store.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureStore block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceFeatureStoreBlock>? FeatureStore
    {
        set => SetProperty("feature_store", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for managed_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedNetwork block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceManagedNetworkBlock>? ManagedNetwork
    {
        set => SetProperty("managed_network", value);
    }

    /// <summary>
    /// Block for serverless_compute.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessCompute block(s) allowed")]
    public List<AzurermMachineLearningWorkspaceServerlessComputeBlock>? ServerlessCompute
    {
        set => SetProperty("serverless_compute", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningWorkspaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
