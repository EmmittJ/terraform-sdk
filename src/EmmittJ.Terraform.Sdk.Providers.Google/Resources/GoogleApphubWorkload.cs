using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apphub_workload resource.
/// </summary>
public class GoogleApphubWorkload : TerraformResource
{
    public GoogleApphubWorkload(string name) : base("google_apphub_workload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("workload_properties");
        this.DeclareOutput("workload_reference");
    }

    /// <summary>
    /// Part of &#39;parent&#39;.  Full resource name of a parent Application. Example: projects/{HOST_PROJECT_ID}/locations/{LOCATION}/applications/{APPLICATION_ID}
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// User-defined description of a Workload.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Immutable. The resource name of the original discovered workload.
    /// </summary>
    public TerraformProperty<string>? DiscoveredWorkload
    {
        get => GetProperty<TerraformProperty<string>>("discovered_workload");
        set => this.WithProperty("discovered_workload", value);
    }

    /// <summary>
    /// User-defined name for the Workload.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Part of &#39;parent&#39;.  Full resource name of a parent Application. Example: projects/{HOST_PROJECT_ID}/locations/{LOCATION}/applications/{APPLICATION_ID}
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
    /// The Workload identifier.
    /// </summary>
    public TerraformProperty<string>? WorkloadId
    {
        get => GetProperty<TerraformProperty<string>>("workload_id");
        set => this.WithProperty("workload_id", value);
    }

    /// <summary>
    /// Output only. Create time.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Identifier. The resource name of the Workload. Format:&amp;quot;projects/{host-project-id}/locations/{location}/applications/{application-id}/workloads/{workload-id}&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Workload state. Possible values:  STATE_UNSPECIFIED CREATING ACTIVE DELETING DETACHED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. A universally unique identifier (UUID) for the &#39;Workload&#39; in the UUID4 format.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Update time.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Properties of an underlying compute resource represented by the Workload.
    /// </summary>
    public TerraformExpression WorkloadProperties => this["workload_properties"];

    /// <summary>
    /// Reference of an underlying compute resource represented by the Workload.
    /// </summary>
    public TerraformExpression WorkloadReference => this["workload_reference"];

}
