using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_instance_attachment resource.
/// </summary>
public class GoogleApigeeInstanceAttachment : TerraformResource
{
    public GoogleApigeeInstanceAttachment(string name) : base("google_apigee_instance_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
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
    /// The Apigee instance associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/instances/{{instance_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The name of the newly created  attachment (output parameter).
    /// </summary>
    public TerraformExpression Name => this["name"];

}
