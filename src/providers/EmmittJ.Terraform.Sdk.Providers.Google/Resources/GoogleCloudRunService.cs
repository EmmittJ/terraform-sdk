using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata in GoogleCloudRunService.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// 
    /// **Note**: The Cloud Run API may add additional annotations that were not provided in your config.
    /// If terraform plan shows a diff where a server-side annotation is added, you can add it to your config
    /// or apply the lifecycle.ignore_changes rule to the metadata.0.annotations field.
    /// 
    /// Annotations with &#39;run.googleapis.com/&#39; and &#39;autoscaling.knative.dev&#39; are restricted. Use the following annotation
    /// keys to configure features on a Service:
    /// 
    /// - &#39;run.googleapis.com/binary-authorization-breakglass&#39; sets the [Binary Authorization breakglass](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--breakglass).
    /// - &#39;run.googleapis.com/binary-authorization&#39; sets the [Binary Authorization](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--binary-authorization).
    /// - &#39;run.googleapis.com/client-name&#39; sets the client name calling the Cloud Run API.
    /// - &#39;run.googleapis.com/custom-audiences&#39; sets the [custom audiences](https://cloud.google.com/sdk/gcloud/reference/alpha/run/deploy#--add-custom-audiences)
    ///   that can be used in the audience field of ID token for authenticated requests.
    /// - &#39;run.googleapis.com/description&#39; sets a user defined description for the Service.
    /// - &#39;run.googleapis.com/ingress&#39; sets the [ingress settings](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--ingress)
    ///   for the Service. For example, &#39;&amp;quot;run.googleapis.com/ingress&amp;quot; = &amp;quot;all&amp;quot;&#39;.
    /// - &#39;run.googleapis.com/launch-stage&#39; sets the [launch stage](https://cloud.google.com/run/docs/troubleshooting#launch-stage-validation)
    ///   when a preview feature is used. For example, &#39;&amp;quot;run.googleapis.com/launch-stage&amp;quot;: &amp;quot;BETA&amp;quot;&#39;
    /// - &#39;run.googleapis.com/minScale&#39; sets the [minimum number of container instances](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--min) of the Service.
    /// - &#39;run.googleapis.com/scalingMode&#39; sets the type of scaling mode for the service. The supported values for scaling mode are &amp;quot;manual&amp;quot; and &amp;quot;automatic&amp;quot;. If not provided, it defaults to &amp;quot;automatic&amp;quot;.
    /// - &#39;run.googleapis.com/manualInstanceCount&#39; sets the total instance count for the service in manual scaling mode. This number of instances is divided among all revisions with specified traffic based on the percent of traffic they are receiving.
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
    /// A sequence number representing a specific generation of the desired state.
    /// </summary>
    public TerraformValue<double> Generation
        => AsReference("generation");

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// and routes.
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
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// An opaque value that represents the internal version of this object that
    /// can be used by clients to determine when objects have changed. May be used
    /// for optimistic concurrency, change detection, and the watch operation on a
    /// resource or set of resources. They may only be valid for a
    /// particular resource or set of resources.
    /// </summary>
    public TerraformValue<string> ResourceVersion
        => AsReference("resource_version");

    /// <summary>
    /// SelfLink is a URL representing this object.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// UID is a unique id generated by the server on successful creation of a resource and is not
    /// allowed to change on PUT operations.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

}


/// <summary>
/// Block type for template in GoogleCloudRunService.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template";

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlock>? Spec
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}

