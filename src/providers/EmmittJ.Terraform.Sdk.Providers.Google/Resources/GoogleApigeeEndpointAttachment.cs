using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEndpointAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEndpointAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_apigee_endpoint_attachment Terraform resource.
/// Manages a google_apigee_endpoint_attachment resource.
/// </summary>
public partial class GoogleApigeeEndpointAttachment(string name) : TerraformResource("google_apigee_endpoint_attachment", name)
{
    /// <summary>
    /// ID of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointAttachmentId is required")]
    public required TerraformValue<string> EndpointAttachmentId
    {
        get => new TerraformReference<string>(this, "endpoint_attachment_id");
        set => SetArgument("endpoint_attachment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Location of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAttachment is required")]
    public required TerraformValue<string> ServiceAttachment
    {
        get => new TerraformReference<string>(this, "service_attachment");
        set => SetArgument("service_attachment", value);
    }

    /// <summary>
    /// State of the endpoint attachment connection to the service attachment.
    /// </summary>
    public TerraformValue<string> ConnectionState
    {
        get => new TerraformReference<string>(this, "connection_state");
    }

    /// <summary>
    /// Host that can be used in either HTTP Target Endpoint directly, or as the host in Target Server.
    /// </summary>
    public TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
    }

    /// <summary>
    /// Name of the Endpoint Attachment in the following format:
    /// organizations/{organization}/endpointAttachments/{endpointAttachment}.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEndpointAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEndpointAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
