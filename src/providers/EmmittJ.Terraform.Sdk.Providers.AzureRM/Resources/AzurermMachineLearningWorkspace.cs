using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for feature_store in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceFeatureStoreBlock : ITerraformBlock
{
    /// <summary>
    /// The computer_spark_runtime_version attribute.
    /// </summary>
    [TerraformPropertyName("computer_spark_runtime_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ComputerSparkRuntimeVersion { get; set; }

    /// <summary>
    /// The offline_connection_name attribute.
    /// </summary>
    [TerraformPropertyName("offline_connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OfflineConnectionName { get; set; }

    /// <summary>
    /// The online_connection_name attribute.
    /// </summary>
    [TerraformPropertyName("online_connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OnlineConnectionName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for managed_network in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceManagedNetworkBlock : ITerraformBlock
{
    /// <summary>
    /// The isolation_mode attribute.
    /// </summary>
    [TerraformPropertyName("isolation_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IsolationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "isolation_mode");

    /// <summary>
    /// The provision_on_creation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("provision_on_creation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProvisionOnCreationEnabled { get; set; }

}

/// <summary>
/// Block type for serverless_compute in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceServerlessComputeBlock : ITerraformBlock
{
    /// <summary>
    /// The public_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicIpEnabled { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_machine_learning_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMachineLearningWorkspace : TerraformResource
{
    public AzurermMachineLearningWorkspace(string name) : base("azurerm_machine_learning_workspace", name)
    {
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    [TerraformPropertyName("application_insights_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationInsightsId { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerRegistryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FriendlyName { get; set; }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    [TerraformPropertyName("high_business_impact")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HighBusinessImpact { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The image_build_compute_name attribute.
    /// </summary>
    [TerraformPropertyName("image_build_compute_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageBuildComputeName { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Kind { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    [TerraformPropertyName("primary_user_assigned_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrimaryUserAssignedIdentity { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("service_side_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ServiceSideEncryptionEnabled { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SkuName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    [TerraformPropertyName("v1_legacy_mode_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? V1LegacyModeEnabled { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceEncryptionBlock>>? Encryption { get; set; } = new();

    /// <summary>
    /// Block for feature_store.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureStore block(s) allowed")]
    [TerraformPropertyName("feature_store")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceFeatureStoreBlock>>? FeatureStore { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for managed_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedNetwork block(s) allowed")]
    [TerraformPropertyName("managed_network")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceManagedNetworkBlock>>? ManagedNetwork { get; set; } = new();

    /// <summary>
    /// Block for serverless_compute.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessCompute block(s) allowed")]
    [TerraformPropertyName("serverless_compute")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceServerlessComputeBlock>>? ServerlessCompute { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMachineLearningWorkspaceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    [TerraformPropertyName("discovery_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiscoveryUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "discovery_url");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_id");

}
