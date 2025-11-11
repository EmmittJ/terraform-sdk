using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_capacity in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamFleetComputeCapacityBlock : TerraformBlockBase
{

    /// <summary>
    /// The desired_instances attribute.
    /// </summary>
    [TerraformProperty("desired_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DesiredInstances { get; set; }

    /// <summary>
    /// The desired_sessions attribute.
    /// </summary>
    [TerraformProperty("desired_sessions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DesiredSessions { get; set; }



}

/// <summary>
/// Block type for domain_join_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamFleetDomainJoinInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformProperty("directory_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DirectoryName { get; set; }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_distinguished_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OrganizationalUnitDistinguishedName { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppstreamFleetVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_appstream_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppstreamFleet : TerraformResource
{
    public AwsAppstreamFleet(string name) : base("aws_appstream_fleet", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("disconnect_timeout_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DisconnectTimeoutInSeconds { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    [TerraformProperty("enable_default_internet_access")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableDefaultInternetAccess { get; set; }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformProperty("fleet_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> FleetType { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("idle_disconnect_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? IdleDisconnectTimeoutInSeconds { get; set; }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    [TerraformProperty("image_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ImageArn { get; set; }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [TerraformProperty("image_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ImageName { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    [TerraformProperty("max_sessions_per_instance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxSessionsPerInstance { get; set; }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    [TerraformProperty("max_user_duration_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxUserDurationInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    [TerraformProperty("stream_view")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StreamView { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for compute_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCapacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeCapacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeCapacity block(s) allowed")]
    [TerraformProperty("compute_capacity")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetComputeCapacityBlock>>? ComputeCapacity { get; set; }

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    [TerraformProperty("domain_join_info")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetDomainJoinInfoBlock>>? DomainJoinInfo { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
