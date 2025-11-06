using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_security_mirroring_deployment resource.
/// </summary>
public class GoogleNetworkSecurityMirroringDeployment : TerraformResource
{
    public GoogleNetworkSecurityMirroringDeployment(string name) : base("google_network_security_mirroring_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User-provided description of the deployment.
    /// Used as additional context for the deployment.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The regional forwarding rule that fronts the mirroring collectors, for
    /// example: &#39;projects/123456789/regions/us-central1/forwardingRules/my-rule&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    public string? ForwardingRule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forwarding_rule")?.Value;
        set => this.WithProperty("forwarding_rule", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The cloud location of the deployment, e.g. &#39;us-central1-a&#39; or &#39;asia-south1-b&#39;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment group that this deployment is a part of, for example:
    /// &#39;projects/123456789/locations/global/mirroringDeploymentGroups/my-dg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    public string? MirroringDeploymentGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mirroring_deployment_group")?.Value;
        set => this.WithProperty("mirroring_deployment_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the new deployment, which will become the final
    /// component of the deployment&#39;s resource name.
    /// </summary>
    public string? MirroringDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mirroring_deployment_id")?.Value;
        set => this.WithProperty("mirroring_deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name of this deployment, for example:
    /// &#39;projects/123456789/locations/us-central1-a/mirroringDeployments/my-dep&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This part of the normal
    /// operation (e.g. linking a new association to the parent group).
    /// See https://google.aip.dev/128.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of the deployment.
    /// See https://google.aip.dev/216.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
    /// OUT_OF_SYNC
    /// DELETE_FAILED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
