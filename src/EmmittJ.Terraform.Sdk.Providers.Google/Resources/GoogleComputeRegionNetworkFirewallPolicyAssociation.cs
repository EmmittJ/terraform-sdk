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
    public string? AttachmentTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attachment_target")?.Value;
        set => this.WithProperty("attachment_target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    public string? FirewallPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_policy")?.Value;
        set => this.WithProperty("firewall_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name for an association.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location of this resource.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    public TerraformExpression ShortName => this["short_name"];

}
