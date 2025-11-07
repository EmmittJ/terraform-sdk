using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_org_policy_policy resource.
/// </summary>
public class GoogleOrgPolicyPolicy : TerraformResource
{
    public GoogleOrgPolicyPolicy(string name) : base("google_org_policy_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// Immutable. The resource name of the Policy. Must be one of the following forms, where constraint_name is the name of the constraint which this Policy configures: * &#39;projects/{project_number}/policies/{constraint_name}&#39; * &#39;folders/{folder_id}/policies/{constraint_name}&#39; * &#39;organizations/{organization_id}/policies/{constraint_name}&#39; For example, &amp;quot;projects/123/policies/compute.disableSerialPortAccess&amp;quot;. Note: &#39;projects/{project_id}/policies/{constraint_name}&#39; is also an acceptable name for API requests, but responses will return the name using the equivalent project number.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent of the resource.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Optional. An opaque tag indicating the current state of the policy, used for concurrency control. This &#39;etag&#39; is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
