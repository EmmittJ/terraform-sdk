using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_router_configuration.
/// </summary>
public partial class AwsDxRouterConfigurationDataSource : TerraformDataSource
{
    public AwsDxRouterConfigurationDataSource(string name) : base("aws_dx_router_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The router_type_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouterTypeIdentifier is required")]
    [TerraformProperty("router_type_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RouterTypeIdentifier { get; set; }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    [TerraformProperty("virtual_interface_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualInterfaceId { get; set; }

    /// <summary>
    /// The customer_router_config attribute.
    /// </summary>
    [TerraformProperty("customer_router_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerRouterConfig { get; }

    /// <summary>
    /// The router attribute.
    /// </summary>
    [TerraformProperty("router")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Router { get; }

    /// <summary>
    /// The virtual_interface_name attribute.
    /// </summary>
    [TerraformProperty("virtual_interface_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualInterfaceName { get; }

}
