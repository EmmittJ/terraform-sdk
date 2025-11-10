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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DnsName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The reverse_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("reverse_dns_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReverseDnsName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reverse_dns_name");

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("reverse_dns_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReverseDnsPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reverse_dns_prefix");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_id");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Partition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partition");

    /// <summary>
    /// The supported attribute.
    /// </summary>
    [TerraformPropertyName("supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Supported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supported");

}
