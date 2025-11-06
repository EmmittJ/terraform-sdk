using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_env_references resource.
/// </summary>
public class GoogleApigeeEnvReferences : TerraformResource
{
    public GoogleApigeeEnvReferences(string name) : base("google_apigee_env_references", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Optional. A human-readable description of this reference.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    public string? EnvId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("env_id")?.Value;
        set => this.WithProperty("env_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Required. The resource id of this reference. Values must match the regular expression [\w\s-.]+.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Required. The id of the resource to which this reference refers. Must be the id of a resource that exists in the parent environment and is of the given resourceType.
    /// </summary>
    public string? Refers
    {
        get => GetProperty<TerraformLiteralProperty<string>>("refers")?.Value;
        set => this.WithProperty("refers", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of resource referred to by this reference. Valid values are &#39;KeyStore&#39; or &#39;TrustStore&#39;.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
