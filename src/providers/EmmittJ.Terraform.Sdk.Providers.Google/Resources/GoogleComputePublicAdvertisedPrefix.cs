using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputePublicAdvertisedPrefixTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_compute_public_advertised_prefix resource.
/// </summary>
public class GoogleComputePublicAdvertisedPrefix : TerraformResource
{
    public GoogleComputePublicAdvertisedPrefix(string name) : base("google_compute_public_advertised_prefix", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("self_link");
        SetOutput("shared_secret");
        SetOutput("description");
        SetOutput("dns_verification_ip");
        SetOutput("id");
        SetOutput("ip_cidr_range");
        SetOutput("name");
        SetOutput("pdp_scope");
        SetOutput("project");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The IPv4 address to be used for reverse DNS verification.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsVerificationIp is required")]
    public required TerraformProperty<string> DnsVerificationIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_verification_ip");
        set => SetProperty("dns_verification_ip", value);
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
    /// The address range, in CIDR format, represented by this public advertised prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformProperty<string> IpCidrRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_cidr_range");
        set => SetProperty("ip_cidr_range", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Specifies how child public delegated prefix will be scoped. pdpScope
    /// must be one of: GLOBAL, REGIONAL
    /// * REGIONAL: The public delegated prefix is regional only. The
    /// provisioning will take a few minutes.
    /// * GLOBAL: The public delegated prefix is global only. The provisioning
    /// will take ~4 weeks. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string> PdpScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pdp_scope");
        set => SetProperty("pdp_scope", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputePublicAdvertisedPrefixTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Output Only. The shared secret to be used for reverse DNS verification.
    /// </summary>
    public TerraformExpression SharedSecret => this["shared_secret"];

}
