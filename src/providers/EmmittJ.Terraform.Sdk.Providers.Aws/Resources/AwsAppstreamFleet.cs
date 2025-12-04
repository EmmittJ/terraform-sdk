using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_capacity in AwsAppstreamFleet.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetComputeCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_capacity";

    /// <summary>
    /// The available attribute.
    /// </summary>
    public TerraformValue<double> Available
        => AsReference("available");

    /// <summary>
    /// The desired_instances attribute.
    /// </summary>
    public TerraformValue<double>? DesiredInstances
    {
        get => GetArgument<TerraformValue<double>>("desired_instances");
        set => SetArgument("desired_instances", value);
    }

    /// <summary>
    /// The desired_sessions attribute.
    /// </summary>
    public TerraformValue<double>? DesiredSessions
    {
        get => GetArgument<TerraformValue<double>>("desired_sessions");
        set => SetArgument("desired_sessions", value);
    }

    /// <summary>
    /// The in_use attribute.
    /// </summary>
    public TerraformValue<double> InUse
        => AsReference("in_use");

    /// <summary>
    /// The running attribute.
    /// </summary>
    public TerraformValue<double> Running
        => AsReference("running");

}


/// <summary>
/// Block type for domain_join_info in AwsAppstreamFleet.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetDomainJoinInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "domain_join_info";

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryName
    {
        get => GetArgument<TerraformValue<string>>("directory_name");
        set => SetArgument("directory_name", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnitDistinguishedName
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit_distinguished_name");
        set => SetArgument("organizational_unit_distinguished_name", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsAppstreamFleet.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformList<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformList<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformList<string>? SubnetIds
    {
        get => GetArgument<TerraformList<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_appstream_fleet Terraform resource.
/// Manages a aws_appstream_fleet resource.
/// </summary>
public partial class AwsAppstreamFleet(string name) : TerraformResource("aws_appstream_fleet", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DisconnectTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("disconnect_timeout_in_seconds");
        set => SetArgument("disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDefaultInternetAccess
    {
        get => GetArgument<TerraformValue<bool>>("enable_default_internet_access");
        set => SetArgument("enable_default_internet_access", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformValue<string>? FleetType
    {
        get => GetArgument<TerraformValue<string>>("fleet_type");
        set => SetArgument("fleet_type", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
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
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IdleDisconnectTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("idle_disconnect_timeout_in_seconds");
        set => SetArgument("idle_disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformValue<string>? ImageArn
    {
        get => GetArgument<TerraformValue<string>>("image_arn");
        set => SetArgument("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformValue<string>? ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? MaxSessionsPerInstance
    {
        get => GetArgument<TerraformValue<double>>("max_sessions_per_instance");
        set => SetArgument("max_sessions_per_instance", value);
    }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxUserDurationInSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_user_duration_in_seconds");
        set => SetArgument("max_user_duration_in_seconds", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    public TerraformValue<string>? StreamView
    {
        get => GetArgument<TerraformValue<string>>("stream_view");
        set => SetArgument("stream_view", value);
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
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// ComputeCapacity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCapacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeCapacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeCapacity block(s) allowed")]
    public required TerraformList<AwsAppstreamFleetComputeCapacityBlock> ComputeCapacity
    {
        get => GetRequiredArgument<TerraformList<AwsAppstreamFleetComputeCapacityBlock>>("compute_capacity");
        set => SetArgument("compute_capacity", value);
    }

    /// <summary>
    /// DomainJoinInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    public TerraformList<AwsAppstreamFleetDomainJoinInfoBlock>? DomainJoinInfo
    {
        get => GetArgument<TerraformList<AwsAppstreamFleetDomainJoinInfoBlock>>("domain_join_info");
        set => SetArgument("domain_join_info", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsAppstreamFleetVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsAppstreamFleetVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
