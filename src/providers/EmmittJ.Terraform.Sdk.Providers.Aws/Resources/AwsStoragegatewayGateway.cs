using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_start_time in AwsStoragegatewayGateway.
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewayMaintenanceStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_start_time";

    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformValue<string>? DayOfMonth
    {
        get => GetArgument<TerraformValue<string>>("day_of_month");
        set => SetArgument("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformValue<string>? DayOfWeek
    {
        get => GetArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    public TerraformValue<double>? MinuteOfHour
    {
        get => GetArgument<TerraformValue<double>>("minute_of_hour");
        set => SetArgument("minute_of_hour", value);
    }

}


/// <summary>
/// Block type for smb_active_directory_settings in AwsStoragegatewayGateway.
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "smb_active_directory_settings";

    /// <summary>
    /// The active_directory_status attribute.
    /// </summary>
    public TerraformValue<string> ActiveDirectoryStatus
        => AsReference("active_directory_status");

    /// <summary>
    /// The domain_controllers attribute.
    /// </summary>
    public TerraformSet<string>? DomainControllers
    {
        get => GetArgument<TerraformSet<string>>("domain_controllers");
        set => SetArgument("domain_controllers", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnit
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsStoragegatewayGateway.
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayGatewayTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_storagegateway_gateway Terraform resource.
/// Manages a aws_storagegateway_gateway resource.
/// </summary>
public partial class AwsStoragegatewayGateway(string name) : TerraformResource("aws_storagegateway_gateway", name)
{
    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public TerraformValue<string> ActivationKey
    {
        get => GetArgument<TerraformValue<string>>("activation_key") ?? AsReference("activation_key");
        set => SetArgument("activation_key", value);
    }

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformValue<double>? AverageDownloadRateLimitInBitsPerSec
    {
        get => GetArgument<TerraformValue<double>>("average_download_rate_limit_in_bits_per_sec");
        set => SetArgument("average_download_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformValue<double>? AverageUploadRateLimitInBitsPerSec
    {
        get => GetArgument<TerraformValue<double>>("average_upload_rate_limit_in_bits_per_sec");
        set => SetArgument("average_upload_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchLogGroupArn
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_log_group_arn");
        set => SetArgument("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    public TerraformValue<string> GatewayIpAddress
    {
        get => GetArgument<TerraformValue<string>>("gateway_ip_address") ?? AsReference("gateway_ip_address");
        set => SetArgument("gateway_ip_address", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformValue<string> GatewayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_name");
        set => SetArgument("gateway_name", value);
    }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayTimezone is required")]
    public required TerraformValue<string> GatewayTimezone
    {
        get => GetRequiredArgument<TerraformValue<string>>("gateway_timezone");
        set => SetArgument("gateway_timezone", value);
    }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    public TerraformValue<string>? GatewayType
    {
        get => GetArgument<TerraformValue<string>>("gateway_type");
        set => SetArgument("gateway_type", value);
    }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? GatewayVpcEndpoint
    {
        get => GetArgument<TerraformValue<string>>("gateway_vpc_endpoint");
        set => SetArgument("gateway_vpc_endpoint", value);
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
    /// The medium_changer_type attribute.
    /// </summary>
    public TerraformValue<string>? MediumChangerType
    {
        get => GetArgument<TerraformValue<string>>("medium_changer_type");
        set => SetArgument("medium_changer_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The smb_file_share_visibility attribute.
    /// </summary>
    public TerraformValue<bool>? SmbFileShareVisibility
    {
        get => GetArgument<TerraformValue<bool>>("smb_file_share_visibility");
        set => SetArgument("smb_file_share_visibility", value);
    }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    public TerraformValue<string>? SmbGuestPassword
    {
        get => GetArgument<TerraformValue<string>>("smb_guest_password");
        set => SetArgument("smb_guest_password", value);
    }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    public TerraformValue<string> SmbSecurityStrategy
    {
        get => GetArgument<TerraformValue<string>>("smb_security_strategy") ?? AsReference("smb_security_strategy");
        set => SetArgument("smb_security_strategy", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tape_drive_type attribute.
    /// </summary>
    public TerraformValue<string>? TapeDriveType
    {
        get => GetArgument<TerraformValue<string>>("tape_drive_type");
        set => SetArgument("tape_drive_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The ec2_instance_id attribute.
    /// </summary>
    public TerraformValue<string> Ec2InstanceId
        => AsReference("ec2_instance_id");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointType
        => AsReference("endpoint_type");

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformValue<string> GatewayId
        => AsReference("gateway_id");

    /// <summary>
    /// The gateway_network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GatewayNetworkInterface
        => AsReference("gateway_network_interface");

    /// <summary>
    /// The host_environment attribute.
    /// </summary>
    public TerraformValue<string> HostEnvironment
        => AsReference("host_environment");

    /// <summary>
    /// MaintenanceStartTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStartTime block(s) allowed")]
    public TerraformList<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>? MaintenanceStartTime
    {
        get => GetArgument<TerraformList<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>>("maintenance_start_time");
        set => SetArgument("maintenance_start_time", value);
    }

    /// <summary>
    /// SmbActiveDirectorySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmbActiveDirectorySettings block(s) allowed")]
    public TerraformList<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>? SmbActiveDirectorySettings
    {
        get => GetArgument<TerraformList<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>>("smb_active_directory_settings");
        set => SetArgument("smb_active_directory_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsStoragegatewayGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsStoragegatewayGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
