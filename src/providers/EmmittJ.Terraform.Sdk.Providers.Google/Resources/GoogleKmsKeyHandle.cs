using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleKmsKeyHandleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_kms_key_handle resource.
/// </summary>
public partial class GoogleKmsKeyHandle : TerraformResource
{
    public GoogleKmsKeyHandle(string name) : base("google_kms_key_handle", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the KeyHandle.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name for the KeyHandle.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Selector of the resource type where we want to protect resources.
    /// For example, &#39;storage.googleapis.com/Bucket&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    [TerraformProperty("resource_type_selector")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceTypeSelector { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleKmsKeyHandleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// A reference to a Cloud KMS CryptoKey that can be used for CMEK in the requested
    /// product/project/location, for example
    /// &#39;projects/1/locations/us-east1/keyRings/foo/cryptoKeys/bar-ffffff&#39;
    /// </summary>
    [TerraformProperty("kms_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKey { get; }

}
