using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dns_managed_zone_iam_policy resource.
/// </summary>
public class GoogleDnsManagedZoneIamPolicy : TerraformResource
{
    public GoogleDnsManagedZoneIamPolicy(string name) : base("google_dns_managed_zone_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    public TerraformProperty<string>? ManagedZone
    {
        get => GetProperty<TerraformProperty<string>>("managed_zone");
        set => this.WithProperty("managed_zone", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
