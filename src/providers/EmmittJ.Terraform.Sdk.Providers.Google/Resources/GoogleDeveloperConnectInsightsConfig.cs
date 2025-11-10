using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for artifact_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock : TerraformBlock
{
    /// <summary>
    /// The URI of the artifact that is deployed.
    /// e.g. &#39;us-docker.pkg.dev/my-project/my-repo/image&#39;.
    /// The URI does not include the tag / digest because it captures a lineage of
    /// artifacts.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectInsightsConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_developer_connect_insights_config resource.
/// </summary>
public class GoogleDeveloperConnectInsightsConfig : TerraformResource
{
    public GoogleDeveloperConnectInsightsConfig(string name) : base("google_developer_connect_insights_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("errors");
        SetOutput("name");
        SetOutput("reconciling");
        SetOutput("runtime_configs");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("app_hub_application");
        SetOutput("id");
        SetOutput("insights_config_id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// User specified annotations. See https://google.aip.dev/148#annotations
    /// for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The name of the App Hub Application.
    /// Format:
    /// projects/{project}/locations/{location}/applications/{application}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppHubApplication is required")]
    public required TerraformProperty<string> AppHubApplication
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_hub_application");
        set => SetProperty("app_hub_application", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// ID of the requesting InsightsConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsConfigId is required")]
    public required TerraformProperty<string> InsightsConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("insights_config_id");
        set => SetProperty("insights_config_id", value);
    }

    /// <summary>
    /// Set of labels associated with an InsightsConfig.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for artifact_configs.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDeveloperConnectInsightsConfigArtifactConfigsBlock>? ArtifactConfigs
    {
        set => SetProperty("artifact_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDeveloperConnectInsightsConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// [Output only] Create timestamp
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
    /// Any errors that occurred while setting up the InsightsConfig.
    /// Each error will be in the format: &#39;field_name: error_message&#39;, e.g.
    /// GetAppHubApplication: Permission denied while getting App Hub
    /// application. Please grant permissions to the P4SA.
    /// </summary>
    public TerraformExpression Errors => this["errors"];

    /// <summary>
    /// Identifier. The name of the InsightsConfig.
    /// Format:
    /// projects/{project}/locations/{location}/insightsConfigs/{insightsConfig}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of InsightsConfig does not match the
    /// user&#39;s intended state, and the service is actively updating the resource to
    /// reconcile them. This can happen due to user-triggered updates or
    /// system actions like failover or maintenance.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The runtime configurations where the application is deployed.
    /// </summary>
    public TerraformExpression RuntimeConfigs => this["runtime_configs"];

    /// <summary>
    /// The state of the InsightsConfig.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// PENDING
    /// COMPLETE
    /// ERROR
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
