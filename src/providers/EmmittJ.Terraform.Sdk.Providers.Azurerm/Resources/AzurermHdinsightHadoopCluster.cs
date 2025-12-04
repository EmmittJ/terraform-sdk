using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for component_version in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterComponentVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component_version";

    /// <summary>
    /// The hadoop attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hadoop is required")]
    public required TerraformValue<string> Hadoop
    {
        get => GetRequiredArgument<TerraformValue<string>>("hadoop");
        set => SetArgument("hadoop", value);
    }

}


/// <summary>
/// Block type for compute_isolation in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterComputeIsolationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_isolation";

    /// <summary>
    /// The compute_isolation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ComputeIsolationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("compute_isolation_enabled");
        set => SetArgument("compute_isolation_enabled", value);
    }

    /// <summary>
    /// The host_sku attribute.
    /// </summary>
    public TerraformValue<string>? HostSku
    {
        get => GetArgument<TerraformValue<string>>("host_sku");
        set => SetArgument("host_sku", value);
    }

}


/// <summary>
/// Block type for disk_encryption in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption";

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_managed_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultManagedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_managed_identity_id");
        set => SetArgument("key_vault_managed_identity_id", value);
    }

}


/// <summary>
/// Block type for extension in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    public required TerraformValue<string> PrimaryKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("primary_key");
        set => SetArgument("primary_key", value);
    }

}


/// <summary>
/// Block type for gateway in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterGatewayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for metastores in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterMetastoresBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metastores";

    /// <summary>
    /// Ambari block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ambari block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterMetastoresBlockAmbariBlock>? Ambari
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterMetastoresBlockAmbariBlock>>("ambari");
        set => SetArgument("ambari", value);
    }

    /// <summary>
    /// Hive block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hive block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterMetastoresBlockHiveBlock>? Hive
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterMetastoresBlockHiveBlock>>("hive");
        set => SetArgument("hive", value);
    }

    /// <summary>
    /// Oozie block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oozie block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterMetastoresBlockOozieBlock>? Oozie
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterMetastoresBlockOozieBlock>>("oozie");
        set => SetArgument("oozie", value);
    }

}

/// <summary>
/// Block type for ambari in AzurermHdinsightHadoopClusterMetastoresBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterMetastoresBlockAmbariBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ambari";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for hive in AzurermHdinsightHadoopClusterMetastoresBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterMetastoresBlockHiveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for oozie in AzurermHdinsightHadoopClusterMetastoresBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterMetastoresBlockOozieBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oozie";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetRequiredArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for monitor in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterMonitorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor";

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKey is required")]
    public required TerraformValue<string> PrimaryKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("primary_key");
        set => SetArgument("primary_key", value);
    }

}


/// <summary>
/// Block type for network in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network";

    /// <summary>
    /// The connection_direction attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionDirection
    {
        get => GetArgument<TerraformValue<string>>("connection_direction");
        set => SetArgument("connection_direction", value);
    }

    /// <summary>
    /// The private_link_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateLinkEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_link_enabled");
        set => SetArgument("private_link_enabled", value);
    }

}


/// <summary>
/// Block type for private_link_configuration in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_link_configuration";

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
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
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfiguration block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlockIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

}

/// <summary>
/// Block type for ip_configuration in AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlockIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

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
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The private_ip_allocation_method attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAllocationMethod
    {
        get => GetArgument<TerraformValue<string>>("private_ip_allocation_method");
        set => SetArgument("private_ip_allocation_method", value);
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
/// Block type for roles in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "roles";

    /// <summary>
    /// EdgeNode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EdgeNode block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlock>? EdgeNode
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlock>>("edge_node");
        set => SetArgument("edge_node", value);
    }

    /// <summary>
    /// HeadNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadNode block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlock> HeadNode
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlock>>("head_node");
        set => SetArgument("head_node", value);
    }

    /// <summary>
    /// WorkerNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerNode block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlock> WorkerNode
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlock>>("worker_node");
        set => SetArgument("worker_node", value);
    }

    /// <summary>
    /// ZookeeperNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZookeeperNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ZookeeperNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZookeeperNode block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlock> ZookeeperNode
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlock>>("zookeeper_node");
        set => SetArgument("zookeeper_node", value);
    }

}

/// <summary>
/// Block type for edge_node in AzurermHdinsightHadoopClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "edge_node";

    /// <summary>
    /// The target_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetInstanceCount is required")]
    public required TerraformValue<double> TargetInstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_instance_count");
        set => SetArgument("target_instance_count", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// HttpsEndpoints block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockHttpsEndpointsBlock>? HttpsEndpoints
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockHttpsEndpointsBlock>>("https_endpoints");
        set => SetArgument("https_endpoints", value);
    }

    /// <summary>
    /// InstallScriptAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstallScriptAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstallScriptAction block(s) required")]
    public required TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockInstallScriptActionBlock> InstallScriptAction
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockInstallScriptActionBlock>>("install_script_action");
        set => SetArgument("install_script_action", value);
    }

    /// <summary>
    /// UninstallScriptActions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockUninstallScriptActionsBlock>? UninstallScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockUninstallScriptActionsBlock>>("uninstall_script_actions");
        set => SetArgument("uninstall_script_actions", value);
    }

}

