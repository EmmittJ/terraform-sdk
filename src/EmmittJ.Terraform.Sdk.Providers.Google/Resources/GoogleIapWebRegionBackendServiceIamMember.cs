using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_web_region_backend_service_iam_member resource.
/// </summary>
public class GoogleIapWebRegionBackendServiceIamMember : TerraformResource
{
    public GoogleIapWebRegionBackendServiceIamMember(string name) : base("google_iap_web_region_backend_service_iam_member", name)
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
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The web_region_backend_service attribute.
    /// </summary>
    public TerraformProperty<string>? WebRegionBackendService
    {
        get => GetProperty<TerraformProperty<string>>("web_region_backend_service");
        set => this.WithProperty("web_region_backend_service", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
