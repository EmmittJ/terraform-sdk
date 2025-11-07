using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_developer resource.
/// </summary>
public class GoogleApigeeDeveloper : TerraformResource
{
    public GoogleApigeeDeveloper(string name) : base("google_apigee_developer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("last_modified_at");
        this.DeclareOutput("organizatio_name");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// Email address of the developer. This value is used to uniquely identify the developer in Apigee hybrid. Note that the email address has to be in lowercase only..
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => this.WithProperty("email", value);
    }

    /// <summary>
    /// First name of the developer.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => this.WithProperty("first_name", value);
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
    /// Last name of the developer.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => this.WithProperty("last_name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// User name of the developer. Not used by Apigee hybrid.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    public TerraformExpression LastModifiedAt => this["last_modified_at"];

    /// <summary>
    /// Name of the Apigee organization in which the developer resides.
    /// </summary>
    public TerraformExpression OrganizatioName => this["organizatio_name"];

    /// <summary>
    /// Status of the developer. Valid values are active and inactive.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
