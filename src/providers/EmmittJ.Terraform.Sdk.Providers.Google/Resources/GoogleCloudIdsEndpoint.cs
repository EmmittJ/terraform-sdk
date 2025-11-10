using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdsEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("create_time");
        SetOutput("endpoint_forwarding_rule");
        SetOutput("endpoint_ip");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network");
        SetOutput("project");
        SetOutput("severity");
        SetOutput("threat_exceptions");
    }

    /// <summary>
    /// An optional description of the endpoint.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location for the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Name of the endpoint in the format projects/{project_id}/locations/{locationId}/endpoints/{endpointId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Name of the VPC network that is connected to the IDS endpoint. This can either contain the VPC network name itself (like &amp;quot;src-net&amp;quot;) or the full URL to the network (like &amp;quot;projects/{project_id}/global/networks/src-net&amp;quot;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The minimum alert severity level that is reported by the endpoint. Possible values: [&amp;quot;INFORMATIONAL&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;CRITICAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformProperty<string> Severity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// Configuration for threat IDs excluded from generating alerts. Limit: 99 IDs.
    /// </summary>
    public List<TerraformProperty<string>> ThreatExceptions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("threat_exceptions");
        set => SetProperty("threat_exceptions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudIdsEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
