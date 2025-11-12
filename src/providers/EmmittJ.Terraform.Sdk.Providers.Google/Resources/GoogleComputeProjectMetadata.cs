using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeProjectMetadataTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_project_metadata resource.
/// </summary>
public partial class GoogleComputeProjectMetadata : TerraformResource
{
    public GoogleComputeProjectMetadata(string name) : base("google_compute_project_metadata", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A series of key value pairs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    [TerraformProperty("metadata")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeProjectMetadataTimeoutsBlock Timeouts { get; set; } = new();

}