/// <summary>
/// Block type for metadata in GoogleCloudRunServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata";

    /// <summary>
    /// Annotations is a key value map stored with a resource that
    /// may be set by external tools to store and retrieve arbitrary metadata.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// 
    /// **Note**: The Cloud Run API may add additional annotations that were not provided in your config.
    /// If terraform plan shows a diff where a server-side annotation is added, you can add it to your config
    /// or apply the lifecycle.ignore_changes rule to the metadata.0.annotations field.
    /// 
    /// Annotations with &#39;run.googleapis.com/&#39; and &#39;autoscaling.knative.dev&#39; are restricted. Use the following annotation
    /// keys to configure features on a Revision template:
    /// 
    /// - &#39;autoscaling.knative.dev/maxScale&#39; sets the [maximum number of container
    ///   instances](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--max-instances) of the Revision to run.
    /// - &#39;autoscaling.knative.dev/minScale&#39; sets the [minimum number of container
    ///   instances](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--min-instances) of the Revision to run.
    /// - &#39;run.googleapis.com/client-name&#39; sets the client name calling the Cloud Run API.
    /// - &#39;run.googleapis.com/cloudsql-instances&#39; sets the [Cloud SQL
    ///   instances](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--add-cloudsql-instances) the Revision connects to.
    /// - &#39;run.googleapis.com/cpu-throttling&#39; sets whether to throttle the CPU when the container is not actively serving
    ///   requests. See https://cloud.google.com/sdk/gcloud/reference/run/deploy#--[no-]cpu-throttling.
    /// - &#39;run.googleapis.com/encryption-key-shutdown-hours&#39; sets the number of hours to wait before an automatic shutdown
    ///   server after CMEK key revocation is detected.
    /// - &#39;run.googleapis.com/encryption-key&#39; sets the [CMEK key](https://cloud.google.com/run/docs/securing/using-cmek)
    ///   reference to encrypt the container with.
    /// - &#39;run.googleapis.com/execution-environment&#39; sets the [execution
    ///   environment](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--execution-environment)
    ///   where the application will run.
    /// - &#39;run.googleapis.com/post-key-revocation-action-type&#39; sets the
    ///   [action type](https://cloud.google.com/sdk/gcloud/reference/run/deploy#--post-key-revocation-action-type)
    ///   after CMEK key revocation.
    /// - &#39;run.googleapis.com/secrets&#39; sets a list of key-value pairs to set as
    ///   [secrets](https://cloud.google.com/run/docs/configuring/secrets#yaml).
    /// - &#39;run.googleapis.com/sessionAffinity&#39; sets whether to enable
    ///   [session affinity](https://cloud.google.com/sdk/gcloud/reference/beta/run/deploy#--[no-]session-affinity)
    ///   for connections to the Revision.
    /// - &#39;run.googleapis.com/startup-cpu-boost&#39; sets whether to allocate extra CPU to containers on startup.
    ///   See https://cloud.google.com/sdk/gcloud/reference/run/deploy#--[no-]cpu-boost.
    /// - &#39;run.googleapis.com/network-interfaces&#39; sets [Direct VPC egress](https://cloud.google.com/run/docs/configuring/vpc-direct-vpc#yaml)
    ///   for the Revision.
    /// - &#39;run.googleapis.com/vpc-access-connector&#39; sets a [VPC connector](https://cloud.google.com/run/docs/configuring/connecting-vpc#terraform_1)
    ///   for the Revision.
    /// - &#39;run.googleapis.com/vpc-access-egress&#39; sets the outbound traffic to send through the VPC connector for this resource.
    ///   See https://cloud.google.com/sdk/gcloud/reference/run/deploy#--vpc-egress.
    /// - &#39;run.googleapis.com/gpu-zonal-redundancy-disabled&#39; sets
    ///   [GPU zonal redundancy](https://cloud.google.com/run/docs/configuring/services/gpu-zonal-redundancy) for the Revision.
    /// - &#39;run.googleapis.com/health-check-disabled&#39; disabled health checking containers during deployment.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// A sequence number representing a specific generation of the desired state.
    /// </summary>
    public TerraformValue<double> Generation
        => AsReference("generation");

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name must be unique within a Google Cloud project and region.
    /// Is required when creating resources. Name is primarily intended
    /// for creation idempotence and configuration definition. Cannot be updated.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// In Cloud Run the namespace must be equal to either the
    /// project ID or project number. It will default to the resource&#39;s project.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// An opaque value that represents the internal version of this object that
    /// can be used by clients to determine when objects have changed. May be used
    /// for optimistic concurrency, change detection, and the watch operation on a
    /// resource or set of resources. They may only be valid for a
    /// particular resource or set of resources.
    /// </summary>
    public TerraformValue<string> ResourceVersion
        => AsReference("resource_version");

    /// <summary>
    /// SelfLink is a URL representing this object.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// UID is a unique id generated by the server on successful creation of a resource and is not
    /// allowed to change on PUT operations.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

}

