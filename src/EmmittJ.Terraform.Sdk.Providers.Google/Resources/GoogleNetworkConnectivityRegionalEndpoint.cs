using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_connectivity_regional_endpoint resource.
/// </summary>
public class GoogleNetworkConnectivityRegionalEndpoint : TerraformResource
{
    public GoogleNetworkConnectivityRegionalEndpoint(string name) : base("google_network_connectivity_regional_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("psc_forwarding_rule");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The access type of this regional endpoint. This field is reflected in the PSC Forwarding Rule configuration to enable global access. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? AccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_type");
        set => this.WithProperty("access_type", value);
    }

    /// <summary>
    /// The IP Address of the Regional Endpoint. When no address is provided, an IP from the subnetwork is allocated. Use one of the following formats: * IPv4 address as in &#39;10.0.0.1&#39; * Address resource URI as in &#39;projects/{project}/regions/{region}/addresses/{address_name}&#39;
    /// 
    /// ~&amp;gt; **Note:** This field accepts both a reference to a Compute Address resource, which is the resource name of which format is given in the description, and IP literal value. If the user chooses to input a reserved address value; they need to make sure that the reserved address is in IPv4 version, its purpose is GCE_ENDPOINT, its type is INTERNAL and its status is RESERVED. If the user chooses to input an IP literal, they need to make sure that it&#39;s a valid IPv4 address (x.x.x.x) within the subnetwork.
    /// </summary>
    public TerraformLiteralProperty<string>? Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address");
        set => this.WithProperty("address", value);
    }

    /// <summary>
    /// A description of this resource.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the RegionalEndpoint.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the RegionalEndpoint.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name of the VPC network for this private regional endpoint. Format: &#39;projects/{project}/global/networks/{network}&#39;
    /// </summary>
    public TerraformLiteralProperty<string>? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the subnetwork from which the IP address will be allocated. Format: &#39;projects/{project}/regions/{region}/subnetworks/{subnetwork}&#39;
    /// </summary>
    public TerraformLiteralProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnetwork");
        set => this.WithProperty("subnetwork", value);
    }

    /// <summary>
    /// The service endpoint this private regional endpoint connects to. Format: &#39;{apiname}.{region}.rep.googleapis.com&#39; Example: \&amp;quot;cloudkms.us-central1.rep.googleapis.com\&amp;quot;.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetGoogleApi
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_google_api");
        set => this.WithProperty("target_google_api", value);
    }

    /// <summary>
    /// Time when the RegionalEndpoint was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource reference of the PSC Forwarding Rule created on behalf of the customer. Format: &#39;//compute.googleapis.com/projects/{project}/regions/{region}/forwardingRules/{forwarding_rule_name}&#39;
    /// </summary>
    public TerraformExpression PscForwardingRule => this["psc_forwarding_rule"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time when the RegionalEndpoint was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
