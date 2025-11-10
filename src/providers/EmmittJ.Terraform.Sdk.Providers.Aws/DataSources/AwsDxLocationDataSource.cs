using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_location.
/// </summary>
public class AwsDxLocationDataSource : TerraformDataSource
{
    public AwsDxLocationDataSource(string name) : base("aws_dx_location", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationCode is required")]
    [TerraformPropertyName("location_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LocationCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The available_macsec_port_speeds attribute.
    /// </summary>
    [TerraformPropertyName("available_macsec_port_speeds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailableMacsecPortSpeeds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "available_macsec_port_speeds");

    /// <summary>
    /// The available_port_speeds attribute.
    /// </summary>
    [TerraformPropertyName("available_port_speeds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailablePortSpeeds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "available_port_speeds");

    /// <summary>
    /// The available_providers attribute.
    /// </summary>
    [TerraformPropertyName("available_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailableProviders => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "available_providers");

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [TerraformPropertyName("location_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocationName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location_name");

}
