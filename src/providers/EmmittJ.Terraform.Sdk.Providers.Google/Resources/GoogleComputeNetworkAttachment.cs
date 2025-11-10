using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkAttachmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_network_attachment resource.
/// </summary>
public class GoogleComputeNetworkAttachment : TerraformResource
{
    public GoogleComputeNetworkAttachment(string name) : base("google_compute_network_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("connection_endpoints");
        this.WithOutput("creation_timestamp");
        this.WithOutput("fingerprint");
        this.WithOutput("id");
        this.WithOutput("kind");
        this.WithOutput("network");
        this.WithOutput("self_link");
        this.WithOutput("self_link_with_id");
    }

    /// <summary>
    /// The connection preference of service attachment. The value can be set to ACCEPT_AUTOMATIC. An ACCEPT_AUTOMATIC service attachment is one that always accepts the connection from consumer forwarding rules. Possible values: [&amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;, &amp;quot;INVALID&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPreference is required")]
    public required TerraformProperty<string> ConnectionPreference
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_preference");
        set => this.WithProperty("connection_preference", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Projects that are allowed to connect to this network attachment. The project can be specified using its id or number.
    /// </summary>
    public List<TerraformProperty<string>>? ProducerAcceptLists
    {
        get => GetProperty<List<TerraformProperty<string>>>("producer_accept_lists");
        set => this.WithProperty("producer_accept_lists", value);
    }

    /// <summary>
    /// Projects that are not allowed to connect to this network attachment. The project can be specified using its id or number.
    /// </summary>
    public List<TerraformProperty<string>>? ProducerRejectLists
    {
        get => GetProperty<List<TerraformProperty<string>>>("producer_reject_lists");
        set => this.WithProperty("producer_reject_lists", value);
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
    /// URL of the region where the network attachment resides. This field applies only to the region resource. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// An array of URLs where each entry is the URL of a subnet provided by the service consumer to use for endpoints in the producers that connect to this network attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnetworks is required")]
    public List<TerraformProperty<string>>? Subnetworks
    {
        get => GetProperty<List<TerraformProperty<string>>>("subnetworks");
        set => this.WithProperty("subnetworks", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeNetworkAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// An array of connections for all the producers connected to this network attachment.
    /// </summary>
    public TerraformExpression ConnectionEndpoints => this["connection_endpoints"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This
    /// field is used in optimistic locking. An up-to-date fingerprint must be provided in order to patch.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique identifier for the resource type. The server generates this identifier.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// Type of the resource.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The URL of the network which the Network Attachment belongs to. Practically it is inferred by fetching the network of the first subnetwork associated.
    /// Because it is required that all the subnetworks must be from the same network, it is assured that the Network Attachment belongs to the same network as all the subnetworks.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Server-defined URL for this resource&#39;s resource id.
    /// </summary>
    public TerraformExpression SelfLinkWithId => this["self_link_with_id"];

}
