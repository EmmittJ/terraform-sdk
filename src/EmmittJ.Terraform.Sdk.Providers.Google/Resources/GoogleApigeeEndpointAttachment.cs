using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("connection_state");
        this.DeclareOutput("host");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// ID of the endpoint attachment.
    /// </summary>
    public string? EndpointAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_attachment_id")?.Value;
        set => this.WithProperty("endpoint_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Location of the endpoint attachment.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    public string? ServiceAttachment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_attachment")?.Value;
        set => this.WithProperty("service_attachment", value == null ? null : new TerraformLiteralProperty<string>(value));
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
