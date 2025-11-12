using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsCustomerGatewayDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCustomerGatewayDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_customer_gateway.
/// </summary>
public partial class AwsCustomerGatewayDataSource : TerraformDataSource
{
    public AwsCustomerGatewayDataSource(string name) : base("aws_customer_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsCustomerGatewayDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCustomerGatewayDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [TerraformProperty("bgp_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> BgpAsn { get; }

    /// <summary>
    /// The bgp_asn_extended attribute.
    /// </summary>
    [TerraformProperty("bgp_asn_extended")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> BgpAsnExtended { get; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformProperty("device_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeviceName { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
