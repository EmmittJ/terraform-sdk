using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEndpointAttachmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apigee_endpoint_attachment resource.
/// </summary>
public class GoogleApigeeEndpointAttachment : TerraformResource
{
    public GoogleApigeeEndpointAttachment(string name) : base("google_apigee_endpoint_attachment", name)
    {
    }

    /// <summary>
    /// ID of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointAttachmentId is required")]
    [TerraformPropertyName("endpoint_attachment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointAttachmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Location of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAttachment is required")]
    [TerraformPropertyName("service_attachment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAttachment { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeEndpointAttachmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// State of the endpoint attachment connection to the service attachment.
    /// </summary>
    [TerraformPropertyName("connection_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_state");

    /// <summary>
    /// Host that can be used in either HTTP Target Endpoint directly, or as the host in Target Server.
    /// </summary>
    [TerraformPropertyName("host")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Host => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host");

    /// <summary>
    /// Name of the Endpoint Attachment in the following format:
    /// organizations/{organization}/endpointAttachments/{endpointAttachment}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
