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
        set => SetProperty("available", value);
    }

    /// <summary>
    /// The desired_instances attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredInstances
    {
        set => SetProperty("desired_instances", value);
    }

    /// <summary>
    /// The desired_sessions attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredSessions
    {
        set => SetProperty("desired_sessions", value);
    }

    /// <summary>
    /// The in_use attribute.
    /// </summary>
    public TerraformProperty<double>? InUse
    {
        set => SetProperty("in_use", value);
    }

    /// <summary>
    /// The running attribute.
    /// </summary>
    public TerraformProperty<double>? Running
    {
        set => SetProperty("running", value);
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
        set => SetProperty("directory_name", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitDistinguishedName
    {
        set => SetProperty("organizational_unit_distinguished_name", value);
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
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_appstream_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamFleet : TerraformResource
{
    public AwsAppstreamFleet(string name) : base("aws_appstream_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_time");
        SetOutput("state");
        SetOutput("description");
        SetOutput("disconnect_timeout_in_seconds");
        SetOutput("display_name");
        SetOutput("enable_default_internet_access");
        SetOutput("fleet_type");
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("idle_disconnect_timeout_in_seconds");
        SetOutput("image_arn");
        SetOutput("image_name");
        SetOutput("instance_type");
        SetOutput("max_sessions_per_instance");
        SetOutput("max_user_duration_in_seconds");
        SetOutput("name");
        SetOutput("region");
        SetOutput("stream_view");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> DisconnectTimeoutInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("disconnect_timeout_in_seconds");
        set => SetProperty("disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDefaultInternetAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_default_internet_access");
        set => SetProperty("enable_default_internet_access", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string> FleetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_type");
        set => SetProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> IdleDisconnectTimeoutInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_disconnect_timeout_in_seconds");
        set => SetProperty("idle_disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformProperty<string> ImageArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_arn");
        set => SetProperty("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string> ImageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_name");
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    public TerraformProperty<double> MaxSessionsPerInstance
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_sessions_per_instance");
        set => SetProperty("max_sessions_per_instance", value);
    }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MaxUserDurationInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_user_duration_in_seconds");
        set => SetProperty("max_user_duration_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    public TerraformProperty<string> StreamView
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_view");
        set => SetProperty("stream_view", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for compute_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCapacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeCapacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeCapacity block(s) allowed")]
    public List<AwsAppstreamFleetComputeCapacityBlock>? ComputeCapacity
    {
        set => SetProperty("compute_capacity", value);
    }

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    public List<AwsAppstreamFleetDomainJoinInfoBlock>? DomainJoinInfo
    {
        set => SetProperty("domain_join_info", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsAppstreamFleetVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
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
