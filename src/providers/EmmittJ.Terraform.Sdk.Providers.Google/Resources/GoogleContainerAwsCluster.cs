using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in GoogleContainerAwsCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// AdminGroups block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleContainerAwsClusterAuthorizationBlockAdminGroupsBlock>? AdminGroups
    {
        get => GetArgument<TerraformList<GoogleContainerAwsClusterAuthorizationBlockAdminGroupsBlock>>("admin_groups");
        set => SetArgument("admin_groups", value);
    }

    /// <summary>
    /// AdminUsers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AdminUsers block(s) required")]
    public required TerraformList<GoogleContainerAwsClusterAuthorizationBlockAdminUsersBlock> AdminUsers
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterAuthorizationBlockAdminUsersBlock>>("admin_users");
        set => SetArgument("admin_users", value);
    }

}

/// <summary>
/// Block type for admin_groups in GoogleContainerAwsClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterAuthorizationBlockAdminGroupsBlock : TerraformBlock
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
/// Block type for admin_users in GoogleContainerAwsClusterAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterAuthorizationBlockAdminUsersBlock : TerraformBlock
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
/// Block type for binary_authorization in GoogleContainerAwsCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "binary_authorization";

    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation. Possible values: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE
    /// </summary>
    public TerraformValue<string> EvaluationMode
    {
        get => GetArgument<TerraformValue<string>>("evaluation_mode") ?? AsReference("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
    }

}


/// <summary>
/// Block type for control_plane in GoogleContainerAwsCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_plane";

    /// <summary>
    /// The name of the AWS IAM instance pofile to assign to each control plane replica.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamInstanceProfile is required")]
    public required TerraformValue<string> IamInstanceProfile
    {
        get => GetRequiredArgument<TerraformValue<string>>("iam_instance_profile");
        set => SetArgument("iam_instance_profile", value);
    }

    /// <summary>
    /// Optional. The AWS instance type. When unspecified, it defaults to `m5.large`.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type") ?? AsReference("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// Optional. The IDs of additional security groups to add to control plane replicas. The Anthos Multi-Cloud API will automatically create and manage security groups with the minimum rules needed for a functioning cluster.
    /// </summary>
    public TerraformList<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformList<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The list of subnets where control plane replicas will run. A replica will be provisioned on each subnet and up to three values can be provided. Each subnet must be in a different AWS Availability Zone (AZ).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => GetArgument<TerraformList<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// Optional. A set of AWS resource tags to propagate to all underlying managed AWS resources. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The Kubernetes version to run on control plane replicas (e.g. `1.19.10-gke.1000`). You can list all supported versions on a given Google Cloud region by calling .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// AwsServicesAuthentication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsServicesAuthentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AwsServicesAuthentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsServicesAuthentication block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterControlPlaneBlockAwsServicesAuthenticationBlock> AwsServicesAuthentication
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockAwsServicesAuthenticationBlock>>("aws_services_authentication");
        set => SetArgument("aws_services_authentication", value);
    }

    /// <summary>
    /// ConfigEncryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigEncryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConfigEncryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigEncryption block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterControlPlaneBlockConfigEncryptionBlock> ConfigEncryption
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockConfigEncryptionBlock>>("config_encryption");
        set => SetArgument("config_encryption", value);
    }

    /// <summary>
    /// DatabaseEncryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseEncryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatabaseEncryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseEncryption block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterControlPlaneBlockDatabaseEncryptionBlock> DatabaseEncryption
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockDatabaseEncryptionBlock>>("database_encryption");
        set => SetArgument("database_encryption", value);
    }

    /// <summary>
    /// MainVolume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MainVolume block(s) allowed")]
    public TerraformList<GoogleContainerAwsClusterControlPlaneBlockMainVolumeBlock>? MainVolume
    {
        get => GetArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockMainVolumeBlock>>("main_volume");
        set => SetArgument("main_volume", value);
    }

    /// <summary>
    /// ProxyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfig block(s) allowed")]
    public TerraformList<GoogleContainerAwsClusterControlPlaneBlockProxyConfigBlock>? ProxyConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockProxyConfigBlock>>("proxy_config");
        set => SetArgument("proxy_config", value);
    }

    /// <summary>
    /// RootVolume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolume block(s) allowed")]
    public TerraformList<GoogleContainerAwsClusterControlPlaneBlockRootVolumeBlock>? RootVolume
    {
        get => GetArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockRootVolumeBlock>>("root_volume");
        set => SetArgument("root_volume", value);
    }

    /// <summary>
    /// SshConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SshConfig block(s) allowed")]
    public TerraformList<GoogleContainerAwsClusterControlPlaneBlockSshConfigBlock>? SshConfig
    {
        get => GetArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlockSshConfigBlock>>("ssh_config");
        set => SetArgument("ssh_config", value);
    }

}

