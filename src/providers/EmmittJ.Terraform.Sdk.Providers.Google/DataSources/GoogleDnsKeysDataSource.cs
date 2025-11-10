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
        SetOutput("key_signing_keys");
        SetOutput("zone_signing_keys");
        SetOutput("id");
        SetOutput("managed_zone");
        SetOutput("project");
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
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformProperty<string> ManagedZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_zone");
        set => SetProperty("managed_zone", value);
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
    /// The key_signing_keys attribute.
    /// </summary>
    public TerraformExpression KeySigningKeys => this["key_signing_keys"];

    /// <summary>
    /// The zone_signing_keys attribute.
    /// </summary>
    public TerraformExpression ZoneSigningKeys => this["zone_signing_keys"];

}