/// <summary>
/// Block type for spec in GoogleCloudRunServiceTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// ContainerConcurrency specifies the maximum allowed in-flight (concurrent)
    /// requests per container of the Revision. If not specified or 0, defaults to 80 when
    /// requested CPU &amp;gt;= 1 and defaults to 1 when requested CPU &amp;lt; 1.
    /// </summary>
    public TerraformValue<double>? ContainerConcurrency
    {
        get => GetArgument<TerraformValue<double>>("container_concurrency");
        set => SetArgument("container_concurrency", value);
    }

    /// <summary>
    /// Node Selector describes the hardware requirements of the resources.
    /// Use the following node selector keys to configure features on a Revision:
    ///   - &#39;run.googleapis.com/accelerator&#39; sets the [type of GPU](https://cloud.google.com/run/docs/configuring/services/gpu) required by the Revision to run.
    /// </summary>
    public TerraformMap<string>? NodeSelector
    {
        get => GetArgument<TerraformMap<string>>("node_selector");
        set => SetArgument("node_selector", value);
    }

    /// <summary>
    /// Email address of the IAM service account associated with the revision of the
    /// service. The service account represents the identity of the running revision,
    /// and determines what permissions the revision has. If not provided, the revision
    /// will use the project&#39;s default service account.
    /// </summary>
    public TerraformValue<string>? ServiceAccountName
    {
        get => GetArgument<TerraformValue<string>>("service_account_name");
        set => SetArgument("service_account_name", value);
    }

    /// <summary>
    /// ServingState holds a value describing the state the resources
    /// are in for this Revision.
    /// It is expected
    /// that the system will manipulate this based on routability and load.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ServingState
        => AsReference("serving_state");

    /// <summary>
    /// TimeoutSeconds holds the max duration the instance is allowed for responding to a request.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Containers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock>? Containers
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock>>("containers");
        set => SetArgument("containers", value);
    }

    /// <summary>
    /// Volumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock>? Volumes
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock>>("volumes");
        set => SetArgument("volumes", value);
    }

}

/// <summary>
/// Block type for containers in GoogleCloudRunServiceTemplateBlockSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "containers";

    /// <summary>
    /// Arguments to the entrypoint.
    /// The docker image&#39;s CMD is used if this is not provided.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Entrypoint array. Not executed within a shell.
    /// The docker image&#39;s ENTRYPOINT is used if this is not provided.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// Docker image name. This is most often a reference to a container located
    /// in the container registry, such as gcr.io/cloudrun/hello
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Name of the container
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Container&#39;s working directory.
    /// If not specified, the container runtime&#39;s default will be used, which
    /// might be configured in the container image.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? WorkingDir
    {
        get => GetArgument<TerraformValue<string>>("working_dir");
        set => SetArgument("working_dir", value);
    }

    /// <summary>
    /// Env block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// EnvFrom block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlock>? EnvFrom
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlock>>("env_from");
        set => SetArgument("env_from", value);
    }

    /// <summary>
    /// LivenessProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlock>? LivenessProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlock>>("liveness_probe");
        set => SetArgument("liveness_probe", value);
    }

    /// <summary>
    /// Ports block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockPortsBlock>? Ports
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockPortsBlock>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// StartupProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartupProbe block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlock>? StartupProbe
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlock>>("startup_probe");
        set => SetArgument("startup_probe", value);
    }

    /// <summary>
    /// VolumeMounts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockVolumeMountsBlock>? VolumeMounts
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockVolumeMountsBlock>>("volume_mounts");
        set => SetArgument("volume_mounts", value);
    }

}

