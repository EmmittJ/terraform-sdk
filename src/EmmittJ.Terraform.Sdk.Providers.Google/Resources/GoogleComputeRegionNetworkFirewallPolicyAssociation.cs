using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_network_firewall_policy_association resource.
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyAssociation : TerraformResource
{
    public GoogleComputeRegionNetworkFirewallPolicyAssociation(string name) : base("google_compute_region_network_firewall_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("short_name");
    }

    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    public TerraformProperty<string>? AttachmentTarget
    {
        get => GetProperty<TerraformProperty<string>>("attachment_target");
        set => this.WithProperty("attachment_target", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    public TerraformProperty<string>? FirewallPolicy
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy");
        set => this.WithProperty("firewall_policy", value);
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
    /// The name for an association.
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

    /// <summary>
    /// The location of this resource.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    public TerraformExpression ShortName => this["short_name"];

}
