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
    public TerraformLiteralProperty<string>? ActivationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("activation_key");
        set => this.WithProperty("activation_key", value);
    }

    /// <summary>
    /// The average_download_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AverageDownloadRateLimitInBitsPerSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("average_download_rate_limit_in_bits_per_sec");
        set => this.WithProperty("average_download_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The average_upload_rate_limit_in_bits_per_sec attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AverageUploadRateLimitInBitsPerSec
    {
        get => GetProperty<TerraformLiteralProperty<double>>("average_upload_rate_limit_in_bits_per_sec");
        set => this.WithProperty("average_upload_rate_limit_in_bits_per_sec", value);
    }

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CloudwatchLogGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_log_group_arn");
        set => this.WithProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The gateway_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_ip_address");
        set => this.WithProperty("gateway_ip_address", value);
    }

    /// <summary>
    /// The gateway_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_name");
        set => this.WithProperty("gateway_name", value);
    }

    /// <summary>
    /// The gateway_timezone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayTimezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_timezone");
        set => this.WithProperty("gateway_timezone", value);
    }

    /// <summary>
    /// The gateway_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_type");
        set => this.WithProperty("gateway_type", value);
    }

    /// <summary>
    /// The gateway_vpc_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GatewayVpcEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_vpc_endpoint");
        set => this.WithProperty("gateway_vpc_endpoint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The medium_changer_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MediumChangerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("medium_changer_type");
        set => this.WithProperty("medium_changer_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The smb_file_share_visibility attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SmbFileShareVisibility
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_file_share_visibility");
        set => this.WithProperty("smb_file_share_visibility", value);
    }

    /// <summary>
    /// The smb_guest_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SmbGuestPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("smb_guest_password");
        set => this.WithProperty("smb_guest_password", value);
    }

    /// <summary>
    /// The smb_security_strategy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SmbSecurityStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("smb_security_strategy");
        set => this.WithProperty("smb_security_strategy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tape_drive_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TapeDriveType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tape_drive_type");
        set => this.WithProperty("tape_drive_type", value);
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