/// <summary>
/// Block type for https_endpoints in AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockHttpsEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "https_endpoints";

    /// <summary>
    /// The access_modes attribute.
    /// </summary>
    public TerraformList<string>? AccessModes
    {
        get => GetArgument<TerraformList<string>>("access_modes");
        set => SetArgument("access_modes", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformValue<double>? DestinationPort
    {
        get => GetArgument<TerraformValue<double>>("destination_port");
        set => SetArgument("destination_port", value);
    }

    /// <summary>
    /// The disable_gateway_auth attribute.
    /// </summary>
    public TerraformValue<bool>? DisableGatewayAuth
    {
        get => GetArgument<TerraformValue<bool>>("disable_gateway_auth");
        set => SetArgument("disable_gateway_auth", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The sub_domain_suffix attribute.
    /// </summary>
    public TerraformValue<string>? SubDomainSuffix
    {
        get => GetArgument<TerraformValue<string>>("sub_domain_suffix");
        set => SetArgument("sub_domain_suffix", value);
    }

}

/// <summary>
/// Block type for install_script_action in AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockInstallScriptActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "install_script_action";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for uninstall_script_actions in AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockEdgeNodeBlockUninstallScriptActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "uninstall_script_actions";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for head_node in AzurermHdinsightHadoopClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "head_node";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The ssh_keys attribute.
    /// </summary>
    public TerraformSet<string>? SshKeys
    {
        get => GetArgument<TerraformSet<string>>("ssh_keys");
        set => SetArgument("ssh_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// ScriptActions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlockScriptActionsBlock>? ScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlockScriptActionsBlock>>("script_actions");
        set => SetArgument("script_actions", value);
    }

}

/// <summary>
/// Block type for script_actions in AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockHeadNodeBlockScriptActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "script_actions";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for worker_node in AzurermHdinsightHadoopClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_node";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The ssh_keys attribute.
    /// </summary>
    public TerraformSet<string>? SshKeys
    {
        get => GetArgument<TerraformSet<string>>("ssh_keys");
        set => SetArgument("ssh_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The target_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetInstanceCount is required")]
    public required TerraformValue<double> TargetInstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_instance_count");
        set => SetArgument("target_instance_count", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// Autoscale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscale block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlock>? Autoscale
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlock>>("autoscale");
        set => SetArgument("autoscale", value);
    }

    /// <summary>
    /// ScriptActions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockScriptActionsBlock>? ScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockScriptActionsBlock>>("script_actions");
        set => SetArgument("script_actions", value);
    }

}

/// <summary>
/// Block type for autoscale in AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscale";

    /// <summary>
    /// Capacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockCapacityBlock>? Capacity
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockCapacityBlock>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// Recurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Recurrence block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock>? Recurrence
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock>>("recurrence");
        set => SetArgument("recurrence", value);
    }

}

/// <summary>
/// Block type for capacity in AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity";

    /// <summary>
    /// The max_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstanceCount is required")]
    public required TerraformValue<double> MaxInstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_instance_count");
        set => SetArgument("max_instance_count", value);
    }

    /// <summary>
    /// The min_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinInstanceCount is required")]
    public required TerraformValue<double> MinInstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_instance_count");
        set => SetArgument("min_instance_count", value);
    }

}

