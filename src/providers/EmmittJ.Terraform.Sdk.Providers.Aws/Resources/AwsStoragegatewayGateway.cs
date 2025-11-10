using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_start_time in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewayMaintenanceStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_month attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfMonth
    {
        set => SetProperty("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformProperty<double> HourOfDay
    {
        set => SetProperty("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    public TerraformProperty<double>? MinuteOfHour
    {
        set => SetProperty("minute_of_hour", value);
    }

}

/// <summary>
/// Block type for smb_active_directory_settings in .
/// Nesting mode: list
/// </summary>
public class AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock : TerraformBlock
{
    /// <summary>
    /// The active_directory_status attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryStatus
    {
        set => SetProperty("active_directory_status", value);
    }

    /// <summary>
    /// The domain_controllers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DomainControllers
    {
        set => SetProperty("domain_controllers", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnit
    {
        set => SetProperty("organizational_unit", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        set => SetProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsStoragegatewayGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_storagegateway_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsStoragegatewayGateway : TerraformResource
{
    public AwsStoragegatewayGateway(string name) : base("aws_storagegateway_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("ec2_instance_id");
        SetOutput("endpoint_type");
        SetOutput("gateway_id");
        SetOutput("gateway_network_interface");
        SetOutput("host_environment");
        SetOutput("activation_key");
        SetOutput("average_download_rate_limit_in_bits_per_sec");
        SetOutput("average_upload_rate_limit_in_bits_per_sec");
        SetOutput("cloudwatch_log_group_arn");
        SetOutput("gateway_ip_address");
        SetOutput("gateway_name");
        SetOutput("gateway_timezone");
        SetOutput("gateway_type");
        SetOutput("gateway_vpc_endpoint");
        SetOutput("id");
        SetOutput("medium_changer_type");
        SetOutput("region");
        SetOutput("smb_file_share_visibility");
        SetOutput("smb_guest_password");
        SetOutput("smb_security_strategy");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tape_drive_type");
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public TerraformProperty<string> ActivationKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("activation_key");
        set => SetProperty("activation_key", value);
    }

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformProperty<double> AverageDownloadRateLimitInBitsPerSec
    {
        get => GetRequiredOutput<TerraformProperty<double>>("average_download_rate_limit_in_bits_per_sec");
        set => SetProperty("average_download_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformProperty<double> AverageUploadRateLimitInBitsPerSec
    {
        get => GetRequiredOutput<TerraformProperty<double>>("average_upload_rate_limit_in_bits_per_sec");
        set => SetProperty("average_upload_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformProperty<string> CloudwatchLogGroupArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloudwatch_log_group_arn");
        set => SetProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    public TerraformProperty<string> GatewayIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_ip_address");
        set => SetProperty("gateway_ip_address", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformProperty<string> GatewayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_name");
        set => SetProperty("gateway_name", value);
    }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayTimezone is required")]
    public required TerraformProperty<string> GatewayTimezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_timezone");
        set => SetProperty("gateway_timezone", value);
    }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    public TerraformProperty<string> GatewayType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_type");
        set => SetProperty("gateway_type", value);
    }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> GatewayVpcEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_vpc_endpoint");
        set => SetProperty("gateway_vpc_endpoint", value);
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
    /// The medium_changer_type attribute.
    /// </summary>
    public TerraformProperty<string> MediumChangerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("medium_changer_type");
        set => SetProperty("medium_changer_type", value);
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
    /// The smb_file_share_visibility attribute.
    /// </summary>
    public TerraformProperty<bool> SmbFileShareVisibility
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("smb_file_share_visibility");
        set => SetProperty("smb_file_share_visibility", value);
    }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    public TerraformProperty<string> SmbGuestPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("smb_guest_password");
        set => SetProperty("smb_guest_password", value);
    }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    public TerraformProperty<string> SmbSecurityStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("smb_security_strategy");
        set => SetProperty("smb_security_strategy", value);
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
    /// The tape_drive_type attribute.
    /// </summary>
    public TerraformProperty<string> TapeDriveType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tape_drive_type");
        set => SetProperty("tape_drive_type", value);
    }

    /// <summary>
    /// Block for maintenance_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStartTime block(s) allowed")]
    public List<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>? MaintenanceStartTime
    {
        set => SetProperty("maintenance_start_time", value);
    }

    /// <summary>
    /// Block for smb_active_directory_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmbActiveDirectorySettings block(s) allowed")]
    public List<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>? SmbActiveDirectorySettings
    {
        set => SetProperty("smb_active_directory_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsStoragegatewayGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ec2_instance_id attribute.
    /// </summary>
    public TerraformExpression Ec2InstanceId => this["ec2_instance_id"];

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformExpression EndpointType => this["endpoint_type"];

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformExpression GatewayId => this["gateway_id"];

    /// <summary>
    /// The gateway_network_interface attribute.
    /// </summary>
    public TerraformExpression GatewayNetworkInterface => this["gateway_network_interface"];

    /// <summary>
    /// The host_environment attribute.
    /// </summary>
    public TerraformExpression HostEnvironment => this["host_environment"];

}
