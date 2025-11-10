using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_network_firewall_policy_association resource.
/// </summary>
public class GoogleComputeNetworkFirewallPolicyAssociation : TerraformResource
{
    public GoogleComputeNetworkFirewallPolicyAssociation(string name) : base("google_compute_network_firewall_policy_association", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    public required TerraformProperty<string> AttachmentTarget
    {
        get => GetProperty<TerraformProperty<string>>("attachment_target");
        set => this.WithProperty("attachment_target", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    public required TerraformProperty<string> FirewallPolicy
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    public TerraformExpression ShortName => this["short_name"];

}
