using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_service.
/// </summary>
public class AwsServiceDataSource : TerraformDataSource
{
    public AwsServiceDataSource(string name) : base("aws_service", name)
    {
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DnsName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The reverse_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("reverse_dns_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReverseDnsName { get; set; } = default!;

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("reverse_dns_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReverseDnsPrefix { get; set; } = default!;

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceId { get; set; } = default!;

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Partition => new TerraformReference(this, "partition");

    /// <summary>
    /// The supported attribute.
    /// </summary>
    [TerraformPropertyName("supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Supported => new TerraformReference(this, "supported");

}
