using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for org_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock : TerraformBlock
{
    /// <summary>
    /// The project that will run the scan. The DLP service account that exists within this project must have access to all resources that are profiled, and the cloud DLP API must be enabled.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

}

/// <summary>
/// Block type for other_cloud_starting_location in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_data_loss_prevention_discovery_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionDiscoveryConfig : TerraformResource
{
    public GoogleDataLossPreventionDiscoveryConfig(string name) : base("google_data_loss_prevention_discovery_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("errors");
        SetOutput("last_run_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("inspect_templates");
        SetOutput("location");
        SetOutput("parent");
        SetOutput("status");
    }

    /// <summary>
    /// Display Name (max 1000 Chars)
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Detection logic for profile generation
    /// </summary>
    public List<TerraformProperty<string>> InspectTemplates
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("inspect_templates");
        set => SetProperty("inspect_templates", value);
    }

    /// <summary>
    /// Location to create the discovery config in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The parent of the discovery config in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Required. A status for this configuration Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataLossPreventionDiscoveryConfigActionsBlock>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// Block for org_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgConfig block(s) allowed")]
    public List<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock>? OrgConfig
    {
        set => SetProperty("org_config", value);
    }

    /// <summary>
    /// Block for other_cloud_starting_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherCloudStartingLocation block(s) allowed")]
    public List<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock>? OtherCloudStartingLocation
    {
        set => SetProperty("other_cloud_starting_location", value);
    }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataLossPreventionDiscoveryConfigTargetsBlock>? Targets
    {
        set => SetProperty("targets", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of a DiscoveryConfig.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. A stream of errors encountered when the config was activated. Repeated errors may result in the config automatically being paused. Output only field. Will return the last 100 errors. Whenever the config is modified this list will be cleared.
    /// </summary>
    public TerraformExpression Errors => this["errors"];

    /// <summary>
    /// Output only. The timestamp of the last time this config was executed
    /// </summary>
    public TerraformExpression LastRunTime => this["last_run_time"];

    /// <summary>
    /// Unique resource name for the DiscoveryConfig, assigned by the service when the DiscoveryConfig is created.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The last update timestamp of a DiscoveryConfig.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
