using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dns_managed_zone_iam_member resource.
/// </summary>
public class GoogleDnsManagedZoneIamMember : TerraformResource
{
    public GoogleDnsManagedZoneIamMember(string name) : base("google_dns_managed_zone_iam_member", name)
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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_zone");
        set => this.WithProperty("managed_zone", value);
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Member
    {
        get => GetProperty<TerraformLiteralProperty<string>>("member");
        set => this.WithProperty("member", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
