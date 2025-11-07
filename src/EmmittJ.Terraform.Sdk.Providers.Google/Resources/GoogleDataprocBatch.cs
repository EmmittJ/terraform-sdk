using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataproc_batch resource.
/// </summary>
public class GoogleDataprocBatch : TerraformResource
{
    public GoogleDataprocBatch(string name) : base("google_dataproc_batch", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("creator");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("operation");
        this.DeclareOutput("runtime_info");
        this.DeclareOutput("state");
        this.DeclareOutput("state_history");
        this.DeclareOutput("state_message");
        this.DeclareOutput("state_time");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uuid");
    }

    /// <summary>
    /// The ID to use for the batch, which will become the final component of the batch&#39;s resource name.
    /// This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
    /// </summary>
    public TerraformLiteralProperty<string>? BatchId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("batch_id");
        set => this.WithProperty("batch_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The labels to associate with this batch.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location in which the batch will be created in.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The time when the batch was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The email address of the user who created the batch.
    /// </summary>
    public TerraformExpression Creator => this["creator"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name of the batch.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource name of the operation associated with this batch.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

    /// <summary>
    /// Runtime information about batch execution.
    /// </summary>
    public TerraformExpression RuntimeInfo => this["runtime_info"];

    /// <summary>
    /// The state of the batch. For possible values, see the [API documentation](https://cloud.google.com/dataproc-serverless/docs/reference/rest/v1/projects.locations.batches#State).
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Historical state information for the batch.
    /// </summary>
    public TerraformExpression StateHistory => this["state_history"];

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    public TerraformExpression StateTime => this["state_time"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}
