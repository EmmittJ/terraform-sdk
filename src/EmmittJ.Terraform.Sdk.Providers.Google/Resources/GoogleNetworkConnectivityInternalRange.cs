using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_connectivity_internal_range resource.
/// </summary>
public class GoogleNetworkConnectivityInternalRange : TerraformResource
{
    public GoogleNetworkConnectivityInternalRange(string name) : base("google_network_connectivity_internal_range", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("users");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. List of IP CIDR ranges to be excluded. Resulting reserved Internal Range will not overlap with any CIDR blocks mentioned in this list.
    /// Only IPv4 CIDR ranges are supported.
    /// </summary>
    public List<string>? ExcludeCidrRanges
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("exclude_cidr_ranges")?.Value;
        set => this.WithProperty("exclude_cidr_ranges", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// Immutable ranges cannot have their fields modified, except for labels and description.
    /// </summary>
    public bool? Immutable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("immutable")?.Value;
        set => this.WithProperty("immutable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The IP range that this internal range defines.
    /// NOTE: IPv6 ranges are limited to usage=EXTERNAL_TO_VPC and peering=FOR_SELF
    /// NOTE: For IPv6 Ranges this field is compulsory, i.e. the address range must be specified explicitly.
    /// </summary>
    public string? IpCidrRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_cidr_range")?.Value;
        set => this.WithProperty("ip_cidr_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Types of resources that are allowed to overlap with the current internal range. Possible values: [&amp;quot;OVERLAP_ROUTE_RANGE&amp;quot;, &amp;quot;OVERLAP_EXISTING_SUBNET_RANGE&amp;quot;]
    /// </summary>
    public List<string>? Overlaps
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("overlaps")?.Value;
        set => this.WithProperty("overlaps", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The type of peering set for this internal range. Possible values: [&amp;quot;FOR_SELF&amp;quot;, &amp;quot;FOR_PEER&amp;quot;, &amp;quot;NOT_SHARED&amp;quot;]
    /// </summary>
    public string? Peering
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering")?.Value;
        set => this.WithProperty("peering", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An alternate to ipCidrRange. Can be set when trying to create a reservation that automatically finds a free range of the given size.
    /// If both ipCidrRange and prefixLength are set, there is an error if the range sizes do not match. Can also be used during updates to change the range size.
    /// NOTE: For IPv6 this field only works if ip_cidr_range is set as well, and both fields must match. In other words, with IPv6 this field only works as
    /// a redundant parameter.
    /// </summary>
    public double? PrefixLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("prefix_length")?.Value;
        set => this.WithProperty("prefix_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Can be set to narrow down or pick a different address space while searching for a free range.
    /// If not set, defaults to the &amp;quot;10.0.0.0/8&amp;quot; address space. This can be used to search in other rfc-1918 address spaces like &amp;quot;172.16.0.0/12&amp;quot; and &amp;quot;192.168.0.0/16&amp;quot; or non-rfc-1918 address spaces used in the VPC.
    /// </summary>
    public List<string>? TargetCidrRange
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_cidr_range")?.Value;
        set => this.WithProperty("target_cidr_range", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The type of usage set for this InternalRange. Possible values: [&amp;quot;FOR_VPC&amp;quot;, &amp;quot;EXTERNAL_TO_VPC&amp;quot;, &amp;quot;FOR_MIGRATION&amp;quot;]
    /// </summary>
    public string? Usage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage")?.Value;
        set => this.WithProperty("usage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The list of resources that refer to this internal range.
    /// Resources that use the internal range for their range allocation are referred to as users of the range.
    /// Other resources mark themselves as users while doing so by creating a reference to this internal range. Having a user, based on this reference, prevents deletion of the internal range referred to. Can be empty.
    /// </summary>
    public TerraformExpression Users => this["users"];

}
