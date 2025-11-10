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
        get => GetProperty<TerraformProperty<string>>("assessment");
        set => WithProperty("assessment", value);
    }

    /// <summary>
    /// The weight of the assessment. Possible values: [&amp;quot;MINOR&amp;quot;, &amp;quot;MODERATE&amp;quot;, &amp;quot;MAJOR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformProperty<string> Weight
    {
        get => GetProperty<TerraformProperty<string>>("weight");
        set => WithProperty("weight", value);
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
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the security profile.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The Apigee Organization associated with the Apigee Security Profile V2,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Resource ID of the security profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformProperty<string> ProfileId
    {
        get => GetProperty<TerraformProperty<string>>("profile_id");
        set => this.WithProperty("profile_id", value);
    }

    /// <summary>
    /// Block for profile_assessment_configs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProfileAssessmentConfigs block(s) required")]
    public HashSet<GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock>? ProfileAssessmentConfigs
    {
        get => GetProperty<HashSet<GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock>>("profile_assessment_configs");
        set => this.WithProperty("profile_assessment_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeSecurityProfileV2TimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeSecurityProfileV2TimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
