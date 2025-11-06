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
    public List<string>? Cidrs
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cidrs")?.Value;
        set => this.WithProperty("cidrs", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// List of FQDNs that this group applies to.
    /// </summary>
    public List<string>? Fqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fqdns")?.Value;
        set => this.WithProperty("fqdns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Unique tunnel destination group name.
    /// </summary>
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region of the tunnel group. Must be the same as the network resources in the group.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Full resource name.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
