using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for desired_user_created_endpoints in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMemorystoreInstanceDesiredUserCreatedEndpointsDesiredUserCreatedEndpointsBlock() : TerraformBlock("desired_user_created_endpoints")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMemorystoreInstanceDesiredUserCreatedEndpointsTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_memorystore_instance_desired_user_created_endpoints resource.
/// </summary>
public partial class GoogleMemorystoreInstanceDesiredUserCreatedEndpoints : TerraformResource
{
    public GoogleMemorystoreInstanceDesiredUserCreatedEndpoints(string name) : base("google_memorystore_instance_desired_user_created_endpoints", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Memorystore instance these endpoints should be added to.
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
    /// The name of the region of the Memorystore instance these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for desired_user_created_endpoints.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("desired_user_created_endpoints")]
    public TerraformList<GoogleMemorystoreInstanceDesiredUserCreatedEndpointsDesiredUserCreatedEndpointsBlock> DesiredUserCreatedEndpoints { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleMemorystoreInstanceDesiredUserCreatedEndpointsTimeoutsBlock Timeouts { get; set; } = new();

}
