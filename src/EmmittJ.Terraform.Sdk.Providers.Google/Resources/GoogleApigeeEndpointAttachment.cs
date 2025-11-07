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
    public TerraformProperty<string>? EndpointAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_attachment_id");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Format: projects/*/regions/*/serviceAttachments/*
    /// </summary>
    public TerraformProperty<string>? ServiceAttachment
    {
        get => GetProperty<TerraformProperty<string>>("service_attachment");
        set => this.WithProperty("service_attachment", value);
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