/// <summary>
/// Block type for env in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: set
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// Name of the environment variable.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Defaults to &amp;quot;&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// ValueFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValueFrom block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlock>? ValueFrom
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlock>>("value_from");
        set => SetArgument("value_from", value);
    }

}

/// <summary>
/// Block type for value_from in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_from";

    /// <summary>
    /// SecretKeyRef block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretKeyRef is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecretKeyRef block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretKeyRef block(s) allowed")]
    public required TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlockSecretKeyRefBlock> SecretKeyRef
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlockSecretKeyRefBlock>>("secret_key_ref");
        set => SetArgument("secret_key_ref", value);
    }

}

/// <summary>
/// Block type for secret_key_ref in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvBlockValueFromBlockSecretKeyRefBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_key_ref";

    /// <summary>
    /// A Cloud Secret Manager secret version. Must be &#39;latest&#39; for the latest
    /// version or an integer for a specific version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project.
    /// If the secret is in another project, you must define an alias.
    /// An alias definition has the form:
    /// {alias}:projects/{project-id|project-number}/secrets/{secret-name}.
    /// If multiple alias definitions are needed, they must be separated by commas.
    /// The alias definitions must be set on the run.googleapis.com/secrets annotation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for env_from in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env_from";

    /// <summary>
    /// An optional identifier to prepend to each key in the ConfigMap.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// ConfigMapRef block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigMapRef block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlock>? ConfigMapRef
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlock>>("config_map_ref");
        set => SetArgument("config_map_ref", value);
    }

    /// <summary>
    /// SecretRef block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretRef block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlock>? SecretRef
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlock>>("secret_ref");
        set => SetArgument("secret_ref", value);
    }

}

/// <summary>
/// Block type for config_map_ref in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_map_ref";

    /// <summary>
    /// Specify whether the ConfigMap must be defined
    /// </summary>
    public TerraformValue<bool>? Optional
    {
        get => GetArgument<TerraformValue<bool>>("optional");
        set => SetArgument("optional", value);
    }

    /// <summary>
    /// LocalObjectReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalObjectReference block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlockLocalObjectReferenceBlock>? LocalObjectReference
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlockLocalObjectReferenceBlock>>("local_object_reference");
        set => SetArgument("local_object_reference", value);
    }

}

/// <summary>
/// Block type for local_object_reference in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockConfigMapRefBlockLocalObjectReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_object_reference";

    /// <summary>
    /// Name of the referent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for secret_ref in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_ref";

    /// <summary>
    /// Specify whether the Secret must be defined
    /// </summary>
    public TerraformValue<bool>? Optional
    {
        get => GetArgument<TerraformValue<bool>>("optional");
        set => SetArgument("optional", value);
    }

    /// <summary>
    /// LocalObjectReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalObjectReference block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlockLocalObjectReferenceBlock>? LocalObjectReference
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlockLocalObjectReferenceBlock>>("local_object_reference");
        set => SetArgument("local_object_reference", value);
    }

}

