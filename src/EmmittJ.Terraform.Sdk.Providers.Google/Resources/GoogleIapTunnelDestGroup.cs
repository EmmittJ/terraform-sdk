using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
    }

    /// <summary>
    /// List of CIDRs that this group applies to.
    /// </summary>
    public TerraformProperty<List<string>>? Cidrs
    {
        get => GetProperty<TerraformProperty<List<string>>>("cidrs");
        set => this.WithProperty("cidrs", value);
    }

    /// <summary>
    /// List of FQDNs that this group applies to.
    /// </summary>
    public TerraformProperty<List<string>>? Fqdns
    {
        get => GetProperty<TerraformProperty<List<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
    }

    /// <summary>
    /// Unique tunnel destination group name.
    /// </summary>
    public TerraformProperty<string>? GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the tunnel group. Must be the same as the network resources in the group.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Full resource name.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
