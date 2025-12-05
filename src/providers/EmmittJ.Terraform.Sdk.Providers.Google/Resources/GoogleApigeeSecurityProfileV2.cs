using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for profile_assessment_configs in GoogleApigeeSecurityProfileV2.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "profile_assessment_configs";

    /// <summary>
    /// The assessment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Assessment is required")]
    public required TerraformValue<string> Assessment
    {
        get => GetRequiredArgument<TerraformValue<string>>("assessment");
        set => SetArgument("assessment", value);
    }

    /// <summary>
    /// The weight of the assessment. Possible values: [&amp;quot;MINOR&amp;quot;, &amp;quot;MODERATE&amp;quot;, &amp;quot;MAJOR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<string> Weight
    {
        get => GetRequiredArgument<TerraformValue<string>>("weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeSecurityProfileV2.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityProfileV2TimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_security_profile_v2 Terraform resource.
/// Manages a google_apigee_security_profile_v2 resource.
/// </summary>
public partial class GoogleApigeeSecurityProfileV2(string name) : TerraformResource("google_apigee_security_profile_v2", name)
{
    /// <summary>
    /// Description of the security profile.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The Apigee Organization associated with the Apigee Security Profile V2,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Resource ID of the security profile.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformValue<string> ProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("profile_id");
        set => SetArgument("profile_id", value);
    }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Name of the security profile v2 resource,
    /// in the format &#39;organizations/{{org_name}}/securityProfilesV2/{{profile_id}}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// ProfileAssessmentConfigs block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileAssessmentConfigs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProfileAssessmentConfigs block(s) required")]
    public required TerraformSet<GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock> ProfileAssessmentConfigs
    {
        get => GetRequiredArgument<TerraformSet<GoogleApigeeSecurityProfileV2ProfileAssessmentConfigsBlock>>("profile_assessment_configs");
        set => SetArgument("profile_assessment_configs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeSecurityProfileV2TimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeSecurityProfileV2TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