/// <summary>
/// Block type for local_object_reference in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockEnvFromBlockSecretRefBlockLocalObjectReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_object_reference";

    /// <summary>
    /// Name of the referent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for liveness_probe in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_probe";

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 3600.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 3600.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than period_seconds.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Path to access on the HTTP server. If set, it should not be empty string.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockLivenessProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ports in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ports";

    /// <summary>
    /// Port number the container listens on. This must be a valid port number (between 1 and 65535). Defaults to &amp;quot;8080&amp;quot;.
    /// </summary>
    public TerraformValue<double>? ContainerPort
    {
        get => GetArgument<TerraformValue<double>>("container_port");
        set => SetArgument("container_port", value);
    }

    /// <summary>
    /// If specified, used to specify which protocol to use. Allowed values are &amp;quot;http1&amp;quot; (HTTP/1) and &amp;quot;h2c&amp;quot; (HTTP/2 end-to-end). Defaults to &amp;quot;http1&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Protocol for port. Must be &amp;quot;TCP&amp;quot;. Defaults to &amp;quot;TCP&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for resources in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// CPU Limit details:
    /// - For fractional CPU values (e.g. &#39;0.5&#39;, &#39;0.75&#39;, min &#39;0.08&#39;) are also supported.
    /// - CPU allocation must comply with memory limits and concurrency rules described in:
    ///   https://cloud.google.com/run/docs/configuring/services/cpu
    /// The values of the map is string form of the &#39;quantity&#39; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    public TerraformMap<string>? Limits
    {
        get => GetArgument<TerraformMap<string>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is
    /// explicitly specified, otherwise to an implementation-defined value.
    /// The values of the map is string form of the &#39;quantity&#39; k8s type:
    /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
    /// </summary>
    public TerraformMap<string>? Requests
    {
        get => GetArgument<TerraformMap<string>>("requests");
        set => SetArgument("requests", value);
    }

}

/// <summary>
/// Block type for startup_probe in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "startup_probe";

    /// <summary>
    /// Minimum consecutive failures for the probe to be considered failed after
    /// having succeeded. Defaults to 3. Minimum value is 1.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Number of seconds after the container has started before the probe is
    /// initiated.
    /// Defaults to 0 seconds. Minimum value is 0. Maximum value is 240.
    /// </summary>
    public TerraformValue<double>? InitialDelaySeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_seconds");
        set => SetArgument("initial_delay_seconds", value);
    }

    /// <summary>
    /// How often (in seconds) to perform the probe.
    /// Default to 10 seconds. Minimum value is 1. Maximum value is 240.
    /// </summary>
    public TerraformValue<double>? PeriodSeconds
    {
        get => GetArgument<TerraformValue<double>>("period_seconds");
        set => SetArgument("period_seconds", value);
    }

    /// <summary>
    /// Number of seconds after which the probe times out.
    /// Defaults to 1 second. Minimum value is 1. Maximum value is 3600.
    /// Must be smaller than periodSeconds.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// HttpGet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpGet block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlock>? HttpGet
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlock>>("http_get");
        set => SetArgument("http_get", value);
    }

    /// <summary>
    /// TcpSocket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpSocket block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockTcpSocketBlock>? TcpSocket
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockTcpSocketBlock>>("tcp_socket");
        set => SetArgument("tcp_socket", value);
    }

}

/// <summary>
/// Block type for grpc in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The name of the service to place in the gRPC HealthCheckRequest
    /// (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
    /// If this is not specified, the default behavior is defined by gRPC.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for http_get in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_get";

    /// <summary>
    /// Path to access on the HTTP server. If set, it should not be empty string.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// HttpHeaders block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>? HttpHeaders
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock>>("http_headers");
        set => SetArgument("http_headers", value);
    }

}

/// <summary>
/// Block type for http_headers in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockHttpGetBlockHttpHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_headers";

    /// <summary>
    /// The header field name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The header field value.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp_socket in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockStartupProbeBlockTcpSocketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_socket";

    /// <summary>
    /// Port number to access on the container. Number must be in the range 1 to 65535.
    /// If not specified, defaults to the same value as container.ports[0].containerPort.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for volume_mounts in GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockContainersBlockVolumeMountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_mounts";

    /// <summary>
    /// Path within the container at which the volume should be mounted.  Must
    /// not contain &#39;:&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MountPath is required")]
    public required TerraformValue<string> MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// This must match the Name of a Volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Path within the volume from which the container&#39;s volume should be mounted.
    /// </summary>
    public TerraformValue<string>? SubPath
    {
        get => GetArgument<TerraformValue<string>>("sub_path");
        set => SetArgument("sub_path", value);
    }

}

