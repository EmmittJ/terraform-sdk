using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpclattice_service Terraform data source.
/// Retrieves information about a aws_vpclattice_service.
/// </summary>
public partial class AwsVpclatticeServiceDataSource(string name) : TerraformDataSource("aws_vpclattice_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ServiceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("service_identifier");
        set => SetArgument("service_identifier", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformValue<string> AuthType
        => AsReference("auth_type");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => AsReference("certificate_arn");

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainName
        => AsReference("custom_domain_name");

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsEntry
        => AsReference("dns_entry");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
