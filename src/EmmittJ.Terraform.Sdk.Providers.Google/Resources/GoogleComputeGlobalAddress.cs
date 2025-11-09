using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_global_address resource.
/// </summary>
public class GoogleComputeGlobalAddress : TerraformResource
{
    public GoogleComputeGlobalAddress(string name) : base("google_compute_global_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The IP address or beginning of the address range represented by this
    /// resource. This can be supplied as an input to reserve a specific
    /// address or omitted to allow GCP to choose a valid one for you.
    /// </summary>
    public TerraformProperty<string>? Address
    {
        get => GetProperty<TerraformProperty<string>>("address");
        set => this.WithProperty("address", value);
    }

    /// <summary>
    /// The type of the address to reserve.
    /// 
    /// * EXTERNAL indicates public/external single IP address.
    /// * INTERNAL indicates internal IP ranges belonging to some network. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AddressType
    {
        get => GetProperty<TerraformProperty<string>>("address_type");
        set => this.WithProperty("address_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IpVersion
    {
        get => GetProperty<TerraformProperty<string>>("ip_version");
        set => this.WithProperty("ip_version", value);
    }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The URL of the network in which to reserve the IP range. The IP range
    /// must be in RFC1918 space. The network cannot be deleted if there are
    /// any reserved IP ranges referring to it.
    /// 
    /// This should only be set when using an Internal address.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The prefix length of the IP range. If not present, it means the
    /// address field is a single IP address.
    /// 
    /// This field is not applicable to addresses with addressType=INTERNAL
    /// when purpose=PRIVATE_SERVICE_CONNECT
    /// </summary>
    public TerraformProperty<double>? PrefixLength
    {
        get => GetProperty<TerraformProperty<double>>("prefix_length");
        set => this.WithProperty("prefix_length", value);
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
    /// The purpose of the resource. Possible values include:
    /// 
    /// * VPC_PEERING - for peer networks
    /// 
    /// * PRIVATE_SERVICE_CONNECT - for ([Beta](https://terraform.io/docs/providers/google/guides/provider_versions.html) only) Private Service Connect networks
    /// </summary>
    public TerraformProperty<string>? Purpose
    {
        get => GetProperty<TerraformProperty<string>>("purpose");
        set => this.WithProperty("purpose", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
