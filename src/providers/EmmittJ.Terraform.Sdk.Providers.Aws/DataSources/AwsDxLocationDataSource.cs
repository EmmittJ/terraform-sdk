using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_location.
/// </summary>
public partial class AwsDxLocationDataSource : TerraformDataSource
{
    public AwsDxLocationDataSource(string name) : base("aws_dx_location", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationCode is required")]
    [TerraformProperty("location_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LocationCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The available_macsec_port_speeds attribute.
    /// </summary>
    [TerraformProperty("available_macsec_port_speeds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailableMacsecPortSpeeds { get; }

    /// <summary>
    /// The available_port_speeds attribute.
    /// </summary>
    [TerraformProperty("available_port_speeds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailablePortSpeeds { get; }

    /// <summary>
    /// The available_providers attribute.
    /// </summary>
    [TerraformProperty("available_providers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailableProviders { get; }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [TerraformProperty("location_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LocationName { get; }

}
