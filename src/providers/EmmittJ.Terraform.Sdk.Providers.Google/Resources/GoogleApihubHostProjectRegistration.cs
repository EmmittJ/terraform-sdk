using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApihubHostProjectRegistration.
/// Nesting mode: single
/// </summary>
public class GoogleApihubHostProjectRegistrationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_apihub_host_project_registration Terraform resource.
/// Manages a google_apihub_host_project_registration resource.
/// </summary>
public partial class GoogleApihubHostProjectRegistration(string name) : TerraformResource("google_apihub_host_project_registration", name)
{
    /// <summary>
    /// Required. Immutable. Google cloud project name in the format: &amp;quot;projects/abc&amp;quot; or &amp;quot;projects/123&amp;quot;.
    /// As input, project name with either project id or number are accepted.
    /// As output, this field will contain project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpProject is required")]
    public required TerraformValue<string> GcpProject
    {
        get => GetArgument<TerraformValue<string>>("gcp_project");
        set => SetArgument("gcp_project", value);
    }

    /// <summary>
    /// Required. The ID to use for the Host Project Registration, which will become the
    /// final component of the host project registration&#39;s resource name. The ID
    /// must be the same as the Google cloud project specified in the
    /// host_project_registration.gcp_project field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProjectRegistrationId is required")]
    public required TerraformValue<string> HostProjectRegistrationId
    {
        get => GetArgument<TerraformValue<string>>("host_project_registration_id");
        set => SetArgument("host_project_registration_id", value);
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
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The time at which the host project registration was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Identifier. The name of the host project registration.
    /// Format:
    /// &amp;quot;projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}&amp;quot;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApihubHostProjectRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApihubHostProjectRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
