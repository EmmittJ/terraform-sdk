using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_service Terraform data source.
/// Retrieves information about a aws_service.
/// </summary>
public partial class AwsServiceDataSource(string name) : TerraformDataSource("aws_service", name)
{
    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
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
    /// The reverse_dns_name attribute.
    /// </summary>
    public TerraformValue<string> ReverseDnsName
    {
        get => new TerraformReference<string>(this, "reverse_dns_name");
        set => SetArgument("reverse_dns_name", value);
    }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> ReverseDnsPrefix
    {
        get => new TerraformReference<string>(this, "reverse_dns_prefix");
        set => SetArgument("reverse_dns_prefix", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceId
    {
        get => new TerraformReference<string>(this, "service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
    {
        get => new TerraformReference<string>(this, "partition");
    }

    /// <summary>
    /// The supported attribute.
    /// </summary>
    public TerraformValue<bool> Supported
    {
        get => new TerraformReference<bool>(this, "supported");
    }

}
