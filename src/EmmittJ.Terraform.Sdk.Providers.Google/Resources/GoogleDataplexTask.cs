using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_task resource.
/// </summary>
public class GoogleDataplexTask : TerraformResource
{
    public GoogleDataplexTask(string name) : base("google_dataplex_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("execution_status");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User-provided description of the task.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User friendly display name.
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
    /// User-defined labels for the task.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The lake in which the task will be created in.
    /// </summary>
    public TerraformProperty<string>? Lake
    {
        get => GetProperty<TerraformProperty<string>>("lake");
        set => this.WithProperty("lake", value);
    }

    /// <summary>
    /// The location in which the task will be created in.
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
    /// The task Id of the task.
    /// </summary>
    public TerraformProperty<string>? TaskId
    {
        get => GetProperty<TerraformProperty<string>>("task_id");
        set => this.WithProperty("task_id", value);
    }

    /// <summary>
    /// The time when the task was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Configuration for the cluster
    /// </summary>
    public TerraformExpression ExecutionStatus => this["execution_status"];

    /// <summary>
    /// The relative resource name of the task, of the form: projects/{project_number}/locations/{locationId}/lakes/{lakeId}/ tasks/{name}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Current state of the task.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time when the task was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
