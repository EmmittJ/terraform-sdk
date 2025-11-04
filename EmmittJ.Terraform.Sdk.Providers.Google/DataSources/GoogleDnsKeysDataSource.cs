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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    public string? ManagedZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_zone")?.Value;
        set => this.WithProperty("managed_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_signing_keys attribute.
    /// </summary>
    public TerraformExpression KeySigningKeys => this["key_signing_keys"];

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    public TerraformExpression ZoneSigningKeys => this["zone_signing_keys"];

}