/// <summary>
/// Block type for aws_services_authentication in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockAwsServicesAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_services_authentication";

    /// <summary>
    /// The Amazon Resource Name (ARN) of the role that the Anthos Multi-Cloud API will assume when managing AWS resources on your account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// Optional. An identifier for the assumed role session. When unspecified, it defaults to `multicloud-service-agent`.
    /// </summary>
    public TerraformValue<string> RoleSessionName
    {
        get => GetArgument<TerraformValue<string>>("role_session_name") ?? AsReference("role_session_name");
        set => SetArgument("role_session_name", value);
    }

}

/// <summary>
/// Block type for config_encryption in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockConfigEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_encryption";

    /// <summary>
    /// The ARN of the AWS KMS key used to encrypt cluster configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for database_encryption in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockDatabaseEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_encryption";

    /// <summary>
    /// The ARN of the AWS KMS key used to encrypt cluster secrets.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for main_volume in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockMainVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "main_volume";

    /// <summary>
    /// Optional. The number of I/O operations per second (IOPS) to provision for GP3 volume.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => GetArgument<TerraformValue<double>>("iops") ?? AsReference("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// Optional. The size of the volume, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.
    /// </summary>
    public TerraformValue<double> SizeGib
    {
        get => GetArgument<TerraformValue<double>>("size_gib") ?? AsReference("size_gib");
        set => SetArgument("size_gib", value);
    }

    /// <summary>
    /// Optional. The throughput to provision for the volume, in MiB/s. Only valid if the volume type is GP3. If volume type is gp3 and throughput is not specified, the throughput will defaults to 125.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput") ?? AsReference("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// Optional. Type of the EBS volume. When unspecified, it defaults to GP2 volume. Possible values: VOLUME_TYPE_UNSPECIFIED, GP2, GP3
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type") ?? AsReference("volume_type");
        set => SetArgument("volume_type", value);
    }

}

/// <summary>
/// Block type for proxy_config in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockProxyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_config";

    /// <summary>
    /// The ARN of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretArn is required")]
    public required TerraformValue<string> SecretArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// The version string of the AWS Secret Manager secret that contains the HTTP(S) proxy configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for root_volume in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockRootVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_volume";

    /// <summary>
    /// Optional. The number of I/O operations per second (IOPS) to provision for GP3 volume.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => GetArgument<TerraformValue<double>>("iops") ?? AsReference("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// Optional. The Amazon Resource Name (ARN) of the Customer Managed Key (CMK) used to encrypt AWS EBS volumes. If not specified, the default Amazon managed key associated to the AWS region where this cluster runs will be used.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// Optional. The size of the volume, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.
    /// </summary>
    public TerraformValue<double> SizeGib
    {
        get => GetArgument<TerraformValue<double>>("size_gib") ?? AsReference("size_gib");
        set => SetArgument("size_gib", value);
    }

    /// <summary>
    /// Optional. The throughput to provision for the volume, in MiB/s. Only valid if the volume type is GP3. If volume type is gp3 and throughput is not specified, the throughput will defaults to 125.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput") ?? AsReference("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// Optional. Type of the EBS volume. When unspecified, it defaults to GP2 volume. Possible values: VOLUME_TYPE_UNSPECIFIED, GP2, GP3
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type") ?? AsReference("volume_type");
        set => SetArgument("volume_type", value);
    }

}

