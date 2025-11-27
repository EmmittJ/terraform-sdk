using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dns_keys Terraform data source.
/// Retrieves information about a google_dns_keys.
/// </summary>
public partial class GoogleDnsKeysDataSource(string name) : TerraformDataSource("google_dns_keys", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformValue<string> ManagedZone
    {
        get => new TerraformReference<string>(this, "managed_zone");
        set => SetArgument("managed_zone", value);
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
    /// The key_signing_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeySigningKeys
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "key_signing_keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZoneSigningKeys
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "zone_signing_keys").ResolveNodes(ctx));
    }

}
