using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceEncryptionBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for feature_store in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceFeatureStoreBlock
{
    /// <summary>
    /// The computer_spark_runtime_version attribute.
    /// </summary>
    [TerraformPropertyName("computer_spark_runtime_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComputerSparkRuntimeVersion { get; set; }

    /// <summary>
    /// The offline_connection_name attribute.
    /// </summary>
    [TerraformPropertyName("offline_connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OfflineConnectionName { get; set; }

    /// <summary>
    /// The online_connection_name attribute.
    /// </summary>
    [TerraformPropertyName("online_connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OnlineConnectionName { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for managed_network in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceManagedNetworkBlock
{
    /// <summary>
    /// The isolation_mode attribute.
    /// </summary>
    [TerraformPropertyName("isolation_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IsolationMode { get; set; } = default!;

    /// <summary>
    /// The provision_on_creation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("provision_on_creation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProvisionOnCreationEnabled { get; set; }

}

/// <summary>
/// Block type for serverless_compute in .
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceServerlessComputeBlock
{
    /// <summary>
    /// The public_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicIpEnabled { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceTimeoutsBlock
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
    public required TerraformValue<string> ApplicationInsightsId { get; set; }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerRegistryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    [TerraformPropertyName("high_business_impact")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HighBusinessImpact { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The image_build_compute_name attribute.
    /// </summary>
    [TerraformPropertyName("image_build_compute_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImageBuildComputeName { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    [TerraformPropertyName("primary_user_assigned_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrimaryUserAssignedIdentity { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("service_side_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ServiceSideEncryptionEnabled { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SkuName { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    [TerraformPropertyName("v1_legacy_mode_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? V1LegacyModeEnabled { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceEncryptionBlock>>? Encryption { get; set; }

    /// <summary>
    /// Block for feature_store.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureStore block(s) allowed")]
    [TerraformPropertyName("feature_store")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceFeatureStoreBlock>>? FeatureStore { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for managed_network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedNetwork block(s) allowed")]
    [TerraformPropertyName("managed_network")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceManagedNetworkBlock>>? ManagedNetwork { get; set; }

    /// <summary>
    /// Block for serverless_compute.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessCompute block(s) allowed")]
    [TerraformPropertyName("serverless_compute")]
    public TerraformList<TerraformBlock<AzurermMachineLearningWorkspaceServerlessComputeBlock>>? ServerlessCompute { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMachineLearningWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    [TerraformPropertyName("discovery_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiscoveryUrl => new TerraformReference(this, "discovery_url");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceId => new TerraformReference(this, "workspace_id");

}
