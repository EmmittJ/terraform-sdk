using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_start_time in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewayMaintenanceStartTimeBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    [TerraformPropertyName("day_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DayOfMonth { get; set; }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [TerraformPropertyName("day_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DayOfWeek { get; set; }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    [TerraformPropertyName("hour_of_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> HourOfDay { get; set; }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    [TerraformPropertyName("minute_of_hour")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinuteOfHour { get; set; }

}

/// <summary>
/// Block type for smb_active_directory_settings in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The active_directory_status attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActiveDirectoryStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "active_directory_status");

    /// <summary>
    /// The domain_controllers attribute.
    /// </summary>
    [TerraformPropertyName("domain_controllers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DomainControllers { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrganizationalUnit { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayGatewayTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ActivationKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "activation_key");

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    [TerraformPropertyName("average_download_rate_limit_in_bits_per_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AverageDownloadRateLimitInBitsPerSec { get; set; }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    [TerraformPropertyName("average_upload_rate_limit_in_bits_per_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AverageUploadRateLimitInBitsPerSec { get; set; }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_log_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("gateway_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GatewayIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_ip_address");

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    [TerraformPropertyName("gateway_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GatewayName { get; set; }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayTimezone is required")]
    [TerraformPropertyName("gateway_timezone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GatewayTimezone { get; set; }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    [TerraformPropertyName("gateway_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GatewayType { get; set; }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("gateway_vpc_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GatewayVpcEndpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The medium_changer_type attribute.
    /// </summary>
    [TerraformPropertyName("medium_changer_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MediumChangerType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The smb_file_share_visibility attribute.
    /// </summary>
    [TerraformPropertyName("smb_file_share_visibility")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbFileShareVisibility { get; set; }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    [TerraformPropertyName("smb_guest_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SmbGuestPassword { get; set; }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    [TerraformPropertyName("smb_security_strategy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SmbSecurityStrategy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "smb_security_strategy");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The tape_drive_type attribute.
    /// </summary>
    [TerraformPropertyName("tape_drive_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TapeDriveType { get; set; }

    /// <summary>
    /// Block for maintenance_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStartTime block(s) allowed")]
    [TerraformPropertyName("maintenance_start_time")]
    public TerraformList<TerraformBlock<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>>? MaintenanceStartTime { get; set; } = new();

    /// <summary>
    /// Block for smb_active_directory_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmbActiveDirectorySettings block(s) allowed")]
    [TerraformPropertyName("smb_active_directory_settings")]
    public TerraformList<TerraformBlock<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>>? SmbActiveDirectorySettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsStoragegatewayGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The ec2_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("ec2_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ec2InstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ec2_instance_id");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_type");

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_id");

    /// <summary>
    /// The gateway_network_interface attribute.
    /// </summary>
    [TerraformPropertyName("gateway_network_interface")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> GatewayNetworkInterface => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "gateway_network_interface");

    /// <summary>
    /// The host_environment attribute.
    /// </summary>
    [TerraformPropertyName("host_environment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostEnvironment => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_environment");

}
