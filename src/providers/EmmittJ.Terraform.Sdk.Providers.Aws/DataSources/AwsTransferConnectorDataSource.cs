using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_transfer_connector.
/// </summary>
public class AwsTransferConnectorDataSource : TerraformDataSource
{
    public AwsTransferConnectorDataSource(string name) : base("aws_transfer_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_role");
        this.WithOutput("arn");
        this.WithOutput("as2_config");
        this.WithOutput("logging_role");
        this.WithOutput("security_policy_name");
        this.WithOutput("service_managed_egress_ip_addresses");
        this.WithOutput("sftp_config");
        this.WithOutput("tags");
        this.WithOutput("url");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The access_role attribute.
    /// </summary>
    public TerraformExpression AccessRole => this["access_role"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The as2_config attribute.
    /// </summary>
    public TerraformExpression As2Config => this["as2_config"];

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformExpression LoggingRole => this["logging_role"];

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformExpression SecurityPolicyName => this["security_policy_name"];

    /// <summary>
    /// The service_managed_egress_ip_addresses attribute.
    /// </summary>
    public TerraformExpression ServiceManagedEgressIpAddresses => this["service_managed_egress_ip_addresses"];

    /// <summary>
    /// The sftp_config attribute.
    /// </summary>
    public TerraformExpression SftpConfig => this["sftp_config"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
