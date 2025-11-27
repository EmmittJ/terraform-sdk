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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    public TerraformValue<string> AccessRole
    {
        get => new TerraformReference<string>(this, "access_role");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The as2_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> As2Config
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "as2_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string> LoggingRole
    {
        get => new TerraformReference<string>(this, "logging_role");
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicyName
    {
        get => new TerraformReference<string>(this, "security_policy_name");
    }

    /// <summary>
    /// The service_managed_egress_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ServiceManagedEgressIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "service_managed_egress_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sftp_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SftpConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sftp_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
