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
        get => GetProperty<TerraformProperty<bool>>("enable_cloud_logging");
        set => WithProperty("enable_cloud_logging", value);
    }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect and block mode.
    /// Requests that trip Model Armor filters will be blocked.
    /// </summary>
    public TerraformProperty<bool>? InspectAndBlock
    {
        get => GetProperty<TerraformProperty<bool>>("inspect_and_block");
        set => WithProperty("inspect_and_block", value);
    }

    /// <summary>
    /// If true, Model Armor filters will be run in inspect only mode. No action
    /// will be taken on the request.
    /// </summary>
    public TerraformProperty<bool>? InspectOnly
    {
        get => GetProperty<TerraformProperty<bool>>("inspect_only");
        set => WithProperty("inspect_only", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Floor Settings enforcement status.
    /// </summary>
    public TerraformProperty<bool>? EnableFloorSettingEnforcement
    {
        get => GetProperty<TerraformProperty<bool>>("enable_floor_setting_enforcement");
        set => this.WithProperty("enable_floor_setting_enforcement", value);
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
    /// List of integrated services for which the floor setting is applicable.
    /// </summary>
    public List<TerraformProperty<string>>? IntegratedServices
    {
        get => GetProperty<List<TerraformProperty<string>>>("integrated_services");
        set => this.WithProperty("integrated_services", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for ai_platform_floor_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AiPlatformFloorSetting block(s) allowed")]
    public List<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock>? AiPlatformFloorSetting
    {
        get => GetProperty<List<GoogleModelArmorFloorsettingAiPlatformFloorSettingBlock>>("ai_platform_floor_setting");
        set => this.WithProperty("ai_platform_floor_setting", value);
    }

    /// <summary>
    /// Block for filter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterConfig block(s) allowed")]
    public List<GoogleModelArmorFloorsettingFilterConfigBlock>? FilterConfig
    {
        get => GetProperty<List<GoogleModelArmorFloorsettingFilterConfigBlock>>("filter_config");
        set => this.WithProperty("filter_config", value);
    }

    /// <summary>
    /// Block for floor_setting_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FloorSettingMetadata block(s) allowed")]
    public List<GoogleModelArmorFloorsettingFloorSettingMetadataBlock>? FloorSettingMetadata
    {
        get => GetProperty<List<GoogleModelArmorFloorsettingFloorSettingMetadataBlock>>("floor_setting_metadata");
        set => this.WithProperty("floor_setting_metadata", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleModelArmorFloorsettingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleModelArmorFloorsettingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
