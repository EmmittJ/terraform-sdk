using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_securityposture_posture_deployment resource.
/// </summary>
public class GoogleSecurityposturePostureDeployment : TerraformResource
{
    public GoogleSecurityposturePostureDeployment(string name) : base("google_securityposture_posture_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("desired_posture_id");
        this.DeclareOutput("desired_posture_revision_id");
        this.DeclareOutput("etag");
        this.DeclareOutput("failure_message");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the posture deployment.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location of the resource, eg. global&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// ID of the posture deployment.
    /// </summary>
    public TerraformLiteralProperty<string>? PostureDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("posture_deployment_id");
        set => this.WithProperty("posture_deployment_id", value);
    }

    /// <summary>
    /// Relative name of the posture which needs to be deployed. It should be in the format:
    ///   organizations/{organization_id}/locations/{location}/postures/{posture_id}
    /// </summary>
    public TerraformLiteralProperty<string>? PostureId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("posture_id");
        set => this.WithProperty("posture_id", value);
    }

    /// <summary>
    /// Revision_id the posture which needs to be deployed.
    /// </summary>
    public TerraformLiteralProperty<string>? PostureRevisionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("posture_revision_id");
        set => this.WithProperty("posture_revision_id", value);
    }

    /// <summary>
    /// The resource on which the posture should be deployed. This can be in one of the following formats:
    /// projects/{project_number},
    /// folders/{folder_number},
    /// organizations/{organization_id}
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource");
        set => this.WithProperty("target_resource", value);
    }

    /// <summary>
    /// Time the posture deployment was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture to be deployed.
    /// </summary>
    public TerraformExpression DesiredPostureId => this["desired_posture_id"];

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture revision_id to be deployed.
    /// </summary>
    public TerraformExpression DesiredPostureRevisionId => this["desired_posture_revision_id"];

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// This is a output only optional field which will be filled in case where
    /// PostureDeployment enters a failure state like UPDATE_FAILED or
    /// CREATE_FAILED or DELETE_FAILED. It will have the failure message for posture deployment&#39;s
    /// CREATE/UPDATE/DELETE methods.
    /// </summary>
    public TerraformExpression FailureMessage => this["failure_message"];

    /// <summary>
    /// Name of the posture deployment instance.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// If set, there are currently changes in flight to the posture deployment.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// State of the posture deployment. A posture deployment can be in the following terminal states:
    /// ACTIVE, CREATE_FAILED, UPDATE_FAILED, DELETE_FAILED.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Time the posture deployment was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
