using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeGlobalAddress.
/// Nesting mode: single
/// </summary>
public class GoogleComputeGlobalAddressTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_global_address Terraform resource.
/// Manages a google_compute_global_address resource.
/// </summary>
public partial class GoogleComputeGlobalAddress(string name) : TerraformResource("google_compute_global_address", name)
{
    /// <summary>
    /// The IP address or beginning of the address range represented by this
    /// resource. This can be supplied as an input to reserve a specific
    /// address or omitted to allow GCP to choose a valid one for you.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => GetArgument<TerraformValue<string>>("address") ?? CreateReference("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type of the address to reserve.
    /// 
    /// * EXTERNAL indicates public/external single IP address.
    /// * INTERNAL indicates internal IP ranges belonging to some network. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AddressType
    {
        get => GetArgument<TerraformValue<string>>("address_type");
        set => SetArgument("address_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpVersion
    {
        get => GetArgument<TerraformValue<string>>("ip_version");
        set => SetArgument("ip_version", value);
    }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The URL of the network in which to reserve the IP range. The IP range
    /// must be in RFC1918 space. The network cannot be deleted if there are
    /// any reserved IP ranges referring to it.
    /// 
    /// This should only be set when using an Internal address.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The prefix length of the IP range. If not present, it means the
    /// address field is a single IP address.
    /// 
    /// This field is not applicable to addresses with addressType=INTERNAL
    /// when purpose=PRIVATE_SERVICE_CONNECT
    /// </summary>
    public TerraformValue<double> PrefixLength
    {
        get => GetArgument<TerraformValue<double>>("prefix_length") ?? CreateReference("prefix_length");
        set => SetArgument("prefix_length", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The purpose of the resource. Possible values include:
    /// 
    /// * VPC_PEERING - for peer networks
    /// 
    /// * PRIVATE_SERVICE_CONNECT - for ([Beta](https://terraform.io/docs/providers/google/guides/provider_versions.html) only) Private Service Connect networks
    /// </summary>
    public TerraformValue<string>? Purpose
    {
        get => GetArgument<TerraformValue<string>>("purpose");
        set => SetArgument("purpose", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => CreateReference("label_fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeGlobalAddressTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeGlobalAddressTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
