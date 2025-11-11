using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_datastream_static_ips.
/// </summary>
public partial class GoogleDatastreamStaticIpsDataSource : TerraformDataSource
{
    public GoogleDatastreamStaticIpsDataSource(string name) : base("google_datastream_static_ips", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The static_ips attribute.
    /// </summary>
    [TerraformProperty("static_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> StaticIps { get; }

}
