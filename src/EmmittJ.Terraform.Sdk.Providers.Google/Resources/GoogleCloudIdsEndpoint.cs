using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_ids_endpoint resource.
/// </summary>
public class GoogleCloudIdsEndpoint : TerraformResource
{
    public GoogleCloudIdsEndpoint(string name) : base("google_cloud_ids_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("endpoint_forwarding_rule");
        this.DeclareOutput("endpoint_ip");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// An optional description of the endpoint.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location for the endpoint.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Name of the endpoint in the format projects/{project_id}/locations/{locationId}/endpoints/{endpointId}.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Name of the VPC network that is connected to the IDS endpoint. This can either contain the VPC network name itself (like &amp;quot;src-net&amp;quot;) or the full URL to the network (like &amp;quot;projects/{project_id}/global/networks/src-net&amp;quot;).
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The minimum alert severity level that is reported by the endpoint. Possible values: [&amp;quot;INFORMATIONAL&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;CRITICAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Severity
    {
        get => GetProperty<TerraformProperty<string>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// Configuration for threat IDs excluded from generating alerts. Limit: 99 IDs.
    /// </summary>
    public TerraformProperty<List<string>>? ThreatExceptions
    {
        get => GetProperty<TerraformProperty<List<string>>>("threat_exceptions");
        set => this.WithProperty("threat_exceptions", value);
    }

    /// <summary>
    /// Creation timestamp in RFC 3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// URL of the endpoint&#39;s network address to which traffic is to be sent by Packet Mirroring.
    /// </summary>
    public TerraformExpression EndpointForwardingRule => this["endpoint_forwarding_rule"];

    /// <summary>
    /// Internal IP address of the endpoint&#39;s network entry point.
    /// </summary>
    public TerraformExpression EndpointIp => this["endpoint_ip"];

    /// <summary>
    /// Last update timestamp in RFC 3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
