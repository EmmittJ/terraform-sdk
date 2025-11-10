using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_router_configuration.
/// </summary>
public class AwsDxRouterConfigurationDataSource : TerraformDataSource
{
    public AwsDxRouterConfigurationDataSource(string name) : base("aws_dx_router_configuration", name)
    {
    }

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
    /// The router_type_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouterTypeIdentifier is required")]
    [TerraformPropertyName("router_type_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RouterTypeIdentifier { get; set; }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    [TerraformPropertyName("virtual_interface_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualInterfaceId { get; set; }

    /// <summary>
    /// The customer_router_config attribute.
    /// </summary>
    [TerraformPropertyName("customer_router_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerRouterConfig => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_router_config");

    /// <summary>
    /// The router attribute.
    /// </summary>
    [TerraformPropertyName("router")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Router => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "router");

    /// <summary>
    /// The virtual_interface_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_interface_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualInterfaceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_interface_name");

}
