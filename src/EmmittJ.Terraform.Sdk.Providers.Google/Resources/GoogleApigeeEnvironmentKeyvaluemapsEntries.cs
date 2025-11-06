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
    public string? EnvKeyvaluemapId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("env_keyvaluemap_id")?.Value;
        set => this.WithProperty("env_keyvaluemap_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Required. Resource URI that can be used to identify the scope of the key value map entries.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Required. Data or payload that is being retrieved and associated with the unique key.
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
