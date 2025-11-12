using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeEndpointAttachmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_apigee_endpoint_attachment resource.
/// </summary>
public partial class GoogleApigeeEndpointAttachment : TerraformResource
{
    public GoogleApigeeEndpointAttachment(string name) : base("google_apigee_endpoint_attachment", name)
    {
    }

    /// <summary>
    /// ID of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointAttachmentId is required")]
    [TerraformProperty("endpoint_attachment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointAttachmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Location of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAttachment is required")]
    [TerraformProperty("service_attachment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceAttachment { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeEndpointAttachmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// State of the endpoint attachment connection to the service attachment.
    /// </summary>
    [TerraformProperty("connection_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionState { get; }

    /// <summary>
    /// Host that can be used in either HTTP Target Endpoint directly, or as the host in Target Server.
    /// </summary>
    [TerraformProperty("host")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Host { get; }

    /// <summary>
    /// Name of the Endpoint Attachment in the following format:
    /// organizations/{organization}/endpointAttachments/{endpointAttachment}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
