using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for spark_application_environment_config in GoogleDataprocGdcApplicationEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcApplicationEnvironmentSparkApplicationEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_application_environment_config";

    /// <summary>
    /// A map of default Spark properties to apply to workloads in this application environment. These defaults may be overridden by per-application properties.
    /// </summary>
    public TerraformMap<string>? DefaultProperties
    {
        get => GetArgument<TerraformMap<string>>("default_properties");
        set => SetArgument("default_properties", value);
    }

    /// <summary>
    /// The default Dataproc version to use for applications submitted to this application environment
    /// </summary>
    public TerraformValue<string>? DefaultVersion
    {
        get => GetArgument<TerraformValue<string>>("default_version");
        set => SetArgument("default_version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocGdcApplicationEnvironment.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcApplicationEnvironmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dataproc_gdc_application_environment Terraform resource.
/// Manages a google_dataproc_gdc_application_environment resource.
/// </summary>
public partial class GoogleDataprocGdcApplicationEnvironment(string name) : TerraformResource("google_dataproc_gdc_application_environment", name)
{
    /// <summary>
    /// The annotations to associate with this application environment. Annotations may be used to store client information, but are not used by the server.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The id of the application environment
    /// </summary>
    public TerraformValue<string>? ApplicationEnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("application_environment_id");
        set => SetArgument("application_environment_id", value);
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The labels to associate with this application environment. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the application environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the namespace in which to create this ApplicationEnvironment. This namespace must already exist in the cluster
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
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
    /// The id of the service instance to which this application environment belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serviceinstance is required")]
    public required TerraformValue<string> Serviceinstance
    {
        get => GetArgument<TerraformValue<string>>("serviceinstance");
        set => SetArgument("serviceinstance", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. The name of the application environment. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/applicationEnvironments/{application_environment_id}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// System generated unique identifier for this application environment, formatted as UUID4.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// SparkApplicationEnvironmentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkApplicationEnvironmentConfig block(s) allowed")]
    public TerraformList<GoogleDataprocGdcApplicationEnvironmentSparkApplicationEnvironmentConfigBlock>? SparkApplicationEnvironmentConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcApplicationEnvironmentSparkApplicationEnvironmentConfigBlock>>("spark_application_environment_config");
        set => SetArgument("spark_application_environment_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocGdcApplicationEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocGdcApplicationEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
