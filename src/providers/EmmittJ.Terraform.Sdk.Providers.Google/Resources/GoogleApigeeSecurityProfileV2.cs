using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for profile_assessment_configs in .
/// Nesting mode: set
/// </summary>
public class GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock : TerraformBlock
{
    /// <summary>
    /// The assessment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Assessment is required")]
    public required TerraformProperty<string> Assessment
    {
        set => SetProperty("assessment", value);
    }

    /// <summary>
    /// The weight of the assessment. Possible values: [&amp;quot;MINOR&amp;quot;, &amp;quot;MODERATE&amp;quot;, &amp;quot;MAJOR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformProperty<string> Weight
    {
        set => SetProperty("weight", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityProfileV2TimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_security_profile_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeSecurityProfileV2 : TerraformResource
{
    public GoogleApigeeSecurityProfileV2(string name) : base("google_apigee_security_profile_v2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("profile_id");
    }

    /// <summary>
    /// Description of the security profile.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The Apigee Organization associated with the Apigee Security Profile V2,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Resource ID of the security profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformProperty<string> ProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_id");
        set => SetProperty("profile_id", value);
    }

    /// <summary>
    /// Block for profile_assessment_configs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileAssessmentConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProfileAssessmentConfigs block(s) required")]
    public HashSet<GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock>? ProfileAssessmentConfigs
    {
        set => SetProperty("profile_assessment_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeSecurityProfileV2TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Name of the security profile v2 resource,
    /// in the format &#39;organizations/{{org_name}}/securityProfilesV2/{{profile_id}}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
