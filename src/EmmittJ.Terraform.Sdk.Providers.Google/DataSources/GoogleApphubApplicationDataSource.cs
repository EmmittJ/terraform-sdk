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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
