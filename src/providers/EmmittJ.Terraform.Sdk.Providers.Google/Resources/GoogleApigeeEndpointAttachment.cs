using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEndpointAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_apigee_endpoint_attachment resource.
/// </summary>
public class GoogleApigeeEndpointAttachment : TerraformResource
{
    public GoogleApigeeEndpointAttachment(string name) : base("google_apigee_endpoint_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("connection_state");
        this.WithOutput("host");
        this.WithOutput("name");
    }

    /// <summary>
    /// ID of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointAttachmentId is required")]
    public required TerraformProperty<string> EndpointAttachmentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("endpoint_attachment_id");
        set => this.WithProperty("endpoint_attachment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Location of the endpoint attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAttachment is required")]
    public required TerraformProperty<string> ServiceAttachment
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_attachment");
        set => this.WithProperty("service_attachment", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeEndpointAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeEndpointAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// State of the endpoint attachment connection to the service attachment.
    /// </summary>
    public TerraformExpression ConnectionState => this["connection_state"];

    /// <summary>
    /// Host that can be used in either HTTP Target Endpoint directly, or as the host in Target Server.
    /// </summary>
    public TerraformExpression Host => this["host"];

    /// <summary>
    /// Name of the Endpoint Attachment in the following format:
    /// organizations/{organization}/endpointAttachments/{endpointAttachment}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
