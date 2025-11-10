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
        get => GetProperty<TerraformProperty<string>>("day_of_month");
        set => WithProperty("day_of_month", value);
    }

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    public TerraformProperty<string>? DayOfWeek
    {
        get => GetProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The hour_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformProperty<double> HourOfDay
    {
        get => GetProperty<TerraformProperty<double>>("hour_of_day");
        set => WithProperty("hour_of_day", value);
    }

    /// <summary>
    /// The minute_of_hour attribute.
    /// </summary>
    public TerraformProperty<double>? MinuteOfHour
    {
        get => GetProperty<TerraformProperty<double>>("minute_of_hour");
        set => WithProperty("minute_of_hour", value);
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
        get => GetProperty<TerraformProperty<string>>("active_directory_status");
        set => WithProperty("active_directory_status", value);
    }

    /// <summary>
    /// The domain_controllers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DomainControllers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("domain_controllers");
        set => WithProperty("domain_controllers", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnit
    {
        get => GetProperty<TerraformProperty<string>>("organizational_unit");
        set => WithProperty("organizational_unit", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_storagegateway_gateway resource.
/// </summary>
public class AwsStoragegatewayGateway : TerraformResource
{
    public AwsStoragegatewayGateway(string name) : base("aws_storagegateway_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ec2_instance_id");
        this.DeclareOutput("endpoint_type");
        this.DeclareOutput("gateway_id");
        this.DeclareOutput("gateway_network_interface");
        this.DeclareOutput("host_environment");
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public TerraformProperty<string>? ActivationKey
    {
        get => GetProperty<TerraformProperty<string>>("activation_key");
        set => this.WithProperty("activation_key", value);
    }

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformProperty<double>? AverageDownloadRateLimitInBitsPerSec
    {
        get => GetProperty<TerraformProperty<double>>("average_download_rate_limit_in_bits_per_sec");
        set => this.WithProperty("average_download_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformProperty<double>? AverageUploadRateLimitInBitsPerSec
    {
        get => GetProperty<TerraformProperty<double>>("average_upload_rate_limit_in_bits_per_sec");
        set => this.WithProperty("average_upload_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLogGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_log_group_arn");
        set => this.WithProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("gateway_ip_address");
        set => this.WithProperty("gateway_ip_address", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayName is required")]
    public required TerraformProperty<string> GatewayName
    {
        get => GetProperty<TerraformProperty<string>>("gateway_name");
        set => this.WithProperty("gateway_name", value);
    }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayTimezone is required")]
    public required TerraformProperty<string> GatewayTimezone
    {
        get => GetProperty<TerraformProperty<string>>("gateway_timezone");
        set => this.WithProperty("gateway_timezone", value);
    }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayType
    {
        get => GetProperty<TerraformProperty<string>>("gateway_type");
        set => this.WithProperty("gateway_type", value);
    }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayVpcEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("gateway_vpc_endpoint");
        set => this.WithProperty("gateway_vpc_endpoint", value);
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
    /// The medium_changer_type attribute.
    /// </summary>
    public TerraformProperty<string>? MediumChangerType
    {
        get => GetProperty<TerraformProperty<string>>("medium_changer_type");
        set => this.WithProperty("medium_changer_type", value);
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
    /// The smb_file_share_visibility attribute.
    /// </summary>
    public TerraformProperty<bool>? SmbFileShareVisibility
    {
        get => GetProperty<TerraformProperty<bool>>("smb_file_share_visibility");
        set => this.WithProperty("smb_file_share_visibility", value);
    }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    public TerraformProperty<string>? SmbGuestPassword
    {
        get => GetProperty<TerraformProperty<string>>("smb_guest_password");
        set => this.WithProperty("smb_guest_password", value);
    }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? SmbSecurityStrategy
    {
        get => GetProperty<TerraformProperty<string>>("smb_security_strategy");
        set => this.WithProperty("smb_security_strategy", value);
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
    /// The tape_drive_type attribute.
    /// </summary>
    public TerraformProperty<string>? TapeDriveType
    {
        get => GetProperty<TerraformProperty<string>>("tape_drive_type");
        set => this.WithProperty("tape_drive_type", value);
    }

    /// <summary>
    /// Block for maintenance_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceStartTime block(s) allowed")]
    public List<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>? MaintenanceStartTime
    {
        get => GetProperty<List<AwsStoragegatewayGatewayMaintenanceStartTimeBlock>>("maintenance_start_time");
        set => this.WithProperty("maintenance_start_time", value);
    }

    /// <summary>
    /// Block for smb_active_directory_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmbActiveDirectorySettings block(s) allowed")]
    public List<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>? SmbActiveDirectorySettings
    {
        get => GetProperty<List<AwsStoragegatewayGatewaySmbActiveDirectorySettingsBlock>>("smb_active_directory_settings");
        set => this.WithProperty("smb_active_directory_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsStoragegatewayGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsStoragegatewayGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
