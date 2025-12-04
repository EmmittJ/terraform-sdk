using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in AwsDaxCluster.
/// Nesting mode: list
/// </summary>
public class AwsDaxClusterServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDaxCluster.
/// Nesting mode: single
/// </summary>
public class AwsDaxClusterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_dax_cluster Terraform resource.
/// Manages a aws_dax_cluster resource.
/// </summary>
public partial class AwsDaxCluster(string name) : TerraformResource("aws_dax_cluster", name)
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string>? AvailabilityZones
    {
        get => GetArgument<TerraformSet<string>>("availability_zones");
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The cluster_endpoint_encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? ClusterEndpointEncryptionType
    {
        get => GetArgument<TerraformValue<string>>("cluster_endpoint_encryption_type");
        set => SetArgument("cluster_endpoint_encryption_type", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
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
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
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
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTopicArn
    {
        get => GetArgument<TerraformValue<string>>("notification_topic_arn");
        set => SetArgument("notification_topic_arn", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFactor is required")]
    public required TerraformValue<double> ReplicationFactor
    {
        get => GetArgument<TerraformValue<double>>("replication_factor");
        set => SetArgument("replication_factor", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string>? SubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("subnet_group_name");
        set => SetArgument("subnet_group_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cluster_address attribute.
    /// </summary>
    public TerraformValue<string> ClusterAddress
        => AsReference("cluster_address");

    /// <summary>
    /// The configuration_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpoint
        => AsReference("configuration_endpoint");

    /// <summary>
    /// The nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Nodes
        => AsReference("nodes");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// ServerSideEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public TerraformList<AwsDaxClusterServerSideEncryptionBlock>? ServerSideEncryption
    {
        get => GetArgument<TerraformList<AwsDaxClusterServerSideEncryptionBlock>>("server_side_encryption");
        set => SetArgument("server_side_encryption", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDaxClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDaxClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
