using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetComputeCapacityBlock : TerraformBlock
{
    /// <summary>
    /// The available attribute.
    /// </summary>
    public TerraformProperty<double>? Available
    {
        get => GetProperty<TerraformProperty<double>>("available");
        set => WithProperty("available", value);
    }

    /// <summary>
    /// The desired_instances attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredInstances
    {
        get => GetProperty<TerraformProperty<double>>("desired_instances");
        set => WithProperty("desired_instances", value);
    }

    /// <summary>
    /// The desired_sessions attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredSessions
    {
        get => GetProperty<TerraformProperty<double>>("desired_sessions");
        set => WithProperty("desired_sessions", value);
    }

    /// <summary>
    /// The in_use attribute.
    /// </summary>
    public TerraformProperty<double>? InUse
    {
        get => GetProperty<TerraformProperty<double>>("in_use");
        set => WithProperty("in_use", value);
    }

    /// <summary>
    /// The running attribute.
    /// </summary>
    public TerraformProperty<double>? Running
    {
        get => GetProperty<TerraformProperty<double>>("running");
        set => WithProperty("running", value);
    }

}

/// <summary>
/// Block type for domain_join_info in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetDomainJoinInfoBlock : TerraformBlock
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryName
    {
        get => GetProperty<TerraformProperty<string>>("directory_name");
        set => WithProperty("directory_name", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitDistinguishedName
    {
        get => GetProperty<TerraformProperty<string>>("organizational_unit_distinguished_name");
        set => WithProperty("organizational_unit_distinguished_name", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_appstream_fleet resource.
/// </summary>
public class AwsAppstreamFleet : TerraformResource
{
    public AwsAppstreamFleet(string name) : base("aws_appstream_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("disconnect_timeout_in_seconds");
        set => this.WithProperty("disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDefaultInternetAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_default_internet_access");
        set => this.WithProperty("enable_default_internet_access", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string>? FleetType
    {
        get => GetProperty<TerraformProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IdleDisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("idle_disconnect_timeout_in_seconds");
        set => this.WithProperty("idle_disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ImageArn
    {
        get => GetProperty<TerraformProperty<string>>("image_arn");
        set => this.WithProperty("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSessionsPerInstance
    {
        get => GetProperty<TerraformProperty<double>>("max_sessions_per_instance");
        set => this.WithProperty("max_sessions_per_instance", value);
    }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUserDurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_user_duration_in_seconds");
        set => this.WithProperty("max_user_duration_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    public TerraformProperty<string>? StreamView
    {
        get => GetProperty<TerraformProperty<string>>("stream_view");
        set => this.WithProperty("stream_view", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for compute_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeCapacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeCapacity block(s) allowed")]
    public List<AwsAppstreamFleetComputeCapacityBlock>? ComputeCapacity
    {
        get => GetProperty<List<AwsAppstreamFleetComputeCapacityBlock>>("compute_capacity");
        set => this.WithProperty("compute_capacity", value);
    }

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    public List<AwsAppstreamFleetDomainJoinInfoBlock>? DomainJoinInfo
    {
        get => GetProperty<List<AwsAppstreamFleetDomainJoinInfoBlock>>("domain_join_info");
        set => this.WithProperty("domain_join_info", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsAppstreamFleetVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsAppstreamFleetVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
