using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallPolicyAssociationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_firewall_policy_association resource.
/// </summary>
public class GoogleComputeFirewallPolicyAssociation : TerraformResource
{
    public GoogleComputeFirewallPolicyAssociation(string name) : base("google_compute_firewall_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("short_name");
    }

    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    public required TerraformProperty<string> AttachmentTarget
    {
        get => GetRequiredProperty<TerraformProperty<string>>("attachment_target");
        set => this.WithProperty("attachment_target", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// 
    /// This field can be updated to refer to a different Firewall Policy, which will create a new association from that new
    /// firewall policy with the flag to override the existing attachmentTarget&#39;s policy association.
    /// 
    /// **Note** Due to potential risks with this operation it is *highly* recommended to use the &#39;create_before_destroy&#39; life cycle option
    /// on your exisiting firewall policy so as to prevent a situation where your attachment target has no associated policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    public required TerraformProperty<string> FirewallPolicy
    {
        get => GetRequiredProperty<TerraformProperty<string>>("firewall_policy");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeFirewallPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeFirewallPolicyAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    public TerraformExpression ShortName => this["short_name"];

}