/// <summary>
/// Block type for recurrence in AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurrence";

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timezone is required")]
    public required TerraformValue<string> Timezone
    {
        get => GetRequiredArgument<TerraformValue<string>>("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    public required TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public TerraformList<string>? Days
    {
        get => GetArgument<TerraformList<string>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The target_instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetInstanceCount is required")]
    public required TerraformValue<double> TargetInstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_instance_count");
        set => SetArgument("target_instance_count", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => GetRequiredArgument<TerraformValue<string>>("time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for script_actions in AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockWorkerNodeBlockScriptActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "script_actions";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for zookeeper_node in AzurermHdinsightHadoopClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zookeeper_node";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The ssh_keys attribute.
    /// </summary>
    public TerraformSet<string>? SshKeys
    {
        get => GetArgument<TerraformSet<string>>("ssh_keys");
        set => SetArgument("ssh_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// ScriptActions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlockScriptActionsBlock>? ScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlockScriptActionsBlock>>("script_actions");
        set => SetArgument("script_actions", value);
    }

}

/// <summary>
/// Block type for script_actions in AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterRolesBlockZookeeperNodeBlockScriptActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "script_actions";

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
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for security_profile in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterSecurityProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_profile";

    /// <summary>
    /// The aadds_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AaddsResourceId is required")]
    public required TerraformValue<string> AaddsResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("aadds_resource_id");
        set => SetArgument("aadds_resource_id", value);
    }

    /// <summary>
    /// The cluster_users_group_dns attribute.
    /// </summary>
    public TerraformSet<string>? ClusterUsersGroupDns
    {
        get => GetArgument<TerraformSet<string>>("cluster_users_group_dns");
        set => SetArgument("cluster_users_group_dns", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_user_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUserPassword is required")]
    public required TerraformValue<string> DomainUserPassword
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_user_password");
        set => SetArgument("domain_user_password", value);
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainUsername is required")]
    public required TerraformValue<string> DomainUsername
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_username");
        set => SetArgument("domain_username", value);
    }

    /// <summary>
    /// The ldaps_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LdapsUrls is required")]
    public required TerraformSet<string> LdapsUrls
    {
        get => GetRequiredArgument<TerraformSet<string>>("ldaps_urls");
        set => SetArgument("ldaps_urls", value);
    }

    /// <summary>
    /// The msi_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MsiResourceId is required")]
    public required TerraformValue<string> MsiResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("msi_resource_id");
        set => SetArgument("msi_resource_id", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account";

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    public required TerraformValue<bool> IsDefault
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformValue<string> StorageAccountKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_key");
        set => SetArgument("storage_account_key", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformValue<string> StorageContainerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_container_id");
        set => SetArgument("storage_container_id", value);
    }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageResourceId
    {
        get => GetArgument<TerraformValue<string>>("storage_resource_id");
        set => SetArgument("storage_resource_id", value);
    }

}


/// <summary>
/// Block type for storage_account_gen2 in AzurermHdinsightHadoopCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightHadoopClusterStorageAccountGen2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account_gen2";

    /// <summary>
    /// The filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilesystemId is required")]
    public required TerraformValue<string> FilesystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("filesystem_id");
        set => SetArgument("filesystem_id", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDefault is required")]
    public required TerraformValue<bool> IsDefault
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The managed_identity_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedIdentityResourceId is required")]
    public required TerraformValue<string> ManagedIdentityResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_identity_resource_id");
        set => SetArgument("managed_identity_resource_id", value);
    }

    /// <summary>
    /// The storage_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageResourceId is required")]
    public required TerraformValue<string> StorageResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_resource_id");
        set => SetArgument("storage_resource_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermHdinsightHadoopCluster.
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightHadoopClusterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_hdinsight_hadoop_cluster Terraform resource.
/// Manages a azurerm_hdinsight_hadoop_cluster resource.
/// </summary>
public partial class AzurermHdinsightHadoopCluster(string name) : TerraformResource("azurerm_hdinsight_hadoop_cluster", name)
{
    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterVersion is required")]
    public required TerraformValue<string> ClusterVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_version");
        set => SetArgument("cluster_version", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
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
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetRequiredArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The tls_min_version attribute.
    /// </summary>
    public TerraformValue<string>? TlsMinVersion
    {
        get => GetArgument<TerraformValue<string>>("tls_min_version");
        set => SetArgument("tls_min_version", value);
    }

    /// <summary>
    /// The https_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HttpsEndpoint
        => AsReference("https_endpoint");

    /// <summary>
    /// The ssh_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SshEndpoint
        => AsReference("ssh_endpoint");

    /// <summary>
    /// ComponentVersion block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentVersion is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComponentVersion block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComponentVersion block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterComponentVersionBlock> ComponentVersion
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterComponentVersionBlock>>("component_version");
        set => SetArgument("component_version", value);
    }

    /// <summary>
    /// ComputeIsolation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeIsolation block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterComputeIsolationBlock>? ComputeIsolation
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterComputeIsolationBlock>>("compute_isolation");
        set => SetArgument("compute_isolation", value);
    }

    /// <summary>
    /// DiskEncryption block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterDiskEncryptionBlock>? DiskEncryption
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterDiskEncryptionBlock>>("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Extension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extension block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterExtensionBlock>? Extension
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// Gateway block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Gateway block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterGatewayBlock> Gateway
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterGatewayBlock>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// Metastores block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metastores block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterMetastoresBlock>? Metastores
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterMetastoresBlock>>("metastores");
        set => SetArgument("metastores", value);
    }

    /// <summary>
    /// Monitor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitor block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterMonitorBlock>? Monitor
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterMonitorBlock>>("monitor");
        set => SetArgument("monitor", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterNetworkBlock>? Network
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// PrivateLinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLinkConfiguration block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterPrivateLinkConfigurationBlock>>("private_link_configuration");
        set => SetArgument("private_link_configuration", value);
    }

    /// <summary>
    /// Roles block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Roles block(s) allowed")]
    public required TerraformList<AzurermHdinsightHadoopClusterRolesBlock> Roles
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightHadoopClusterRolesBlock>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// SecurityProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterSecurityProfileBlock>? SecurityProfile
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterSecurityProfileBlock>>("security_profile");
        set => SetArgument("security_profile", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightHadoopClusterStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// StorageAccountGen2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccountGen2 block(s) allowed")]
    public TerraformList<AzurermHdinsightHadoopClusterStorageAccountGen2Block>? StorageAccountGen2
    {
        get => GetArgument<TerraformList<AzurermHdinsightHadoopClusterStorageAccountGen2Block>>("storage_account_gen2");
        set => SetArgument("storage_account_gen2", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHdinsightHadoopClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHdinsightHadoopClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
