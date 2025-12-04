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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformValue<string> ManagedZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_zone");
        set => SetArgument("managed_zone", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The key_signing_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> KeySigningKeys
        => AsReference("key_signing_keys");

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ZoneSigningKeys
        => AsReference("zone_signing_keys");

}
