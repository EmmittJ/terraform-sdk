using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_start_time in .
/// Nesting mode: list
/// </summary>
public partial class AwsStoragegatewayGatewayMaintenanceStartTimeBlock : TerraformBlockBase
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformProperty("day_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformProperty("day_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DayOfWeek { get; set; }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    [TerraformProperty("hour_of_day")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> HourOfDay { get; set; }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [TerraformProperty("minute_of_hour")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinuteOfHour { get; set; }

}

/// <summary>
/// Block type for smb_active_directory_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock : TerraformBlockBase
{

    /// <summary>
    /// The domain_controllers attribute.
    /// </summary>
    [TerraformProperty("domain_controllers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DomainControllers { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    [TerraformProperty("organizational_unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationalUnit { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsStoragegatewayGatewayTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_storagegateway_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsStoragegatewayGateway : TerraformResource
{
    public AwsStoragegatewayGateway(string name) : base("aws_storagegateway_gateway", name)
    {
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    [TerraformProperty("activation_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ActivationKey { get; set; }

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    [TerraformProperty("average_download_rate_limit_in_bits_per_sec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AverageDownloadRateLimitInBitsPerSec { get; set; }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    [TerraformProperty("average_upload_rate_limit_in_bits_per_sec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AverageUploadRateLimitInBitsPerSec { get; set; }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_log_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    [TerraformProperty("gateway_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GatewayIpAddress { get; set; }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformProperty("gateway_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewayName { get; set; }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayTimezone is required")]
    [TerraformProperty("gateway_timezone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewayTimezone { get; set; }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    [TerraformProperty("gateway_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayType { get; set; }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    [TerraformProperty("gateway_vpc_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayVpcEndpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The medium_changer_type attribute.
    /// </summary>
    [TerraformProperty("medium_changer_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MediumChangerType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The smb_file_share_visibility attribute.
    /// </summary>
    [TerraformProperty("smb_file_share_visibility")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmbFileShareVisibility { get; set; }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    [TerraformProperty("smb_guest_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SmbGuestPassword { get; set; }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    [TerraformProperty("smb_security_strategy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SmbSecurityStrategy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tape_drive_type attribute.
    /// </summary>
    [TerraformProperty("tape_drive_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TapeDriveType { get; set; }

    /// <summary>
    /// Block for maintenance_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStartTime block(s) allowed")]
    [TerraformProperty("maintenance_start_time")]
    public partial TerraformList<TerraformBlock<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>>? MaintenanceStartTime { get; set; }

    /// <summary>
    /// Block for smb_active_directory_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmbActiveDirectorySettings block(s) allowed")]
    [TerraformProperty("smb_active_directory_settings")]
    public partial TerraformList<TerraformBlock<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>>? SmbActiveDirectorySettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsStoragegatewayGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ec2_instance_id attribute.
    /// </summary>
    [TerraformProperty("ec2_instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ec2InstanceId { get; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointType { get; }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformProperty("gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayId { get; }

    /// <summary>
    /// The gateway_network_interface attribute.
    /// </summary>
    [TerraformProperty("gateway_network_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GatewayNetworkInterface { get; }

    /// <summary>
    /// The host_environment attribute.
    /// </summary>
    [TerraformProperty("host_environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostEnvironment { get; }

}
