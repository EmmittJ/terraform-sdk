using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for encryption in AzurermMachineLearningWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for feature_store in AzurermMachineLearningWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceFeatureStoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_store";

    /// <summary>
    /// The computer_spark_runtime_version attribute.
    /// </summary>
    public TerraformValue<string>? ComputerSparkRuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("computer_spark_runtime_version");
        set => SetArgument("computer_spark_runtime_version", value);
    }

    /// <summary>
    /// The offline_connection_name attribute.
    /// </summary>
    public TerraformValue<string>? OfflineConnectionName
    {
        get => GetArgument<TerraformValue<string>>("offline_connection_name");
        set => SetArgument("offline_connection_name", value);
    }

    /// <summary>
    /// The online_connection_name attribute.
    /// </summary>
    public TerraformValue<string>? OnlineConnectionName
    {
        get => GetArgument<TerraformValue<string>>("online_connection_name");
        set => SetArgument("online_connection_name", value);
    }

}


/// <summary>
/// Block type for identity in AzurermMachineLearningWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for managed_network in AzurermMachineLearningWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceManagedNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_network";

    /// <summary>
    /// The isolation_mode attribute.
    /// </summary>
    public TerraformValue<string>? IsolationMode
    {
        get => GetArgument<TerraformValue<string>>("isolation_mode");
        set => SetArgument("isolation_mode", value);
    }

    /// <summary>
    /// The provision_on_creation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ProvisionOnCreationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("provision_on_creation_enabled");
        set => SetArgument("provision_on_creation_enabled", value);
    }

}


/// <summary>
/// Block type for serverless_compute in AzurermMachineLearningWorkspace.
/// Nesting mode: list
/// </summary>
public class AzurermMachineLearningWorkspaceServerlessComputeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serverless_compute";

    /// <summary>
    /// The public_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_ip_enabled");
        set => SetArgument("public_ip_enabled", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMachineLearningWorkspace.
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_machine_learning_workspace Terraform resource.
/// Manages a azurerm_machine_learning_workspace resource.
/// </summary>
public partial class AzurermMachineLearningWorkspace(string name) : TerraformResource("azurerm_machine_learning_workspace", name)
{
    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => GetArgument<TerraformValue<string>>("application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public TerraformValue<string>? ContainerRegistryId
    {
        get => GetArgument<TerraformValue<string>>("container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => GetArgument<TerraformValue<string>>("friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The high_business_impact attribute.
    /// </summary>
    public TerraformValue<bool>? HighBusinessImpact
    {
        get => GetArgument<TerraformValue<bool>>("high_business_impact");
        set => SetArgument("high_business_impact", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_build_compute_name attribute.
    /// </summary>
    public TerraformValue<string>? ImageBuildComputeName
    {
        get => GetArgument<TerraformValue<string>>("image_build_compute_name");
        set => SetArgument("image_build_compute_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryUserAssignedIdentity
    {
        get => GetArgument<TerraformValue<string>>("primary_user_assigned_identity");
        set => SetArgument("primary_user_assigned_identity", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_side_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ServiceSideEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("service_side_encryption_enabled");
        set => SetArgument("service_side_encryption_enabled", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The v1_legacy_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? V1LegacyModeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("v1_legacy_mode_enabled");
        set => SetArgument("v1_legacy_mode_enabled", value);
    }

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    public TerraformValue<string> DiscoveryUrl
        => AsReference("discovery_url");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
        => AsReference("workspace_id");

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<AzurermMachineLearningWorkspaceEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AzurermMachineLearningWorkspaceEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// FeatureStore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureStore block(s) allowed")]
    public TerraformList<AzurermMachineLearningWorkspaceFeatureStoreBlock>? FeatureStore
    {
        get => GetArgument<TerraformList<AzurermMachineLearningWorkspaceFeatureStoreBlock>>("feature_store");
        set => SetArgument("feature_store", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermMachineLearningWorkspaceIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermMachineLearningWorkspaceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ManagedNetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedNetwork block(s) allowed")]
    public TerraformList<AzurermMachineLearningWorkspaceManagedNetworkBlock>? ManagedNetwork
    {
        get => GetArgument<TerraformList<AzurermMachineLearningWorkspaceManagedNetworkBlock>>("managed_network");
        set => SetArgument("managed_network", value);
    }

    /// <summary>
    /// ServerlessCompute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessCompute block(s) allowed")]
    public TerraformList<AzurermMachineLearningWorkspaceServerlessComputeBlock>? ServerlessCompute
    {
        get => GetArgument<TerraformList<AzurermMachineLearningWorkspaceServerlessComputeBlock>>("serverless_compute");
        set => SetArgument("serverless_compute", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMachineLearningWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMachineLearningWorkspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
