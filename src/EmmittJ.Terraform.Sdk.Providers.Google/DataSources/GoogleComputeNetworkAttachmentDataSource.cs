using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network_attachment.
/// </summary>
public class GoogleComputeNetworkAttachmentDataSource : TerraformDataSource
{
    public GoogleComputeNetworkAttachmentDataSource(string name) : base("google_compute_network_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_endpoints");
        this.DeclareOutput("connection_preference");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("description");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("id");
        this.DeclareOutput("kind");
        this.DeclareOutput("network");
        this.DeclareOutput("producer_accept_lists");
        this.DeclareOutput("producer_reject_lists");
        this.DeclareOutput("self_link");
        this.DeclareOutput("self_link_with_id");
        this.DeclareOutput("subnetworks");
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// An array of connections for all the producers connected to this network attachment.
    /// </summary>
    public TerraformExpression ConnectionEndpoints => this["connection_endpoints"];

    /// <summary>
    /// The connection preference of service attachment. The value can be set to ACCEPT_AUTOMATIC. An ACCEPT_AUTOMATIC service attachment is one that always accepts the connection from consumer forwarding rules. Possible values: [&amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;, &amp;quot;INVALID&amp;quot;]
    /// </summary>
    public TerraformExpression ConnectionPreference => this["connection_preference"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

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
    /// Projects that are allowed to connect to this network attachment. The project can be specified using its id or number.
    /// </summary>
    public TerraformExpression ProducerAcceptLists => this["producer_accept_lists"];

    /// <summary>
    /// Projects that are not allowed to connect to this network attachment. The project can be specified using its id or number.
    /// </summary>
    public TerraformExpression ProducerRejectLists => this["producer_reject_lists"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Server-defined URL for this resource&#39;s resource id.
    /// </summary>
    public TerraformExpression SelfLinkWithId => this["self_link_with_id"];

    /// <summary>
    /// An array of URLs where each entry is the URL of a subnet provided by the service consumer to use for endpoints in the producers that connect to this network attachment.
    /// </summary>
    public TerraformExpression Subnetworks => this["subnetworks"];

}
