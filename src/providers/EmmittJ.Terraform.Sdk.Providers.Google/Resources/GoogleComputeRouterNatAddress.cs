using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeRouterNatAddress.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRouterNatAddressTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_router_nat_address Terraform resource.
/// Manages a google_compute_router_nat_address resource.
/// </summary>
public partial class GoogleComputeRouterNatAddress(string name) : TerraformResource("google_compute_router_nat_address", name)
{
    /// <summary>
    /// A list of URLs of the IP resources to be drained. These IPs must be
    /// valid static external IPs that have been assigned to the NAT.
    /// </summary>
    public TerraformSet<string>? DrainNatIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "drain_nat_ips").ResolveNodes(ctx));
        set => SetArgument("drain_nat_ips", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Self-links of NAT IPs to be used in a Nat service. Only valid if the referenced RouterNat
    /// natIpAllocateOption is set to MANUAL_ONLY.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatIps is required")]
    public required TerraformSet<string> NatIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "nat_ips").ResolveNodes(ctx));
        set => SetArgument("nat_ips", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where the NAT service reside.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The name of the Cloud Router in which the referenced NAT service is configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformValue<string> Router
    {
        get => new TerraformReference<string>(this, "router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// The name of the Nat service in which this address will be configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouterNat is required")]
    public required TerraformValue<string> RouterNat
    {
        get => new TerraformReference<string>(this, "router_nat");
        set => SetArgument("router_nat", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRouterNatAddressTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRouterNatAddressTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
