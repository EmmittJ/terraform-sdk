using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for artifact_configs in GoogleDeveloperConnectInsightsConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "artifact_configs";

    /// <summary>
    /// The URI of the artifact that is deployed.
    /// e.g. &#39;us-docker.pkg.dev/my-project/my-repo/image&#39;.
    /// The URI does not include the tag / digest because it captures a lineage of
    /// artifacts.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// GoogleArtifactAnalysis block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleArtifactAnalysis block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlockGoogleArtifactAnalysisBlock>? GoogleArtifactAnalysis
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlockGoogleArtifactAnalysisBlock>>("google_artifact_analysis");
        set => SetArgument("google_artifact_analysis", value);
    }

    /// <summary>
    /// GoogleArtifactRegistry block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleArtifactRegistry block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlockGoogleArtifactRegistryBlock>? GoogleArtifactRegistry
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlockGoogleArtifactRegistryBlock>>("google_artifact_registry");
        set => SetArgument("google_artifact_registry", value);
    }

}

/// <summary>
/// Block type for google_artifact_analysis in GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectInsightsConfigArtifactConfigsBlockGoogleArtifactAnalysisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_artifact_analysis";

    /// <summary>
    /// The project id of the project where the provenance is stored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for google_artifact_registry in GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectInsightsConfigArtifactConfigsBlockGoogleArtifactRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_artifact_registry";

    /// <summary>
    /// The name of the artifact registry package.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactRegistryPackage is required")]
    public required TerraformValue<string> ArtifactRegistryPackage
    {
        get => GetRequiredArgument<TerraformValue<string>>("artifact_registry_package");
        set => SetArgument("artifact_registry_package", value);
    }

    /// <summary>
    /// The host project of Artifact Registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDeveloperConnectInsightsConfig.
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectInsightsConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_developer_connect_insights_config Terraform resource.
/// Manages a google_developer_connect_insights_config resource.
/// </summary>
public partial class GoogleDeveloperConnectInsightsConfig(string name) : TerraformResource("google_developer_connect_insights_config", name)
{
    /// <summary>
    /// User specified annotations. See https://google.aip.dev/148#annotations
    /// for more details such as format and size limitations.
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
    /// The name of the App Hub Application.
    /// Format:
    /// projects/{project}/locations/{location}/applications/{application}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppHubApplication is required")]
    public required TerraformValue<string> AppHubApplication
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_hub_application");
        set => SetArgument("app_hub_application", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the requesting InsightsConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsConfigId is required")]
    public required TerraformValue<string> InsightsConfigId
    {
        get => GetRequiredArgument<TerraformValue<string>>("insights_config_id");
        set => SetArgument("insights_config_id", value);
    }

    /// <summary>
    /// Set of labels associated with an InsightsConfig.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Any errors that occurred while setting up the InsightsConfig.
    /// Each error will be in the format: &#39;field_name: error_message&#39;, e.g.
    /// GetAppHubApplication: Permission denied while getting App Hub
    /// application. Please grant permissions to the P4SA.
    /// </summary>
    public TerraformList<TerraformMap<object>> Errors
        => CreateReference("errors");

    /// <summary>
    /// Identifier. The name of the InsightsConfig.
    /// Format:
    /// projects/{project}/locations/{location}/insightsConfigs/{insightsConfig}
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of InsightsConfig does not match the
    /// user&#39;s intended state, and the service is actively updating the resource to
    /// reconcile them. This can happen due to user-triggered updates or
    /// system actions like failover or maintenance.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// The runtime configurations where the application is deployed.
    /// </summary>
    public TerraformList<TerraformMap<object>> RuntimeConfigs
        => CreateReference("runtime_configs");

    /// <summary>
    /// The state of the InsightsConfig.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// PENDING
    /// COMPLETE
    /// ERROR
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// ArtifactConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock>? ArtifactConfigs
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock>>("artifact_configs");
        set => SetArgument("artifact_configs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDeveloperConnectInsightsConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDeveloperConnectInsightsConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
