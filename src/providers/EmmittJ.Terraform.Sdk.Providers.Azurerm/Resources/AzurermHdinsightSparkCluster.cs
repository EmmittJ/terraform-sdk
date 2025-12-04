using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for component_version in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterComponentVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "component_version";

    /// <summary>
    /// The spark attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spark is required")]
    public required TerraformValue<string> Spark
    {
        get => GetRequiredArgument<TerraformValue<string>>("spark");
        set => SetArgument("spark", value);
    }

}


/// <summary>
/// Block type for compute_isolation in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterComputeIsolationBlock : TerraformBlock
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
/// Block type for disk_encryption in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterDiskEncryptionBlock : TerraformBlock
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
/// Block type for extension in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterExtensionBlock : TerraformBlock
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
/// Block type for gateway in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterGatewayBlock : TerraformBlock
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
/// Block type for metastores in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMetastoresBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metastores";

    /// <summary>
    /// Ambari block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ambari block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterMetastoresBlockAmbariBlock>? Ambari
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterMetastoresBlockAmbariBlock>>("ambari");
        set => SetArgument("ambari", value);
    }

    /// <summary>
    /// Hive block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hive block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterMetastoresBlockHiveBlock>? Hive
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterMetastoresBlockHiveBlock>>("hive");
        set => SetArgument("hive", value);
    }

    /// <summary>
    /// Oozie block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oozie block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterMetastoresBlockOozieBlock>? Oozie
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterMetastoresBlockOozieBlock>>("oozie");
        set => SetArgument("oozie", value);
    }

}

/// <summary>
/// Block type for ambari in AzurermHdinsightSparkClusterMetastoresBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMetastoresBlockAmbariBlock : TerraformBlock
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
/// Block type for hive in AzurermHdinsightSparkClusterMetastoresBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMetastoresBlockHiveBlock : TerraformBlock
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
/// Block type for oozie in AzurermHdinsightSparkClusterMetastoresBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMetastoresBlockOozieBlock : TerraformBlock
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
/// Block type for monitor in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterMonitorBlock : TerraformBlock
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
/// Block type for network in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterNetworkBlock : TerraformBlock
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
/// Block type for private_link_configuration in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock : TerraformBlock
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
    public required TerraformList<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlockIpConfigurationBlock> IpConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlockIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

}

/// <summary>
/// Block type for ip_configuration in AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterPrivateLinkConfigurationBlockIpConfigurationBlock : TerraformBlock
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
/// Block type for roles in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "roles";

    /// <summary>
    /// HeadNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadNode block(s) allowed")]
    public required TerraformList<AzurermHdinsightSparkClusterRolesBlockHeadNodeBlock> HeadNode
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockHeadNodeBlock>>("head_node");
        set => SetArgument("head_node", value);
    }

    /// <summary>
    /// WorkerNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerNode block(s) allowed")]
    public required TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlock> WorkerNode
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlock>>("worker_node");
        set => SetArgument("worker_node", value);
    }

    /// <summary>
    /// ZookeeperNode block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZookeeperNode is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ZookeeperNode block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZookeeperNode block(s) allowed")]
    public required TerraformList<AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlock> ZookeeperNode
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlock>>("zookeeper_node");
        set => SetArgument("zookeeper_node", value);
    }

}

/// <summary>
/// Block type for head_node in AzurermHdinsightSparkClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockHeadNodeBlock : TerraformBlock
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
    public TerraformList<AzurermHdinsightSparkClusterRolesBlockHeadNodeBlockScriptActionsBlock>? ScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockHeadNodeBlockScriptActionsBlock>>("script_actions");
        set => SetArgument("script_actions", value);
    }

}

/// <summary>
/// Block type for script_actions in AzurermHdinsightSparkClusterRolesBlockHeadNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockHeadNodeBlockScriptActionsBlock : TerraformBlock
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
/// Block type for worker_node in AzurermHdinsightSparkClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlock : TerraformBlock
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
    public TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlock>? Autoscale
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlock>>("autoscale");
        set => SetArgument("autoscale", value);
    }

    /// <summary>
    /// ScriptActions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockScriptActionsBlock>? ScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockScriptActionsBlock>>("script_actions");
        set => SetArgument("script_actions", value);
    }

}

/// <summary>
/// Block type for autoscale in AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscale";

    /// <summary>
    /// Capacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockCapacityBlock>? Capacity
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockCapacityBlock>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// Recurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Recurrence block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock>? Recurrence
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock>>("recurrence");
        set => SetArgument("recurrence", value);
    }

}

