using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ai_platform_floor_setting in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock : TerraformBlock
{
    /// <summary>
    /// If true, log Model Armor filter results to Cloud Logging.
    /// </summary>
    public TerraformProperty<bool>? EnableCloudLogging
    {
        set => SetProperty("enable_cloud_logging", value);
    }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    public TerraformProperty<bool>? InspectAndBlock
    {
        set => SetProperty("inspect_and_block", value);
    }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    public TerraformProperty<bool>? InspectOnly
    {
        set => SetProperty("inspect_only", value);
    }

}

/// <summary>
/// Block type for filter_config in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFilterConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for floor_setting_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleModelArmorFloorsettingFloorSettingMetadataBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleModelArmorFloorsettingTimeoutsBlock : TerraformBlock
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
/// Manages a google_model_armor_floorsetting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleModelArmorFloorsetting : TerraformResource
{
    public GoogleModelArmorFloorsetting(string name) : base("google_model_armor_floorsetting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("enable_floor_setting_enforcement");
        SetOutput("id");
        SetOutput("integrated_services");
        SetOutput("location");
        SetOutput("parent");
    }

    /// <summary>
    /// Floor Settings enforcement status.
    /// </summary>
    public TerraformProperty<bool> EnableFloorSettingEnforcement
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_floor_setting_enforcement");
        set => SetProperty("enable_floor_setting_enforcement", value);
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
    /// List of integrated services for which the floor setting is applicable.
    /// </summary>
    public List<TerraformProperty<string>> IntegratedServices
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("integrated_services");
        set => SetProperty("integrated_services", value);
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
    /// Will be any one of these:
    /// 
    /// * &#39;projects/{project}&#39;
    /// * &#39;folders/{folder}&#39;
    /// * &#39;organizations/{organizationId}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Block for ai_platform_floor_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AiPlatformFloorSetting block(s) allowed")]
    public List<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock>? AiPlatformFloorSetting
    {
        set => SetProperty("ai_platform_floor_setting", value);
    }

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    public List<GoogleModelArmorFloorsettingFilterConfigBlock>? FilterConfig
    {
        set => SetProperty("filter_config", value);
    }

    /// <summary>
    /// Block for floor_setting_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloorSettingMetadata block(s) allowed")]
    public List<GoogleModelArmorFloorsettingFloorSettingMetadataBlock>? FloorSettingMetadata
    {
        set => SetProperty("floor_setting_metadata", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleModelArmorFloorsettingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// [Output only] Create timestamp
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Identifier. The resource name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// [Output only] Update timestamp
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
