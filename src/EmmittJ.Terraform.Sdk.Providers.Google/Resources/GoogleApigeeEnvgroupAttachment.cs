using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_envgroup_attachment resource.
/// </summary>
public class GoogleApigeeEnvgroupAttachment : TerraformResource
{
    public GoogleApigeeEnvgroupAttachment(string name) : base("google_apigee_envgroup_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/envgroups/{{envgroup_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? EnvgroupId
    {
        get => GetProperty<TerraformProperty<string>>("envgroup_id");
        set => this.WithProperty("envgroup_id", value);
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// The name of the newly created  attachment (output parameter).
    /// </summary>
    public TerraformExpression Name => this["name"];

}
