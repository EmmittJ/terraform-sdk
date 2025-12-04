using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputePublicAdvertisedPrefix.
/// Nesting mode: single
/// </summary>
public class GoogleComputePublicAdvertisedPrefixTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_public_advertised_prefix Terraform resource.
/// Manages a google_compute_public_advertised_prefix resource.
/// </summary>
public partial class GoogleComputePublicAdvertisedPrefix(string name) : TerraformResource("google_compute_public_advertised_prefix", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The IPv4 address to be used for reverse DNS verification.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsVerificationIp is required")]
    public required TerraformValue<string> DnsVerificationIp
    {
        get => GetArgument<TerraformValue<string>>("dns_verification_ip");
        set => SetArgument("dns_verification_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The address range, in CIDR format, represented by this public advertised prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformValue<string> IpCidrRange
    {
        get => GetArgument<TerraformValue<string>>("ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Specifies how child public delegated prefix will be scoped. pdpScope
    /// must be one of: GLOBAL, REGIONAL
    /// * REGIONAL: The public delegated prefix is regional only. The
    /// provisioning will take a few minutes.
    /// * GLOBAL: The public delegated prefix is global only. The provisioning
    /// will take ~4 weeks. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PdpScope
    {
        get => GetArgument<TerraformValue<string>>("pdp_scope");
        set => SetArgument("pdp_scope", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Output Only. The shared secret to be used for reverse DNS verification.
    /// </summary>
    public TerraformValue<string> SharedSecret
        => AsReference("shared_secret");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputePublicAdvertisedPrefixTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputePublicAdvertisedPrefixTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
