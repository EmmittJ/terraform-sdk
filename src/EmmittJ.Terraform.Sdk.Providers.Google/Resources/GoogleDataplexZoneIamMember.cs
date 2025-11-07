using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_zone_iam_member resource.
/// </summary>
public class GoogleDataplexZoneIamMember : TerraformResource
{
    public GoogleDataplexZoneIamMember(string name) : base("google_dataplex_zone_iam_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The dataplex_zone attribute.
    /// </summary>
    public TerraformProperty<string>? DataplexZone
    {
        get => GetProperty<TerraformProperty<string>>("dataplex_zone");
        set => this.WithProperty("dataplex_zone", value);
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
    /// The lake attribute.
    /// </summary>
    public TerraformProperty<string>? Lake
    {
        get => GetProperty<TerraformProperty<string>>("lake");
        set => this.WithProperty("lake", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformProperty<string>? Member
    {
        get => GetProperty<TerraformProperty<string>>("member");
        set => this.WithProperty("member", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
