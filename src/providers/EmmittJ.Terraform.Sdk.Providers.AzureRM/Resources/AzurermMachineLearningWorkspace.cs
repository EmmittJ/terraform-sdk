using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningWorkspaceEncryptionBlock() : TerraformBlock("encryption")
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for feature_store in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningWorkspaceFeatureStoreBlock() : TerraformBlock("feature_store")
{
    /// <summary>
    /// The computer_spark_runtime_version attribute.
    /// </summary>
    [TerraformProperty("computer_spark_runtime_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputerSparkRuntimeVersion { get; set; }

    /// <summary>
    /// The offline_connection_name attribute.
    /// </summary>
    [TerraformProperty("offline_connection_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OfflineConnectionName { get; set; }

    /// <summary>
    /// The online_connection_name attribute.
    /// </summary>
    [TerraformProperty("online_connection_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OnlineConnectionName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningWorkspaceIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for managed_network in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningWorkspaceManagedNetworkBlock() : TerraformBlock("managed_network")
{
    /// <summary>
    /// The isolation_mode attribute.
    /// </summary>
    [TerraformProperty("isolation_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IsolationMode { get; set; }

    /// <summary>
    /// The provision_on_creation_enabled attribute.
    /// </summary>
    [TerraformProperty("provision_on_creation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ProvisionOnCreationEnabled { get; set; }

}

/// <summary>
/// Block type for serverless_compute in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningWorkspaceServerlessComputeBlock() : TerraformBlock("serverless_compute")
{
    /// <summary>
    /// The public_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("public_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicIpEnabled { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMachineLearningWorkspaceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_machine_learning_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMachineLearningWorkspace : TerraformResource
{
    public AzurermMachineLearningWorkspace(string name) : base("azurerm_machine_learning_workspace", name)
    {
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    [TerraformProperty("application_insights_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationInsightsId { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformProperty("container_registry_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerRegistryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    [TerraformProperty("high_business_impact")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HighBusinessImpact { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_build_compute_name attribute.
    /// </summary>
    [TerraformProperty("image_build_compute_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImageBuildComputeName { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    [TerraformProperty("primary_user_assigned_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrimaryUserAssignedIdentity { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("service_side_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ServiceSideEncryptionEnabled { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    [TerraformProperty("v1_legacy_mode_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? V1LegacyModeEnabled { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformProperty("encryption")]
    public TerraformList<AzurermMachineLearningWorkspaceEncryptionBlock> Encryption { get; set; } = new();

    /// <summary>
    /// Block for feature_store.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureStore block(s) allowed")]
    [TerraformProperty("feature_store")]
    public TerraformList<AzurermMachineLearningWorkspaceFeatureStoreBlock> FeatureStore { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public required TerraformList<AzurermMachineLearningWorkspaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for managed_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedNetwork block(s) allowed")]
    [TerraformProperty("managed_network")]
    public TerraformList<AzurermMachineLearningWorkspaceManagedNetworkBlock> ManagedNetwork { get; set; } = new();

    /// <summary>
    /// Block for serverless_compute.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessCompute block(s) allowed")]
    [TerraformProperty("serverless_compute")]
    public TerraformList<AzurermMachineLearningWorkspaceServerlessComputeBlock> ServerlessCompute { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMachineLearningWorkspaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    [TerraformProperty("discovery_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DiscoveryUrl { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceId { get; }

}
