using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apihub_host_project_registration resource.
/// </summary>
public class GoogleApihubHostProjectRegistration : TerraformResource
{
    public GoogleApihubHostProjectRegistration(string name) : base("google_apihub_host_project_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Required. Immutable. Google cloud project name in the format: &amp;quot;projects/abc&amp;quot; or &amp;quot;projects/123&amp;quot;.
    /// As input, project name with either project id or number are accepted.
    /// As output, this field will contain project number.
    /// </summary>
    public TerraformProperty<string>? GcpProject
    {
        get => GetProperty<TerraformProperty<string>>("gcp_project");
        set => this.WithProperty("gcp_project", value);
    }

    /// <summary>
    /// Required. The ID to use for the Host Project Registration, which will become the
    /// final component of the host project registration&#39;s resource name. The ID
    /// must be the same as the Google cloud project specified in the
    /// host_project_registration.gcp_project field.
    /// </summary>
    public TerraformProperty<string>? HostProjectRegistrationId
    {
        get => GetProperty<TerraformProperty<string>>("host_project_registration_id");
        set => this.WithProperty("host_project_registration_id", value);
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
    /// Output only. The time at which the host project registration was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Identifier. The name of the host project registration.
    /// Format:
    /// &amp;quot;projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