/// <summary>
/// Block type for capacity in AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockCapacityBlock : TerraformBlock
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
/// Block type for recurrence in AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock : TerraformBlock
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
    public required TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockAutoscaleBlockRecurrenceBlockScheduleBlock : TerraformBlock
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
/// Block type for script_actions in AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockWorkerNodeBlockScriptActionsBlock : TerraformBlock
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
/// Block type for zookeeper_node in AzurermHdinsightSparkClusterRolesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlock : TerraformBlock
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
    public TerraformList<AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlockScriptActionsBlock>? ScriptActions
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlockScriptActionsBlock>>("script_actions");
        set => SetArgument("script_actions", value);
    }

}

/// <summary>
/// Block type for script_actions in AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterRolesBlockZookeeperNodeBlockScriptActionsBlock : TerraformBlock
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
/// Block type for security_profile in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterSecurityProfileBlock : TerraformBlock
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
/// Block type for storage_account in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterStorageAccountBlock : TerraformBlock
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
/// Block type for storage_account_gen2 in AzurermHdinsightSparkCluster.
/// Nesting mode: list
/// </summary>
public class AzurermHdinsightSparkClusterStorageAccountGen2Block : TerraformBlock
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
/// Block type for timeouts in AzurermHdinsightSparkCluster.
/// Nesting mode: single
/// </summary>
public class AzurermHdinsightSparkClusterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_hdinsight_spark_cluster Terraform resource.
/// Manages a azurerm_hdinsight_spark_cluster resource.
/// </summary>
public partial class AzurermHdinsightSparkCluster(string name) : TerraformResource("azurerm_hdinsight_spark_cluster", name)
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
    /// The encryption_in_transit_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionInTransitEnabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_in_transit_enabled");
        set => SetArgument("encryption_in_transit_enabled", value);
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
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
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
    public required TerraformList<AzurermHdinsightSparkClusterComponentVersionBlock> ComponentVersion
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterComponentVersionBlock>>("component_version");
        set => SetArgument("component_version", value);
    }

    /// <summary>
    /// ComputeIsolation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeIsolation block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterComputeIsolationBlock>? ComputeIsolation
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterComputeIsolationBlock>>("compute_isolation");
        set => SetArgument("compute_isolation", value);
    }

    /// <summary>
    /// DiskEncryption block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightSparkClusterDiskEncryptionBlock>? DiskEncryption
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterDiskEncryptionBlock>>("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Extension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extension block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterExtensionBlock>? Extension
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterExtensionBlock>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// Gateway block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gateway is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Gateway block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gateway block(s) allowed")]
    public required TerraformList<AzurermHdinsightSparkClusterGatewayBlock> Gateway
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterGatewayBlock>>("gateway");
        set => SetArgument("gateway", value);
    }

    /// <summary>
    /// Metastores block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metastores block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterMetastoresBlock>? Metastores
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterMetastoresBlock>>("metastores");
        set => SetArgument("metastores", value);
    }

    /// <summary>
    /// Monitor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitor block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterMonitorBlock>? Monitor
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterMonitorBlock>>("monitor");
        set => SetArgument("monitor", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterNetworkBlock>? Network
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// PrivateLinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLinkConfiguration block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock>? PrivateLinkConfiguration
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterPrivateLinkConfigurationBlock>>("private_link_configuration");
        set => SetArgument("private_link_configuration", value);
    }

    /// <summary>
    /// Roles block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Roles block(s) allowed")]
    public required TerraformList<AzurermHdinsightSparkClusterRolesBlock> Roles
    {
        get => GetRequiredArgument<TerraformList<AzurermHdinsightSparkClusterRolesBlock>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// SecurityProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterSecurityProfileBlock>? SecurityProfile
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterSecurityProfileBlock>>("security_profile");
        set => SetArgument("security_profile", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermHdinsightSparkClusterStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// StorageAccountGen2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccountGen2 block(s) allowed")]
    public TerraformList<AzurermHdinsightSparkClusterStorageAccountGen2Block>? StorageAccountGen2
    {
        get => GetArgument<TerraformList<AzurermHdinsightSparkClusterStorageAccountGen2Block>>("storage_account_gen2");
        set => SetArgument("storage_account_gen2", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHdinsightSparkClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHdinsightSparkClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