/// <summary>
/// Block type for ssh_config in GoogleContainerAwsClusterControlPlaneBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlockSshConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_config";

    /// <summary>
    /// The name of the EC2 key pair used to login into cluster machines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2KeyPair is required")]
    public required TerraformValue<string> Ec2KeyPair
    {
        get => GetRequiredArgument<TerraformValue<string>>("ec2_key_pair");
        set => SetArgument("ec2_key_pair", value);
    }

}


/// <summary>
/// Block type for fleet in GoogleContainerAwsCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fleet";

    /// <summary>
    /// The name of the managed Hub Membership resource associated to this cluster. Membership names are formatted as projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;.
    /// </summary>
    public TerraformValue<string> Membership
        => AsReference("membership");

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for networking in GoogleContainerAwsCluster.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networking";

    /// <summary>
    /// Disable the per node pool subnet security group rules on the control plane security group. When set to true, you must also provide one or more security groups that ensure node pools are able to send requests to the control plane on TCP/443 and TCP/8132. Failure to do so may result in unavailable node pools.
    /// </summary>
    public TerraformValue<bool>? PerNodePoolSgRulesDisabled
    {
        get => GetArgument<TerraformValue<bool>>("per_node_pool_sg_rules_disabled");
        set => SetArgument("per_node_pool_sg_rules_disabled", value);
    }

    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    public TerraformList<string>? PodAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("pod_address_cidr_blocks");
        set => SetArgument("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public TerraformList<string>? ServiceAddressCidrBlocks
    {
        get => GetArgument<TerraformList<string>>("service_address_cidr_blocks");
        set => SetArgument("service_address_cidr_blocks", value);
    }

    /// <summary>
    /// The VPC associated with the cluster. All component clusters (i.e. control plane and node pools) run on a single VPC. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAwsCluster.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAwsClusterTimeoutsBlock : TerraformBlock
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
/// Represents a google_container_aws_cluster Terraform resource.
/// Manages a google_container_aws_cluster resource.
/// </summary>
public partial class GoogleContainerAwsCluster(string name) : TerraformResource("google_container_aws_cluster", name)
{
    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
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
    /// The AWS region where the cluster runs. Each Google Cloud region supports a subset of nearby AWS regions. You can call to list all supported AWS regions within a given Google Cloud region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRegion is required")]
    public required TerraformValue<string> AwsRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("aws_region");
        set => SetArgument("aws_region", value);
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// Output only. The endpoint of the cluster&#39;s API server.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output only. If set, there are currently changes in flight to the cluster.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Output only. The current state of the cluster. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. A globally unique identifier for the cluster.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. The time at which this cluster was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Output only. Workload Identity settings.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadIdentityConfig
        => AsReference("workload_identity_config");

    /// <summary>
    /// Authorization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterAuthorizationBlock> Authorization
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// BinaryAuthorization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public TerraformList<GoogleContainerAwsClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetArgument<TerraformList<GoogleContainerAwsClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => SetArgument("binary_authorization", value);
    }

    /// <summary>
    /// ControlPlane block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPlane is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlane block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterControlPlaneBlock> ControlPlane
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterControlPlaneBlock>>("control_plane");
        set => SetArgument("control_plane", value);
    }

    /// <summary>
    /// Fleet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fleet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterFleetBlock> Fleet
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterFleetBlock>>("fleet");
        set => SetArgument("fleet", value);
    }

    /// <summary>
    /// Networking block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networking is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    public required TerraformList<GoogleContainerAwsClusterNetworkingBlock> Networking
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAwsClusterNetworkingBlock>>("networking");
        set => SetArgument("networking", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAwsClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAwsClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
