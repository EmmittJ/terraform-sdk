using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_model_armor_floorsetting resource.
/// </summary>
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
    public TerraformProperty<List<string>>? IntegratedServices
    {
        get => GetProperty<TerraformProperty<List<string>>>("integrated_services");
        set => this.WithProperty("integrated_services", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformProperty<string>? Location
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
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
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
