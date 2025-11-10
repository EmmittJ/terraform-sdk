using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentAddonsConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_environment_addons_config resource.
/// </summary>
public class GoogleApigeeEnvironmentAddonsConfig : TerraformResource
{
    public GoogleApigeeEnvironmentAddonsConfig(string name) : base("google_apigee_environment_addons_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("analytics_enabled");
        SetOutput("env_id");
        SetOutput("id");
    }

    /// <summary>
    /// Flag to enable/disable Analytics.
    /// </summary>
    public TerraformProperty<bool> AnalyticsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("analytics_enabled");
        set => SetProperty("analytics_enabled", value);
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformProperty<string> EnvId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("env_id");
        set => SetProperty("env_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeEnvironmentAddonsConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
