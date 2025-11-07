using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_apphub_application.
/// </summary>
public class GoogleApphubApplicationDataSource : TerraformDataSource
{
    public GoogleApphubApplicationDataSource(string name) : base("google_apphub_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attributes");
        this.DeclareOutput("create_time");
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("name");
        this.DeclareOutput("scope");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Required. The Application identifier.
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Consumer provided attributes.
    /// </summary>
    public TerraformExpression Attributes => this["attributes"];

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Optional. User-defined description of an Application.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Optional. User-defined name for the Application.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Identifier. The resource name of an Application. Format:
    /// &amp;quot;projects/{host-project-id}/locations/{location}/applications/{application-id}&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Scope of an application.
    /// </summary>
    public TerraformExpression Scope => this["scope"];

    /// <summary>
    /// Output only. Application state. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    /// CREATING
    /// ACTIVE
    /// DELETING
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. A universally unique identifier (in UUID4 format) for the &#39;Application&#39;.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Update time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
