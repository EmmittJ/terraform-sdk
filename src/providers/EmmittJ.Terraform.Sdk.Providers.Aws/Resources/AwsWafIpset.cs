using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_set_descriptors in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafIpsetIpSetDescriptorsBlock() : TerraformBlock("ip_set_descriptors")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_waf_ipset resource.
/// </summary>
public partial class AwsWafIpset : TerraformResource
{
    public AwsWafIpset(string name) : base("aws_waf_ipset", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for ip_set_descriptors.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ip_set_descriptors")]
    public TerraformSet<AwsWafIpsetIpSetDescriptorsBlock> IpSetDescriptors { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
