using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_apphub_application Terraform data source.
/// Retrieves information about a google_apphub_application.
/// </summary>
public partial class GoogleApphubApplicationDataSource(string name) : TerraformDataSource("google_apphub_application", name)
{
    /// <summary>
    /// Required. The Application identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Consumer provided attributes.
    /// </summary>
    public TerraformList<TerraformMap<object>> Attributes
        => AsReference("attributes");

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Optional. User-defined description of an Application.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Optional. User-defined name for the Application.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// Identifier. The resource name of an Application. Format:
    /// &amp;quot;projects/{host-project-id}/locations/{location}/applications/{application-id}&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Scope of an application.
    /// </summary>
    public TerraformList<TerraformMap<object>> Scope
        => AsReference("scope");

    /// <summary>
    /// Output only. Application state. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    /// CREATING
    /// ACTIVE
    /// DELETING
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Output only. A universally unique identifier (in UUID4 format) for the &#39;Application&#39;.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. Update time.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
