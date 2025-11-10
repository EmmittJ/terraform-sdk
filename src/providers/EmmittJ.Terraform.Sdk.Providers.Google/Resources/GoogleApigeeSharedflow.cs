using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSharedflowTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_sharedflow resource.
/// </summary>
public class GoogleApigeeSharedflow : TerraformResource
{
    public GoogleApigeeSharedflow(string name) : base("google_apigee_sharedflow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("latest_revision_id");
        SetOutput("md5hash");
        SetOutput("meta_data");
        SetOutput("revision");
        SetOutput("config_bundle");
        SetOutput("detect_md5hash");
        SetOutput("id");
        SetOutput("name");
        SetOutput("org_id");
    }

    /// <summary>
    /// Path to the config zip bundle
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigBundle is required")]
    public required TerraformProperty<string> ConfigBundle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("config_bundle");
        set => SetProperty("config_bundle", value);
    }

    /// <summary>
    /// A hash of local config bundle in string, user needs to use a Terraform Hash function of their choice. A change in hash will trigger an update.
    /// </summary>
    public TerraformProperty<string> DetectMd5hash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detect_md5hash");
        set => SetProperty("detect_md5hash", value);
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
    /// The ID of the shared flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeSharedflowTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The id of the most recently created revision for this shared flow.
    /// </summary>
    public TerraformExpression LatestRevisionId => this["latest_revision_id"];

    /// <summary>
    /// Base 64 MD5 hash of the uploaded config bundle.
    /// </summary>
    public TerraformExpression Md5hash => this["md5hash"];

    /// <summary>
    /// Metadata describing the shared flow.
    /// </summary>
    public TerraformExpression MetaData => this["meta_data"];

    /// <summary>
    /// A list of revisions of this shared flow.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
