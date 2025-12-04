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
    public TerraformValue<string>? DnsName
    {
        get => GetArgument<TerraformValue<string>>("dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The reverse_dns_name attribute.
    /// </summary>
    public TerraformValue<string>? ReverseDnsName
    {
        get => GetArgument<TerraformValue<string>>("reverse_dns_name");
        set => SetArgument("reverse_dns_name", value);
    }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ReverseDnsPrefix
    {
        get => GetArgument<TerraformValue<string>>("reverse_dns_prefix");
        set => SetArgument("reverse_dns_prefix", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformValue<string>? ServiceId
    {
        get => GetArgument<TerraformValue<string>>("service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
        => AsReference("partition");

    /// <summary>
    /// The supported attribute.
    /// </summary>
    public TerraformValue<bool> Supported
        => AsReference("supported");

}
