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
    public TerraformLiteralProperty<List<string>>? Cidrs
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cidrs");
        set => this.WithProperty("cidrs", value);
    }

    /// <summary>
    /// List of FQDNs that this group applies to.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Fqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
    }

    /// <summary>
    /// Unique tunnel destination group name.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the tunnel group. Must be the same as the network resources in the group.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Full resource name.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
