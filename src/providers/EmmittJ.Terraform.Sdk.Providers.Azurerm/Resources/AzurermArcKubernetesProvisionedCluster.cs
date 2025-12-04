using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_active_directory in AzurermArcKubernetesProvisionedCluster.
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_active_directory";

    /// <summary>
    /// The admin_group_object_ids attribute.
    /// </summary>
    public TerraformList<string>? AdminGroupObjectIds
    {
        get => GetArgument<TerraformList<string>>("admin_group_object_ids");
        set => SetArgument("admin_group_object_ids", value);
    }

    /// <summary>
    /// The azure_rbac_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AzureRbacEnabled
    {
        get => GetArgument<TerraformValue<bool>>("azure_rbac_enabled");
        set => SetArgument("azure_rbac_enabled", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermArcKubernetesProvisionedCluster.
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesProvisionedClusterIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

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
/// Block type for timeouts in AzurermArcKubernetesProvisionedCluster.
/// Nesting mode: single
/// </summary>
public class AzurermArcKubernetesProvisionedClusterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_arc_kubernetes_provisioned_cluster Terraform resource.
/// Manages a azurerm_arc_kubernetes_provisioned_cluster resource.
/// </summary>
public partial class AzurermArcKubernetesProvisionedCluster(string name) : TerraformResource("azurerm_arc_kubernetes_provisioned_cluster", name)
{
    /// <summary>
    /// The arc_agent_auto_upgrade_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ArcAgentAutoUpgradeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("arc_agent_auto_upgrade_enabled");
        set => SetArgument("arc_agent_auto_upgrade_enabled", value);
    }

    /// <summary>
    /// The arc_agent_desired_version attribute.
    /// </summary>
    public TerraformValue<string>? ArcAgentDesiredVersion
    {
        get => GetArgument<TerraformValue<string>>("arc_agent_desired_version");
        set => SetArgument("arc_agent_desired_version", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
        => AsReference("agent_version");

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    public TerraformValue<string> Distribution
        => AsReference("distribution");

    /// <summary>
    /// The infrastructure attribute.
    /// </summary>
    public TerraformValue<string> Infrastructure
        => AsReference("infrastructure");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
        => AsReference("kubernetes_version");

    /// <summary>
    /// The offering attribute.
    /// </summary>
    public TerraformValue<string> Offering
        => AsReference("offering");

    /// <summary>
    /// The total_core_count attribute.
    /// </summary>
    public TerraformValue<double> TotalCoreCount
        => AsReference("total_core_count");

    /// <summary>
    /// The total_node_count attribute.
    /// </summary>
    public TerraformValue<double> TotalNodeCount
        => AsReference("total_node_count");

    /// <summary>
    /// AzureActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectory block(s) allowed")]
    public TerraformList<AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock>? AzureActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermArcKubernetesProvisionedClusterAzureActiveDirectoryBlock>>("azure_active_directory");
        set => SetArgument("azure_active_directory", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermArcKubernetesProvisionedClusterIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermArcKubernetesProvisionedClusterIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermArcKubernetesProvisionedClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermArcKubernetesProvisionedClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
