using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_start_time in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewayMaintenanceStartTimeBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformPropertyName("day_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DayOfWeek { get; set; }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    [TerraformPropertyName("hour_of_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> HourOfDay { get; set; }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [TerraformPropertyName("minute_of_hour")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinuteOfHour { get; set; }

}

/// <summary>
/// Block type for smb_active_directory_settings in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock
{

    /// <summary>
    /// The domain_controllers attribute.
    /// </summary>
    [TerraformPropertyName("domain_controllers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DomainControllers { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrganizationalUnit { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayGatewayTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_storagegateway_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsStoragegatewayGateway : TerraformResource
{
    public AwsStoragegatewayGateway(string name) : base("aws_storagegateway_gateway", name)
    {
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    [TerraformPropertyName("activation_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ActivationKey { get; set; } = default!;

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    [TerraformPropertyName("average_download_rate_limit_in_bits_per_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AverageDownloadRateLimitInBitsPerSec { get; set; }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    [TerraformPropertyName("average_upload_rate_limit_in_bits_per_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AverageUploadRateLimitInBitsPerSec { get; set; }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("gateway_ip_address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> GatewayIpAddress { get; set; } = default!;

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformPropertyName("gateway_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GatewayName { get; set; }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayTimezone is required")]
    [TerraformPropertyName("gateway_timezone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GatewayTimezone { get; set; }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    [TerraformPropertyName("gateway_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GatewayType { get; set; }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("gateway_vpc_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GatewayVpcEndpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The medium_changer_type attribute.
    /// </summary>
    [TerraformPropertyName("medium_changer_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MediumChangerType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The smb_file_share_visibility attribute.
    /// </summary>
    [TerraformPropertyName("smb_file_share_visibility")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SmbFileShareVisibility { get; set; }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    [TerraformPropertyName("smb_guest_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SmbGuestPassword { get; set; }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    [TerraformPropertyName("smb_security_strategy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SmbSecurityStrategy { get; set; } = default!;

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
    /// The tape_drive_type attribute.
    /// </summary>
    [TerraformPropertyName("tape_drive_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TapeDriveType { get; set; }

    /// <summary>
    /// Block for maintenance_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStartTime block(s) allowed")]
    [TerraformPropertyName("maintenance_start_time")]
    public TerraformList<TerraformBlock<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>>? MaintenanceStartTime { get; set; }

    /// <summary>
    /// Block for smb_active_directory_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmbActiveDirectorySettings block(s) allowed")]
    [TerraformPropertyName("smb_active_directory_settings")]
    public TerraformList<TerraformBlock<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>>? SmbActiveDirectorySettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsStoragegatewayGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The ec2_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("ec2_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ec2InstanceId => new TerraformReference(this, "ec2_instance_id");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointType => new TerraformReference(this, "endpoint_type");

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayId => new TerraformReference(this, "gateway_id");

    /// <summary>
    /// The gateway_network_interface attribute.
    /// </summary>
    [TerraformPropertyName("gateway_network_interface")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GatewayNetworkInterface => new TerraformReference(this, "gateway_network_interface");

    /// <summary>
    /// The host_environment attribute.
    /// </summary>
    [TerraformPropertyName("host_environment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostEnvironment => new TerraformReference(this, "host_environment");

}
