using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appfabric_app_authorization resource.
/// </summary>
public class AwsAppfabricAppAuthorization : TerraformResource
{
    public AwsAppfabricAppAuthorization(string name) : base("aws_appfabric_app_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auth_url");
        this.DeclareOutput("created_at");
        this.DeclareOutput("id");
        this.DeclareOutput("persona");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("updated_at");
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    public string? App
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app")?.Value;
        set => this.WithProperty("app", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    public string? AppBundleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_bundle_arn")?.Value;
        set => this.WithProperty("app_bundle_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public string? AuthType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_type")?.Value;
        set => this.WithProperty("auth_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auth_url attribute.
    /// </summary>
    public TerraformExpression AuthUrl => this["auth_url"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The persona attribute.
    /// </summary>
    public TerraformExpression Persona => this["persona"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
