using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_connector Terraform data source.
/// Retrieves information about a aws_transfer_connector.
/// </summary>
public partial class AwsTransferConnectorDataSource(string name) : TerraformDataSource("aws_transfer_connector", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The access_role attribute.
    /// </summary>
    public TerraformValue<string> AccessRole
        => AsReference("access_role");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The as2_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> As2Config
        => AsReference("as2_config");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string> LoggingRole
        => AsReference("logging_role");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicyName
        => AsReference("security_policy_name");

    /// <summary>
    /// The service_managed_egress_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ServiceManagedEgressIpAddresses
        => AsReference("service_managed_egress_ip_addresses");

    /// <summary>
    /// The sftp_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SftpConfig
        => AsReference("sftp_config");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

}
