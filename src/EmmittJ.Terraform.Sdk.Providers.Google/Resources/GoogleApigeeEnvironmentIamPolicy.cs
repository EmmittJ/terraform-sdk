using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_environment_iam_policy resource.
/// </summary>
public class GoogleApigeeEnvironmentIamPolicy : TerraformResource
{
    public GoogleApigeeEnvironmentIamPolicy(string name) : base("google_apigee_environment_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The env_id attribute.
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
    /// The org_id attribute.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public string? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data")?.Value;
        set => this.WithProperty("policy_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
