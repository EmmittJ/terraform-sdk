using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in GoogleContainerAzureCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// AdminGroups block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerAzureClusterAuthorizationBlockAdminGroupsBlock>? AdminGroups
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterAuthorizationBlockAdminGroupsBlock>>("admin_groups");
        set => SetArgument("admin_groups", value);
    }

    /// <summary>
    /// AdminUsers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AdminUsers block(s) required")]
    public required TerraformList<GoogleContainerAzureClusterAuthorizationBlockAdminUsersBlock> AdminUsers
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureClusterAuthorizationBlockAdminUsersBlock>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}

/// <summary>
/// Block type for admin_groups in GoogleContainerAzureClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterAuthorizationBlockAdminGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_groups";

    /// <summary>
    /// The name of the group, e.g. `my-group@domain.com`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformValue<string> Group
    {
        get => GetRequiredArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

}

/// <summary>
/// Block type for admin_users in GoogleContainerAzureClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterAuthorizationBlockAdminUsersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_users";

    /// <summary>
    /// The name of the user, e.g. `my-gcp-id@gmail.com`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for azure_services_authentication in GoogleContainerAzureCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterAzureServicesAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_services_authentication";

    /// <summary>
    /// The Azure Active Directory Application ID for Authentication configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The Azure Active Directory Tenant ID for Authentication configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for control_plane in GoogleContainerAzureCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane";

    /// <summary>
    /// The ARM ID of the subnet where the control plane VMs are deployed. Example: `/subscriptions//resourceGroups//providers/Microsoft.Network/virtualNetworks//subnets/default`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// Optional. A set of tags to apply to all underlying control plane Azure resources.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The Kubernetes version to run on control plane replicas (e.g. `1.19.10-gke.1000`). You can list all supported versions on a given Google Cloud region by calling GetAzureServerConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Optional. The Azure VM size name. Example: `Standard_DS2_v2`. For available VM sizes, see https://docs.microsoft.com/en-us/azure/virtual-machines/vm-naming-conventions. When unspecified, it defaults to `Standard_DS2_v2`.
    /// </summary>
    public TerraformValue<string> VmSize
    {
        get => GetArgument<TerraformValue<string>>("vm_size") ?? CreateReference("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// DatabaseEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    public TerraformList<GoogleContainerAzureClusterControlPlaneBlockDatabaseEncryptionBlock>? DatabaseEncryption
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlockDatabaseEncryptionBlock>>("database_encryption");
        set => SetArgument("database_encryption", value);
    }

    /// <summary>
    /// MainVolume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MainVolume block(s) allowed")]
    public TerraformList<GoogleContainerAzureClusterControlPlaneBlockMainVolumeBlock>? MainVolume
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlockMainVolumeBlock>>("main_volume");
        set => SetArgument("main_volume", value);
    }

    /// <summary>
    /// ProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    public TerraformList<GoogleContainerAzureClusterControlPlaneBlockProxyConfigBlock>? ProxyConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlockProxyConfigBlock>>("proxy_config");
        set => SetArgument("proxy_config", value);
    }

    /// <summary>
    /// ReplicaPlacements block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerAzureClusterControlPlaneBlockReplicaPlacementsBlock>? ReplicaPlacements
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlockReplicaPlacementsBlock>>("replica_placements");
        set => SetArgument("replica_placements", value);
    }

    /// <summary>
    /// RootVolume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolume block(s) allowed")]
    public TerraformList<GoogleContainerAzureClusterControlPlaneBlockRootVolumeBlock>? RootVolume
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlockRootVolumeBlock>>("root_volume");
        set => SetArgument("root_volume", value);
    }

    /// <summary>
    /// SshConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SshConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshConfig block(s) allowed")]
    public required TerraformList<GoogleContainerAzureClusterControlPlaneBlockSshConfigBlock> SshConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlockSshConfigBlock>>("ssh_config");
        set => SetArgument("ssh_config", value);
    }

}

/// <summary>
/// Block type for database_encryption in GoogleContainerAzureClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlockDatabaseEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_encryption";

    /// <summary>
    /// The ARM ID of the Azure Key Vault key to encrypt / decrypt data. For example: `/subscriptions/&amp;lt;subscription-id&amp;gt;/resourceGroups/&amp;lt;resource-group-id&amp;gt;/providers/Microsoft.KeyVault/vaults/&amp;lt;key-vault-id&amp;gt;/keys/&amp;lt;key-name&amp;gt;` Encryption will always take the latest version of the key and hence specific version is not supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

}

/// <summary>
/// Block type for main_volume in GoogleContainerAzureClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlockMainVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "main_volume";

    /// <summary>
    /// Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.
    /// </summary>
    public TerraformValue<double> SizeGib
    {
        get => GetArgument<TerraformValue<double>>("size_gib") ?? CreateReference("size_gib");
        set => SetArgument("size_gib", value);
    }

}

/// <summary>
/// Block type for proxy_config in GoogleContainerAzureClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlockProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_config";

    /// <summary>
    /// The ARM ID the of the resource group containing proxy keyvault. Resource group ids are formatted as `/subscriptions/&amp;lt;subscription-id&amp;gt;/resourceGroups/&amp;lt;resource-group-name&amp;gt;`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The URL the of the proxy setting secret with its version. Secret ids are formatted as `https:&amp;lt;key-vault-name&amp;gt;.vault.azure.net/secrets/&amp;lt;secret-name&amp;gt;/&amp;lt;secret-version&amp;gt;`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

}

