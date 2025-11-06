using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_security_profile_v2 resource.
/// </summary>
public class GoogleApigeeSecurityProfileV2 : TerraformResource
{
    public GoogleApigeeSecurityProfileV2(string name) : base("google_apigee_security_profile_v2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the security profile.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The Apigee Organization associated with the Apigee Security Profile V2,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource ID of the security profile.
    /// </summary>
    public string? ProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_id")?.Value;
        set => this.WithProperty("profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Name of the security profile v2 resource,
    /// in the format &#39;organizations/{{org_name}}/securityProfilesV2/{{profile_id}}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
