using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetComputeCapacityBlock
{

    /// <summary>
    /// The desired_instances attribute.
    /// </summary>
    [TerraformPropertyName("desired_instances")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DesiredInstances { get; set; }

    /// <summary>
    /// The desired_sessions attribute.
    /// </summary>
    [TerraformPropertyName("desired_sessions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DesiredSessions { get; set; }



}

/// <summary>
/// Block type for domain_join_info in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetDomainJoinInfoBlock
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformPropertyName("directory_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DirectoryName { get; set; } = default!;

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_distinguished_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OrganizationalUnitDistinguishedName { get; set; } = default!;

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetVpcConfigBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> SecurityGroupIds { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> SubnetIds { get; set; } = default!;

}

/// <summary>
/// Manages a aws_appstream_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamFleet : TerraformResource
{
    public AwsAppstreamFleet(string name) : base("aws_appstream_fleet", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Description { get; set; } = default!;

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("disconnect_timeout_in_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DisconnectTimeoutInSeconds { get; set; } = default!;

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_default_internet_access")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableDefaultInternetAccess { get; set; } = default!;

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformPropertyName("fleet_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FleetType { get; set; } = default!;

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IamRoleArn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_disconnect_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleDisconnectTimeoutInSeconds { get; set; }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ImageArn { get; set; } = default!;

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [TerraformPropertyName("image_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ImageName { get; set; } = default!;

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    [TerraformPropertyName("max_sessions_per_instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxSessionsPerInstance { get; set; }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_user_duration_in_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxUserDurationInSeconds { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    [TerraformPropertyName("stream_view")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StreamView { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for compute_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCapacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeCapacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeCapacity block(s) allowed")]
    [TerraformPropertyName("compute_capacity")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetComputeCapacityBlock>>? ComputeCapacity { get; set; }

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    [TerraformPropertyName("domain_join_info")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetDomainJoinInfoBlock>>? DomainJoinInfo { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
