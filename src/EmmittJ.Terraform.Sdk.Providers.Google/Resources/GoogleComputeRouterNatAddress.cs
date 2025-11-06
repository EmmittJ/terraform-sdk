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
    public HashSet<string>? DrainNatIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("drain_nat_ips")?.Value;
        set => this.WithProperty("drain_nat_ips", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// Self-links of NAT IPs to be used in a Nat service. Only valid if the referenced RouterNat
    /// natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    public HashSet<string>? NatIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("nat_ips")?.Value;
        set => this.WithProperty("nat_ips", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// Region where the NAT service reside.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Cloud Router in which the referenced NAT service is configured.
    /// </summary>
    public string? Router
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router")?.Value;
        set => this.WithProperty("router", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Nat service in which this address will be configured.
    /// </summary>
    public string? RouterNat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router_nat")?.Value;
        set => this.WithProperty("router_nat", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