/// <summary>
/// Block type for volumes in GoogleCloudRunServiceTemplateBlockSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volumes";

    /// <summary>
    /// Volume&#39;s name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Csi block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Csi block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockCsiBlock>? Csi
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockCsiBlock>>("csi");
        set => SetArgument("csi", value);
    }

    /// <summary>
    /// EmptyDir block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmptyDir block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockEmptyDirBlock>? EmptyDir
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockEmptyDirBlock>>("empty_dir");
        set => SetArgument("empty_dir", value);
    }

    /// <summary>
    /// Nfs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Nfs block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockNfsBlock>? Nfs
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockNfsBlock>>("nfs");
        set => SetArgument("nfs", value);
    }

    /// <summary>
    /// Secret block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secret block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlock>? Secret
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}

/// <summary>
/// Block type for csi in GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockCsiBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csi";

    /// <summary>
    /// Unique name representing the type of file system to be created. Cloud Run supports the following values:
    ///   * gcsfuse.run.googleapis.com: Mount a Google Cloud Storage bucket using GCSFuse. This driver requires the
    ///     run.googleapis.com/execution-environment annotation to be unset or set to &amp;quot;gen2&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Driver is required")]
    public required TerraformValue<string> Driver
    {
        get => GetArgument<TerraformValue<string>>("driver");
        set => SetArgument("driver", value);
    }

    /// <summary>
    /// If true, all mounts created from this volume will be read-only.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// Driver-specific attributes. The following options are supported for available drivers:
    ///   * gcsfuse.run.googleapis.com
    ///     * bucketName: The name of the Cloud Storage Bucket that backs this volume. The Cloud Run Service identity must have access to this bucket.
    /// </summary>
    public TerraformMap<string>? VolumeAttributes
    {
        get => GetArgument<TerraformMap<string>>("volume_attributes");
        set => SetArgument("volume_attributes", value);
    }

}

/// <summary>
/// Block type for empty_dir in GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockEmptyDirBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "empty_dir";

    /// <summary>
    /// The medium on which the data is stored. The default is &amp;quot;&amp;quot; which means to use the node&#39;s default medium. Must be an empty string (default) or Memory.
    /// </summary>
    public TerraformValue<string>? Medium
    {
        get => GetArgument<TerraformValue<string>>("medium");
        set => SetArgument("medium", value);
    }

    /// <summary>
    /// Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. This field&#39;s values are of the &#39;Quantity&#39; k8s type: https://kubernetes.io/docs/reference/kubernetes-api/common-definitions/quantity/. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir.
    /// </summary>
    public TerraformValue<string>? SizeLimit
    {
        get => GetArgument<TerraformValue<string>>("size_limit");
        set => SetArgument("size_limit", value);
    }

}

/// <summary>
/// Block type for nfs in GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockNfsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs";

    /// <summary>
    /// Path exported by the NFS server
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// If true, mount the NFS volume as read only in all mounts. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ReadOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// IP address or hostname of the NFS server
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

}

