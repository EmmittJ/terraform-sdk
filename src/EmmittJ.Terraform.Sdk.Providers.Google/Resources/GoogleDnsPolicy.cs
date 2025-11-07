using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dns_policy resource.
/// </summary>
public class GoogleDnsPolicy : TerraformResource
{
    public GoogleDnsPolicy(string name) : base("google_dns_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Allows networks bound to this policy to receive DNS queries sent
    /// by VMs or applications over VPN connections. When enabled, a
    /// virtual IP address will be allocated from each of the sub-networks
    /// that are bound to this policy.
    /// </summary>
    public TerraformProperty<bool>? EnableInboundForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("enable_inbound_forwarding");
        set => this.WithProperty("enable_inbound_forwarding", value);
    }

    /// <summary>
    /// Controls whether logging is enabled for the networks bound to this policy.
    /// Defaults to no logging if not set.
    /// </summary>
    public TerraformProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
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
    /// User assigned name for this policy.
    /// </summary>
    public TerraformProperty<string>? Name
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

}
