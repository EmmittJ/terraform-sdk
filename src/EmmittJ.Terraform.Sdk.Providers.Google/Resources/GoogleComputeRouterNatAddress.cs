using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_router_nat_address resource.
/// </summary>
public class GoogleComputeRouterNatAddress : TerraformResource
{
    public GoogleComputeRouterNatAddress(string name) : base("google_compute_router_nat_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DrainNatIps
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("drain_nat_ips");
        set => this.WithProperty("drain_nat_ips", value);
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
    /// Self-links of NAT IPs to be used in a Nat service. Only valid if the referenced RouterNat
    /// natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    public TerraformProperty<HashSet<string>>? NatIps
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("nat_ips");
        set => this.WithProperty("nat_ips", value);
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
    /// Region where the NAT service reside.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which the referenced NAT service is configured.
    /// </summary>
    public TerraformProperty<string>? Router
    {
        get => GetProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// The name of the Nat service in which this address will be configured.
    /// </summary>
    public TerraformProperty<string>? RouterNat
    {
        get => GetProperty<TerraformProperty<string>>("router_nat");
        set => this.WithProperty("router_nat", value);
    }

}
