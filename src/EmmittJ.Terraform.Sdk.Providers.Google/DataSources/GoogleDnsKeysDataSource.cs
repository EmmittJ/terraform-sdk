using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dns_keys.
/// </summary>
public class GoogleDnsKeysDataSource : TerraformDataSource
{
    public GoogleDnsKeysDataSource(string name) : base("google_dns_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("key_signing_keys");
        this.DeclareOutput("zone_signing_keys");
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
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformProperty<string> ManagedZone
    {
        get => GetProperty<TerraformProperty<string>>("managed_zone");
        set => this.WithProperty("managed_zone", value);
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
    /// The key_signing_keys attribute.
    /// </summary>
    public TerraformExpression KeySigningKeys => this["key_signing_keys"];

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    public TerraformExpression ZoneSigningKeys => this["zone_signing_keys"];

}
