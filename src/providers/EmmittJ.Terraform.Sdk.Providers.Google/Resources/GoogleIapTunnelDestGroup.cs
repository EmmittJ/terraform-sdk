using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIapTunnelDestGroupTimeoutsBlock : TerraformBlock
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
/// Manages a google_iap_tunnel_dest_group resource.
/// </summary>
public class GoogleIapTunnelDestGroup : TerraformResource
{
    public GoogleIapTunnelDestGroup(string name) : base("google_iap_tunnel_dest_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("cidrs");
        SetOutput("fqdns");
        SetOutput("group_name");
        SetOutput("id");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// List of CIDRs that this group applies to.
    /// </summary>
    public List<TerraformProperty<string>> Cidrs
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cidrs");
        set => SetProperty("cidrs", value);
    }

    /// <summary>
    /// List of FQDNs that this group applies to.
    /// </summary>
    public List<TerraformProperty<string>> Fqdns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("fqdns");
        set => SetProperty("fqdns", value);
    }

    /// <summary>
    /// Unique tunnel destination group name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_name");
        set => SetProperty("group_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region of the tunnel group. Must be the same as the network resources in the group.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIapTunnelDestGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Full resource name.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
