using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_globalaccelerator_accelerator Terraform data source.
/// Retrieves information about a aws_globalaccelerator_accelerator.
/// </summary>
public partial class AwsGlobalacceleratorAcceleratorDataSource(string name) : TerraformDataSource("aws_globalaccelerator_accelerator", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    /// The attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Attributes
        => AsReference("attributes");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The dual_stack_dns_name attribute.
    /// </summary>
    public TerraformValue<string> DualStackDnsName
        => AsReference("dual_stack_dns_name");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
        => AsReference("ip_address_type");

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpSets
        => AsReference("ip_sets");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

}
