using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? ActivationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("activation_key")?.Value;
        set => this.WithProperty("activation_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public double? AverageDownloadRateLimitInBitsPerSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("average_download_rate_limit_in_bits_per_sec")?.Value;
        set => this.WithProperty("average_download_rate_limit_in_bits_per_sec", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public double? AverageUploadRateLimitInBitsPerSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("average_upload_rate_limit_in_bits_per_sec")?.Value;
        set => this.WithProperty("average_upload_rate_limit_in_bits_per_sec", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public string? CloudwatchLogGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_log_group_arn")?.Value;
        set => this.WithProperty("cloudwatch_log_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    public string? GatewayIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_ip_address")?.Value;
        set => this.WithProperty("gateway_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public string? GatewayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_name")?.Value;
        set => this.WithProperty("gateway_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    public string? GatewayTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_timezone")?.Value;
        set => this.WithProperty("gateway_timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    public string? GatewayType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_type")?.Value;
        set => this.WithProperty("gateway_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    public string? GatewayVpcEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_vpc_endpoint")?.Value;
        set => this.WithProperty("gateway_vpc_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The medium_changer_type attribute.
    /// </summary>
    public string? MediumChangerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("medium_changer_type")?.Value;
        set => this.WithProperty("medium_changer_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The smb_file_share_visibility attribute.
    /// </summary>
    public bool? SmbFileShareVisibility
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_file_share_visibility")?.Value;
        set => this.WithProperty("smb_file_share_visibility", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    public string? SmbGuestPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("smb_guest_password")?.Value;
        set => this.WithProperty("smb_guest_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    public string? SmbSecurityStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("smb_security_strategy")?.Value;
        set => this.WithProperty("smb_security_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tape_drive_type attribute.
    /// </summary>
    public string? TapeDriveType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tape_drive_type")?.Value;
        set => this.WithProperty("tape_drive_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
