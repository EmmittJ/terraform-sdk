using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataproc_gdc_spark_application resource.
/// </summary>
public class GoogleDataprocGdcSparkApplication : TerraformResource
{
    public GoogleDataprocGdcSparkApplication(string name) : base("google_dataproc_gdc_spark_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("monitoring_endpoint");
        this.DeclareOutput("name");
        this.DeclareOutput("output_uri");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("state_message");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The annotations to associate with this application. Annotations may be used to store client information, but are not used by the server. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Annotations
    {
        get => GetProperty<TerraformMapProperty<string>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// An ApplicationEnvironment from which to inherit configuration properties.
    /// </summary>
    public TerraformProperty<string>? ApplicationEnvironment
    {
        get => GetProperty<TerraformProperty<string>>("application_environment");
        set => this.WithProperty("application_environment", value);
    }

    /// <summary>
    /// List of container image uris for additional file dependencies. Dependent files are sequentially copied from each image. If a file with the same name exists in 2 images then the file from later image is used.
    /// </summary>
    public TerraformProperty<List<string>>? DependencyImages
    {
        get => GetProperty<TerraformProperty<List<string>>>("dependency_images");
        set => this.WithProperty("dependency_images", value);
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
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
    /// The labels to associate with this application. Labels may be used for filtering and billing tracking. 
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
    /// The location of the spark application.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The Kubernetes namespace in which to create the application. This namespace must already exist on the cluster.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// application-specific properties.
    /// </summary>
    public TerraformMapProperty<string>? Properties
    {
        get => GetProperty<TerraformMapProperty<string>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// The id of the service instance to which this spark application belongs.
    /// </summary>
    public TerraformProperty<string>? Serviceinstance
    {
        get => GetProperty<TerraformProperty<string>>("serviceinstance");
        set => this.WithProperty("serviceinstance", value);
    }

    /// <summary>
    /// The id of the application
    /// </summary>
    public TerraformProperty<string>? SparkApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("spark_application_id");
        set => this.WithProperty("spark_application_id", value);
    }

    /// <summary>
    /// The Dataproc version of this application.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// URL for a monitoring UI for this application (for eventual Spark PHS/UI support) Out of scope for private GA
    /// </summary>
    public TerraformExpression MonitoringEndpoint => this["monitoring_endpoint"];

    /// <summary>
    /// Identifier. The name of the application. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/sparkApplications/{application}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// An HCFS URI pointing to the location of stdout and stdout of the application Mainly useful for Pantheon and gcloud Not in scope for private GA
    /// </summary>
    public TerraformExpression OutputUri => this["output_uri"];

    /// <summary>
    /// Whether the application is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state.
    /// Possible values:
    /// * &#39;STATE_UNSPECIFIED&#39;
    /// * &#39;PENDING&#39;
    /// * &#39;RUNNING&#39;
    /// * &#39;CANCELLING&#39;
    /// * &#39;CANCELLED&#39;
    /// * &#39;SUCCEEDED&#39;
    /// * &#39;FAILED&#39;
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated unique identifier for this application, formatted as UUID4.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
