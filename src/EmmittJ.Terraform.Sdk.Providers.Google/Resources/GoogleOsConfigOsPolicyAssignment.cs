using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_os_config_os_policy_assignment resource.
/// </summary>
public class GoogleOsConfigOsPolicyAssignment : TerraformResource
{
    public GoogleOsConfigOsPolicyAssignment(string name) : base("google_os_config_os_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("baseline");
        this.DeclareOutput("deleted");
        this.DeclareOutput("etag");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("revision_create_time");
        this.DeclareOutput("revision_id");
        this.DeclareOutput("rollout_state");
        this.DeclareOutput("uid");
    }

    /// <summary>
    /// OS policy assignment description. Length of the description is limited to 1024 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource name.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Set to true to skip awaiting rollout during resource creation and update.
    /// </summary>
    public bool? SkipAwaitRollout
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_await_rollout")?.Value;
        set => this.WithProperty("skip_await_rollout", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision.
    /// For a given OS policy assignment, there is only one revision with a value of &#39;true&#39; for this field.
    /// </summary>
    public TerraformExpression Baseline => this["baseline"];

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    public TerraformExpression Deleted => this["deleted"];

    /// <summary>
    /// The etag for this OS policy assignment. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress for the revision. This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. The timestamp that the revision was created.
    /// </summary>
    public TerraformExpression RevisionCreateTime => this["revision_create_time"];

    /// <summary>
    /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// Output only. OS policy assignment rollout state
    /// </summary>
    public TerraformExpression RolloutState => this["rollout_state"];

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
