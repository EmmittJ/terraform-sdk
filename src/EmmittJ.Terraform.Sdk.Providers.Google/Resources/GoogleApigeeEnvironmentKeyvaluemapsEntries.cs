using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_environment_keyvaluemaps_entries resource.
/// </summary>
public class GoogleApigeeEnvironmentKeyvaluemapsEntries : TerraformResource
{
    public GoogleApigeeEnvironmentKeyvaluemapsEntries(string name) : base("google_apigee_environment_keyvaluemaps_entries", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The Apigee environment keyvalumaps Id associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}/keyvaluemaps/{{keyvaluemap_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? EnvKeyvaluemapId
    {
        get => GetProperty<TerraformProperty<string>>("env_keyvaluemap_id");
        set => this.WithProperty("env_keyvaluemap_id", value);
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
    /// Required. Resource URI that can be used to identify the scope of the key value map entries.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Required. Data or payload that is being retrieved and associated with the unique key.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

}
