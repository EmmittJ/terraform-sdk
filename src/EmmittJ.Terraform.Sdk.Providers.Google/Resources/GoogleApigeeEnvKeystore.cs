using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_env_keystore resource.
/// </summary>
public class GoogleApigeeEnvKeystore : TerraformResource
{
    public GoogleApigeeEnvKeystore(string name) : base("google_apigee_env_keystore", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aliases");
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? EnvId
    {
        get => GetProperty<TerraformProperty<string>>("env_id");
        set => this.WithProperty("env_id", value);
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
    /// The name of the newly created keystore.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Aliases in this keystore.
    /// </summary>
    public TerraformExpression Aliases => this["aliases"];

}