/// <summary>
/// Block type for secret in GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// Mode bits to use on created files by default. Must be a value between 0000
    /// and 0777. Defaults to 0644. Directories within the path are not affected by
    /// this setting. This might be in conflict with other options that affect the
    /// file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    public TerraformValue<double>? DefaultMode
    {
        get => GetArgument<TerraformValue<double>>("default_mode");
        set => SetArgument("default_mode", value);
    }

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. By default, the secret
    /// is assumed to be in the same project.
    /// If the secret is in another project, you must define an alias.
    /// An alias definition has the form:
    /// {alias}:projects/{project-id|project-number}/secrets/{secret-name}.
    /// If multiple alias definitions are needed, they must be separated by
    /// commas.
    /// The alias definitions must be set on the run.googleapis.com/secrets
    /// annotation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTemplateBlockSpecBlockVolumesBlockSecretBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The Cloud Secret Manager secret version.
    /// Can be &#39;latest&#39; for the latest value or an integer for a specific version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Mode bits to use on this file, must be a value between 0000 and 0777. If
    /// not specified, the volume defaultMode will be used. This might be in
    /// conflict with other options that affect the file mode, like fsGroup, and
    /// the result can be other mode bits set.
    /// </summary>
    public TerraformValue<double>? Mode
    {
        get => GetArgument<TerraformValue<double>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The relative path of the file to map the key to.
    /// May not be an absolute path.
    /// May not contain the path element &#39;..&#39;.
    /// May not start with the string &#39;..&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudRunService.
/// Nesting mode: single
/// </summary>
public class GoogleCloudRunServiceTimeoutsBlock : TerraformBlock
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
/// Block type for traffic in GoogleCloudRunService.
/// Nesting mode: list
/// </summary>
public class GoogleCloudRunServiceTrafficBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic";

    /// <summary>
    /// LatestRevision may be optionally provided to indicate that the latest ready
    /// Revision of the Configuration should be used for this traffic target. When
    /// provided LatestRevision must be true if RevisionName is empty; it must be
    /// false when RevisionName is non-empty.
    /// </summary>
    public TerraformValue<bool>? LatestRevision
    {
        get => GetArgument<TerraformValue<bool>>("latest_revision");
        set => SetArgument("latest_revision", value);
    }

    /// <summary>
    /// Percent specifies percent of the traffic to this Revision or Configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Percent is required")]
    public required TerraformValue<double> Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

    /// <summary>
    /// RevisionName of a specific revision to which to send this portion of traffic.
    /// </summary>
    public TerraformValue<string>? RevisionName
    {
        get => GetArgument<TerraformValue<string>>("revision_name");
        set => SetArgument("revision_name", value);
    }

    /// <summary>
    /// Tag is optionally used to expose a dedicated url for referencing this target exclusively.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

    /// <summary>
    /// URL displays the URL for accessing tagged traffic targets. URL is displayed in status,
    /// and is disallowed on spec. URL must contain a scheme (e.g. http://) and a hostname,
    /// but may not contain anything else (e.g. basic auth, url path, etc.)
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

}


/// <summary>
/// Represents a google_cloud_run_service Terraform resource.
/// Manages a google_cloud_run_service resource.
/// </summary>
public partial class GoogleCloudRunService(string name) : TerraformResource("google_cloud_run_service", name)
{
    /// <summary>
    /// If set to &#39;true&#39;, the revision name (template.metadata.name) will be omitted and
    /// autogenerated by Cloud Run. This cannot be set to &#39;true&#39; while &#39;template.metadata.name&#39;
    /// is also set.
    /// (For legacy support, if &#39;template.metadata.name&#39; is unset in state while
    /// this field is set to false, the revision name will still autogenerate.)
    /// </summary>
    public TerraformValue<bool>? AutogenerateRevisionName
    {
        get => GetArgument<TerraformValue<bool>>("autogenerate_revision_name");
        set => SetArgument("autogenerate_revision_name", value);
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
    /// The location of the cloud run instance. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name must be unique within a Google Cloud project and region.
    /// Is required when creating resources. Name is primarily intended
    /// for creation idempotence and configuration definition. Cannot be updated.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The current status of the Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

    /// <summary>
    /// Metadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceMetadataBlock>? Metadata
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceMetadataBlock>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Template block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Template block(s) allowed")]
    public TerraformList<GoogleCloudRunServiceTemplateBlock>? Template
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTemplateBlock>>("template");
        set => SetArgument("template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudRunServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudRunServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Traffic block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudRunServiceTrafficBlock>? Traffic
    {
        get => GetArgument<TerraformList<GoogleCloudRunServiceTrafficBlock>>("traffic");
        set => SetArgument("traffic", value);
    }

}
