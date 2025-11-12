using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for features in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowFulfillmentFeaturesBlock() : TerraformBlock("features")
{
    /// <summary>
    /// The type of the feature that enabled for fulfillment.
    /// * SMALLTALK: Fulfillment is enabled for SmallTalk. Possible values: [&amp;quot;SMALLTALK&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for generic_web_service in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowFulfillmentGenericWebServiceBlock() : TerraformBlock("generic_web_service")
{
    /// <summary>
    /// The password for HTTP Basic authentication.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The HTTP request headers to send together with fulfillment requests.
    /// </summary>
    [TerraformProperty("request_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequestHeaders { get; set; }

    /// <summary>
    /// The fulfillment URI for receiving POST requests. It must use https protocol.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

    /// <summary>
    /// The user name for HTTP Basic authentication.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowFulfillmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_dialogflow_fulfillment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowFulfillment : TerraformResource
{
    public GoogleDialogflowFulfillment(string name) : base("google_dialogflow_fulfillment", name)
    {
    }

    /// <summary>
    /// The human-readable name of the fulfillment, unique within the agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Whether fulfillment is enabled.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for features.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("features")]
    public TerraformList<GoogleDialogflowFulfillmentFeaturesBlock> Features { get; set; } = new();

    /// <summary>
    /// Block for generic_web_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenericWebService block(s) allowed")]
    [TerraformProperty("generic_web_service")]
    public TerraformList<GoogleDialogflowFulfillmentGenericWebServiceBlock> GenericWebService { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDialogflowFulfillmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique identifier of the fulfillment.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/agent/fulfillment - projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agent/fulfillment
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
