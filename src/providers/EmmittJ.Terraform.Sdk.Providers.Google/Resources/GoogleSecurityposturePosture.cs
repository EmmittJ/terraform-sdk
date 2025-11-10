using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for policy_sets in .
/// Nesting mode: list
/// </summary>
public class GoogleSecurityposturePosturePolicySetsBlock : TerraformBlock
{
    /// <summary>
    /// Description of the policy set.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// ID of the policy set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySetId is required")]
    public required TerraformProperty<string> PolicySetId
    {
        set => SetProperty("policy_set_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecurityposturePostureTimeoutsBlock : TerraformBlock
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
/// Manages a google_securityposture_posture resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecurityposturePosture : TerraformResource
{
    public GoogleSecurityposturePosture(string name) : base("google_securityposture_posture", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("etag");
        SetOutput("name");
        SetOutput("reconciling");
        SetOutput("revision_id");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("parent");
        SetOutput("posture_id");
        SetOutput("state");
    }

    /// <summary>
    /// Description of the posture.
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
    /// Location of the resource, eg: global.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Id of the posture. It is an immutable field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureId is required")]
    public required TerraformProperty<string> PostureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("posture_id");
        set => SetProperty("posture_id", value);
    }

    /// <summary>
    /// State of the posture. Update to state field should not be triggered along with
    /// with other field updates. Possible values: [&amp;quot;DEPRECATED&amp;quot;, &amp;quot;DRAFT&amp;quot;, &amp;quot;ACTIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// Block for policy_sets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicySets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicySets block(s) required")]
    public List<GoogleSecurityposturePosturePolicySetsBlock>? PolicySets
    {
        set => SetProperty("policy_sets", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecurityposturePostureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the Posture was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Name of the posture.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// If set, there are currently changes in flight to the posture.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Revision_id of the posture.
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// Time the Posture was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
