using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for jupyter_session in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateJupyterSessionBlock : ITerraformBlock
{
    /// <summary>
    /// Display name, shown in the Jupyter kernelspec card.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// Kernel to be used with Jupyter interactive session. Possible values: [&amp;quot;PYTHON&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    [TerraformPropertyName("kernel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Kernel { get; set; }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateRuntimeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    [TerraformPropertyName("container_image")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerImage { get; set; }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    [TerraformPropertyName("effective_properties")]
    // Computed attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveProperties => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "effective_properties");

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// Version of the session runtime.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for spark_connect_session in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateSparkConnectSessionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocSessionTemplateTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_session_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocSessionTemplate : TerraformResource
{
    public GoogleDataprocSessionTemplate(string name) : base("google_dataproc_session_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The labels to associate with this session template.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location in which the session template will be created in.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The resource name of the session template in the following format:
    /// projects/{project}/locations/{location}/sessionTemplates/{template_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    [TerraformPropertyName("environment_config")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateEnvironmentConfigBlock>>? EnvironmentConfig { get; set; } = new();

    /// <summary>
    /// Block for jupyter_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterSession block(s) allowed")]
    [TerraformPropertyName("jupyter_session")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateJupyterSessionBlock>>? JupyterSession { get; set; } = new();

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    [TerraformPropertyName("runtime_config")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateRuntimeConfigBlock>>? RuntimeConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_connect_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConnectSession block(s) allowed")]
    [TerraformPropertyName("spark_connect_session")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateSparkConnectSessionBlock>>? SparkConnectSession { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocSessionTemplateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time when the session template was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The email address of the user who created the session template.
    /// </summary>
    [TerraformPropertyName("creator")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Creator => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The time when the session template was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// A session template UUID (Unique Universal Identifier). The service generates this value when it creates the session template.
    /// </summary>
    [TerraformPropertyName("uuid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uuid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uuid");

}