/// <summary>
/// Block type for replica_placements in GoogleContainerAzureClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlockReplicaPlacementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica_placements";

    /// <summary>
    /// For a given replica, the Azure availability zone where to provision the control plane VM and the ETCD disk.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureAvailabilityZone is required")]
    public required TerraformValue<string> AzureAvailabilityZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("azure_availability_zone");
        set => SetArgument("azure_availability_zone", value);
    }

    /// <summary>
    /// For a given replica, the ARM ID of the subnet where the control plane VM is deployed. Make sure it&#39;s a subnet under the virtual network in the cluster configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for root_volume in GoogleContainerAzureClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlockRootVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_volume";

    /// <summary>
    /// Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.
    /// </summary>
    public TerraformValue<double> SizeGib
    {
        get => GetArgument<TerraformValue<double>>("size_gib") ?? CreateReference("size_gib");
        set => SetArgument("size_gib", value);
    }

}

/// <summary>
/// Block type for ssh_config in GoogleContainerAzureClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterControlPlaneBlockSshConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_config";

    /// <summary>
    /// The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizedKey is required")]
    public required TerraformValue<string> AuthorizedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("authorized_key");
        set => SetArgument("authorized_key", value);
    }

}


/// <summary>
/// Block type for fleet in GoogleContainerAzureCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet";

    /// <summary>
    /// The name of the managed Hub Membership resource associated to this cluster. Membership names are formatted as projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;.
    /// </summary>
    public TerraformValue<string> Membership
        => CreateReference("membership");

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for networking in GoogleContainerAzureCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAzureClusterNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networking";

    /// <summary>
    /// The IP address range of the pods in this cluster, in CIDR notation (e.g. `10.96.0.0/14`). All pods in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    public TerraformList<string>? PodAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("pod_address_cidr_blocks");
        set => SetArgument("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// The IP address range for services in this cluster, in CIDR notation (e.g. `10.96.0.0/14`). All services in the cluster get assigned a unique RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creating a cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public TerraformList<string>? ServiceAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("service_address_cidr_blocks");
        set => SetArgument("service_address_cidr_blocks", value);
    }

    /// <summary>
    /// The Azure Resource Manager (ARM) ID of the VNet associated with your cluster. All components in the cluster (i.e. control plane and node pools) run on a single VNet. Example: `/subscriptions/*/resourceGroups/*/providers/Microsoft.Network/virtualNetworks/*` This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAzureCluster.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAzureClusterTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_container_azure_cluster Terraform resource.
/// Manages a google_container_azure_cluster resource.
/// </summary>
public partial class GoogleContainerAzureCluster(string name) : TerraformResource("google_container_azure_cluster", name)
{
    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The Azure region where the cluster runs. Each Google Cloud region supports a subset of nearby Azure regions. You can call to list all supported Azure regions within a given Google Cloud region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureRegion is required")]
    public required TerraformValue<string> AzureRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("azure_region");
        set => SetArgument("azure_region", value);
    }

    /// <summary>
    /// Name of the AzureClient. The `AzureClient` resource must reside on the same GCP project and region as the `AzureCluster`. `AzureClient` names are formatted as `projects/&amp;lt;project-number&amp;gt;/locations/&amp;lt;region&amp;gt;/azureClients/&amp;lt;client-id&amp;gt;`. See Resource Names (https:cloud.google.com/apis/design/resource_names) for more details on Google Cloud resource names.
    /// </summary>
    public TerraformValue<string>? Client
    {
        get => GetArgument<TerraformValue<string>>("client");
        set => SetArgument("client", value);
    }

    /// <summary>
    /// Optional. A human readable description of this cluster. Cannot be longer than 255 UTF-8 encoded bytes.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ARM ID of the resource group where the cluster resources are deployed. For example: `/subscriptions/*/resourceGroups/*`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// Output only. The endpoint of the cluster&#39;s API server.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// Output only. If set, there are currently changes in flight to the cluster.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// Output only. The current state of the cluster. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Output only. A globally unique identifier for the cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// Output only. The time at which this cluster was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Output only. Workload Identity settings.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadIdentityConfig
        => CreateReference("workload_identity_config");

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public required TerraformList<GoogleContainerAzureClusterAuthorizationBlock> Authorization
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureClusterAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// AzureServicesAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureServicesAuthentication block(s) allowed")]
    public TerraformList<GoogleContainerAzureClusterAzureServicesAuthenticationBlock>? AzureServicesAuthentication
    {
        get => GetArgument<TerraformList<GoogleContainerAzureClusterAzureServicesAuthenticationBlock>>("azure_services_authentication");
        set => SetArgument("azure_services_authentication", value);
    }

    /// <summary>
    /// ControlPlane block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlane is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlane block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public required TerraformList<GoogleContainerAzureClusterControlPlaneBlock> ControlPlane
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureClusterControlPlaneBlock>>("control_plane");
        set => SetArgument("control_plane", value);
    }

    /// <summary>
    /// Fleet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public required TerraformList<GoogleContainerAzureClusterFleetBlock> Fleet
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureClusterFleetBlock>>("fleet");
        set => SetArgument("fleet", value);
    }

    /// <summary>
    /// Networking block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networking is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    public required TerraformList<GoogleContainerAzureClusterNetworkingBlock> Networking
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAzureClusterNetworkingBlock>>("networking");
        set => SetArgument("networking", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAzureClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAzureClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
