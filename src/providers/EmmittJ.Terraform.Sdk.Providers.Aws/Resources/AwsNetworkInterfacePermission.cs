using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNetworkInterfacePermissionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_network_interface_permission resource.
/// </summary>
public partial class AwsNetworkInterfacePermission : TerraformResource
{
    public AwsNetworkInterfacePermission(string name) : base("aws_network_interface_permission", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsAccountId is required")]
    [TerraformProperty("aws_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    [TerraformProperty("network_interface_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformProperty("permission")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Permission { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsNetworkInterfacePermissionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The network_interface_permission_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_permission_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkInterfacePermissionId { get; }

}
