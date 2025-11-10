using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterNatAddressTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("drain_nat_ips");
        SetOutput("id");
        SetOutput("nat_ips");
        SetOutput("project");
        SetOutput("region");
        SetOutput("router");
        SetOutput("router_nat");
    }

    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public HashSet<TerraformProperty<string>> DrainNatIps
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("drain_nat_ips");
        set => SetProperty("drain_nat_ips", value);
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
    /// Self-links of NAT IPs to be used in a Nat service. Only valid if the referenced RouterNat
    /// natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatIps is required")]
    public HashSet<TerraformProperty<string>> NatIps
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("nat_ips");
        set => SetProperty("nat_ips", value);
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
    /// Region where the NAT service reside.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which the referenced NAT service is configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformProperty<string> Router
    {
        get => GetRequiredOutput<TerraformProperty<string>>("router");
        set => SetProperty("router", value);
    }

    /// <summary>
    /// The name of the Nat service in which this address will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouterNat is required")]
    public required TerraformProperty<string> RouterNat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("router_nat");
        set => SetProperty("router_nat", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRouterNatAddressTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
